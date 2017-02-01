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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PresetForm));
            System.Windows.Forms.Label preRemPrt1Label;
            System.Windows.Forms.Label preRemPrt2Label;
            System.Windows.Forms.Label presetChippableLabel;
            System.Windows.Forms.Label presetPriorityLabel;
            System.Windows.Forms.Label presetPrintLabel1;
            System.Windows.Forms.Label keyCodeLabel;
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
            this.PresetSplitContainer = new System.Windows.Forms.SplitContainer();
            this.SearchResults_GroupBox = new System.Windows.Forms.GroupBox();
            this.searchResults_DataGridView = new System.Windows.Forms.DataGridView();
            this.PresetDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchResults_Label = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.PresetSearch_Button = new System.Windows.Forms.Button();
            this.PresetSearchLabel = new System.Windows.Forms.Label();
            this.PresetSearch_TextBox = new System.Windows.Forms.TextBox();
            this.CollapseNodes_Button = new System.Windows.Forms.Button();
            this.ExpandNodes_Button = new System.Windows.Forms.Button();
            this.ViewKeys_Button = new System.Windows.Forms.Button();
            this.Update_Button = new System.Windows.Forms.Button();
            this.presetMasterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jartrekDataSet = new Preset_Maintenance.jartrekDataSet();
            this.presetMasterTableAdapter = new Preset_Maintenance.jartrekDataSetTableAdapters.PresetMasterTableAdapter();
            this.tableAdapterManager = new Preset_Maintenance.jartrekDataSetTableAdapters.TableAdapterManager();
            this.keyMasterTableAdapter1 = new Preset_Maintenance.jartrekDataSetTableAdapters.KeyMasterTableAdapter();
            this.NewItem_TreeView = new MyTreeView.DataBoundTreeView();
            this.DataBoundTree = new MyTreeView.DataBoundTreeView();
            this.CancelChanges_Button = new System.Windows.Forms.Button();
            this.Pricing_GroupBox = new Preset_Maintenance.CustomGrpBox();
            this.PresetPriority_Label = new System.Windows.Forms.Label();
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
            this.preRemPrt1TextBox = new System.Windows.Forms.TextBox();
            this.Remote2_CheckBox = new System.Windows.Forms.CheckBox();
            this.preRemPrt2TextBox = new System.Windows.Forms.TextBox();
            this.Remote1_CheckBox = new System.Windows.Forms.CheckBox();
            this.PresetChippable_CheckBox = new System.Windows.Forms.CheckBox();
            this.presetChippableTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmAdd_Button = new System.Windows.Forms.Button();
            this.CurrentlyAdding_Label = new System.Windows.Forms.Label();
            this.CanceledChanges_Label = new System.Windows.Forms.Label();
            this.UpdateRow_Label = new System.Windows.Forms.Label();
            this.bitMap_ComboBox = new System.Windows.Forms.ComboBox();
            this.presetPriorityTextBox = new System.Windows.Forms.TextBox();
            this.Success_Label = new System.Windows.Forms.Label();
            this.keyCodeComboBox = new System.Windows.Forms.ComboBox();
            this.presetPrintComboBox = new System.Windows.Forms.ComboBox();
            this.presetCodeTextBox = new System.Windows.Forms.TextBox();
            this.presetColorTextBox = new System.Windows.Forms.TextBox();
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
            this.TrashBin_Panel = new System.Windows.Forms.FlowLayoutPanel();
            this.presetPriorityControl1 = new Preset_Maintenance.PresetPriorityControl();
            this.customGrpBox1 = new Preset_Maintenance.CustomGrpBox();
            this.CurrentPreset_Button = new System.Windows.Forms.Button();
            this.CurrentKey_GroupBox = new Preset_Maintenance.CustomGrpBox();
            this.KeyPreview_Button = new System.Windows.Forms.Button();
            preRemPrt1Label = new System.Windows.Forms.Label();
            preRemPrt2Label = new System.Windows.Forms.Label();
            presetChippableLabel = new System.Windows.Forms.Label();
            presetPriorityLabel = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.PresetSplitContainer)).BeginInit();
            this.PresetSplitContainer.Panel2.SuspendLayout();
            this.PresetSplitContainer.SuspendLayout();
            this.SearchResults_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchResults_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presetMasterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jartrekDataSet)).BeginInit();
            this.Pricing_GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.presetMasterBindingNavigator)).BeginInit();
            this.presetMasterBindingNavigator.SuspendLayout();
            this.ChitSettings_GroupBox.SuspendLayout();
            this.presetTrashBin.SuspendLayout();
            this.customGrpBox1.SuspendLayout();
            this.CurrentKey_GroupBox.SuspendLayout();
            this.SuspendLayout();
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
            this.Main_SplitCon.Size = new System.Drawing.Size(1228, 752);
            this.Main_SplitCon.SplitterDistance = 862;
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
            this.Nested_SplitCon.Panel1.Controls.Add(this.NewItem_TreeView);
            this.Nested_SplitCon.Panel1.Controls.Add(this.Pricing_GroupBox);
            this.Nested_SplitCon.Panel1.Controls.Add(this.PresetSplitContainer);
            this.Nested_SplitCon.Panel1.Controls.Add(this.SearchResults_GroupBox);
            this.Nested_SplitCon.Panel1.Controls.Add(this.SearchResults_Label);
            this.Nested_SplitCon.Panel1.Controls.Add(this.ClearButton);
            this.Nested_SplitCon.Panel1.Controls.Add(this.PresetSearch_Button);
            this.Nested_SplitCon.Panel1.Controls.Add(this.PresetSearchLabel);
            this.Nested_SplitCon.Panel1.Controls.Add(this.PresetSearch_TextBox);
            this.Nested_SplitCon.Panel1.Controls.Add(this.customGrpBox1);
            this.Nested_SplitCon.Panel1.Controls.Add(this.CollapseNodes_Button);
            this.Nested_SplitCon.Panel1.Controls.Add(this.ExpandNodes_Button);
            this.Nested_SplitCon.Panel1.Controls.Add(this.ViewKeys_Button);
            this.Nested_SplitCon.Panel1.Controls.Add(this.CurrentKey_GroupBox);
            this.Nested_SplitCon.Panel1.Controls.Add(this.Update_Button);
            this.Nested_SplitCon.Panel1MinSize = 400;
            // 
            // Nested_SplitCon.Panel2
            // 
            this.Nested_SplitCon.Panel2.AccessibleName = "";
            this.Nested_SplitCon.Panel2Collapsed = true;
            this.Nested_SplitCon.Panel2MinSize = 100;
            this.Nested_SplitCon.Size = new System.Drawing.Size(862, 752);
            this.Nested_SplitCon.SplitterDistance = 400;
            this.Nested_SplitCon.SplitterWidth = 2;
            this.Nested_SplitCon.TabIndex = 2;
            // 
            // PresetSplitContainer
            // 
            this.PresetSplitContainer.AllowDrop = true;
            this.PresetSplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PresetSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.PresetSplitContainer.Location = new System.Drawing.Point(535, 285);
            this.PresetSplitContainer.Name = "PresetSplitContainer";
            this.PresetSplitContainer.Panel1Collapsed = true;
            // 
            // PresetSplitContainer.Panel2
            // 
            this.PresetSplitContainer.Panel2.Controls.Add(this.presetTrashBin);
            this.PresetSplitContainer.Panel2.Controls.Add(this.presetPriorityControl1);
            this.PresetSplitContainer.Size = new System.Drawing.Size(317, 462);
            this.PresetSplitContainer.SplitterDistance = 192;
            this.PresetSplitContainer.TabIndex = 106;
            this.PresetSplitContainer.TabStop = false;
            // 
            // SearchResults_GroupBox
            // 
            this.SearchResults_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchResults_GroupBox.Controls.Add(this.searchResults_DataGridView);
            this.SearchResults_GroupBox.Location = new System.Drawing.Point(648, 17);
            this.SearchResults_GroupBox.Name = "SearchResults_GroupBox";
            this.SearchResults_GroupBox.Size = new System.Drawing.Size(207, 182);
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
            this.searchResults_DataGridView.Size = new System.Drawing.Size(201, 163);
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
            this.SearchResults_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchResults_Label.AutoSize = true;
            this.SearchResults_Label.Location = new System.Drawing.Point(642, 203);
            this.SearchResults_Label.Name = "SearchResults_Label";
            this.SearchResults_Label.Size = new System.Drawing.Size(71, 13);
            this.SearchResults_Label.TabIndex = 100;
            this.SearchResults_Label.Text = "Items Found: ";
            // 
            // ClearButton
            // 
            this.ClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearButton.Location = new System.Drawing.Point(833, 250);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(20, 25);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "X";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // PresetSearch_Button
            // 
            this.PresetSearch_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PresetSearch_Button.Location = new System.Drawing.Point(771, 250);
            this.PresetSearch_Button.Name = "PresetSearch_Button";
            this.PresetSearch_Button.Size = new System.Drawing.Size(56, 25);
            this.PresetSearch_Button.TabIndex = 3;
            this.PresetSearch_Button.Text = "Search";
            this.PresetSearch_Button.UseVisualStyleBackColor = true;
            this.PresetSearch_Button.Click += new System.EventHandler(this.PresetSearch_Button_Click);
            // 
            // PresetSearchLabel
            // 
            this.PresetSearchLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PresetSearchLabel.Location = new System.Drawing.Point(591, 224);
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
            this.PresetSearch_TextBox.Location = new System.Drawing.Point(691, 224);
            this.PresetSearch_TextBox.Name = "PresetSearch_TextBox";
            this.PresetSearch_TextBox.Size = new System.Drawing.Size(164, 20);
            this.PresetSearch_TextBox.TabIndex = 2;
            // 
            // CollapseNodes_Button
            // 
            this.CollapseNodes_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CollapseNodes_Button.Location = new System.Drawing.Point(594, 250);
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
            this.ExpandNodes_Button.Location = new System.Drawing.Point(682, 250);
            this.ExpandNodes_Button.Name = "ExpandNodes_Button";
            this.ExpandNodes_Button.Size = new System.Drawing.Size(82, 25);
            this.ExpandNodes_Button.TabIndex = 3;
            this.ExpandNodes_Button.Text = "Expand Keys";
            this.ExpandNodes_Button.UseVisualStyleBackColor = true;
            this.ExpandNodes_Button.Click += new System.EventHandler(this.ExpandNodes_Button_Click);
            // 
            // ViewKeys_Button
            // 
            this.ViewKeys_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ViewKeys_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewKeys_Button.Location = new System.Drawing.Point(808, 3);
            this.ViewKeys_Button.Name = "ViewKeys_Button";
            this.ViewKeys_Button.Size = new System.Drawing.Size(46, 15);
            this.ViewKeys_Button.TabIndex = 99;
            this.ViewKeys_Button.TabStop = false;
            this.ViewKeys_Button.Text = "^";
            this.ViewKeys_Button.UseVisualStyleBackColor = true;
            this.ViewKeys_Button.Click += new System.EventHandler(this.ViewKeys_Click);
            // 
            // Update_Button
            // 
            this.Update_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Update_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_Button.Location = new System.Drawing.Point(305, 250);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.Size = new System.Drawing.Size(63, 25);
            this.Update_Button.TabIndex = 1;
            this.Update_Button.Text = "Update";
            this.Update_Button.UseVisualStyleBackColor = true;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
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
            // presetMasterTableAdapter
            // 
            this.presetMasterTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GoToPriorTableAdapter = null;
            this.tableAdapterManager.KeyMasterTableAdapter = null;
            this.tableAdapterManager.PresetMasterTableAdapter = this.presetMasterTableAdapter;
            this.tableAdapterManager.UpdateOrder = Preset_Maintenance.jartrekDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // keyMasterTableAdapter1
            // 
            this.keyMasterTableAdapter1.ClearBeforeFill = true;
            // 
            // NewItem_TreeView
            // 
            this.NewItem_TreeView.Location = new System.Drawing.Point(309, 289);
            this.NewItem_TreeView.Name = "NewItem_TreeView";
            this.NewItem_TreeView.Size = new System.Drawing.Size(220, 455);
            this.NewItem_TreeView.TabIndex = 108;
            // 
            // DataBoundTree
            // 
            this.DataBoundTree.AllowDrop = true;
            this.DataBoundTree.Cursor = System.Windows.Forms.Cursors.Default;
            this.DataBoundTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataBoundTree.Location = new System.Drawing.Point(0, 0);
            this.DataBoundTree.Name = "DataBoundTree";
            this.DataBoundTree.Size = new System.Drawing.Size(364, 752);
            this.DataBoundTree.TabIndex = 1;
            // 
            // CancelChanges_Button
            // 
            this.CancelChanges_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelChanges_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelChanges_Button.Location = new System.Drawing.Point(227, 709);
            this.CancelChanges_Button.Name = "CancelChanges_Button";
            this.CancelChanges_Button.Size = new System.Drawing.Size(65, 35);
            this.CancelChanges_Button.TabIndex = 143;
            this.CancelChanges_Button.Text = "Cancel All Changes";
            this.CancelChanges_Button.UseVisualStyleBackColor = true;
            this.CancelChanges_Button.Visible = false;
            this.CancelChanges_Button.Click += new System.EventHandler(this.CancelChanges_Button_Click);
            // 
            // Pricing_GroupBox
            // 
            this.Pricing_GroupBox.Controls.Add(this.PresetPriority_Label);
            this.Pricing_GroupBox.Controls.Add(this.presetMasterBindingNavigator);
            this.Pricing_GroupBox.Controls.Add(this.ChitSettings_GroupBox);
            this.Pricing_GroupBox.Controls.Add(this.ConfirmAdd_Button);
            this.Pricing_GroupBox.Controls.Add(this.CurrentlyAdding_Label);
            this.Pricing_GroupBox.Controls.Add(presetPriorityLabel);
            this.Pricing_GroupBox.Controls.Add(this.CanceledChanges_Label);
            this.Pricing_GroupBox.Controls.Add(this.UpdateRow_Label);
            this.Pricing_GroupBox.Controls.Add(this.bitMap_ComboBox);
            this.Pricing_GroupBox.Controls.Add(this.presetPriorityTextBox);
            this.Pricing_GroupBox.Controls.Add(this.CancelChanges_Button);
            this.Pricing_GroupBox.Controls.Add(this.Success_Label);
            this.Pricing_GroupBox.Controls.Add(this.keyCodeComboBox);
            this.Pricing_GroupBox.Controls.Add(presetPrintLabel1);
            this.Pricing_GroupBox.Controls.Add(this.presetPrintComboBox);
            this.Pricing_GroupBox.Controls.Add(keyCodeLabel);
            this.Pricing_GroupBox.Controls.Add(presetCodeLabel);
            this.Pricing_GroupBox.Controls.Add(this.presetCodeTextBox);
            this.Pricing_GroupBox.Controls.Add(this.presetColorTextBox);
            this.Pricing_GroupBox.Controls.Add(presetColorLabel);
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
            this.Pricing_GroupBox.Size = new System.Drawing.Size(300, 752);
            this.Pricing_GroupBox.TabIndex = 107;
            this.Pricing_GroupBox.TabStop = false;
            this.Pricing_GroupBox.Text = "Pricing Information";
            // 
            // PresetPriority_Label
            // 
            this.PresetPriority_Label.AutoSize = true;
            this.PresetPriority_Label.Location = new System.Drawing.Point(208, 507);
            this.PresetPriority_Label.Name = "PresetPriority_Label";
            this.PresetPriority_Label.Size = new System.Drawing.Size(84, 13);
            this.PresetPriority_Label.TabIndex = 104;
            this.PresetPriority_Label.Text = "Button Position: ";
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
            this.ChitSettings_GroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChitSettings_GroupBox.Controls.Add(preRemPrt1Label);
            this.ChitSettings_GroupBox.Controls.Add(preRemPrt2Label);
            this.ChitSettings_GroupBox.Controls.Add(this.preRemPrt1TextBox);
            this.ChitSettings_GroupBox.Controls.Add(this.Remote2_CheckBox);
            this.ChitSettings_GroupBox.Controls.Add(this.preRemPrt2TextBox);
            this.ChitSettings_GroupBox.Controls.Add(this.Remote1_CheckBox);
            this.ChitSettings_GroupBox.Controls.Add(this.PresetChippable_CheckBox);
            this.ChitSettings_GroupBox.Controls.Add(this.presetChippableTextBox);
            this.ChitSettings_GroupBox.Controls.Add(presetChippableLabel);
            this.ChitSettings_GroupBox.Location = new System.Drawing.Point(8, 526);
            this.ChitSettings_GroupBox.Name = "ChitSettings_GroupBox";
            this.ChitSettings_GroupBox.Size = new System.Drawing.Size(284, 102);
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
            this.preRemPrt1TextBox.Size = new System.Drawing.Size(44, 20);
            this.preRemPrt1TextBox.TabIndex = 139;
            this.preRemPrt1TextBox.TabStop = false;
            this.preRemPrt1TextBox.Text = " ";
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
            // preRemPrt2TextBox
            // 
            this.preRemPrt2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PreRemPrt2", true));
            this.preRemPrt2TextBox.Location = new System.Drawing.Point(234, 63);
            this.preRemPrt2TextBox.Name = "preRemPrt2TextBox";
            this.preRemPrt2TextBox.Size = new System.Drawing.Size(44, 20);
            this.preRemPrt2TextBox.TabIndex = 140;
            this.preRemPrt2TextBox.TabStop = false;
            this.preRemPrt2TextBox.Text = " ";
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
            // presetChippableTextBox
            // 
            this.presetChippableTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetChippable", true));
            this.presetChippableTextBox.Location = new System.Drawing.Point(234, 17);
            this.presetChippableTextBox.Name = "presetChippableTextBox";
            this.presetChippableTextBox.Size = new System.Drawing.Size(44, 20);
            this.presetChippableTextBox.TabIndex = 111;
            this.presetChippableTextBox.TabStop = false;
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
            // ConfirmAdd_Button
            // 
            this.ConfirmAdd_Button.Location = new System.Drawing.Point(227, 678);
            this.ConfirmAdd_Button.Name = "ConfirmAdd_Button";
            this.ConfirmAdd_Button.Size = new System.Drawing.Size(65, 26);
            this.ConfirmAdd_Button.TabIndex = 0;
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
            this.CurrentlyAdding_Label.Location = new System.Drawing.Point(8, 680);
            this.CurrentlyAdding_Label.Name = "CurrentlyAdding_Label";
            this.CurrentlyAdding_Label.Size = new System.Drawing.Size(177, 17);
            this.CurrentlyAdding_Label.TabIndex = 146;
            this.CurrentlyAdding_Label.Text = "Currently Adding New Item!";
            this.CurrentlyAdding_Label.Visible = false;
            // 
            // presetPriorityLabel
            // 
            presetPriorityLabel.AutoSize = true;
            presetPriorityLabel.Location = new System.Drawing.Point(18, 503);
            presetPriorityLabel.Name = "presetPriorityLabel";
            presetPriorityLabel.Size = new System.Drawing.Size(74, 13);
            presetPriorityLabel.TabIndex = 101;
            presetPriorityLabel.Text = "Preset Priority:";
            // 
            // CanceledChanges_Label
            // 
            this.CanceledChanges_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CanceledChanges_Label.AutoSize = true;
            this.CanceledChanges_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CanceledChanges_Label.ForeColor = System.Drawing.Color.Red;
            this.CanceledChanges_Label.Location = new System.Drawing.Point(8, 697);
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
            this.UpdateRow_Label.Location = new System.Drawing.Point(8, 714);
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
            this.bitMap_ComboBox.Location = new System.Drawing.Point(98, 179);
            this.bitMap_ComboBox.Name = "bitMap_ComboBox";
            this.bitMap_ComboBox.Size = new System.Drawing.Size(188, 21);
            this.bitMap_ComboBox.TabIndex = 4;
            this.bitMap_ComboBox.Text = "Button Picture";
            // 
            // presetPriorityTextBox
            // 
            this.presetPriorityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetPriority", true));
            this.presetPriorityTextBox.Location = new System.Drawing.Point(98, 500);
            this.presetPriorityTextBox.Name = "presetPriorityTextBox";
            this.presetPriorityTextBox.Size = new System.Drawing.Size(32, 20);
            this.presetPriorityTextBox.TabIndex = 102;
            // 
            // Success_Label
            // 
            this.Success_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Success_Label.AutoSize = true;
            this.Success_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Success_Label.ForeColor = System.Drawing.Color.Green;
            this.Success_Label.Location = new System.Drawing.Point(8, 731);
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
            // presetPrintLabel1
            // 
            presetPrintLabel1.AutoSize = true;
            presetPrintLabel1.Location = new System.Drawing.Point(12, 476);
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
            this.presetPrintComboBox.Location = new System.Drawing.Point(98, 473);
            this.presetPrintComboBox.Name = "presetPrintComboBox";
            this.presetPrintComboBox.Size = new System.Drawing.Size(108, 21);
            this.presetPrintComboBox.TabIndex = 139;
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
            // presetCodeTextBox
            // 
            this.presetCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetCode", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.presetCodeTextBox.Location = new System.Drawing.Point(98, 101);
            this.presetCodeTextBox.MaxLength = 10;
            this.presetCodeTextBox.Name = "presetCodeTextBox";
            this.presetCodeTextBox.Size = new System.Drawing.Size(188, 20);
            this.presetCodeTextBox.TabIndex = 1;
            // 
            // presetColorTextBox
            // 
            this.presetColorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetColor", true));
            this.presetColorTextBox.Location = new System.Drawing.Point(98, 206);
            this.presetColorTextBox.Name = "presetColorTextBox";
            this.presetColorTextBox.Size = new System.Drawing.Size(108, 20);
            this.presetColorTextBox.TabIndex = 5;
            this.presetColorTextBox.Text = " ";
            // 
            // presetColorLabel
            // 
            presetColorLabel.AutoSize = true;
            presetColorLabel.Location = new System.Drawing.Point(13, 209);
            presetColorLabel.Name = "presetColorLabel";
            presetColorLabel.Size = new System.Drawing.Size(67, 13);
            presetColorLabel.TabIndex = 121;
            presetColorLabel.Text = "Preset Color:";
            // 
            // presetPictureLabel
            // 
            presetPictureLabel.AutoSize = true;
            presetPictureLabel.Location = new System.Drawing.Point(12, 182);
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
            // presetLegendLabel
            // 
            presetLegendLabel.AutoSize = true;
            presetLegendLabel.Location = new System.Drawing.Point(12, 130);
            presetLegendLabel.Name = "presetLegendLabel";
            presetLegendLabel.Size = new System.Drawing.Size(62, 13);
            presetLegendLabel.TabIndex = 117;
            presetLegendLabel.Text = "Button Text";
            // 
            // presetLegendTextBox
            // 
            this.presetLegendTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetLegend", true));
            this.presetLegendTextBox.Location = new System.Drawing.Point(98, 127);
            this.presetLegendTextBox.Name = "presetLegendTextBox";
            this.presetLegendTextBox.Size = new System.Drawing.Size(188, 20);
            this.presetLegendTextBox.TabIndex = 2;
            this.presetLegendTextBox.TextChanged += new System.EventHandler(this.presetLegendTextBox_TextChanged);
            // 
            // presetTaxLabel
            // 
            presetTaxLabel.AutoSize = true;
            presetTaxLabel.Location = new System.Drawing.Point(12, 236);
            presetTaxLabel.Name = "presetTaxLabel";
            presetTaxLabel.Size = new System.Drawing.Size(61, 13);
            presetTaxLabel.TabIndex = 118;
            presetTaxLabel.Text = "Preset Tax:";
            // 
            // presetTaxTextBox
            // 
            this.presetTaxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetTax", true));
            this.presetTaxTextBox.Location = new System.Drawing.Point(98, 233);
            this.presetTaxTextBox.Name = "presetTaxTextBox";
            this.presetTaxTextBox.Size = new System.Drawing.Size(108, 20);
            this.presetTaxTextBox.TabIndex = 6;
            // 
            // presetPriceLabel
            // 
            presetPriceLabel.AutoSize = true;
            presetPriceLabel.Location = new System.Drawing.Point(12, 263);
            presetPriceLabel.Name = "presetPriceLabel";
            presetPriceLabel.Size = new System.Drawing.Size(67, 13);
            presetPriceLabel.TabIndex = 119;
            presetPriceLabel.Text = "Preset Price:";
            // 
            // presetPriceTextBox
            // 
            this.presetPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetPrice", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.presetPriceTextBox.Location = new System.Drawing.Point(98, 260);
            this.presetPriceTextBox.Name = "presetPriceTextBox";
            this.presetPriceTextBox.Size = new System.Drawing.Size(108, 20);
            this.presetPriceTextBox.TabIndex = 7;
            this.presetPriceTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.presetPriceTextBox_KeyDown);
            this.presetPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.presetPriceTextBox_KeyPress);
            // 
            // presetReceiptLabel
            // 
            presetReceiptLabel.AutoSize = true;
            presetReceiptLabel.Location = new System.Drawing.Point(12, 156);
            presetReceiptLabel.Name = "presetReceiptLabel";
            presetReceiptLabel.Size = new System.Drawing.Size(71, 13);
            presetReceiptLabel.TabIndex = 126;
            presetReceiptLabel.Text = "Receipt Text:";
            // 
            // presetReceiptTextBox
            // 
            this.presetReceiptTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetReceipt", true));
            this.presetReceiptTextBox.Location = new System.Drawing.Point(98, 153);
            this.presetReceiptTextBox.Name = "presetReceiptTextBox";
            this.presetReceiptTextBox.Size = new System.Drawing.Size(108, 20);
            this.presetReceiptTextBox.TabIndex = 3;
            this.presetReceiptTextBox.Text = " ";
            // 
            // presetPrice2Label
            // 
            presetPrice2Label.AutoSize = true;
            presetPrice2Label.Location = new System.Drawing.Point(12, 289);
            presetPrice2Label.Name = "presetPrice2Label";
            presetPrice2Label.Size = new System.Drawing.Size(73, 13);
            presetPrice2Label.TabIndex = 122;
            presetPrice2Label.Text = "Preset Price2:";
            // 
            // presetPrice6Label
            // 
            presetPrice6Label.AutoSize = true;
            presetPrice6Label.Location = new System.Drawing.Point(12, 397);
            presetPrice6Label.Name = "presetPrice6Label";
            presetPrice6Label.Size = new System.Drawing.Size(73, 13);
            presetPrice6Label.TabIndex = 133;
            presetPrice6Label.Text = "Preset Price6:";
            // 
            // presetPrice2TextBox
            // 
            this.presetPrice2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetPrice2", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.presetPrice2TextBox.Location = new System.Drawing.Point(98, 286);
            this.presetPrice2TextBox.Name = "presetPrice2TextBox";
            this.presetPrice2TextBox.Size = new System.Drawing.Size(108, 20);
            this.presetPrice2TextBox.TabIndex = 101;
            // 
            // presetPrice8TextBox
            // 
            this.presetPrice8TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetPrice8", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.presetPrice8TextBox.Location = new System.Drawing.Point(98, 447);
            this.presetPrice8TextBox.Name = "presetPrice8TextBox";
            this.presetPrice8TextBox.Size = new System.Drawing.Size(108, 20);
            this.presetPrice8TextBox.TabIndex = 107;
            // 
            // presetPrice3Label
            // 
            presetPrice3Label.AutoSize = true;
            presetPrice3Label.Location = new System.Drawing.Point(13, 316);
            presetPrice3Label.Name = "presetPrice3Label";
            presetPrice3Label.Size = new System.Drawing.Size(73, 13);
            presetPrice3Label.TabIndex = 123;
            presetPrice3Label.Text = "Preset Price3:";
            // 
            // presetPrice8Label
            // 
            presetPrice8Label.AutoSize = true;
            presetPrice8Label.Location = new System.Drawing.Point(12, 450);
            presetPrice8Label.Name = "presetPrice8Label";
            presetPrice8Label.Size = new System.Drawing.Size(73, 13);
            presetPrice8Label.TabIndex = 135;
            presetPrice8Label.Text = "Preset Price8:";
            // 
            // presetPrice3TextBox
            // 
            this.presetPrice3TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetPrice3", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.presetPrice3TextBox.Location = new System.Drawing.Point(98, 313);
            this.presetPrice3TextBox.Name = "presetPrice3TextBox";
            this.presetPrice3TextBox.Size = new System.Drawing.Size(108, 20);
            this.presetPrice3TextBox.TabIndex = 102;
            // 
            // presetPrice7TextBox
            // 
            this.presetPrice7TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetPrice7", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.presetPrice7TextBox.Location = new System.Drawing.Point(98, 420);
            this.presetPrice7TextBox.Name = "presetPrice7TextBox";
            this.presetPrice7TextBox.Size = new System.Drawing.Size(108, 20);
            this.presetPrice7TextBox.TabIndex = 106;
            // 
            // presetPrice4Label
            // 
            presetPrice4Label.AutoSize = true;
            presetPrice4Label.Location = new System.Drawing.Point(12, 343);
            presetPrice4Label.Name = "presetPrice4Label";
            presetPrice4Label.Size = new System.Drawing.Size(73, 13);
            presetPrice4Label.TabIndex = 124;
            presetPrice4Label.Text = "Preset Price4:";
            // 
            // presetPrice7Label
            // 
            presetPrice7Label.AutoSize = true;
            presetPrice7Label.Location = new System.Drawing.Point(12, 423);
            presetPrice7Label.Name = "presetPrice7Label";
            presetPrice7Label.Size = new System.Drawing.Size(73, 13);
            presetPrice7Label.TabIndex = 134;
            presetPrice7Label.Text = "Preset Price7:";
            // 
            // presetPrice4TextBox
            // 
            this.presetPrice4TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetPrice4", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.presetPrice4TextBox.Location = new System.Drawing.Point(98, 340);
            this.presetPrice4TextBox.Name = "presetPrice4TextBox";
            this.presetPrice4TextBox.Size = new System.Drawing.Size(108, 20);
            this.presetPrice4TextBox.TabIndex = 103;
            // 
            // presetPrice6TextBox
            // 
            this.presetPrice6TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetPrice6", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.presetPrice6TextBox.Location = new System.Drawing.Point(98, 393);
            this.presetPrice6TextBox.Name = "presetPrice6TextBox";
            this.presetPrice6TextBox.Size = new System.Drawing.Size(108, 20);
            this.presetPrice6TextBox.TabIndex = 105;
            // 
            // presetPrice5Label
            // 
            presetPrice5Label.AutoSize = true;
            presetPrice5Label.Location = new System.Drawing.Point(12, 370);
            presetPrice5Label.Name = "presetPrice5Label";
            presetPrice5Label.Size = new System.Drawing.Size(73, 13);
            presetPrice5Label.TabIndex = 125;
            presetPrice5Label.Text = "Preset Price5:";
            // 
            // presetPrice5TextBox
            // 
            this.presetPrice5TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.presetMasterBindingSource, "PresetPrice5", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "C2"));
            this.presetPrice5TextBox.Location = new System.Drawing.Point(98, 367);
            this.presetPrice5TextBox.Name = "presetPrice5TextBox";
            this.presetPrice5TextBox.Size = new System.Drawing.Size(108, 20);
            this.presetPrice5TextBox.TabIndex = 104;
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
            // presetPriorityControl1
            // 
            this.presetPriorityControl1.AllowDrop = true;
            this.presetPriorityControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.presetPriorityControl1.Location = new System.Drawing.Point(0, 119);
            this.presetPriorityControl1.Name = "presetPriorityControl1";
            this.presetPriorityControl1.Size = new System.Drawing.Size(317, 343);
            this.presetPriorityControl1.TabIndex = 108;
            // 
            // customGrpBox1
            // 
            this.customGrpBox1.Controls.Add(this.CurrentPreset_Button);
            this.customGrpBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customGrpBox1.Location = new System.Drawing.Point(306, 123);
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
            // CurrentKey_GroupBox
            // 
            this.CurrentKey_GroupBox.Controls.Add(this.KeyPreview_Button);
            this.CurrentKey_GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentKey_GroupBox.Location = new System.Drawing.Point(306, 3);
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
            // PresetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.CancelButton = this.CancelChanges_Button;
            this.ClientSize = new System.Drawing.Size(1228, 752);
            this.Controls.Add(this.Main_SplitCon);
            this.MinimumSize = new System.Drawing.Size(980, 790);
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
            this.PresetSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PresetSplitContainer)).EndInit();
            this.PresetSplitContainer.ResumeLayout(false);
            this.SearchResults_GroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchResults_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presetMasterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jartrekDataSet)).EndInit();
            this.Pricing_GroupBox.ResumeLayout(false);
            this.Pricing_GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.presetMasterBindingNavigator)).EndInit();
            this.presetMasterBindingNavigator.ResumeLayout(false);
            this.presetMasterBindingNavigator.PerformLayout();
            this.ChitSettings_GroupBox.ResumeLayout(false);
            this.ChitSettings_GroupBox.PerformLayout();
            this.presetTrashBin.ResumeLayout(false);
            this.customGrpBox1.ResumeLayout(false);
            this.CurrentKey_GroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer Main_SplitCon;
        private CustomGrpBox CurrentKey_GroupBox;
        private System.Windows.Forms.Button KeyPreview_Button;
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
        public jartrekDataSet jartrekDataSet;
        public jartrekDataSetTableAdapters.PresetMasterTableAdapter presetMasterTableAdapter;
        public jartrekDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        public System.Windows.Forms.BindingSource presetMasterBindingSource;
        private System.Windows.Forms.Label SearchResults_Label;
        private System.Windows.Forms.Button Update_Button;
        public System.Windows.Forms.Label PresetPriority_Label;
        private System.Windows.Forms.Button ConfirmAdd_Button;
        private System.Windows.Forms.GroupBox SearchResults_GroupBox;
        public System.Windows.Forms.DataGridView searchResults_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PresetDesc;
        public System.Windows.Forms.SplitContainer PresetSplitContainer;
        private System.Windows.Forms.ComboBox bitMap_ComboBox;
        public CustomGrpBox Pricing_GroupBox;
        private System.Windows.Forms.TextBox presetCodeTextBox;
        private System.Windows.Forms.TextBox presetColorTextBox;
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
        private System.Windows.Forms.ComboBox keyCodeComboBox;
        private System.Windows.Forms.Label Success_Label;
        private System.Windows.Forms.Label CanceledChanges_Label;
        private System.Windows.Forms.Label UpdateRow_Label;
        private System.Windows.Forms.Button CancelChanges_Button;
        private System.Windows.Forms.Label CurrentlyAdding_Label;
        public System.Windows.Forms.TextBox presetPriorityTextBox;
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
        public MyTreeView.DataBoundTreeView DataBoundTree;
        private CustomGrpBox presetTrashBin;
        public PresetPriorityControl presetPriorityControl1;
        private System.Windows.Forms.FlowLayoutPanel TrashBin_Panel;
        private MyTreeView.DataBoundTreeView NewItem_TreeView;
    }
}

