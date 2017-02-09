
namespace Preset_Maintenance
{
    partial class PresetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label presetPrintLabel1;
            System.Windows.Forms.Label keyCodeLabel;
            System.Windows.Forms.Label presetCodeLabel;
            System.Windows.Forms.Label presetPictureLabel;
            System.Windows.Forms.Label presetDescLabel;
            System.Windows.Forms.Label presetLegendLabel;
            System.Windows.Forms.Label presetTaxLabel;
            System.Windows.Forms.Label presetPriceLabel;
            System.Windows.Forms.Label presetReceiptLabel;
            System.Windows.Forms.Label presetPrice2Label;
            System.Windows.Forms.Label presetPrice6Label;
            System.Windows.Forms.Label presetPrice3Label;
            System.Windows.Forms.Label presetPrice8Label;
            System.Windows.Forms.Label presetPrice4Label;
            System.Windows.Forms.Label presetPrice7Label;
            System.Windows.Forms.Label presetPrice5Label;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PresetForm));
            this.Main_SplitCon = new System.Windows.Forms.SplitContainer();
            this.Nested_SplitCon = new System.Windows.Forms.SplitContainer();
            this.ViewKeys_Button = new System.Windows.Forms.Button();
            this.SearchResults_GroupBox = new System.Windows.Forms.GroupBox();
            this.searchResults_DataGridView = new System.Windows.Forms.DataGridView();
            this.PresetDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presetMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jartrekDataSet = new Preset_Maintenance.jartrekDataSet();
            this.NewItem_TreeView = new Preset_Maintenance.DataBoundTreeView();
            this.ColorPicker_GroupBox = new Preset_Maintenance.CustomGrpBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.Pricing_GroupBox = new Preset_Maintenance.CustomGrpBox();
            this.ModifierButton = new System.Windows.Forms.Button();
            this.presetMasterBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ChitSettings_GroupBox = new Preset_Maintenance.CustomGrpBox();
            this.Remote2_CheckBox = new System.Windows.Forms.CheckBox();
            this.Remote1_CheckBox = new System.Windows.Forms.CheckBox();
            this.PresetChippable_CheckBox = new System.Windows.Forms.CheckBox();
            this.ConfirmAdd_Button = new System.Windows.Forms.Button();
            this.CurrentlyAdding_Label = new System.Windows.Forms.Label();
            this.CanceledChanges_Label = new System.Windows.Forms.Label();
            this.UpdateRow_Label = new System.Windows.Forms.Label();
            this.bitMap_ComboBox = new System.Windows.Forms.ComboBox();
            this.CancelChanges_Button = new System.Windows.Forms.Button();
            this.Success_Label = new System.Windows.Forms.Label();
            this.keyCodeComboBox = new System.Windows.Forms.ComboBox();
            this.presetPrintComboBox = new System.Windows.Forms.ComboBox();
            this.presetCodeTextBox = new System.Windows.Forms.TextBox();
            this.Update_Button = new System.Windows.Forms.Button();
            this.presetDescTextBox = new System.Windows.Forms.TextBox();
            this.presetLegendTextBox = new System.Windows.Forms.TextBox();
            this.presetTaxTextBox = new System.Windows.Forms.TextBox();
            this.presetPriceTextBox = new System.Windows.Forms.TextBox();
            this.presetReceiptTextBox = new System.Windows.Forms.TextBox();
            this.presetPrice2TextBox = new System.Windows.Forms.TextBox();
            this.presetPrice8TextBox = new System.Windows.Forms.TextBox();
            this.presetPrice3TextBox = new System.Windows.Forms.TextBox();
            this.presetPrice7TextBox = new System.Windows.Forms.TextBox();
            this.presetPrice4TextBox = new System.Windows.Forms.TextBox();
            this.presetPrice6TextBox = new System.Windows.Forms.TextBox();
            this.presetPrice5TextBox = new System.Windows.Forms.TextBox();
            this.PresetSplitContainer = new System.Windows.Forms.SplitContainer();
            this.MyPriorityControl = new Preset_Maintenance.PresetPriorityControl();
            this.presetTrashBin = new Preset_Maintenance.CustomGrpBox();
            this.TrashBin_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.SearchResults_Label = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.PresetSearch_Button = new System.Windows.Forms.Button();
            this.PresetSearchLabel = new System.Windows.Forms.Label();
            this.PresetSearch_TextBox = new System.Windows.Forms.TextBox();
            this.customGrpBox1 = new Preset_Maintenance.CustomGrpBox();
            this.CurrentPreset_Button = new System.Windows.Forms.Button();
            this.CollapseNodes_Button = new System.Windows.Forms.Button();
            this.ExpandNodes_Button = new System.Windows.Forms.Button();
            this.CurrentKey_GroupBox = new Preset_Maintenance.CustomGrpBox();
            this.KeyPreview_Button = new System.Windows.Forms.Button();
            this.DataBoundTree = new Preset_Maintenance.DataBoundTreeView();
            this.presetMasterTableAdapter = new Preset_Maintenance.jartrekDataSetTableAdapters.PresetMasterTableAdapter();
            this.tableAdapterManager = new Preset_Maintenance.jartrekDataSetTableAdapters.TableAdapterManager();
            this.keyMasterTableAdapter1 = new Preset_Maintenance.jartrekDataSetTableAdapters.KeyMasterTableAdapter();
            this.GoToPriorAdapter = new Preset_Maintenance.jartrekDataSetTableAdapters.GoToPriorTableAdapter();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            presetPrintLabel1 = new System.Windows.Forms.Label();
            keyCodeLabel = new System.Windows.Forms.Label();
            presetCodeLabel = new System.Windows.Forms.Label();
            presetPictureLabel = new System.Windows.Forms.Label();
            presetDescLabel = new System.Windows.Forms.Label();
            presetLegendLabel = new System.Windows.Forms.Label();
            presetTaxLabel = new System.Windows.Forms.Label();
            presetPriceLabel = new System.Windows.Forms.Label();
            presetReceiptLabel = new System.Windows.Forms.Label();
            presetPrice2Label = new System.Windows.Forms.Label();
            presetPrice6Label = new System.Windows.Forms.Label();
            presetPrice3Label = new System.Windows.Forms.Label();
            presetPrice8Label = new System.Windows.Forms.Label();
            presetPrice4Label = new System.Windows.Forms.Label();
            presetPrice7Label = new System.Windows.Forms.Label();
            presetPrice5Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Main_SplitCon)).BeginInit();
            this.Main_SplitCon.Panel1.SuspendLayout();
            this.Main_SplitCon.Panel2.SuspendLayout();
            this.Main_SplitCon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nested_SplitCon)).BeginInit();
            this.Nested_SplitCon.Panel1.SuspendLayout();
            this.Nested_SplitCon.SuspendLayout();
            this.SearchResults_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResults_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presetMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jartrekDataSet)).BeginInit();
            this.ColorPicker_GroupBox.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.Pricing_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.presetMasterBindingNavigator)).BeginInit();
            this.presetMasterBindingNavigator.SuspendLayout();
            this.ChitSettings_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PresetSplitContainer)).BeginInit();
            this.PresetSplitContainer.Panel2.SuspendLayout();
            this.PresetSplitContainer.SuspendLayout();
            this.presetTrashBin.SuspendLayout();
            this.customGrpBox1.SuspendLayout();
            this.CurrentKey_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // presetPrintLabel1
            // 
            presetPrintLabel1.AutoSize = true;
            presetPrintLabel1.Location = new System.Drawing.Point(12, 235);
            presetPrintLabel1.Name = "presetPrintLabel1";
            presetPrintLabel1.Size = new System.Drawing.Size(64, 13);
            presetPrintLabel1.TabIndex = 138;
            presetPrintLabel1.Text = "Preset Print:";
            // 
            // keyCodeLabel
            // 
            keyCodeLabel.AutoSize = true;
            keyCodeLabel.Location = new System.Drawing.Point(12, 78);
            keyCodeLabel.Name = "keyCodeLabel";
            keyCodeLabel.Size = new System.Drawing.Size(56, 13);
            keyCodeLabel.TabIndex = 138;
            keyCodeLabel.Text = "Key Code:";
            // 
            // presetCodeLabel
            // 
            presetCodeLabel.AutoSize = true;
            presetCodeLabel.Location = new System.Drawing.Point(12, 104);
            presetCodeLabel.Name = "presetCodeLabel";
            presetCodeLabel.Size = new System.Drawing.Size(68, 13);
            presetCodeLabel.TabIndex = 115;
            presetCodeLabel.Text = "Preset Code:";
            // 
            // presetPictureLabel
            // 
            presetPictureLabel.AutoSize = true;
            presetPictureLabel.Location = new System.Drawing.Point(12, 130);
            presetPictureLabel.Name = "presetPictureLabel";
            presetPictureLabel.Size = new System.Drawing.Size(76, 13);
            presetPictureLabel.TabIndex = 127;
            presetPictureLabel.Text = "Preset Picture:";
            // 
            // presetDescLabel
            // 
            presetDescLabel.AutoSize = true;
            presetDescLabel.Location = new System.Drawing.Point(12, 52);
            presetDescLabel.Name = "presetDescLabel";
            presetDescLabel.Size = new System.Drawing.Size(68, 13);
            presetDescLabel.TabIndex = 116;
            presetDescLabel.Text = "Preset Desc:";
            // 
            // presetLegendLabel
            // 
            presetLegendLabel.AutoSize = true;
            presetLegendLabel.Location = new System.Drawing.Point(12, 157);
            presetLegendLabel.Name = "presetLegendLabel";
            presetLegendLabel.Size = new System.Drawing.Size(62, 13);
            presetLegendLabel.TabIndex = 117;
            presetLegendLabel.Text = "Button Text";
            // 
            // presetTaxLabel
            // 
            presetTaxLabel.AutoSize = true;
            presetTaxLabel.Location = new System.Drawing.Point(12, 209);
            presetTaxLabel.Name = "presetTaxLabel";
            presetTaxLabel.Size = new System.Drawing.Size(61, 13);
            presetTaxLabel.TabIndex = 118;
            presetTaxLabel.Text = "Preset Tax:";
            // 
            // presetPriceLabel
            // 
            presetPriceLabel.AutoSize = true;
            presetPriceLabel.Location = new System.Drawing.Point(12, 262);
            presetPriceLabel.Name = "presetPriceLabel";
            presetPriceLabel.Size = new System.Drawing.Size(67, 13);
            presetPriceLabel.TabIndex = 119;
            presetPriceLabel.Text = "Preset Price:";
            // 
            // presetReceiptLabel
            // 
            presetReceiptLabel.AutoSize = true;
            presetReceiptLabel.Location = new System.Drawing.Point(12, 183);
            presetReceiptLabel.Name = "presetReceiptLabel";
            presetReceiptLabel.Size = new System.Drawing.Size(71, 13);
            presetReceiptLabel.TabIndex = 126;
            presetReceiptLabel.Text = "Receipt Text:";
            // 
            // presetPrice2Label
            // 
            presetPrice2Label.AutoSize = true;
            presetPrice2Label.Location = new System.Drawing.Point(12, 288);
            presetPrice2Label.Name = "presetPrice2Label";
            presetPrice2Label.Size = new System.Drawing.Size(73, 13);
            presetPrice2Label.TabIndex = 122;
            presetPrice2Label.Text = "Preset Price2:";
            // 
            // presetPrice6Label
            // 
            presetPrice6Label.AutoSize = true;
            presetPrice6Label.Location = new System.Drawing.Point(12, 396);
            presetPrice6Label.Name = "presetPrice6Label";
            presetPrice6Label.Size = new System.Drawing.Size(73, 13);
            presetPrice6Label.TabIndex = 133;
            presetPrice6Label.Text = "Preset Price6:";
            // 
            // presetPrice3Label
            // 
            presetPrice3Label.AutoSize = true;
            presetPrice3Label.Location = new System.Drawing.Point(12, 315);
            presetPrice3Label.Name = "presetPrice3Label";
            presetPrice3Label.Size = new System.Drawing.Size(73, 13);
            presetPrice3Label.TabIndex = 123;
            presetPrice3Label.Text = "Preset Price3:";
            // 
            // presetPrice8Label
            // 
            presetPrice8Label.AutoSize = true;
            presetPrice8Label.Location = new System.Drawing.Point(12, 448);
            presetPrice8Label.Name = "presetPrice8Label";
            presetPrice8Label.Size = new System.Drawing.Size(73, 13);
            presetPrice8Label.TabIndex = 135;
            presetPrice8Label.Text = "Preset Price8:";
            // 
            // presetPrice4Label
            // 
            presetPrice4Label.AutoSize = true;
            presetPrice4Label.Location = new System.Drawing.Point(12, 342);
            presetPrice4Label.Name = "presetPrice4Label";
            presetPrice4Label.Size = new System.Drawing.Size(73, 13);
            presetPrice4Label.TabIndex = 124;
            presetPrice4Label.Text = "Preset Price4:";
            // 
            // presetPrice7Label
            // 
            presetPrice7Label.AutoSize = true;
            presetPrice7Label.Location = new System.Drawing.Point(12, 422);
            presetPrice7Label.Name = "presetPrice7Label";
            presetPrice7Label.Size = new System.Drawing.Size(73, 13);
            presetPrice7Label.TabIndex = 134;
            presetPrice7Label.Text = "Preset Price7:";
            // 
            // presetPrice5Label
            // 
            presetPrice5Label.AutoSize = true;
            presetPrice5Label.Location = new System.Drawing.Point(12, 369);
            presetPrice5Label.Name = "presetPrice5Label";
            presetPrice5Label.Size = new System.Drawing.Size(73, 13);
            presetPrice5Label.TabIndex = 125;
            presetPrice5Label.Text = "Preset Price5:";
            // 
            // Main_SplitCon
            // 
            this.Main_SplitCon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_SplitCon.Location = new System.Drawing.Point(0, 0);
            this.Main_SplitCon.Margin = new System.Windows.Forms.Padding(2);
            this.Main_SplitCon.Name = "Main_SplitCon";
            // 
            // Main_SplitCon.Panel1
            // 
            this.Main_SplitCon.Panel1.Controls.Add(this.Nested_SplitCon);
            // 
            // Main_SplitCon.Panel2
            // 
            this.Main_SplitCon.Panel2.Controls.Add(this.DataBoundTree);
            this.Main_SplitCon.Size = new System.Drawing.Size(1011, 633);
            this.Main_SplitCon.SplitterDistance = 722;
            this.Main_SplitCon.SplitterWidth = 2;
            this.Main_SplitCon.TabIndex = 0;
            // 
            // Nested_SplitCon
            // 
            this.Nested_SplitCon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nested_SplitCon.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.Nested_SplitCon.Location = new System.Drawing.Point(0, 0);
            this.Nested_SplitCon.Margin = new System.Windows.Forms.Padding(2);
            this.Nested_SplitCon.Name = "Nested_SplitCon";
            this.Nested_SplitCon.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Nested_SplitCon.Panel1
            // 
            this.Nested_SplitCon.Panel1.AutoScroll = true;
            this.Nested_SplitCon.Panel1.Controls.Add(this.ViewKeys_Button);
            this.Nested_SplitCon.Panel1.Controls.Add(this.SearchResults_GroupBox);
            this.Nested_SplitCon.Panel1.Controls.Add(this.NewItem_TreeView);
            this.Nested_SplitCon.Panel1.Controls.Add(this.ColorPicker_GroupBox);
            this.Nested_SplitCon.Panel1.Controls.Add(this.Pricing_GroupBox);
            this.Nested_SplitCon.Panel1.Controls.Add(this.PresetSplitContainer);
            this.Nested_SplitCon.Panel1.Controls.Add(this.SearchResults_Label);
            this.Nested_SplitCon.Panel1.Controls.Add(this.ClearButton);
            this.Nested_SplitCon.Panel1.Controls.Add(this.PresetSearch_Button);
            this.Nested_SplitCon.Panel1.Controls.Add(this.PresetSearchLabel);
            this.Nested_SplitCon.Panel1.Controls.Add(this.PresetSearch_TextBox);
            this.Nested_SplitCon.Panel1.Controls.Add(this.customGrpBox1);
            this.Nested_SplitCon.Panel1.Controls.Add(this.CollapseNodes_Button);
            this.Nested_SplitCon.Panel1.Controls.Add(this.ExpandNodes_Button);
            this.Nested_SplitCon.Panel1.Controls.Add(this.CurrentKey_GroupBox);
            this.Nested_SplitCon.Panel1MinSize = 400;
            // 
            // Nested_SplitCon.Panel2
            // 
            this.Nested_SplitCon.Panel2.AccessibleName = "";
            this.Nested_SplitCon.Panel2Collapsed = true;
            this.Nested_SplitCon.Panel2MinSize = 100;
            this.Nested_SplitCon.Size = new System.Drawing.Size(722, 633);
            this.Nested_SplitCon.SplitterDistance = 400;
            this.Nested_SplitCon.SplitterWidth = 2;
            this.Nested_SplitCon.TabIndex = 2;
            // 
            // ViewKeys_Button
            // 
            this.ViewKeys_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewKeys_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewKeys_Button.Location = new System.Drawing.Point(672, 3);
            this.ViewKeys_Button.Name = "ViewKeys_Button";
            this.ViewKeys_Button.Size = new System.Drawing.Size(46, 15);
            this.ViewKeys_Button.TabIndex = 99;
            this.ViewKeys_Button.TabStop = false;
            this.ViewKeys_Button.Text = "^";
            this.ViewKeys_Button.UseVisualStyleBackColor = true;
            this.ViewKeys_Button.Click += new System.EventHandler(this.ViewKeys_Click);
            // 
            // SearchResults_GroupBox
            // 
            this.SearchResults_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchResults_GroupBox.Controls.Add(this.searchResults_DataGridView);
            this.SearchResults_GroupBox.Location = new System.Drawing.Point(441, 4);
            this.SearchResults_GroupBox.Name = "SearchResults_GroupBox";
            this.SearchResults_GroupBox.Size = new System.Drawing.Size(275, 92);
            this.SearchResults_GroupBox.TabIndex = 105;
            this.SearchResults_GroupBox.TabStop = false;
            this.SearchResults_GroupBox.Text = "Search Results";
            // 
            // searchResults_DataGridView
            // 
            this.searchResults_DataGridView.AllowUserToDeleteRows = false;
            this.searchResults_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchResults_DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.searchResults_DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchResults_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResults_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PresetDesc});
            this.searchResults_DataGridView.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.presetMasterBindingSource, "PresetCode", true));
            this.searchResults_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchResults_DataGridView.Location = new System.Drawing.Point(3, 16);
            this.searchResults_DataGridView.Name = "searchResults_DataGridView";
            this.searchResults_DataGridView.RowHeadersWidth = 20;
            this.searchResults_DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.searchResults_DataGridView.Size = new System.Drawing.Size(269, 73);
            this.searchResults_DataGridView.TabIndex = 16;
            this.searchResults_DataGridView.TabStop = false;
            this.searchResults_DataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchResults_DataGrid_CellContentDoubleClick);
            // 
            // PresetDesc
            // 
            this.PresetDesc.HeaderText = "Preset Description";
            this.PresetDesc.Name = "PresetDesc";
            // 
            // presetMasterBindingSource
            // 
            this.presetMasterBindingSource.AllowNew = true;
            this.presetMasterBindingSource.DataMember = "PresetMaster";
            this.presetMasterBindingSource.DataSource = this.jartrekDataSet;
            this.presetMasterBindingSource.AddingNew += new System.ComponentModel.AddingNewEventHandler(this.presetMasterBindingSource_AddingNew);
            this.presetMasterBindingSource.PositionChanged += new System.EventHandler(this.presetMasterBindingSource_PositionChanged);
            // 
            // jartrekDataSet
            // 
            this.jartrekDataSet.DataSetName = "jartrekDataSet";
            this.jartrekDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NewItem_TreeView
            // 
            this.NewItem_TreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NewItem_TreeView.Location = new System.Drawing.Point(452, 24);
            this.NewItem_TreeView.Name = "NewItem_TreeView";
            this.NewItem_TreeView.Size = new System.Drawing.Size(258, 69);
            this.NewItem_TreeView.TabIndex = 108;
            // 
            // ColorPicker_GroupBox
            // 
            this.ColorPicker_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ColorPicker_GroupBox.Controls.Add(this.flowLayoutPanel1);
            this.ColorPicker_GroupBox.Location = new System.Drawing.Point(310, 238);
            this.ColorPicker_GroupBox.Name = "ColorPicker_GroupBox";
            this.ColorPicker_GroupBox.Size = new System.Drawing.Size(79, 395);
            this.ColorPicker_GroupBox.TabIndex = 125;
            this.ColorPicker_GroupBox.TabStop = false;
            this.ColorPicker_GroupBox.Text = "Color Picker";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button16);
            this.flowLayoutPanel1.Controls.Add(this.button8);
            this.flowLayoutPanel1.Controls.Add(this.button15);
            this.flowLayoutPanel1.Controls.Add(this.button7);
            this.flowLayoutPanel1.Controls.Add(this.button14);
            this.flowLayoutPanel1.Controls.Add(this.button6);
            this.flowLayoutPanel1.Controls.Add(this.button13);
            this.flowLayoutPanel1.Controls.Add(this.button5);
            this.flowLayoutPanel1.Controls.Add(this.button12);
            this.flowLayoutPanel1.Controls.Add(this.button4);
            this.flowLayoutPanel1.Controls.Add(this.button11);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Controls.Add(this.button10);
            this.flowLayoutPanel1.Controls.Add(this.button2);
            this.flowLayoutPanel1.Controls.Add(this.button9);
            this.flowLayoutPanel1.Controls.Add(this.button18);
            this.flowLayoutPanel1.Controls.Add(this.button17);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(73, 376);
            this.flowLayoutPanel1.TabIndex = 126;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 35);
            this.button1.TabIndex = 109;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(39, 3);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(30, 35);
            this.button16.TabIndex = 117;
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(3, 44);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(30, 35);
            this.button8.TabIndex = 116;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(39, 44);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(30, 35);
            this.button15.TabIndex = 118;
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 85);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(30, 35);
            this.button7.TabIndex = 115;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(39, 85);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(30, 35);
            this.button14.TabIndex = 119;
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(3, 126);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(30, 35);
            this.button6.TabIndex = 114;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(39, 126);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(30, 35);
            this.button13.TabIndex = 120;
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 167);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(30, 35);
            this.button5.TabIndex = 113;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(39, 167);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(30, 35);
            this.button12.TabIndex = 121;
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 208);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(30, 35);
            this.button4.TabIndex = 112;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(39, 208);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(30, 35);
            this.button11.TabIndex = 122;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 249);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(30, 35);
            this.button3.TabIndex = 111;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(39, 249);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(30, 35);
            this.button10.TabIndex = 123;
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 35);
            this.button2.TabIndex = 110;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(39, 290);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(30, 35);
            this.button9.TabIndex = 124;
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(3, 331);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(30, 35);
            this.button18.TabIndex = 125;
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(39, 331);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(30, 35);
            this.button17.TabIndex = 126;
            this.button17.UseVisualStyleBackColor = true;
            // 
            // Pricing_GroupBox
            // 
            this.Pricing_GroupBox.Controls.Add(this.ModifierButton);
            this.Pricing_GroupBox.Controls.Add(this.presetMasterBindingNavigator);
            this.Pricing_GroupBox.Controls.Add(this.ChitSettings_GroupBox);
            this.Pricing_GroupBox.Controls.Add(this.ConfirmAdd_Button);
            this.Pricing_GroupBox.Controls.Add(this.CurrentlyAdding_Label);
            this.Pricing_GroupBox.Controls.Add(this.CanceledChanges_Label);
            this.Pricing_GroupBox.Controls.Add(this.UpdateRow_Label);
            this.Pricing_GroupBox.Controls.Add(this.bitMap_ComboBox);
            this.Pricing_GroupBox.Controls.Add(this.CancelChanges_Button);
            this.Pricing_GroupBox.Controls.Add(this.Success_Label);
            this.Pricing_GroupBox.Controls.Add(this.keyCodeComboBox);
            this.Pricing_GroupBox.Controls.Add(presetPrintLabel1);
            this.Pricing_GroupBox.Controls.Add(this.presetPrintComboBox);
            this.Pricing_GroupBox.Controls.Add(keyCodeLabel);
            this.Pricing_GroupBox.Controls.Add(presetCodeLabel);
            this.Pricing_GroupBox.Controls.Add(this.presetCodeTextBox);
            this.Pricing_GroupBox.Controls.Add(this.Update_Button);
            this.Pricing_GroupBox.Controls.Add(presetPictureLabel);
            this.Pricing_GroupBox.Controls.Add(presetDescLabel);
            this.Pricing_GroupBox.Controls.Add(this.presetDescTextBox);
            this.Pricing_GroupBox.Controls.Add(presetLegendLabel);
            this.Pricing_GroupBox.Controls.Add(this.presetLegendTextBox);
            this.Pricing_GroupBox.Controls.Add(presetTaxLabel);
            this.Pricing_GroupBox.Controls.Add(this.presetTaxTextBox);
            this.Pricing_GroupBox.Controls.Add(presetPriceLabel);
            this.Pricing_GroupBox.Controls.Add(this.presetPriceTextBox);
            this.Pricing_GroupBox.Controls.Add(presetReceiptLabel);
            this.Pricing_GroupBox.Controls.Add(this.presetReceiptTextBox);
            this.Pricing_GroupBox.Controls.Add(presetPrice2Label);
            this.Pricing_GroupBox.Controls.Add(presetPrice6Label);
            this.Pricing_GroupBox.Controls.Add(this.presetPrice2TextBox);
            this.Pricing_GroupBox.Controls.Add(this.presetPrice8TextBox);
            this.Pricing_GroupBox.Controls.Add(presetPrice3Label);
            this.Pricing_GroupBox.Controls.Add(presetPrice8Label);
            this.Pricing_GroupBox.Controls.Add(this.presetPrice3TextBox);
            this.Pricing_GroupBox.Controls.Add(this.presetPrice7TextBox);
            this.Pricing_GroupBox.Controls.Add(presetPrice4Label);
            this.Pricing_GroupBox.Controls.Add(presetPrice7Label);
            this.Pricing_GroupBox.Controls.Add(this.presetPrice4TextBox);
            this.Pricing_GroupBox.Controls.Add(this.presetPrice6TextBox);
            this.Pricing_GroupBox.Controls.Add(presetPrice5Label);
            this.Pricing_GroupBox.Controls.Add(this.presetPrice5TextBox);
            this.Pricing_GroupBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pricing_GroupBox.Location = new System.Drawing.Point(0, 0);
            this.Pricing_GroupBox.Name = "Pricing_GroupBox";
            this.Pricing_GroupBox.Padding = new System.Windows.Forms.Padding(5);
            this.Pricing_GroupBox.Size = new System.Drawing.Size(300, 633);
            this.Pricing_GroupBox.TabIndex = 107;
            this.Pricing_GroupBox.TabStop = false;
            this.Pricing_GroupBox.Text = "Pricing Information";
            // 
            // ModifierButton
            // 
            this.ModifierButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifierButton.Location = new System.Drawing.Point(227, 503);
            this.ModifierButton.Name = "ModifierButton";
            this.ModifierButton.Size = new System.Drawing.Size(65, 23);
            this.ModifierButton.TabIndex = 148;
            this.ModifierButton.Text = "Modifiers";
            this.ModifierButton.UseVisualStyleBackColor = true;
            this.ModifierButton.Visible = false;
            this.ModifierButton.Click += new System.EventHandler(this.ModifierButton_Click);
            // 
            // presetMasterBindingNavigator
            // 
            this.presetMasterBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.presetMasterBindingNavigator.BindingSource = this.presetMasterBindingSource;
            this.presetMasterBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.presetMasterBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.presetMasterBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.presetMasterBindingNavigator.Location = new System.Drawing.Point(5, 18);
            this.presetMasterBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.presetMasterBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.presetMasterBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.presetMasterBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.presetMasterBindingNavigator.Name = "presetMasterBindingNavigator";
            this.presetMasterBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.presetMasterBindingNavigator.Size = new System.Drawing.Size(290, 25);
            this.presetMasterBindingNavigator.TabIndex = 147;
            this.presetMasterBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Enabled = false;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ChitSettings_GroupBox
            // 
            this.ChitSettings_GroupBox.Controls.Add(this.Remote2_CheckBox);
            this.ChitSettings_GroupBox.Controls.Add(this.Remote1_CheckBox);
            this.ChitSettings_GroupBox.Controls.Add(this.PresetChippable_CheckBox);
            this.ChitSettings_GroupBox.Location = new System.Drawing.Point(8, 471);
            this.ChitSettings_GroupBox.Name = "ChitSettings_GroupBox";
            this.ChitSettings_GroupBox.Size = new System.Drawing.Size(139, 88);
            this.ChitSettings_GroupBox.TabIndex = 108;
            this.ChitSettings_GroupBox.TabStop = false;
            this.ChitSettings_GroupBox.Text = "Chit/Scan Settings";
            // 
            // Remote2_CheckBox
            // 
            this.Remote2_CheckBox.AutoSize = true;
            this.Remote2_CheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Remote2_CheckBox.Location = new System.Drawing.Point(6, 65);
            this.Remote2_CheckBox.Name = "Remote2_CheckBox";
            this.Remote2_CheckBox.Size = new System.Drawing.Size(119, 17);
            this.Remote2_CheckBox.TabIndex = 138;
            this.Remote2_CheckBox.TabStop = false;
            this.Remote2_CheckBox.Text = "Send to Remote #2";
            this.Remote2_CheckBox.UseVisualStyleBackColor = true;
            // 
            // Remote1_CheckBox
            // 
            this.Remote1_CheckBox.AutoSize = true;
            this.Remote1_CheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Remote1_CheckBox.Location = new System.Drawing.Point(6, 42);
            this.Remote1_CheckBox.Name = "Remote1_CheckBox";
            this.Remote1_CheckBox.Size = new System.Drawing.Size(119, 17);
            this.Remote1_CheckBox.TabIndex = 137;
            this.Remote1_CheckBox.TabStop = false;
            this.Remote1_CheckBox.Text = "Send to Remote #1";
            this.Remote1_CheckBox.UseVisualStyleBackColor = true;
            // 
            // PresetChippable_CheckBox
            // 
            this.PresetChippable_CheckBox.AutoSize = true;
            this.PresetChippable_CheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PresetChippable_CheckBox.Location = new System.Drawing.Point(52, 19);
            this.PresetChippable_CheckBox.Name = "PresetChippable_CheckBox";
            this.PresetChippable_CheckBox.Size = new System.Drawing.Size(73, 17);
            this.PresetChippable_CheckBox.TabIndex = 136;
            this.PresetChippable_CheckBox.TabStop = false;
            this.PresetChippable_CheckBox.Text = "Chippable";
            this.PresetChippable_CheckBox.UseVisualStyleBackColor = true;
            // 
            // ConfirmAdd_Button
            // 
            this.ConfirmAdd_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ConfirmAdd_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmAdd_Button.Location = new System.Drawing.Point(227, 563);
            this.ConfirmAdd_Button.Name = "ConfirmAdd_Button";
            this.ConfirmAdd_Button.Size = new System.Drawing.Size(65, 26);
            this.ConfirmAdd_Button.TabIndex = 17;
            this.ConfirmAdd_Button.Text = "Confirm";
            this.ConfirmAdd_Button.UseVisualStyleBackColor = true;
            this.ConfirmAdd_Button.Visible = false;
            this.ConfirmAdd_Button.Click += new System.EventHandler(this.ConfirmAdd_Button_Click);
            // 
            // CurrentlyAdding_Label
            // 
            this.CurrentlyAdding_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CurrentlyAdding_Label.AutoSize = true;
            this.CurrentlyAdding_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentlyAdding_Label.ForeColor = System.Drawing.Color.Blue;
            this.CurrentlyAdding_Label.Location = new System.Drawing.Point(8, 578);
            this.CurrentlyAdding_Label.Name = "CurrentlyAdding_Label";
            this.CurrentlyAdding_Label.Size = new System.Drawing.Size(177, 17);
            this.CurrentlyAdding_Label.TabIndex = 146;
            this.CurrentlyAdding_Label.Text = "Currently Adding New Item!";
            this.CurrentlyAdding_Label.Visible = false;
            // 
            // CanceledChanges_Label
            // 
            this.CanceledChanges_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CanceledChanges_Label.AutoSize = true;
            this.CanceledChanges_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CanceledChanges_Label.ForeColor = System.Drawing.Color.Red;
            this.CanceledChanges_Label.Location = new System.Drawing.Point(8, 595);
            this.CanceledChanges_Label.Name = "CanceledChanges_Label";
            this.CanceledChanges_Label.Size = new System.Drawing.Size(212, 17);
            this.CanceledChanges_Label.TabIndex = 145;
            this.CanceledChanges_Label.Text = "Canceled Changes Successfully!";
            this.CanceledChanges_Label.Visible = false;
            // 
            // UpdateRow_Label
            // 
            this.UpdateRow_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UpdateRow_Label.AutoSize = true;
            this.UpdateRow_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateRow_Label.ForeColor = System.Drawing.Color.Orange;
            this.UpdateRow_Label.Location = new System.Drawing.Point(8, 612);
            this.UpdateRow_Label.Name = "UpdateRow_Label";
            this.UpdateRow_Label.Size = new System.Drawing.Size(175, 17);
            this.UpdateRow_Label.TabIndex = 144;
            this.UpdateRow_Label.Text = "Successfully Updated Row";
            this.UpdateRow_Label.Visible = false;
            // 
            // bitMap_ComboBox
            // 
            this.bitMap_ComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.bitMap_ComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.bitMap_ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetPicture", true));
            this.bitMap_ComboBox.FormattingEnabled = true;
            this.bitMap_ComboBox.Items.AddRange(new object[] {
            "<None>"});
            this.bitMap_ComboBox.Location = new System.Drawing.Point(98, 127);
            this.bitMap_ComboBox.Name = "bitMap_ComboBox";
            this.bitMap_ComboBox.Size = new System.Drawing.Size(188, 21);
            this.bitMap_ComboBox.TabIndex = 3;
            this.bitMap_ComboBox.Text = "Button Picture";
            this.bitMap_ComboBox.SelectedValueChanged += new System.EventHandler(this.bitMap_ComboBox_SelectedValueChanged);
            // 
            // CancelChanges_Button
            // 
            this.CancelChanges_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelChanges_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelChanges_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelChanges_Button.Location = new System.Drawing.Point(227, 595);
            this.CancelChanges_Button.Name = "CancelChanges_Button";
            this.CancelChanges_Button.Size = new System.Drawing.Size(65, 35);
            this.CancelChanges_Button.TabIndex = 18;
            this.CancelChanges_Button.Text = "Cancel All Changes";
            this.CancelChanges_Button.UseVisualStyleBackColor = true;
            this.CancelChanges_Button.Visible = false;
            this.CancelChanges_Button.Click += new System.EventHandler(this.CancelChanges_Button_Click);
            // 
            // Success_Label
            // 
            this.Success_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Success_Label.AutoSize = true;
            this.Success_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Success_Label.ForeColor = System.Drawing.Color.Green;
            this.Success_Label.Location = new System.Drawing.Point(8, 561);
            this.Success_Label.Name = "Success_Label";
            this.Success_Label.Size = new System.Drawing.Size(196, 17);
            this.Success_Label.TabIndex = 142;
            this.Success_Label.Text = "Successfully Added New Row!";
            this.Success_Label.Visible = false;
            // 
            // keyCodeComboBox
            // 
            this.keyCodeComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.keyCodeComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.keyCodeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "KeyCode", true));
            this.keyCodeComboBox.FormattingEnabled = true;
            this.keyCodeComboBox.Location = new System.Drawing.Point(98, 75);
            this.keyCodeComboBox.Name = "keyCodeComboBox";
            this.keyCodeComboBox.Size = new System.Drawing.Size(108, 21);
            this.keyCodeComboBox.TabIndex = 1;
            // 
            // presetPrintComboBox
            // 
            this.presetPrintComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetPrint", true));
            this.presetPrintComboBox.FormattingEnabled = true;
            this.presetPrintComboBox.Items.AddRange(new object[] {
            "Y",
            "N",
            "C",
            "O",
            "S",
            "B"});
            this.presetPrintComboBox.Location = new System.Drawing.Point(98, 232);
            this.presetPrintComboBox.Name = "presetPrintComboBox";
            this.presetPrintComboBox.Size = new System.Drawing.Size(108, 21);
            this.presetPrintComboBox.TabIndex = 8;
            // 
            // presetCodeTextBox
            // 
            this.presetCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetCode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.presetCodeTextBox.Location = new System.Drawing.Point(98, 101);
            this.presetCodeTextBox.MaxLength = 10;
            this.presetCodeTextBox.Name = "presetCodeTextBox";
            this.presetCodeTextBox.Size = new System.Drawing.Size(188, 20);
            this.presetCodeTextBox.TabIndex = 2;
            // 
            // Update_Button
            // 
            this.Update_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Update_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Button.Location = new System.Drawing.Point(227, 532);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(65, 25);
            this.Update_Button.TabIndex = 0;
            this.Update_Button.TabStop = false;
            this.Update_Button.Text = "Update";
            this.Update_Button.UseVisualStyleBackColor = true;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // presetDescTextBox
            // 
            this.presetDescTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.presetDescTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetDesc", true));
            this.presetDescTextBox.Location = new System.Drawing.Point(98, 49);
            this.presetDescTextBox.Name = "presetDescTextBox";
            this.presetDescTextBox.Size = new System.Drawing.Size(188, 20);
            this.presetDescTextBox.TabIndex = 0;
            this.presetDescTextBox.TextChanged += new System.EventHandler(this.presetDescTextBox_TextChanged);
            // 
            // presetLegendTextBox
            // 
            this.presetLegendTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetLegend", true));
            this.presetLegendTextBox.Location = new System.Drawing.Point(98, 154);
            this.presetLegendTextBox.Name = "presetLegendTextBox";
            this.presetLegendTextBox.Size = new System.Drawing.Size(188, 20);
            this.presetLegendTextBox.TabIndex = 4;
            this.presetLegendTextBox.TextChanged += new System.EventHandler(this.presetLegendTextBox_TextChanged);
            // 
            // presetTaxTextBox
            // 
            this.presetTaxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetTax", true));
            this.presetTaxTextBox.Location = new System.Drawing.Point(98, 206);
            this.presetTaxTextBox.Name = "presetTaxTextBox";
            this.presetTaxTextBox.Size = new System.Drawing.Size(108, 20);
            this.presetTaxTextBox.TabIndex = 7;
            // 
            // presetPriceTextBox
            // 
            this.presetPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.presetPriceTextBox.Location = new System.Drawing.Point(98, 259);
            this.presetPriceTextBox.Name = "presetPriceTextBox";
            this.presetPriceTextBox.Size = new System.Drawing.Size(108, 20);
            this.presetPriceTextBox.TabIndex = 9;
            this.presetPriceTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.presetPriceTextBox_KeyDown);
            this.presetPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.presetPriceTextBox_KeyPress);
            // 
            // presetReceiptTextBox
            // 
            this.presetReceiptTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetReceipt", true));
            this.presetReceiptTextBox.Location = new System.Drawing.Point(98, 180);
            this.presetReceiptTextBox.Name = "presetReceiptTextBox";
            this.presetReceiptTextBox.Size = new System.Drawing.Size(108, 20);
            this.presetReceiptTextBox.TabIndex = 5;
            this.presetReceiptTextBox.Text = " ";
            // 
            // presetPrice2TextBox
            // 
            this.presetPrice2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetPrice2", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.presetPrice2TextBox.Location = new System.Drawing.Point(98, 285);
            this.presetPrice2TextBox.Name = "presetPrice2TextBox";
            this.presetPrice2TextBox.Size = new System.Drawing.Size(108, 20);
            this.presetPrice2TextBox.TabIndex = 10;
            // 
            // presetPrice8TextBox
            // 
            this.presetPrice8TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetPrice8", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.presetPrice8TextBox.Location = new System.Drawing.Point(98, 445);
            this.presetPrice8TextBox.Name = "presetPrice8TextBox";
            this.presetPrice8TextBox.Size = new System.Drawing.Size(108, 20);
            this.presetPrice8TextBox.TabIndex = 16;
            // 
            // presetPrice3TextBox
            // 
            this.presetPrice3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetPrice3", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.presetPrice3TextBox.Location = new System.Drawing.Point(98, 312);
            this.presetPrice3TextBox.Name = "presetPrice3TextBox";
            this.presetPrice3TextBox.Size = new System.Drawing.Size(108, 20);
            this.presetPrice3TextBox.TabIndex = 11;
            // 
            // presetPrice7TextBox
            // 
            this.presetPrice7TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetPrice7", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.presetPrice7TextBox.Location = new System.Drawing.Point(98, 419);
            this.presetPrice7TextBox.Name = "presetPrice7TextBox";
            this.presetPrice7TextBox.Size = new System.Drawing.Size(108, 20);
            this.presetPrice7TextBox.TabIndex = 15;
            // 
            // presetPrice4TextBox
            // 
            this.presetPrice4TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetPrice4", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.presetPrice4TextBox.Location = new System.Drawing.Point(98, 339);
            this.presetPrice4TextBox.Name = "presetPrice4TextBox";
            this.presetPrice4TextBox.Size = new System.Drawing.Size(108, 20);
            this.presetPrice4TextBox.TabIndex = 12;
            // 
            // presetPrice6TextBox
            // 
            this.presetPrice6TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetPrice6", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.presetPrice6TextBox.Location = new System.Drawing.Point(98, 392);
            this.presetPrice6TextBox.Name = "presetPrice6TextBox";
            this.presetPrice6TextBox.Size = new System.Drawing.Size(108, 20);
            this.presetPrice6TextBox.TabIndex = 14;
            // 
            // presetPrice5TextBox
            // 
            this.presetPrice5TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetPrice5", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.presetPrice5TextBox.Location = new System.Drawing.Point(98, 366);
            this.presetPrice5TextBox.Name = "presetPrice5TextBox";
            this.presetPrice5TextBox.Size = new System.Drawing.Size(108, 20);
            this.presetPrice5TextBox.TabIndex = 13;
            // 
            // PresetSplitContainer
            // 
            this.PresetSplitContainer.AllowDrop = true;
            this.PresetSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PresetSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.PresetSplitContainer.Location = new System.Drawing.Point(399, 174);
            this.PresetSplitContainer.Name = "PresetSplitContainer";
            this.PresetSplitContainer.Panel1Collapsed = true;
            // 
            // PresetSplitContainer.Panel2
            // 
            this.PresetSplitContainer.Panel2.Controls.Add(this.MyPriorityControl);
            this.PresetSplitContainer.Panel2.Controls.Add(this.presetTrashBin);
            this.PresetSplitContainer.Size = new System.Drawing.Size(317, 456);
            this.PresetSplitContainer.SplitterDistance = 192;
            this.PresetSplitContainer.TabIndex = 106;
            this.PresetSplitContainer.TabStop = false;
            // 
            // MyPriorityControl
            // 
            this.MyPriorityControl.AllowDrop = true;
            this.MyPriorityControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyPriorityControl.Location = new System.Drawing.Point(0, 113);
            this.MyPriorityControl.Name = "MyPriorityControl";
            this.MyPriorityControl.ParentForm = null;
            this.MyPriorityControl.Size = new System.Drawing.Size(317, 343);
            this.MyPriorityControl.TabIndex = 0;
            // 
            // presetTrashBin
            // 
            this.presetTrashBin.Controls.Add(this.TrashBin_Panel);
            this.presetTrashBin.Dock = System.Windows.Forms.DockStyle.Top;
            this.presetTrashBin.Location = new System.Drawing.Point(0, 0);
            this.presetTrashBin.Name = "presetTrashBin";
            this.presetTrashBin.Size = new System.Drawing.Size(317, 113);
            this.presetTrashBin.TabIndex = 109;
            this.presetTrashBin.TabStop = false;
            this.presetTrashBin.Text = "Items to Remove from Screen";
            // 
            // TrashBin_Panel
            // 
            this.TrashBin_Panel.AllowDrop = true;
            this.TrashBin_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TrashBin_Panel.Location = new System.Drawing.Point(3, 16);
            this.TrashBin_Panel.Name = "TrashBin_Panel";
            this.TrashBin_Panel.Size = new System.Drawing.Size(311, 94);
            this.TrashBin_Panel.TabIndex = 0;
            // 
            // SearchResults_Label
            // 
            this.SearchResults_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchResults_Label.AutoSize = true;
            this.SearchResults_Label.Location = new System.Drawing.Point(642, 158);
            this.SearchResults_Label.Name = "SearchResults_Label";
            this.SearchResults_Label.Size = new System.Drawing.Size(71, 13);
            this.SearchResults_Label.TabIndex = 100;
            this.SearchResults_Label.Text = "Items Found: ";
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.Location = new System.Drawing.Point(694, 125);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(20, 25);
            this.ClearButton.TabIndex = 2;
            this.ClearButton.Text = "X";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // PresetSearch_Button
            // 
            this.PresetSearch_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PresetSearch_Button.Location = new System.Drawing.Point(632, 125);
            this.PresetSearch_Button.Name = "PresetSearch_Button";
            this.PresetSearch_Button.Size = new System.Drawing.Size(56, 25);
            this.PresetSearch_Button.TabIndex = 1;
            this.PresetSearch_Button.Text = "Search";
            this.PresetSearch_Button.UseVisualStyleBackColor = true;
            this.PresetSearch_Button.Click += new System.EventHandler(this.PresetSearch_Button_Click);
            // 
            // PresetSearchLabel
            // 
            this.PresetSearchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PresetSearchLabel.Location = new System.Drawing.Point(449, 99);
            this.PresetSearchLabel.Name = "PresetSearchLabel";
            this.PresetSearchLabel.Size = new System.Drawing.Size(94, 20);
            this.PresetSearchLabel.TabIndex = 12;
            this.PresetSearchLabel.Text = "Search for Preset";
            this.PresetSearchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PresetSearch_TextBox
            // 
            this.PresetSearch_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PresetSearch_TextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.PresetSearch_TextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.PresetSearch_TextBox.Location = new System.Drawing.Point(549, 100);
            this.PresetSearch_TextBox.Name = "PresetSearch_TextBox";
            this.PresetSearch_TextBox.Size = new System.Drawing.Size(164, 20);
            this.PresetSearch_TextBox.TabIndex = 0;
            // 
            // customGrpBox1
            // 
            this.customGrpBox1.Controls.Add(this.CurrentPreset_Button);
            this.customGrpBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customGrpBox1.Location = new System.Drawing.Point(305, 124);
            this.customGrpBox1.Name = "customGrpBox1";
            this.customGrpBox1.Size = new System.Drawing.Size(91, 92);
            this.customGrpBox1.TabIndex = 99;
            this.customGrpBox1.TabStop = false;
            this.customGrpBox1.Text = "Current Preset";
            // 
            // CurrentPreset_Button
            // 
            this.CurrentPreset_Button.AutoEllipsis = true;
            this.CurrentPreset_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CurrentPreset_Button.BackColor = System.Drawing.Color.White;
            this.CurrentPreset_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CurrentPreset_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentPreset_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPreset_Button.Location = new System.Drawing.Point(3, 17);
            this.CurrentPreset_Button.Name = "CurrentPreset_Button";
            this.CurrentPreset_Button.Size = new System.Drawing.Size(85, 72);
            this.CurrentPreset_Button.TabIndex = 0;
            this.CurrentPreset_Button.TabStop = false;
            this.CurrentPreset_Button.Text = "Bud Lite";
            this.CurrentPreset_Button.UseVisualStyleBackColor = false;
            this.CurrentPreset_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CurrentPreset_Button_MouseDown);
            this.CurrentPreset_Button.MouseMove += new System.Windows.Forms.MouseEventHandler(this.CurrentPreset_Button_MouseMove);
            // 
            // CollapseNodes_Button
            // 
            this.CollapseNodes_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CollapseNodes_Button.Location = new System.Drawing.Point(456, 125);
            this.CollapseNodes_Button.Name = "CollapseNodes_Button";
            this.CollapseNodes_Button.Size = new System.Drawing.Size(82, 25);
            this.CollapseNodes_Button.TabIndex = 4;
            this.CollapseNodes_Button.Text = "Collapse Keys";
            this.CollapseNodes_Button.UseVisualStyleBackColor = true;
            this.CollapseNodes_Button.Click += new System.EventHandler(this.CollapseNodes_Button_Click);
            // 
            // ExpandNodes_Button
            // 
            this.ExpandNodes_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpandNodes_Button.Location = new System.Drawing.Point(544, 125);
            this.ExpandNodes_Button.Name = "ExpandNodes_Button";
            this.ExpandNodes_Button.Size = new System.Drawing.Size(82, 25);
            this.ExpandNodes_Button.TabIndex = 3;
            this.ExpandNodes_Button.Text = "Expand Keys";
            this.ExpandNodes_Button.UseVisualStyleBackColor = true;
            this.ExpandNodes_Button.Click += new System.EventHandler(this.ExpandNodes_Button_Click);
            // 
            // CurrentKey_GroupBox
            // 
            this.CurrentKey_GroupBox.Controls.Add(this.KeyPreview_Button);
            this.CurrentKey_GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentKey_GroupBox.Location = new System.Drawing.Point(306, 4);
            this.CurrentKey_GroupBox.Name = "CurrentKey_GroupBox";
            this.CurrentKey_GroupBox.Size = new System.Drawing.Size(116, 117);
            this.CurrentKey_GroupBox.TabIndex = 99;
            this.CurrentKey_GroupBox.TabStop = false;
            this.CurrentKey_GroupBox.Text = "Current Key";
            // 
            // KeyPreview_Button
            // 
            this.KeyPreview_Button.AutoEllipsis = true;
            this.KeyPreview_Button.BackColor = System.Drawing.Color.Lime;
            this.KeyPreview_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.KeyPreview_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KeyPreview_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview_Button.Location = new System.Drawing.Point(3, 17);
            this.KeyPreview_Button.Name = "KeyPreview_Button";
            this.KeyPreview_Button.Size = new System.Drawing.Size(110, 97);
            this.KeyPreview_Button.TabIndex = 0;
            this.KeyPreview_Button.TabStop = false;
            this.KeyPreview_Button.Text = "Bottled Beer";
            this.KeyPreview_Button.UseVisualStyleBackColor = false;
            // 
            // DataBoundTree
            // 
            this.DataBoundTree.AllowDrop = true;
            this.DataBoundTree.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataBoundTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataBoundTree.Location = new System.Drawing.Point(0, 0);
            this.DataBoundTree.Name = "DataBoundTree";
            this.DataBoundTree.Size = new System.Drawing.Size(287, 633);
            this.DataBoundTree.TabIndex = 1;
            // 
            // presetMasterTableAdapter
            // 
            this.presetMasterTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GoToPriorTableAdapter = null;
            this.tableAdapterManager.KeyMasterTableAdapter = null;
            this.tableAdapterManager.ModifierTableAdapter = null;
            this.tableAdapterManager.ModTemplateTableAdapter = null;
            this.tableAdapterManager.PresetMasterTableAdapter = this.presetMasterTableAdapter;
            this.tableAdapterManager.UpdateOrder = Preset_Maintenance.jartrekDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // keyMasterTableAdapter1
            // 
            this.keyMasterTableAdapter1.ClearBeforeFill = true;
            // 
            // GoToPriorAdapter
            // 
            this.GoToPriorAdapter.ClearBeforeFill = true;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Currently Building Database";
            this.notifyIcon1.BalloonTipTitle = "Build Status";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Database Construction in Progress...";
            this.notifyIcon1.Visible = true;
            // 
            // PresetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.CancelChanges_Button;
            this.ClientSize = new System.Drawing.Size(1011, 633);
            this.Controls.Add(this.Main_SplitCon);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1027, 671);
            this.Name = "PresetForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preset Maintenance";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PresetForm_FormClosing);
            this.Load += new System.EventHandler(this.PresetForm_Load);
            this.Main_SplitCon.Panel1.ResumeLayout(false);
            this.Main_SplitCon.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Main_SplitCon)).EndInit();
            this.Main_SplitCon.ResumeLayout(false);
            this.Nested_SplitCon.Panel1.ResumeLayout(false);
            this.Nested_SplitCon.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nested_SplitCon)).EndInit();
            this.Nested_SplitCon.ResumeLayout(false);
            this.SearchResults_GroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchResults_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presetMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jartrekDataSet)).EndInit();
            this.ColorPicker_GroupBox.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.Pricing_GroupBox.ResumeLayout(false);
            this.Pricing_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.presetMasterBindingNavigator)).EndInit();
            this.presetMasterBindingNavigator.ResumeLayout(false);
            this.presetMasterBindingNavigator.PerformLayout();
            this.ChitSettings_GroupBox.ResumeLayout(false);
            this.ChitSettings_GroupBox.PerformLayout();
            this.PresetSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PresetSplitContainer)).EndInit();
            this.PresetSplitContainer.ResumeLayout(false);
            this.presetTrashBin.ResumeLayout(false);
            this.customGrpBox1.ResumeLayout(false);
            this.CurrentKey_GroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer Main_SplitCon;
        private CustomGrpBox CurrentKey_GroupBox;
        private System.Windows.Forms.SplitContainer Nested_SplitCon;
        private System.Windows.Forms.Button ViewKeys_Button;
        private System.Windows.Forms.Button ExpandNodes_Button;
        private System.Windows.Forms.Button CollapseNodes_Button;
        private CustomGrpBox customGrpBox1;
        private System.Windows.Forms.Button PresetSearch_Button;
        private System.Windows.Forms.Label PresetSearchLabel;
        private System.Windows.Forms.TextBox PresetSearch_TextBox;
        private System.Windows.Forms.Button ClearButton;
        public jartrekDataSet jartrekDataSet;
        public jartrekDataSetTableAdapters.PresetMasterTableAdapter presetMasterTableAdapter;
        public jartrekDataSetTableAdapters.GoToPriorTableAdapter GoToPriorAdapter;
        public jartrekDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.BindingSource presetMasterBindingSource;
        private System.Windows.Forms.Label SearchResults_Label;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.Button ConfirmAdd_Button;
        private System.Windows.Forms.GroupBox SearchResults_GroupBox;
        public System.Windows.Forms.DataGridView searchResults_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PresetDesc;
        public System.Windows.Forms.SplitContainer PresetSplitContainer;
        private System.Windows.Forms.ComboBox bitMap_ComboBox;
        public CustomGrpBox Pricing_GroupBox;
        private System.Windows.Forms.TextBox presetCodeTextBox;
        private System.Windows.Forms.TextBox presetDescTextBox;
        private System.Windows.Forms.TextBox presetLegendTextBox;
        private System.Windows.Forms.TextBox presetTaxTextBox;
        private System.Windows.Forms.TextBox presetPriceTextBox;
        private System.Windows.Forms.TextBox presetReceiptTextBox;
        private System.Windows.Forms.TextBox presetPrice2TextBox;
        private System.Windows.Forms.TextBox presetPrice8TextBox;
        private System.Windows.Forms.TextBox presetPrice3TextBox;
        private System.Windows.Forms.TextBox presetPrice7TextBox;
        private System.Windows.Forms.TextBox presetPrice4TextBox;
        private System.Windows.Forms.TextBox presetPrice6TextBox;
        private System.Windows.Forms.TextBox presetPrice5TextBox;
        private CustomGrpBox ChitSettings_GroupBox;
        private System.Windows.Forms.CheckBox Remote2_CheckBox;
        private System.Windows.Forms.CheckBox Remote1_CheckBox;
        private System.Windows.Forms.CheckBox PresetChippable_CheckBox;
        private System.Windows.Forms.ComboBox presetPrintComboBox;
        private System.Windows.Forms.ComboBox keyCodeComboBox;
        private System.Windows.Forms.Label Success_Label;
        private System.Windows.Forms.Label CanceledChanges_Label;
        private System.Windows.Forms.Label UpdateRow_Label;
        private System.Windows.Forms.Button CancelChanges_Button;
        private System.Windows.Forms.Label CurrentlyAdding_Label;
        private jartrekDataSetTableAdapters.KeyMasterTableAdapter keyMasterTableAdapter1;
        private System.Windows.Forms.BindingNavigator presetMasterBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        public Preset_Maintenance.DataBoundTreeView DataBoundTree;
        private CustomGrpBox presetTrashBin;
        public PresetPriorityControl MyPriorityControl;
        private System.Windows.Forms.FlowLayoutPanel TrashBin_Panel;
        private Preset_Maintenance.DataBoundTreeView NewItem_TreeView;
        public System.Windows.Forms.Button CurrentPreset_Button;
        public System.Windows.Forms.Button KeyPreview_Button;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private CustomGrpBox ColorPicker_GroupBox;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ModifierButton;
    }
}

