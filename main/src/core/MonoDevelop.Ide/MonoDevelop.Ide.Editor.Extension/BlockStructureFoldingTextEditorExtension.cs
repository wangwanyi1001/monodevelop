﻿//
// BlockStructureFoldingTextEditorExtension.cs
//
// Author:
//       Mike Krüger <mikkrg@microsoft.com>
//
// Copyright (c) 2018 Microsoft Corporation. All rights reserved.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Gtk;
using MonoDevelop.Core;
using MonoDevelop.Core.Text;
using MonoDevelop.Ide.Editor.Highlighting;
using MonoDevelop.Ide.TypeSystem;
using Microsoft.CodeAnalysis.Structure;
using System.Collections.Immutable;

namespace MonoDevelop.Ide.Editor.Extension
{
	class BlockStructureFoldingTextEditorExtension : TextEditorExtension
	{
		CancellationTokenSource src = new CancellationTokenSource ();
		bool isDisposed;

		protected override void Initialize ()
		{
			DocumentContext.DocumentParsed += DocumentContext_DocumentParsed;
		}

		public override void Dispose ()
		{
			if (isDisposed)
				return;
			isDisposed = true;
			CancelDocumentParsedUpdate ();
			DocumentContext.DocumentParsed -= DocumentContext_DocumentParsed;
			base.Dispose ();
		}

		void CancelDocumentParsedUpdate ()
		{
			src.Cancel ();
			src = new CancellationTokenSource ();
		}

		async void DocumentContext_DocumentParsed (object sender, EventArgs e)
		{
			CancelDocumentParsedUpdate ();
			var analysisDocument = DocumentContext.AnalysisDocument;
			if (analysisDocument == null || !Editor.Options.ShowFoldMargin)
				return;
			var caretLocation = Editor.CaretOffset;

			var outliningService = BlockStructureService.GetService (analysisDocument);
			if (outliningService == null)
				return;
			var token = src.Token;
			var blockStructure = await outliningService.GetBlockStructureAsync (analysisDocument, token).ConfigureAwait (false);
			UpdateFoldings (Editor, blockStructure.Spans, caretLocation, false, token);
		}

		static void UpdateFoldings (TextEditor Editor, ImmutableArray<BlockSpan> spans, int caretOffset, bool firstTime = false, CancellationToken token = default (CancellationToken))
		{
			try {
				var foldSegments = new List<IFoldSegment> ();

				foreach (var blockSpan in spans) {
					if (token.IsCancellationRequested)
						return;
					if (!blockSpan.IsCollapsible)
						continue;
					var type = FoldingType.Unknown;
					switch (blockSpan.Type) {
					case BlockTypes.Member:
						type = FoldingType.TypeMember;
						break;
					case BlockTypes.Type:
						type = FoldingType.TypeDefinition;
						break;
					case BlockTypes.Comment:
						type = FoldingType.Comment;
						break;
					default:
						type = FoldingType.Unknown;
						break;
					}
					var start = blockSpan.TextSpan.Start;
					var end = blockSpan.TextSpan.End;
					var marker = Editor.CreateFoldSegment (start, end - start);
					if (marker == null)
						continue;
					foldSegments.Add (marker);
					marker.CollapsedText = blockSpan.BannerText;
					marker.FoldingType = type;
					//and, if necessary, set its fold state
					if (firstTime) {
						// only fold on document open, later added folds are NOT folded by default.
						marker.IsCollapsed = blockSpan.IsDefaultCollapsed;
						continue;
					}
					if (blockSpan.TextSpan.Contains (caretOffset))
						marker.IsCollapsed = false;
				}
				if (firstTime) {
					Editor.SetFoldings (foldSegments);
				} else {
					Application.Invoke ((o, args) => {
						if (!token.IsCancellationRequested)
							Editor.SetFoldings (foldSegments);
					});
				}
			} catch (OperationCanceledException) {
			} catch (Exception ex) {
				LoggingService.LogError ("Unhandled exception in ParseInformationUpdaterWorkerThread", ex);
			}
		}
	}
}