
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.CSharp.Project
{
	internal partial class CodeGenerationPanelWidget
	{
		private global::Gtk.VBox vbox62;
		private global::Gtk.Label label82;
		private global::Gtk.HBox hbox56;
		private global::Gtk.Label label81;
		private global::Gtk.VBox vbox65;
		private global::Gtk.Table table1;
		private global::Gtk.CheckButton enableOptimizationCheckButton;
		private global::Gtk.CheckButton generateOverflowChecksCheckButton;
		private global::Gtk.HBox hbox1;
		private global::Gtk.ComboBox comboPlatforms;
		private global::Gtk.HBox hbox2;
		private global::Gtk.ComboBox comboDebug;
		private global::Gtk.HBox hbox4;
		private global::Gtk.CheckButton generateXmlOutputCheckButton;
		private global::MonoDevelop.Components.FileEntry xmlDocsEntry;
		private global::Gtk.Label label1;
		private global::Gtk.Label label2;
		private global::Gtk.Label label87;
		private global::Gtk.Entry symbolsEntry;
		private global::Gtk.Label label93;
		private global::Gtk.HBox hbox48;
		private global::Gtk.Label label73;
		private global::Gtk.VBox vbox67;
		private global::Gtk.HBox hbox60;
		private global::Gtk.Label label85;
		private global::Gtk.SpinButton warningLevelSpinButton;
		private global::Gtk.HBox hbox3;
		private global::Gtk.Label label86;
		private global::Gtk.Entry ignoreWarningsEntry;
		private global::Gtk.CheckButton warningsAsErrorsCheckButton;
		private global::Gtk.HBox hbox5;
		private global::Gtk.Label label74;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.CSharp.Project.CodeGenerationPanelWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.CSharp.Project.CodeGenerationPanelWidget";
			// Container child MonoDevelop.CSharp.Project.CodeGenerationPanelWidget.Gtk.Container+ContainerChild
			this.vbox62 = new global::Gtk.VBox ();
			this.vbox62.Name = "vbox62";
			this.vbox62.Spacing = 12;
			this.vbox62.BorderWidth = ((uint)(6));
			// Container child vbox62.Gtk.Box+BoxChild
			this.label82 = new global::Gtk.Label ();
			this.label82.Name = "label82";
			this.label82.Xalign = 0F;
			this.label82.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>General Options</b>");
			this.label82.UseMarkup = true;
			this.vbox62.Add (this.label82);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox62 [this.label82]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox62.Gtk.Box+BoxChild
			this.hbox56 = new global::Gtk.HBox ();
			this.hbox56.Name = "hbox56";
			// Container child hbox56.Gtk.Box+BoxChild
			this.label81 = new global::Gtk.Label ();
			this.label81.WidthRequest = 18;
			this.label81.Name = "label81";
			this.hbox56.Add (this.label81);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox56 [this.label81]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox56.Gtk.Box+BoxChild
			this.vbox65 = new global::Gtk.VBox ();
			this.vbox65.Name = "vbox65";
			this.vbox65.Spacing = 6;
			// Container child vbox65.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table (((uint)(6)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.enableOptimizationCheckButton = new global::Gtk.CheckButton ();
			this.enableOptimizationCheckButton.CanFocus = true;
			this.enableOptimizationCheckButton.Name = "enableOptimizationCheckButton";
			this.enableOptimizationCheckButton.Label = global::Mono.Unix.Catalog.GetString ("Enable _optimizations");
			this.enableOptimizationCheckButton.DrawIndicator = true;
			this.enableOptimizationCheckButton.UseUnderline = true;
			this.table1.Add (this.enableOptimizationCheckButton);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1 [this.enableOptimizationCheckButton]));
			w3.TopAttach = ((uint)(1));
			w3.BottomAttach = ((uint)(2));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.generateOverflowChecksCheckButton = new global::Gtk.CheckButton ();
			this.generateOverflowChecksCheckButton.CanFocus = true;
			this.generateOverflowChecksCheckButton.Name = "generateOverflowChecksCheckButton";
			this.generateOverflowChecksCheckButton.Label = global::Mono.Unix.Catalog.GetString ("_Generate overflow checks");
			this.generateOverflowChecksCheckButton.DrawIndicator = true;
			this.generateOverflowChecksCheckButton.UseUnderline = true;
			this.table1.Add (this.generateOverflowChecksCheckButton);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1 [this.generateOverflowChecksCheckButton]));
			w4.RightAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.comboPlatforms = global::Gtk.ComboBox.NewText ();
			this.comboPlatforms.AppendText (global::Mono.Unix.Catalog.GetString ("Any CPU"));
			this.comboPlatforms.AppendText (global::Mono.Unix.Catalog.GetString ("x86"));
			this.comboPlatforms.AppendText (global::Mono.Unix.Catalog.GetString ("x64"));
			this.comboPlatforms.AppendText (global::Mono.Unix.Catalog.GetString ("Itanium"));
			this.comboPlatforms.Name = "comboPlatforms";
			this.comboPlatforms.Active = 0;
			this.hbox1.Add (this.comboPlatforms);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.comboPlatforms]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			this.table1.Add (this.hbox1);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox1]));
			w6.TopAttach = ((uint)(5));
			w6.BottomAttach = ((uint)(6));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.comboDebug = global::Gtk.ComboBox.NewText ();
			this.comboDebug.AppendText (global::Mono.Unix.Catalog.GetString ("Full"));
			this.comboDebug.AppendText (global::Mono.Unix.Catalog.GetString ("Symbols only"));
			this.comboDebug.AppendText (global::Mono.Unix.Catalog.GetString ("None"));
			this.comboDebug.Name = "comboDebug";
			this.comboDebug.Active = 0;
			this.hbox2.Add (this.comboDebug);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.comboDebug]));
			w7.Position = 0;
			w7.Expand = false;
			w7.Fill = false;
			this.table1.Add (this.hbox2);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox2]));
			w8.TopAttach = ((uint)(3));
			w8.BottomAttach = ((uint)(4));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.hbox4 = new global::Gtk.HBox ();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.generateXmlOutputCheckButton = new global::Gtk.CheckButton ();
			this.generateXmlOutputCheckButton.CanFocus = true;
			this.generateXmlOutputCheckButton.Name = "generateXmlOutputCheckButton";
			this.generateXmlOutputCheckButton.Label = global::Mono.Unix.Catalog.GetString ("Generate _xml documentation:");
			this.generateXmlOutputCheckButton.DrawIndicator = true;
			this.generateXmlOutputCheckButton.UseUnderline = true;
			this.hbox4.Add (this.generateXmlOutputCheckButton);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.generateXmlOutputCheckButton]));
			w9.Position = 0;
			w9.Expand = false;
			w9.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.xmlDocsEntry = new global::MonoDevelop.Components.FileEntry ();
			this.xmlDocsEntry.Name = "xmlDocsEntry";
			this.xmlDocsEntry.DisplayAsRelativePath = false;
			this.hbox4.Add (this.xmlDocsEntry);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox4 [this.xmlDocsEntry]));
			w10.Position = 1;
			this.table1.Add (this.hbox4);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1 [this.hbox4]));
			w11.TopAttach = ((uint)(2));
			w11.BottomAttach = ((uint)(3));
			w11.RightAttach = ((uint)(2));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.Xalign = 0F;
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Platform target:");
			this.table1.Add (this.label1);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1 [this.label1]));
			w12.TopAttach = ((uint)(5));
			w12.BottomAttach = ((uint)(6));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.Xalign = 0F;
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Debug information:");
			this.table1.Add (this.label2);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1 [this.label2]));
			w13.TopAttach = ((uint)(3));
			w13.BottomAttach = ((uint)(4));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.label87 = new global::Gtk.Label ();
			this.label87.Name = "label87";
			this.label87.Xalign = 0F;
			this.label87.LabelProp = global::Mono.Unix.Catalog.GetString ("Define S_ymbols:");
			this.label87.UseUnderline = true;
			this.table1.Add (this.label87);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1 [this.label87]));
			w14.TopAttach = ((uint)(4));
			w14.BottomAttach = ((uint)(5));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.symbolsEntry = new global::Gtk.Entry ();
			this.symbolsEntry.CanFocus = true;
			this.symbolsEntry.Name = "symbolsEntry";
			this.symbolsEntry.IsEditable = true;
			this.symbolsEntry.InvisibleChar = '●';
			this.table1.Add (this.symbolsEntry);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1 [this.symbolsEntry]));
			w15.TopAttach = ((uint)(4));
			w15.BottomAttach = ((uint)(5));
			w15.LeftAttach = ((uint)(1));
			w15.RightAttach = ((uint)(2));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			this.vbox65.Add (this.table1);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox65 [this.table1]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			this.hbox56.Add (this.vbox65);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox56 [this.vbox65]));
			w17.Position = 1;
			this.vbox62.Add (this.hbox56);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox62 [this.hbox56]));
			w18.Position = 1;
			w18.Expand = false;
			w18.Fill = false;
			// Container child vbox62.Gtk.Box+BoxChild
			this.label93 = new global::Gtk.Label ();
			this.label93.Name = "label93";
			this.label93.Xalign = 0F;
			this.label93.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Warnings</b>");
			this.label93.UseMarkup = true;
			this.label93.UseUnderline = true;
			this.vbox62.Add (this.label93);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox62 [this.label93]));
			w19.Position = 2;
			w19.Expand = false;
			w19.Fill = false;
			// Container child vbox62.Gtk.Box+BoxChild
			this.hbox48 = new global::Gtk.HBox ();
			this.hbox48.Name = "hbox48";
			// Container child hbox48.Gtk.Box+BoxChild
			this.label73 = new global::Gtk.Label ();
			this.label73.WidthRequest = 18;
			this.label73.Name = "label73";
			this.hbox48.Add (this.label73);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox48 [this.label73]));
			w20.Position = 0;
			w20.Expand = false;
			w20.Fill = false;
			// Container child hbox48.Gtk.Box+BoxChild
			this.vbox67 = new global::Gtk.VBox ();
			this.vbox67.Name = "vbox67";
			this.vbox67.Spacing = 6;
			// Container child vbox67.Gtk.Box+BoxChild
			this.hbox60 = new global::Gtk.HBox ();
			this.hbox60.Name = "hbox60";
			this.hbox60.Spacing = 6;
			// Container child hbox60.Gtk.Box+BoxChild
			this.label85 = new global::Gtk.Label ();
			this.label85.Name = "label85";
			this.label85.LabelProp = global::Mono.Unix.Catalog.GetString ("_Warning Level:");
			this.label85.UseUnderline = true;
			this.hbox60.Add (this.label85);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox60 [this.label85]));
			w21.Position = 0;
			w21.Expand = false;
			w21.Fill = false;
			// Container child hbox60.Gtk.Box+BoxChild
			this.warningLevelSpinButton = new global::Gtk.SpinButton (0, 4, 1);
			this.warningLevelSpinButton.CanFocus = true;
			this.warningLevelSpinButton.Name = "warningLevelSpinButton";
			this.warningLevelSpinButton.Adjustment.PageIncrement = 1;
			this.warningLevelSpinButton.ClimbRate = 1;
			this.warningLevelSpinButton.Numeric = true;
			this.warningLevelSpinButton.Value = 2;
			this.hbox60.Add (this.warningLevelSpinButton);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox60 [this.warningLevelSpinButton]));
			w22.Position = 1;
			w22.Expand = false;
			w22.Fill = false;
			this.vbox67.Add (this.hbox60);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox67 [this.hbox60]));
			w23.Position = 0;
			w23.Expand = false;
			w23.Fill = false;
			// Container child vbox67.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label86 = new global::Gtk.Label ();
			this.label86.Name = "label86";
			this.label86.LabelProp = global::Mono.Unix.Catalog.GetString ("_Ignore warnings:");
			this.label86.UseUnderline = true;
			this.hbox3.Add (this.label86);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label86]));
			w24.Position = 0;
			w24.Expand = false;
			w24.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.ignoreWarningsEntry = new global::Gtk.Entry ();
			this.ignoreWarningsEntry.CanFocus = true;
			this.ignoreWarningsEntry.Name = "ignoreWarningsEntry";
			this.ignoreWarningsEntry.IsEditable = true;
			this.ignoreWarningsEntry.InvisibleChar = '●';
			this.hbox3.Add (this.ignoreWarningsEntry);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.ignoreWarningsEntry]));
			w25.Position = 1;
			this.vbox67.Add (this.hbox3);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox67 [this.hbox3]));
			w26.Position = 1;
			w26.Expand = false;
			w26.Fill = false;
			// Container child vbox67.Gtk.Box+BoxChild
			this.warningsAsErrorsCheckButton = new global::Gtk.CheckButton ();
			this.warningsAsErrorsCheckButton.CanFocus = true;
			this.warningsAsErrorsCheckButton.Name = "warningsAsErrorsCheckButton";
			this.warningsAsErrorsCheckButton.Label = global::Mono.Unix.Catalog.GetString ("Treat warnings as _errors");
			this.warningsAsErrorsCheckButton.DrawIndicator = true;
			this.warningsAsErrorsCheckButton.UseUnderline = true;
			this.vbox67.Add (this.warningsAsErrorsCheckButton);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.vbox67 [this.warningsAsErrorsCheckButton]));
			w27.Position = 2;
			w27.Expand = false;
			w27.Fill = false;
			this.hbox48.Add (this.vbox67);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox48 [this.vbox67]));
			w28.Position = 1;
			this.vbox62.Add (this.hbox48);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox62 [this.hbox48]));
			w29.Position = 3;
			w29.Expand = false;
			w29.Fill = false;
			// Container child vbox62.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox ();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.label74 = new global::Gtk.Label ();
			this.label74.WidthRequest = 18;
			this.label74.Name = "label74";
			this.hbox5.Add (this.label74);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox5 [this.label74]));
			w30.Position = 0;
			w30.Expand = false;
			w30.Fill = false;
			this.vbox62.Add (this.hbox5);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.vbox62 [this.hbox5]));
			w31.Position = 4;
			w31.Expand = false;
			w31.Fill = false;
			this.Add (this.vbox62);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.label87.MnemonicWidget = this.symbolsEntry;
			this.label85.MnemonicWidget = this.warningLevelSpinButton;
			this.label86.MnemonicWidget = this.warningLevelSpinButton;
			this.Show ();
		}
	}
}
