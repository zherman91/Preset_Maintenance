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
            System.Windows.Forms.Label presetPriorityLabel;
            System.Windows.Forms.Label preRemPrt1Label;
            System.Windows.Forms.Label preRemPrt2Label;
            System.Windows.Forms.Label presetChippableLabel;
            System.Windows.Forms.Label presetPrintLabel1;
            System.Windows.Forms.Label keyCodeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PresetForm));
            System.Windows.Forms.Label presetCodeLabel;
            System.Windows.Forms.Label presetColorLabel;
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
            this.Main_SplitCon = new System.Windows.Forms.SplitContainer();
            this.Nested_SplitCon = new System.Windows.Forms.SplitContainer();
            this.presetMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jartrekDataSet = new Preset_Maintenance.jartrekDataSet();
            this.ConfirmAdd_Button = new System.Windows.Forms.Button();
            this.PresetSplitContainer = new System.Windows.Forms.SplitContainer();
            this.bitMap_ComboBox = new System.Windows.Forms.ComboBox();
            this.PresetPriority_Label = new System.Windows.Forms.Label();
            this.presetPriorityTextBox = new System.Windows.Forms.TextBox();
            this.SearchResults_GroupBox = new System.Windows.Forms.GroupBox();
            this.searchResults_DataGridView = new System.Windows.Forms.DataGridView();
            this.PresetDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchResults_Label = new System.Windows.Forms.Label();
            this.Update_Button = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.PresetSearch_Button = new System.Windows.Forms.Button();
            this.PresetSearchLabel = new System.Windows.Forms.Label();
            this.PresetSearch_TextBox = new System.Windows.Forms.TextBox();
            this.CollapseNodes_Button = new System.Windows.Forms.Button();
            this.ExpandNodes_Button = new System.Windows.Forms.Button();
            this.ViewKeys_Button = new System.Windows.Forms.Button();
            this.MainTreeView = new System.Windows.Forms.TreeView();
            this.presetDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.presetMasterTableAdapter = new Preset_Maintenance.jartrekDataSetTableAdapters.PresetMasterTableAdapter();
            this.tableAdapterManager = new Preset_Maintenance.jartrekDataSetTableAdapters.TableAdapterManager();
            this.presetDataTableAdapter = new Preset_Maintenance.jartrekDataSetTableAdapters.PresetDataTableAdapter();
            this.ChitSettings_GroupBox = new Preset_Maintenance.CustomGrpBox();
            this.preRemPrt1TextBox = new System.Windows.Forms.TextBox();
            this.Remote2_CheckBox = new System.Windows.Forms.CheckBox();
            this.preRemPrt2TextBox = new System.Windows.Forms.TextBox();
            this.Remote1_CheckBox = new System.Windows.Forms.CheckBox();
            this.PresetChippable_CheckBox = new System.Windows.Forms.CheckBox();
            this.presetChippableTextBox = new System.Windows.Forms.TextBox();
            this.Pricing_GroupBox = new Preset_Maintenance.CustomGrpBox();
            this.presetPrintComboBox = new System.Windows.Forms.ComboBox();
            this.keyCodeTextBox = new System.Windows.Forms.TextBox();
            this.presetMasterBindingNaviagator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.presetCodeTextBox = new System.Windows.Forms.TextBox();
            this.presetColorTextBox = new System.Windows.Forms.TextBox();
            this.presetPictureTextBox = new System.Windows.Forms.TextBox();
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
            this.presetTrashBin = new Preset_Maintenance.CustomGrpBox();
            this.presetClipBoard = new Preset_Maintenance.CustomGrpBox();
            this.Preset_GroupBox = new Preset_Maintenance.CustomGrpBox();
            this.presetPanel = new System.Windows.Forms.Panel();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button28 = new System.Windows.Forms.Button();
            this.button29 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button07 = new System.Windows.Forms.Button();
            this.button08 = new System.Windows.Forms.Button();
            this.button09 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button06 = new System.Windows.Forms.Button();
            this.button05 = new System.Windows.Forms.Button();
            this.button04 = new System.Windows.Forms.Button();
            this.button03 = new System.Windows.Forms.Button();
            this.button02 = new System.Windows.Forms.Button();
            this.button01 = new System.Windows.Forms.Button();
            this.customGrpBox1 = new Preset_Maintenance.CustomGrpBox();
            this.CurrentPreset_Button = new System.Windows.Forms.Button();
            this.CurrentKey_GroupBox = new Preset_Maintenance.CustomGrpBox();
            this.KeyPreview_Button = new System.Windows.Forms.Button();
            presetPriorityLabel = new System.Windows.Forms.Label();
            preRemPrt1Label = new System.Windows.Forms.Label();
            preRemPrt2Label = new System.Windows.Forms.Label();
            presetChippableLabel = new System.Windows.Forms.Label();
            presetPrintLabel1 = new System.Windows.Forms.Label();
            keyCodeLabel = new System.Windows.Forms.Label();
            presetCodeLabel = new System.Windows.Forms.Label();
            presetColorLabel = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.presetMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jartrekDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PresetSplitContainer)).BeginInit();
            this.PresetSplitContainer.Panel1.SuspendLayout();
            this.PresetSplitContainer.Panel2.SuspendLayout();
            this.PresetSplitContainer.SuspendLayout();
            this.SearchResults_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResults_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presetDataBindingSource)).BeginInit();
            this.ChitSettings_GroupBox.SuspendLayout();
            this.Pricing_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.presetMasterBindingNaviagator)).BeginInit();
            this.presetMasterBindingNaviagator.SuspendLayout();
            this.Preset_GroupBox.SuspendLayout();
            this.presetPanel.SuspendLayout();
            this.customGrpBox1.SuspendLayout();
            this.CurrentKey_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // presetPriorityLabel
            // 
            presetPriorityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            presetPriorityLabel.AutoSize = true;
            presetPriorityLabel.Location = new System.Drawing.Point(4, 6);
            presetPriorityLabel.Name = "presetPriorityLabel";
            presetPriorityLabel.Size = new System.Drawing.Size(74, 13);
            presetPriorityLabel.TabIndex = 101;
            presetPriorityLabel.Text = "Preset Priority:";
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
            this.Main_SplitCon.Panel2.Controls.Add(this.MainTreeView);
            this.Main_SplitCon.Size = new System.Drawing.Size(1267, 744);
            this.Main_SplitCon.SplitterDistance = 1015;
            this.Main_SplitCon.SplitterWidth = 2;
            this.Main_SplitCon.TabIndex = 0;
            // 
            // Nested_SplitCon
            // 
            this.Nested_SplitCon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Nested_SplitCon.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.Nested_SplitCon.Location = new System.Drawing.Point(0, 0);
            this.Nested_SplitCon.Margin = new System.Windows.Forms.Padding(2);
            this.Nested_SplitCon.Name = "Nested_SplitCon";
            this.Nested_SplitCon.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Nested_SplitCon.Panel1
            // 
            this.Nested_SplitCon.Panel1.AutoScroll = true;
            this.Nested_SplitCon.Panel1.Controls.Add(this.ChitSettings_GroupBox);
            this.Nested_SplitCon.Panel1.Controls.Add(this.Pricing_GroupBox);
            this.Nested_SplitCon.Panel1.Controls.Add(this.ConfirmAdd_Button);
            this.Nested_SplitCon.Panel1.Controls.Add(this.PresetSplitContainer);
            this.Nested_SplitCon.Panel1.Controls.Add(this.SearchResults_GroupBox);
            this.Nested_SplitCon.Panel1.Controls.Add(this.SearchResults_Label);
            this.Nested_SplitCon.Panel1.Controls.Add(this.Update_Button);
            this.Nested_SplitCon.Panel1.Controls.Add(this.ClearButton);
            this.Nested_SplitCon.Panel1.Controls.Add(this.PresetSearch_Button);
            this.Nested_SplitCon.Panel1.Controls.Add(this.PresetSearchLabel);
            this.Nested_SplitCon.Panel1.Controls.Add(this.PresetSearch_TextBox);
            this.Nested_SplitCon.Panel1.Controls.Add(this.customGrpBox1);
            this.Nested_SplitCon.Panel1.Controls.Add(this.CollapseNodes_Button);
            this.Nested_SplitCon.Panel1.Controls.Add(this.ExpandNodes_Button);
            this.Nested_SplitCon.Panel1.Controls.Add(this.ViewKeys_Button);
            this.Nested_SplitCon.Panel1.Controls.Add(this.CurrentKey_GroupBox);
            this.Nested_SplitCon.Panel1MinSize = 400;
            // 
            // Nested_SplitCon.Panel2
            // 
            this.Nested_SplitCon.Panel2.AccessibleName = "";
            this.Nested_SplitCon.Panel2Collapsed = true;
            this.Nested_SplitCon.Panel2MinSize = 100;
            this.Nested_SplitCon.Size = new System.Drawing.Size(1015, 744);
            this.Nested_SplitCon.SplitterDistance = 400;
            this.Nested_SplitCon.SplitterWidth = 2;
            this.Nested_SplitCon.TabIndex = 2;
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
            // ConfirmAdd_Button
            // 
            this.ConfirmAdd_Button.Location = new System.Drawing.Point(322, 175);
            this.ConfirmAdd_Button.Name = "ConfirmAdd_Button";
            this.ConfirmAdd_Button.Size = new System.Drawing.Size(63, 26);
            this.ConfirmAdd_Button.TabIndex = 2;
            this.ConfirmAdd_Button.Text = "Confirm";
            this.ConfirmAdd_Button.UseVisualStyleBackColor = true;
            this.ConfirmAdd_Button.Visible = false;
            this.ConfirmAdd_Button.Click += new System.EventHandler(this.ConfirmAdd_Button_Click);
            // 
            // PresetSplitContainer
            // 
            this.PresetSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PresetSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.PresetSplitContainer.Location = new System.Drawing.Point(322, 386);
            this.PresetSplitContainer.Name = "PresetSplitContainer";
            // 
            // PresetSplitContainer.Panel1
            // 
            this.PresetSplitContainer.Panel1.Controls.Add(this.presetTrashBin);
            this.PresetSplitContainer.Panel1.Controls.Add(this.presetClipBoard);
            this.PresetSplitContainer.Panel1.Controls.Add(this.bitMap_ComboBox);
            this.PresetSplitContainer.Panel1.Controls.Add(this.PresetPriority_Label);
            this.PresetSplitContainer.Panel1.Controls.Add(presetPriorityLabel);
            this.PresetSplitContainer.Panel1.Controls.Add(this.presetPriorityTextBox);
            // 
            // PresetSplitContainer.Panel2
            // 
            this.PresetSplitContainer.Panel2.Controls.Add(this.Preset_GroupBox);
            this.PresetSplitContainer.Size = new System.Drawing.Size(686, 355);
            this.PresetSplitContainer.SplitterDistance = 356;
            this.PresetSplitContainer.TabIndex = 106;
            this.PresetSplitContainer.TabStop = false;
            // 
            // bitMap_ComboBox
            // 
            this.bitMap_ComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.bitMap_ComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.bitMap_ComboBox.FormattingEnabled = true;
            this.bitMap_ComboBox.Items.AddRange(new object[] {
            "None"});
            this.bitMap_ComboBox.Location = new System.Drawing.Point(7, 42);
            this.bitMap_ComboBox.Name = "bitMap_ComboBox";
            this.bitMap_ComboBox.Size = new System.Drawing.Size(171, 21);
            this.bitMap_ComboBox.TabIndex = 92;
            this.bitMap_ComboBox.Text = "Button Picture";
            this.bitMap_ComboBox.SelectionChangeCommitted += new System.EventHandler(this.bitMap_ComboBox_SelectionChangeCommitted);
            this.bitMap_ComboBox.SelectedValueChanged += new System.EventHandler(this.bitMap_ComboBox_SelectionChangeCommitted);
            // 
            // PresetPriority_Label
            // 
            this.PresetPriority_Label.AutoSize = true;
            this.PresetPriority_Label.Location = new System.Drawing.Point(4, 26);
            this.PresetPriority_Label.Name = "PresetPriority_Label";
            this.PresetPriority_Label.Size = new System.Drawing.Size(84, 13);
            this.PresetPriority_Label.TabIndex = 104;
            this.PresetPriority_Label.Text = "Button Position: ";
            // 
            // presetPriorityTextBox
            // 
            this.presetPriorityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.presetPriorityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetPriority", true));
            this.presetPriorityTextBox.Location = new System.Drawing.Point(84, 3);
            this.presetPriorityTextBox.Name = "presetPriorityTextBox";
            this.presetPriorityTextBox.Size = new System.Drawing.Size(32, 20);
            this.presetPriorityTextBox.TabIndex = 102;
            // 
            // SearchResults_GroupBox
            // 
            this.SearchResults_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchResults_GroupBox.Controls.Add(this.searchResults_DataGridView);
            this.SearchResults_GroupBox.Location = new System.Drawing.Point(744, 24);
            this.SearchResults_GroupBox.Name = "SearchResults_GroupBox";
            this.SearchResults_GroupBox.Size = new System.Drawing.Size(267, 294);
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
            this.searchResults_DataGridView.Size = new System.Drawing.Size(261, 275);
            this.searchResults_DataGridView.TabIndex = 16;
            this.searchResults_DataGridView.TabStop = false;
            this.searchResults_DataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SearchResults_DataGrid_CellContentDoubleClick);
            // 
            // PresetDesc
            // 
            this.PresetDesc.HeaderText = "Preset Description";
            this.PresetDesc.Name = "PresetDesc";
            // 
            // SearchResults_Label
            // 
            this.SearchResults_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchResults_Label.AutoSize = true;
            this.SearchResults_Label.Location = new System.Drawing.Point(744, 4);
            this.SearchResults_Label.Name = "SearchResults_Label";
            this.SearchResults_Label.Size = new System.Drawing.Size(71, 13);
            this.SearchResults_Label.TabIndex = 100;
            this.SearchResults_Label.Text = "Items Found: ";
            // 
            // Update_Button
            // 
            this.Update_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Button.Location = new System.Drawing.Point(322, 123);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(63, 46);
            this.Update_Button.TabIndex = 3;
            this.Update_Button.Text = "Update";
            this.Update_Button.UseVisualStyleBackColor = true;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.Location = new System.Drawing.Point(988, 350);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(20, 27);
            this.ClearButton.TabIndex = 3;
            this.ClearButton.Text = "X";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // PresetSearch_Button
            // 
            this.PresetSearch_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PresetSearch_Button.Location = new System.Drawing.Point(926, 350);
            this.PresetSearch_Button.Name = "PresetSearch_Button";
            this.PresetSearch_Button.Size = new System.Drawing.Size(56, 27);
            this.PresetSearch_Button.TabIndex = 1;
            this.PresetSearch_Button.Text = "Search";
            this.PresetSearch_Button.UseVisualStyleBackColor = true;
            this.PresetSearch_Button.Click += new System.EventHandler(this.PresetSearch_Button_Click);
            // 
            // PresetSearchLabel
            // 
            this.PresetSearchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PresetSearchLabel.Location = new System.Drawing.Point(744, 324);
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
            this.PresetSearch_TextBox.Location = new System.Drawing.Point(844, 324);
            this.PresetSearch_TextBox.Name = "PresetSearch_TextBox";
            this.PresetSearch_TextBox.Size = new System.Drawing.Size(164, 20);
            this.PresetSearch_TextBox.TabIndex = 0;
            // 
            // CollapseNodes_Button
            // 
            this.CollapseNodes_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CollapseNodes_Button.Location = new System.Drawing.Point(750, 350);
            this.CollapseNodes_Button.Name = "CollapseNodes_Button";
            this.CollapseNodes_Button.Size = new System.Drawing.Size(82, 27);
            this.CollapseNodes_Button.TabIndex = 4;
            this.CollapseNodes_Button.Text = "Collapse Keys";
            this.CollapseNodes_Button.UseVisualStyleBackColor = true;
            this.CollapseNodes_Button.Click += new System.EventHandler(this.CollapseNodes_Button_Click);
            // 
            // ExpandNodes_Button
            // 
            this.ExpandNodes_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpandNodes_Button.Location = new System.Drawing.Point(838, 350);
            this.ExpandNodes_Button.Name = "ExpandNodes_Button";
            this.ExpandNodes_Button.Size = new System.Drawing.Size(82, 27);
            this.ExpandNodes_Button.TabIndex = 3;
            this.ExpandNodes_Button.Text = "Expand Keys";
            this.ExpandNodes_Button.UseVisualStyleBackColor = true;
            this.ExpandNodes_Button.Click += new System.EventHandler(this.ExpandNodes_Button_Click);
            // 
            // ViewKeys_Button
            // 
            this.ViewKeys_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewKeys_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewKeys_Button.Location = new System.Drawing.Point(965, 3);
            this.ViewKeys_Button.Name = "ViewKeys_Button";
            this.ViewKeys_Button.Size = new System.Drawing.Size(46, 15);
            this.ViewKeys_Button.TabIndex = 99;
            this.ViewKeys_Button.TabStop = false;
            this.ViewKeys_Button.Text = "^";
            this.ViewKeys_Button.UseVisualStyleBackColor = true;
            this.ViewKeys_Button.Click += new System.EventHandler(this.ViewKeys_Click);
            // 
            // MainTreeView
            // 
            this.MainTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTreeView.Location = new System.Drawing.Point(0, 0);
            this.MainTreeView.Name = "MainTreeView";
            this.MainTreeView.Size = new System.Drawing.Size(250, 744);
            this.MainTreeView.TabIndex = 0;
            this.MainTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.MainTreeView_AfterSelect);
            this.MainTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.MainTreeView_NodeMouseClick);
            this.MainTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.MainTreeView_NodeMouseDoubleClick);
            // 
            // presetDataBindingSource
            // 
            this.presetDataBindingSource.AllowNew = true;
            this.presetDataBindingSource.DataMember = "PresetData";
            this.presetDataBindingSource.DataSource = this.jartrekDataSet;
            // 
            // presetMasterTableAdapter
            // 
            this.presetMasterTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GoToPriorTableAdapter = null;
            this.tableAdapterManager.KeyMasterDataAdapter = null;
            this.tableAdapterManager.KeyMasterTableAdapter = null;
            this.tableAdapterManager.PresetDataTableAdapter = this.presetDataTableAdapter;
            this.tableAdapterManager.PresetMasterTableAdapter = this.presetMasterTableAdapter;
            this.tableAdapterManager.UpdateOrder = Preset_Maintenance.jartrekDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // presetDataTableAdapter
            // 
            this.presetDataTableAdapter.ClearBeforeFill = true;
            // 
            // ChitSettings_GroupBox
            // 
            this.ChitSettings_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ChitSettings_GroupBox.Controls.Add(preRemPrt1Label);
            this.ChitSettings_GroupBox.Controls.Add(preRemPrt2Label);
            this.ChitSettings_GroupBox.Controls.Add(this.preRemPrt1TextBox);
            this.ChitSettings_GroupBox.Controls.Add(this.Remote2_CheckBox);
            this.ChitSettings_GroupBox.Controls.Add(this.preRemPrt2TextBox);
            this.ChitSettings_GroupBox.Controls.Add(this.Remote1_CheckBox);
            this.ChitSettings_GroupBox.Controls.Add(this.PresetChippable_CheckBox);
            this.ChitSettings_GroupBox.Controls.Add(this.presetChippableTextBox);
            this.ChitSettings_GroupBox.Controls.Add(presetChippableLabel);
            this.ChitSettings_GroupBox.Location = new System.Drawing.Point(322, 207);
            this.ChitSettings_GroupBox.Name = "ChitSettings_GroupBox";
            this.ChitSettings_GroupBox.Size = new System.Drawing.Size(353, 97);
            this.ChitSettings_GroupBox.TabIndex = 108;
            this.ChitSettings_GroupBox.TabStop = false;
            this.ChitSettings_GroupBox.Text = "Chit/Scan Settings";
            // 
            // preRemPrt1Label
            // 
            preRemPrt1Label.AutoSize = true;
            preRemPrt1Label.Location = new System.Drawing.Point(155, 43);
            preRemPrt1Label.Name = "preRemPrt1Label";
            preRemPrt1Label.Size = new System.Drawing.Size(73, 13);
            preRemPrt1Label.TabIndex = 138;
            preRemPrt1Label.Text = "Pre Rem Prt1:";
            // 
            // preRemPrt2Label
            // 
            preRemPrt2Label.AutoSize = true;
            preRemPrt2Label.Location = new System.Drawing.Point(155, 66);
            preRemPrt2Label.Name = "preRemPrt2Label";
            preRemPrt2Label.Size = new System.Drawing.Size(73, 13);
            preRemPrt2Label.TabIndex = 139;
            preRemPrt2Label.Text = "Pre Rem Prt2:";
            // 
            // preRemPrt1TextBox
            // 
            this.preRemPrt1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PreRemPrt1", true));
            this.preRemPrt1TextBox.Location = new System.Drawing.Point(234, 40);
            this.preRemPrt1TextBox.Name = "preRemPrt1TextBox";
            this.preRemPrt1TextBox.Size = new System.Drawing.Size(100, 20);
            this.preRemPrt1TextBox.TabIndex = 139;
            // 
            // Remote2_CheckBox
            // 
            this.Remote2_CheckBox.AutoSize = true;
            this.Remote2_CheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Remote2_CheckBox.Location = new System.Drawing.Point(6, 65);
            this.Remote2_CheckBox.Name = "Remote2_CheckBox";
            this.Remote2_CheckBox.Size = new System.Drawing.Size(119, 17);
            this.Remote2_CheckBox.TabIndex = 138;
            this.Remote2_CheckBox.Text = "Send to Remote #2";
            this.Remote2_CheckBox.UseVisualStyleBackColor = true;
            this.Remote2_CheckBox.CheckStateChanged += new System.EventHandler(this.CheckBox_CheckStateChanged);
            // 
            // preRemPrt2TextBox
            // 
            this.preRemPrt2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PreRemPrt2", true));
            this.preRemPrt2TextBox.Location = new System.Drawing.Point(234, 63);
            this.preRemPrt2TextBox.Name = "preRemPrt2TextBox";
            this.preRemPrt2TextBox.Size = new System.Drawing.Size(100, 20);
            this.preRemPrt2TextBox.TabIndex = 140;
            // 
            // Remote1_CheckBox
            // 
            this.Remote1_CheckBox.AutoSize = true;
            this.Remote1_CheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Remote1_CheckBox.Location = new System.Drawing.Point(6, 42);
            this.Remote1_CheckBox.Name = "Remote1_CheckBox";
            this.Remote1_CheckBox.Size = new System.Drawing.Size(119, 17);
            this.Remote1_CheckBox.TabIndex = 137;
            this.Remote1_CheckBox.Text = "Send to Remote #1";
            this.Remote1_CheckBox.UseVisualStyleBackColor = true;
            this.Remote1_CheckBox.CheckStateChanged += new System.EventHandler(this.CheckBox_CheckStateChanged);
            // 
            // PresetChippable_CheckBox
            // 
            this.PresetChippable_CheckBox.AutoSize = true;
            this.PresetChippable_CheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PresetChippable_CheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.presetMasterBindingSource, "PresetChippable", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "Y"));
            this.PresetChippable_CheckBox.Location = new System.Drawing.Point(52, 19);
            this.PresetChippable_CheckBox.Name = "PresetChippable_CheckBox";
            this.PresetChippable_CheckBox.Size = new System.Drawing.Size(73, 17);
            this.PresetChippable_CheckBox.TabIndex = 136;
            this.PresetChippable_CheckBox.Text = "Chippable";
            this.PresetChippable_CheckBox.UseVisualStyleBackColor = true;
            this.PresetChippable_CheckBox.CheckStateChanged += new System.EventHandler(this.CheckBox_CheckStateChanged);
            // 
            // presetChippableTextBox
            // 
            this.presetChippableTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetChippable", true));
            this.presetChippableTextBox.Location = new System.Drawing.Point(234, 17);
            this.presetChippableTextBox.Name = "presetChippableTextBox";
            this.presetChippableTextBox.Size = new System.Drawing.Size(100, 20);
            this.presetChippableTextBox.TabIndex = 111;
            this.presetChippableTextBox.Text = " ";
            // 
            // presetChippableLabel
            // 
            presetChippableLabel.AutoSize = true;
            presetChippableLabel.Location = new System.Drawing.Point(131, 20);
            presetChippableLabel.Name = "presetChippableLabel";
            presetChippableLabel.Size = new System.Drawing.Size(90, 13);
            presetChippableLabel.TabIndex = 129;
            presetChippableLabel.Text = "Preset Chippable:";
            // 
            // Pricing_GroupBox
            // 
            this.Pricing_GroupBox.Controls.Add(presetPrintLabel1);
            this.Pricing_GroupBox.Controls.Add(this.presetPrintComboBox);
            this.Pricing_GroupBox.Controls.Add(keyCodeLabel);
            this.Pricing_GroupBox.Controls.Add(this.keyCodeTextBox);
            this.Pricing_GroupBox.Controls.Add(this.presetMasterBindingNaviagator);
            this.Pricing_GroupBox.Controls.Add(presetCodeLabel);
            this.Pricing_GroupBox.Controls.Add(this.presetCodeTextBox);
            this.Pricing_GroupBox.Controls.Add(this.presetColorTextBox);
            this.Pricing_GroupBox.Controls.Add(presetColorLabel);
            this.Pricing_GroupBox.Controls.Add(presetPictureLabel);
            this.Pricing_GroupBox.Controls.Add(presetDescLabel);
            this.Pricing_GroupBox.Controls.Add(this.presetPictureTextBox);
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
            this.Pricing_GroupBox.Size = new System.Drawing.Size(319, 744);
            this.Pricing_GroupBox.TabIndex = 107;
            this.Pricing_GroupBox.TabStop = false;
            this.Pricing_GroupBox.Text = "Pricing Information";
            // 
            // presetPrintLabel1
            // 
            presetPrintLabel1.AutoSize = true;
            presetPrintLabel1.Location = new System.Drawing.Point(12, 451);
            presetPrintLabel1.Name = "presetPrintLabel1";
            presetPrintLabel1.Size = new System.Drawing.Size(64, 13);
            presetPrintLabel1.TabIndex = 138;
            presetPrintLabel1.Text = "Preset Print:";
            // 
            // presetPrintComboBox
            // 
            this.presetPrintComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetPrint", true));
            this.presetPrintComboBox.FormattingEnabled = true;
            this.presetPrintComboBox.Items.AddRange(new object[] {
            "Yes",
            "No",
            "Condiment",
            "Optional",
            "See Server",
            "Back Key"});
            this.presetPrintComboBox.Location = new System.Drawing.Point(98, 448);
            this.presetPrintComboBox.Name = "presetPrintComboBox";
            this.presetPrintComboBox.Size = new System.Drawing.Size(108, 21);
            this.presetPrintComboBox.TabIndex = 139;
            // 
            // keyCodeLabel
            // 
            keyCodeLabel.AutoSize = true;
            keyCodeLabel.Location = new System.Drawing.Point(12, 24);
            keyCodeLabel.Name = "keyCodeLabel";
            keyCodeLabel.Size = new System.Drawing.Size(56, 13);
            keyCodeLabel.TabIndex = 138;
            keyCodeLabel.Text = "Key Code:";
            // 
            // keyCodeTextBox
            // 
            this.keyCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "KeyCode", true));
            this.keyCodeTextBox.Location = new System.Drawing.Point(98, 21);
            this.keyCodeTextBox.Name = "keyCodeTextBox";
            this.keyCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.keyCodeTextBox.TabIndex = 91;
            // 
            // presetMasterBindingNaviagator
            // 
            this.presetMasterBindingNaviagator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.presetMasterBindingNaviagator.AllowItemReorder = true;
            this.presetMasterBindingNaviagator.BindingSource = this.presetMasterBindingSource;
            this.presetMasterBindingNaviagator.CountItem = this.bindingNavigatorCountItem;
            this.presetMasterBindingNaviagator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.presetMasterBindingNaviagator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.presetMasterBindingNaviagator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.presetMasterBindingNaviagator.Location = new System.Drawing.Point(5, 714);
            this.presetMasterBindingNaviagator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.presetMasterBindingNaviagator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.presetMasterBindingNaviagator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.presetMasterBindingNaviagator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.presetMasterBindingNaviagator.Name = "presetMasterBindingNaviagator";
            this.presetMasterBindingNaviagator.PositionItem = this.bindingNavigatorPositionItem;
            this.presetMasterBindingNaviagator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.presetMasterBindingNaviagator.Size = new System.Drawing.Size(309, 25);
            this.presetMasterBindingNaviagator.TabIndex = 137;
            this.presetMasterBindingNaviagator.Text = "bindingNavigator1";
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
            // presetCodeLabel
            // 
            presetCodeLabel.AutoSize = true;
            presetCodeLabel.Location = new System.Drawing.Point(12, 51);
            presetCodeLabel.Name = "presetCodeLabel";
            presetCodeLabel.Size = new System.Drawing.Size(68, 13);
            presetCodeLabel.TabIndex = 115;
            presetCodeLabel.Text = "Preset Code:";
            // 
            // presetCodeTextBox
            // 
            this.presetCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetCode", true));
            this.presetCodeTextBox.Location = new System.Drawing.Point(98, 48);
            this.presetCodeTextBox.Name = "presetCodeTextBox";
            this.presetCodeTextBox.Size = new System.Drawing.Size(188, 20);
            this.presetCodeTextBox.TabIndex = 93;
            // 
            // presetColorTextBox
            // 
            this.presetColorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetColor", true));
            this.presetColorTextBox.Enabled = false;
            this.presetColorTextBox.Location = new System.Drawing.Point(98, 181);
            this.presetColorTextBox.Name = "presetColorTextBox";
            this.presetColorTextBox.Size = new System.Drawing.Size(108, 20);
            this.presetColorTextBox.TabIndex = 98;
            this.presetColorTextBox.Text = " ";
            // 
            // presetColorLabel
            // 
            presetColorLabel.AutoSize = true;
            presetColorLabel.Enabled = false;
            presetColorLabel.Location = new System.Drawing.Point(13, 184);
            presetColorLabel.Name = "presetColorLabel";
            presetColorLabel.Size = new System.Drawing.Size(67, 13);
            presetColorLabel.TabIndex = 121;
            presetColorLabel.Text = "Preset Color:";
            // 
            // presetPictureLabel
            // 
            presetPictureLabel.AutoSize = true;
            presetPictureLabel.Location = new System.Drawing.Point(12, 157);
            presetPictureLabel.Name = "presetPictureLabel";
            presetPictureLabel.Size = new System.Drawing.Size(76, 13);
            presetPictureLabel.TabIndex = 127;
            presetPictureLabel.Text = "Preset Picture:";
            // 
            // presetDescLabel
            // 
            presetDescLabel.AutoSize = true;
            presetDescLabel.Location = new System.Drawing.Point(12, 78);
            presetDescLabel.Name = "presetDescLabel";
            presetDescLabel.Size = new System.Drawing.Size(68, 13);
            presetDescLabel.TabIndex = 116;
            presetDescLabel.Text = "Preset Desc:";
            // 
            // presetPictureTextBox
            // 
            this.presetPictureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetPicture", true));
            this.presetPictureTextBox.Location = new System.Drawing.Point(98, 154);
            this.presetPictureTextBox.Name = "presetPictureTextBox";
            this.presetPictureTextBox.Size = new System.Drawing.Size(188, 20);
            this.presetPictureTextBox.TabIndex = 97;
            this.presetPictureTextBox.Text = " ";
            // 
            // presetDescTextBox
            // 
            this.presetDescTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetDesc", true));
            this.presetDescTextBox.Location = new System.Drawing.Point(98, 75);
            this.presetDescTextBox.Name = "presetDescTextBox";
            this.presetDescTextBox.Size = new System.Drawing.Size(188, 20);
            this.presetDescTextBox.TabIndex = 94;
            // 
            // presetLegendLabel
            // 
            presetLegendLabel.AutoSize = true;
            presetLegendLabel.Location = new System.Drawing.Point(12, 105);
            presetLegendLabel.Name = "presetLegendLabel";
            presetLegendLabel.Size = new System.Drawing.Size(62, 13);
            presetLegendLabel.TabIndex = 117;
            presetLegendLabel.Text = "Button Text";
            // 
            // presetLegendTextBox
            // 
            this.presetLegendTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetLegend", true));
            this.presetLegendTextBox.Location = new System.Drawing.Point(98, 102);
            this.presetLegendTextBox.Name = "presetLegendTextBox";
            this.presetLegendTextBox.Size = new System.Drawing.Size(188, 20);
            this.presetLegendTextBox.TabIndex = 95;
            // 
            // presetTaxLabel
            // 
            presetTaxLabel.AutoSize = true;
            presetTaxLabel.Location = new System.Drawing.Point(12, 211);
            presetTaxLabel.Name = "presetTaxLabel";
            presetTaxLabel.Size = new System.Drawing.Size(61, 13);
            presetTaxLabel.TabIndex = 118;
            presetTaxLabel.Text = "Preset Tax:";
            // 
            // presetTaxTextBox
            // 
            this.presetTaxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetTax", true));
            this.presetTaxTextBox.Location = new System.Drawing.Point(98, 208);
            this.presetTaxTextBox.Name = "presetTaxTextBox";
            this.presetTaxTextBox.Size = new System.Drawing.Size(108, 20);
            this.presetTaxTextBox.TabIndex = 99;
            // 
            // presetPriceLabel
            // 
            presetPriceLabel.AutoSize = true;
            presetPriceLabel.Location = new System.Drawing.Point(12, 238);
            presetPriceLabel.Name = "presetPriceLabel";
            presetPriceLabel.Size = new System.Drawing.Size(67, 13);
            presetPriceLabel.TabIndex = 119;
            presetPriceLabel.Text = "Preset Price:";
            // 
            // presetPriceTextBox
            // 
            this.presetPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.presetPriceTextBox.Location = new System.Drawing.Point(98, 235);
            this.presetPriceTextBox.Name = "presetPriceTextBox";
            this.presetPriceTextBox.Size = new System.Drawing.Size(108, 20);
            this.presetPriceTextBox.TabIndex = 100;
            this.presetPriceTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.presetPriceTextBox_KeyDown);
            // 
            // presetReceiptLabel
            // 
            presetReceiptLabel.AutoSize = true;
            presetReceiptLabel.Enabled = false;
            presetReceiptLabel.Location = new System.Drawing.Point(12, 131);
            presetReceiptLabel.Name = "presetReceiptLabel";
            presetReceiptLabel.Size = new System.Drawing.Size(80, 13);
            presetReceiptLabel.TabIndex = 126;
            presetReceiptLabel.Text = "Preset Receipt:";
            // 
            // presetReceiptTextBox
            // 
            this.presetReceiptTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetReceipt", true));
            this.presetReceiptTextBox.Enabled = false;
            this.presetReceiptTextBox.Location = new System.Drawing.Point(98, 128);
            this.presetReceiptTextBox.Name = "presetReceiptTextBox";
            this.presetReceiptTextBox.Size = new System.Drawing.Size(108, 20);
            this.presetReceiptTextBox.TabIndex = 109;
            this.presetReceiptTextBox.Text = " ";
            // 
            // presetPrice2Label
            // 
            presetPrice2Label.AutoSize = true;
            presetPrice2Label.Location = new System.Drawing.Point(12, 264);
            presetPrice2Label.Name = "presetPrice2Label";
            presetPrice2Label.Size = new System.Drawing.Size(73, 13);
            presetPrice2Label.TabIndex = 122;
            presetPrice2Label.Text = "Preset Price2:";
            // 
            // presetPrice6Label
            // 
            presetPrice6Label.AutoSize = true;
            presetPrice6Label.Location = new System.Drawing.Point(12, 372);
            presetPrice6Label.Name = "presetPrice6Label";
            presetPrice6Label.Size = new System.Drawing.Size(73, 13);
            presetPrice6Label.TabIndex = 133;
            presetPrice6Label.Text = "Preset Price6:";
            // 
            // presetPrice2TextBox
            // 
            this.presetPrice2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetPrice2", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.presetPrice2TextBox.Location = new System.Drawing.Point(98, 261);
            this.presetPrice2TextBox.Name = "presetPrice2TextBox";
            this.presetPrice2TextBox.Size = new System.Drawing.Size(108, 20);
            this.presetPrice2TextBox.TabIndex = 101;
            // 
            // presetPrice8TextBox
            // 
            this.presetPrice8TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetPrice8", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.presetPrice8TextBox.Location = new System.Drawing.Point(98, 422);
            this.presetPrice8TextBox.Name = "presetPrice8TextBox";
            this.presetPrice8TextBox.Size = new System.Drawing.Size(108, 20);
            this.presetPrice8TextBox.TabIndex = 107;
            // 
            // presetPrice3Label
            // 
            presetPrice3Label.AutoSize = true;
            presetPrice3Label.Location = new System.Drawing.Point(13, 291);
            presetPrice3Label.Name = "presetPrice3Label";
            presetPrice3Label.Size = new System.Drawing.Size(73, 13);
            presetPrice3Label.TabIndex = 123;
            presetPrice3Label.Text = "Preset Price3:";
            // 
            // presetPrice8Label
            // 
            presetPrice8Label.AutoSize = true;
            presetPrice8Label.Location = new System.Drawing.Point(12, 425);
            presetPrice8Label.Name = "presetPrice8Label";
            presetPrice8Label.Size = new System.Drawing.Size(73, 13);
            presetPrice8Label.TabIndex = 135;
            presetPrice8Label.Text = "Preset Price8:";
            // 
            // presetPrice3TextBox
            // 
            this.presetPrice3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetPrice3", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.presetPrice3TextBox.Location = new System.Drawing.Point(98, 288);
            this.presetPrice3TextBox.Name = "presetPrice3TextBox";
            this.presetPrice3TextBox.Size = new System.Drawing.Size(108, 20);
            this.presetPrice3TextBox.TabIndex = 102;
            // 
            // presetPrice7TextBox
            // 
            this.presetPrice7TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetPrice7", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.presetPrice7TextBox.Location = new System.Drawing.Point(98, 395);
            this.presetPrice7TextBox.Name = "presetPrice7TextBox";
            this.presetPrice7TextBox.Size = new System.Drawing.Size(108, 20);
            this.presetPrice7TextBox.TabIndex = 106;
            // 
            // presetPrice4Label
            // 
            presetPrice4Label.AutoSize = true;
            presetPrice4Label.Location = new System.Drawing.Point(12, 318);
            presetPrice4Label.Name = "presetPrice4Label";
            presetPrice4Label.Size = new System.Drawing.Size(73, 13);
            presetPrice4Label.TabIndex = 124;
            presetPrice4Label.Text = "Preset Price4:";
            // 
            // presetPrice7Label
            // 
            presetPrice7Label.AutoSize = true;
            presetPrice7Label.Location = new System.Drawing.Point(12, 398);
            presetPrice7Label.Name = "presetPrice7Label";
            presetPrice7Label.Size = new System.Drawing.Size(73, 13);
            presetPrice7Label.TabIndex = 134;
            presetPrice7Label.Text = "Preset Price7:";
            // 
            // presetPrice4TextBox
            // 
            this.presetPrice4TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetPrice4", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.presetPrice4TextBox.Location = new System.Drawing.Point(98, 315);
            this.presetPrice4TextBox.Name = "presetPrice4TextBox";
            this.presetPrice4TextBox.Size = new System.Drawing.Size(108, 20);
            this.presetPrice4TextBox.TabIndex = 103;
            // 
            // presetPrice6TextBox
            // 
            this.presetPrice6TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetPrice6", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.presetPrice6TextBox.Location = new System.Drawing.Point(98, 368);
            this.presetPrice6TextBox.Name = "presetPrice6TextBox";
            this.presetPrice6TextBox.Size = new System.Drawing.Size(108, 20);
            this.presetPrice6TextBox.TabIndex = 105;
            // 
            // presetPrice5Label
            // 
            presetPrice5Label.AutoSize = true;
            presetPrice5Label.Location = new System.Drawing.Point(12, 345);
            presetPrice5Label.Name = "presetPrice5Label";
            presetPrice5Label.Size = new System.Drawing.Size(73, 13);
            presetPrice5Label.TabIndex = 125;
            presetPrice5Label.Text = "Preset Price5:";
            // 
            // presetPrice5TextBox
            // 
            this.presetPrice5TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetPrice5", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.presetPrice5TextBox.Location = new System.Drawing.Point(98, 342);
            this.presetPrice5TextBox.Name = "presetPrice5TextBox";
            this.presetPrice5TextBox.Size = new System.Drawing.Size(108, 20);
            this.presetPrice5TextBox.TabIndex = 104;
            // 
            // presetTrashBin
            // 
            this.presetTrashBin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.presetTrashBin.Location = new System.Drawing.Point(3, 206);
            this.presetTrashBin.Name = "presetTrashBin";
            this.presetTrashBin.Size = new System.Drawing.Size(350, 146);
            this.presetTrashBin.TabIndex = 1;
            this.presetTrashBin.TabStop = false;
            this.presetTrashBin.Text = "Items to Remove from Screen";
            // 
            // presetClipBoard
            // 
            this.presetClipBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.presetClipBoard.Location = new System.Drawing.Point(3, 77);
            this.presetClipBoard.Name = "presetClipBoard";
            this.presetClipBoard.Size = new System.Drawing.Size(350, 123);
            this.presetClipBoard.TabIndex = 0;
            this.presetClipBoard.TabStop = false;
            this.presetClipBoard.Text = "Clip Board";
            // 
            // Preset_GroupBox
            // 
            this.Preset_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Preset_GroupBox.Controls.Add(this.presetPanel);
            this.Preset_GroupBox.Location = new System.Drawing.Point(3, 1);
            this.Preset_GroupBox.Name = "Preset_GroupBox";
            this.Preset_GroupBox.Size = new System.Drawing.Size(320, 351);
            this.Preset_GroupBox.TabIndex = 99;
            this.Preset_GroupBox.TabStop = false;
            this.Preset_GroupBox.Text = "Screen Layout";
            // 
            // presetPanel
            // 
            this.presetPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.presetPanel.Controls.Add(this.button25);
            this.presetPanel.Controls.Add(this.button26);
            this.presetPanel.Controls.Add(this.button27);
            this.presetPanel.Controls.Add(this.button28);
            this.presetPanel.Controls.Add(this.button29);
            this.presetPanel.Controls.Add(this.button30);
            this.presetPanel.Controls.Add(this.button19);
            this.presetPanel.Controls.Add(this.button20);
            this.presetPanel.Controls.Add(this.button21);
            this.presetPanel.Controls.Add(this.button22);
            this.presetPanel.Controls.Add(this.button23);
            this.presetPanel.Controls.Add(this.button24);
            this.presetPanel.Controls.Add(this.button13);
            this.presetPanel.Controls.Add(this.button14);
            this.presetPanel.Controls.Add(this.button15);
            this.presetPanel.Controls.Add(this.button16);
            this.presetPanel.Controls.Add(this.button17);
            this.presetPanel.Controls.Add(this.button18);
            this.presetPanel.Controls.Add(this.button07);
            this.presetPanel.Controls.Add(this.button08);
            this.presetPanel.Controls.Add(this.button09);
            this.presetPanel.Controls.Add(this.button10);
            this.presetPanel.Controls.Add(this.button11);
            this.presetPanel.Controls.Add(this.button12);
            this.presetPanel.Controls.Add(this.button06);
            this.presetPanel.Controls.Add(this.button05);
            this.presetPanel.Controls.Add(this.button04);
            this.presetPanel.Controls.Add(this.button03);
            this.presetPanel.Controls.Add(this.button02);
            this.presetPanel.Controls.Add(this.button01);
            this.presetPanel.Location = new System.Drawing.Point(6, 19);
            this.presetPanel.Name = "presetPanel";
            this.presetPanel.Size = new System.Drawing.Size(308, 326);
            this.presetPanel.TabIndex = 0;
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(251, 3);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(56, 48);
            this.button25.TabIndex = 29;
            this.button25.Text = "Not Used!";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(251, 57);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(56, 48);
            this.button26.TabIndex = 28;
            this.button26.Text = "Not Used!";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(251, 111);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(56, 48);
            this.button27.TabIndex = 27;
            this.button27.Text = "Not Used!";
            this.button27.UseVisualStyleBackColor = true;
            // 
            // button28
            // 
            this.button28.Location = new System.Drawing.Point(251, 165);
            this.button28.Name = "button28";
            this.button28.Size = new System.Drawing.Size(56, 48);
            this.button28.TabIndex = 26;
            this.button28.Text = "Not Used!";
            this.button28.UseVisualStyleBackColor = true;
            // 
            // button29
            // 
            this.button29.Location = new System.Drawing.Point(251, 219);
            this.button29.Name = "button29";
            this.button29.Size = new System.Drawing.Size(56, 48);
            this.button29.TabIndex = 25;
            this.button29.Text = "Not Used!";
            this.button29.UseVisualStyleBackColor = true;
            // 
            // button30
            // 
            this.button30.Location = new System.Drawing.Point(251, 273);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(56, 48);
            this.button30.TabIndex = 24;
            this.button30.Text = "Not Used!";
            this.button30.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(189, 3);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(56, 48);
            this.button19.TabIndex = 23;
            this.button19.Text = "Not Used!";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(189, 57);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(56, 48);
            this.button20.TabIndex = 22;
            this.button20.Text = "Not Used!";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(189, 111);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(56, 48);
            this.button21.TabIndex = 21;
            this.button21.Text = "Not Used!";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(189, 165);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(56, 48);
            this.button22.TabIndex = 20;
            this.button22.Text = "Not Used!";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(189, 219);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(56, 48);
            this.button23.TabIndex = 19;
            this.button23.Text = "Not Used!";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(189, 273);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(56, 48);
            this.button24.TabIndex = 18;
            this.button24.Text = "Not Used!";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(127, 3);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(56, 48);
            this.button13.TabIndex = 17;
            this.button13.Text = "Not Used!";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(127, 57);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(56, 48);
            this.button14.TabIndex = 16;
            this.button14.Text = "Not Used!";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(127, 111);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(56, 48);
            this.button15.TabIndex = 15;
            this.button15.Text = "Not Used!";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(127, 165);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(56, 48);
            this.button16.TabIndex = 14;
            this.button16.Text = "Not Used!";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(127, 219);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(56, 48);
            this.button17.TabIndex = 13;
            this.button17.Text = "Not Used!";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(127, 273);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(56, 48);
            this.button18.TabIndex = 12;
            this.button18.Text = "Not Used!";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button07
            // 
            this.button07.Location = new System.Drawing.Point(65, 3);
            this.button07.Name = "button07";
            this.button07.Size = new System.Drawing.Size(56, 48);
            this.button07.TabIndex = 11;
            this.button07.Text = "Not Used!";
            this.button07.UseVisualStyleBackColor = true;
            // 
            // button08
            // 
            this.button08.Location = new System.Drawing.Point(65, 57);
            this.button08.Name = "button08";
            this.button08.Size = new System.Drawing.Size(56, 48);
            this.button08.TabIndex = 10;
            this.button08.Text = "Not Used!";
            this.button08.UseVisualStyleBackColor = true;
            // 
            // button09
            // 
            this.button09.Location = new System.Drawing.Point(65, 111);
            this.button09.Name = "button09";
            this.button09.Size = new System.Drawing.Size(56, 48);
            this.button09.TabIndex = 9;
            this.button09.Text = "Not Used!";
            this.button09.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(65, 165);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(56, 48);
            this.button10.TabIndex = 8;
            this.button10.Text = "Not Used!";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(65, 219);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(56, 48);
            this.button11.TabIndex = 7;
            this.button11.Text = "Not Used!";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(65, 273);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(56, 48);
            this.button12.TabIndex = 6;
            this.button12.Text = "Not Used!";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button06
            // 
            this.button06.Location = new System.Drawing.Point(3, 273);
            this.button06.Name = "button06";
            this.button06.Size = new System.Drawing.Size(56, 48);
            this.button06.TabIndex = 5;
            this.button06.Text = "Not Used!";
            this.button06.UseVisualStyleBackColor = true;
            // 
            // button05
            // 
            this.button05.Location = new System.Drawing.Point(3, 219);
            this.button05.Name = "button05";
            this.button05.Size = new System.Drawing.Size(56, 48);
            this.button05.TabIndex = 4;
            this.button05.Text = "Not Used!";
            this.button05.UseVisualStyleBackColor = true;
            // 
            // button04
            // 
            this.button04.Location = new System.Drawing.Point(3, 165);
            this.button04.Name = "button04";
            this.button04.Size = new System.Drawing.Size(56, 48);
            this.button04.TabIndex = 3;
            this.button04.Text = "Not Used!";
            this.button04.UseVisualStyleBackColor = true;
            // 
            // button03
            // 
            this.button03.Location = new System.Drawing.Point(3, 111);
            this.button03.Name = "button03";
            this.button03.Size = new System.Drawing.Size(56, 48);
            this.button03.TabIndex = 2;
            this.button03.Text = "Not Used!";
            this.button03.UseVisualStyleBackColor = true;
            // 
            // button02
            // 
            this.button02.Location = new System.Drawing.Point(3, 57);
            this.button02.Name = "button02";
            this.button02.Size = new System.Drawing.Size(56, 48);
            this.button02.TabIndex = 1;
            this.button02.Text = "Not Used!";
            this.button02.UseVisualStyleBackColor = true;
            // 
            // button01
            // 
            this.button01.Location = new System.Drawing.Point(3, 3);
            this.button01.Name = "button01";
            this.button01.Size = new System.Drawing.Size(56, 48);
            this.button01.TabIndex = 0;
            this.button01.Text = "Not Used!";
            this.button01.UseVisualStyleBackColor = true;
            // 
            // customGrpBox1
            // 
            this.customGrpBox1.Controls.Add(this.CurrentPreset_Button);
            this.customGrpBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customGrpBox1.Location = new System.Drawing.Point(444, 12);
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
            // 
            // CurrentKey_GroupBox
            // 
            this.CurrentKey_GroupBox.Controls.Add(this.KeyPreview_Button);
            this.CurrentKey_GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentKey_GroupBox.Location = new System.Drawing.Point(322, 0);
            this.CurrentKey_GroupBox.Name = "CurrentKey_GroupBox";
            this.CurrentKey_GroupBox.Size = new System.Drawing.Size(116, 120);
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
            this.KeyPreview_Button.Size = new System.Drawing.Size(110, 100);
            this.KeyPreview_Button.TabIndex = 0;
            this.KeyPreview_Button.TabStop = false;
            this.KeyPreview_Button.Text = "Bottled Beer";
            this.KeyPreview_Button.UseVisualStyleBackColor = false;
            // 
            // PresetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1267, 744);
            this.Controls.Add(this.Main_SplitCon);
            this.MinimumSize = new System.Drawing.Size(1065, 782);
            this.Name = "PresetForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.PresetForm_Load);
            this.Main_SplitCon.Panel1.ResumeLayout(false);
            this.Main_SplitCon.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Main_SplitCon)).EndInit();
            this.Main_SplitCon.ResumeLayout(false);
            this.Nested_SplitCon.Panel1.ResumeLayout(false);
            this.Nested_SplitCon.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nested_SplitCon)).EndInit();
            this.Nested_SplitCon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.presetMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jartrekDataSet)).EndInit();
            this.PresetSplitContainer.Panel1.ResumeLayout(false);
            this.PresetSplitContainer.Panel1.PerformLayout();
            this.PresetSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PresetSplitContainer)).EndInit();
            this.PresetSplitContainer.ResumeLayout(false);
            this.SearchResults_GroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchResults_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presetDataBindingSource)).EndInit();
            this.ChitSettings_GroupBox.ResumeLayout(false);
            this.ChitSettings_GroupBox.PerformLayout();
            this.Pricing_GroupBox.ResumeLayout(false);
            this.Pricing_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.presetMasterBindingNaviagator)).EndInit();
            this.presetMasterBindingNaviagator.ResumeLayout(false);
            this.presetMasterBindingNaviagator.PerformLayout();
            this.Preset_GroupBox.ResumeLayout(false);
            this.presetPanel.ResumeLayout(false);
            this.customGrpBox1.ResumeLayout(false);
            this.CurrentKey_GroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer Main_SplitCon;
        private CustomGrpBox CurrentKey_GroupBox;
        private System.Windows.Forms.Button KeyPreview_Button;
        private System.Windows.Forms.TreeView MainTreeView;
        private System.Windows.Forms.SplitContainer Nested_SplitCon;
        private System.Windows.Forms.Button ViewKeys_Button;
        private System.Windows.Forms.Button ExpandNodes_Button;
        private System.Windows.Forms.Button CollapseNodes_Button;
        private CustomGrpBox customGrpBox1;
        private System.Windows.Forms.Button CurrentPreset_Button;
        private System.Windows.Forms.Button PresetSearch_Button;
        private System.Windows.Forms.Label PresetSearchLabel;
        private System.Windows.Forms.TextBox PresetSearch_TextBox;
        private System.Windows.Forms.Button ClearButton;
        private jartrekDataSet jartrekDataSet;
        private jartrekDataSetTableAdapters.PresetMasterTableAdapter presetMasterTableAdapter;
        private jartrekDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private jartrekDataSetTableAdapters.PresetDataTableAdapter presetDataTableAdapter;
        public System.Windows.Forms.BindingSource presetMasterBindingSource;
        private System.Windows.Forms.BindingSource presetDataBindingSource;
        private System.Windows.Forms.Label SearchResults_Label;
        private System.Windows.Forms.Button Update_Button;
        private System.Windows.Forms.TextBox presetPriorityTextBox;
        public System.Windows.Forms.Label PresetPriority_Label;
        private System.Windows.Forms.Button ConfirmAdd_Button;
        private System.Windows.Forms.GroupBox SearchResults_GroupBox;
        public System.Windows.Forms.DataGridView searchResults_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PresetDesc;
        private CustomGrpBox presetTrashBin;
        private CustomGrpBox presetClipBoard;
        private CustomGrpBox Preset_GroupBox;
        private System.Windows.Forms.Panel presetPanel;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button28;
        private System.Windows.Forms.Button button29;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button07;
        private System.Windows.Forms.Button button08;
        private System.Windows.Forms.Button button09;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button06;
        private System.Windows.Forms.Button button05;
        private System.Windows.Forms.Button button04;
        private System.Windows.Forms.Button button03;
        private System.Windows.Forms.Button button02;
        private System.Windows.Forms.Button button01;
        public System.Windows.Forms.SplitContainer PresetSplitContainer;
        private System.Windows.Forms.ComboBox bitMap_ComboBox;
        public CustomGrpBox Pricing_GroupBox;
        private System.Windows.Forms.TextBox keyCodeTextBox;
        private System.Windows.Forms.BindingNavigator presetMasterBindingNaviagator;
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
        private System.Windows.Forms.TextBox presetCodeTextBox;
        private System.Windows.Forms.TextBox presetColorTextBox;
        private System.Windows.Forms.TextBox presetPictureTextBox;
        private System.Windows.Forms.TextBox presetDescTextBox;
        private System.Windows.Forms.TextBox presetLegendTextBox;
        private System.Windows.Forms.TextBox presetTaxTextBox;
        private System.Windows.Forms.TextBox presetPriceTextBox;
        private System.Windows.Forms.TextBox presetReceiptTextBox;
        private System.Windows.Forms.TextBox presetPrice2TextBox;
        private System.Windows.Forms.TextBox presetPrice8TextBox;
        private System.Windows.Forms.TextBox presetChippableTextBox;
        private System.Windows.Forms.TextBox presetPrice3TextBox;
        private System.Windows.Forms.TextBox presetPrice7TextBox;
        private System.Windows.Forms.TextBox presetPrice4TextBox;
        private System.Windows.Forms.TextBox presetPrice6TextBox;
        private System.Windows.Forms.TextBox presetPrice5TextBox;
        private CustomGrpBox ChitSettings_GroupBox;
        private System.Windows.Forms.CheckBox Remote2_CheckBox;
        private System.Windows.Forms.CheckBox Remote1_CheckBox;
        private System.Windows.Forms.CheckBox PresetChippable_CheckBox;
        private System.Windows.Forms.TextBox preRemPrt2TextBox;
        private System.Windows.Forms.TextBox preRemPrt1TextBox;
        private System.Windows.Forms.ComboBox presetPrintComboBox;
    }
}

