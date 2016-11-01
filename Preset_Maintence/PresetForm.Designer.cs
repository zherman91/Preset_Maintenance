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
            this.Main_SplitCon = new System.Windows.Forms.SplitContainer();
            this.Nested_SplitCon = new System.Windows.Forms.SplitContainer();
            this.ExpandTree_Button = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.PresetDesc_Label = new System.Windows.Forms.Label();
            this.PresetCode_Label = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CollapseNodes_Button = new System.Windows.Forms.Button();
            this.ExpandNodes_Button = new System.Windows.Forms.Button();
            this.ViewKeys_Button = new System.Windows.Forms.Button();
            this.MainTreeView = new System.Windows.Forms.TreeView();
            this.customGrpBox1 = new Preset_Maintenance.CustomGrpBox();
            this.CurrentPreset_Button = new System.Windows.Forms.Button();
            this.CurrentKey_GroupBox = new Preset_Maintenance.CustomGrpBox();
            this.Preview_Button = new System.Windows.Forms.Button();
            this.KeyPriGroupBox = new Preset_Maintenance.CustomGrpBox();
            ((System.ComponentModel.ISupportInitialize)(this.Main_SplitCon)).BeginInit();
            this.Main_SplitCon.Panel1.SuspendLayout();
            this.Main_SplitCon.Panel2.SuspendLayout();
            this.Main_SplitCon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nested_SplitCon)).BeginInit();
            this.Nested_SplitCon.Panel1.SuspendLayout();
            this.Nested_SplitCon.Panel2.SuspendLayout();
            this.Nested_SplitCon.SuspendLayout();
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
            this.Main_SplitCon.Panel2.Controls.Add(this.MainTreeView);
            this.Main_SplitCon.Size = new System.Drawing.Size(1272, 691);
            this.Main_SplitCon.SplitterDistance = 1020;
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
            this.Nested_SplitCon.Panel1.Controls.Add(this.ExpandTree_Button);
            this.Nested_SplitCon.Panel1.Controls.Add(this.textBox2);
            this.Nested_SplitCon.Panel1.Controls.Add(this.PresetDesc_Label);
            this.Nested_SplitCon.Panel1.Controls.Add(this.PresetCode_Label);
            this.Nested_SplitCon.Panel1.Controls.Add(this.textBox1);
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
            this.Nested_SplitCon.Panel2.Controls.Add(this.KeyPriGroupBox);
            this.Nested_SplitCon.Panel2MinSize = 100;
            this.Nested_SplitCon.Size = new System.Drawing.Size(1020, 691);
            this.Nested_SplitCon.SplitterDistance = 445;
            this.Nested_SplitCon.SplitterWidth = 2;
            this.Nested_SplitCon.TabIndex = 2;
            // 
            // ExpandTree_Button
            // 
            this.ExpandTree_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpandTree_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpandTree_Button.Location = new System.Drawing.Point(999, 240);
            this.ExpandTree_Button.Name = "ExpandTree_Button";
            this.ExpandTree_Button.Size = new System.Drawing.Size(17, 49);
            this.ExpandTree_Button.TabIndex = 9;
            this.ExpandTree_Button.Text = ">";
            this.ExpandTree_Button.UseVisualStyleBackColor = true;
            this.ExpandTree_Button.Click += new System.EventHandler(this.ExpandTree_Button_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(111, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // PresetDesc_Label
            // 
            this.PresetDesc_Label.AutoSize = true;
            this.PresetDesc_Label.Location = new System.Drawing.Point(12, 143);
            this.PresetDesc_Label.Name = "PresetDesc_Label";
            this.PresetDesc_Label.Size = new System.Drawing.Size(93, 13);
            this.PresetDesc_Label.TabIndex = 7;
            this.PresetDesc_Label.Text = "Preset Description";
            // 
            // PresetCode_Label
            // 
            this.PresetCode_Label.AutoSize = true;
            this.PresetCode_Label.Location = new System.Drawing.Point(12, 117);
            this.PresetCode_Label.Name = "PresetCode_Label";
            this.PresetCode_Label.Size = new System.Drawing.Size(65, 13);
            this.PresetCode_Label.TabIndex = 6;
            this.PresetCode_Label.Text = "Preset Code";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(111, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // CollapseNodes_Button
            // 
            this.CollapseNodes_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CollapseNodes_Button.Location = new System.Drawing.Point(929, 418);
            this.CollapseNodes_Button.Name = "CollapseNodes_Button";
            this.CollapseNodes_Button.Size = new System.Drawing.Size(87, 23);
            this.CollapseNodes_Button.TabIndex = 4;
            this.CollapseNodes_Button.Text = "Collapse Keys";
            this.CollapseNodes_Button.UseVisualStyleBackColor = true;
            this.CollapseNodes_Button.Click += new System.EventHandler(this.CollapseNodes_Button_Click);
            // 
            // ExpandNodes_Button
            // 
            this.ExpandNodes_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpandNodes_Button.Location = new System.Drawing.Point(929, 389);
            this.ExpandNodes_Button.Name = "ExpandNodes_Button";
            this.ExpandNodes_Button.Size = new System.Drawing.Size(87, 23);
            this.ExpandNodes_Button.TabIndex = 3;
            this.ExpandNodes_Button.Text = "Expand Keys";
            this.ExpandNodes_Button.UseVisualStyleBackColor = true;
            this.ExpandNodes_Button.Click += new System.EventHandler(this.ExpandNodes_Button_Click);
            // 
            // ViewKeys_Button
            // 
            this.ViewKeys_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ViewKeys_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewKeys_Button.Location = new System.Drawing.Point(485, 426);
            this.ViewKeys_Button.Name = "ViewKeys_Button";
            this.ViewKeys_Button.Size = new System.Drawing.Size(46, 15);
            this.ViewKeys_Button.TabIndex = 2;
            this.ViewKeys_Button.Text = "^";
            this.ViewKeys_Button.UseVisualStyleBackColor = true;
            this.ViewKeys_Button.Click += new System.EventHandler(this.ViewKeys_Click);
            // 
            // MainTreeView
            // 
            this.MainTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTreeView.Location = new System.Drawing.Point(0, 0);
            this.MainTreeView.Name = "MainTreeView";
            this.MainTreeView.Size = new System.Drawing.Size(250, 691);
            this.MainTreeView.TabIndex = 0;
            this.MainTreeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.MainTreeView_NodeMouseClick);
            this.MainTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.MainTreeView_NodeMouseDoubleClick);
            // 
            // customGrpBox1
            // 
            this.customGrpBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customGrpBox1.Controls.Add(this.CurrentPreset_Button);
            this.customGrpBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customGrpBox1.Location = new System.Drawing.Point(931, 3);
            this.customGrpBox1.Name = "customGrpBox1";
            this.customGrpBox1.Size = new System.Drawing.Size(85, 88);
            this.customGrpBox1.TabIndex = 2;
            this.customGrpBox1.TabStop = false;
            this.customGrpBox1.Text = "Current Preset";
            // 
            // CurrentPreset_Button
            // 
            this.CurrentPreset_Button.AutoSize = true;
            this.CurrentPreset_Button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CurrentPreset_Button.BackColor = System.Drawing.Color.RoyalBlue;
            this.CurrentPreset_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CurrentPreset_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentPreset_Button.Location = new System.Drawing.Point(3, 17);
            this.CurrentPreset_Button.Name = "CurrentPreset_Button";
            this.CurrentPreset_Button.Size = new System.Drawing.Size(79, 68);
            this.CurrentPreset_Button.TabIndex = 0;
            this.CurrentPreset_Button.Text = "Bud Lite";
            this.CurrentPreset_Button.UseVisualStyleBackColor = false;
            // 
            // CurrentKey_GroupBox
            // 
            this.CurrentKey_GroupBox.Controls.Add(this.Preview_Button);
            this.CurrentKey_GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentKey_GroupBox.Location = new System.Drawing.Point(12, 3);
            this.CurrentKey_GroupBox.Name = "CurrentKey_GroupBox";
            this.CurrentKey_GroupBox.Size = new System.Drawing.Size(100, 101);
            this.CurrentKey_GroupBox.TabIndex = 1;
            this.CurrentKey_GroupBox.TabStop = false;
            this.CurrentKey_GroupBox.Text = "Current Key";
            // 
            // Preview_Button
            // 
            this.Preview_Button.BackColor = System.Drawing.Color.Lime;
            this.Preview_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Preview_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Preview_Button.Location = new System.Drawing.Point(3, 17);
            this.Preview_Button.Name = "Preview_Button";
            this.Preview_Button.Size = new System.Drawing.Size(94, 81);
            this.Preview_Button.TabIndex = 0;
            this.Preview_Button.Text = "Bottled Beer";
            this.Preview_Button.UseVisualStyleBackColor = false;
            // 
            // KeyPriGroupBox
            // 
            this.KeyPriGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.KeyPriGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KeyPriGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPriGroupBox.Location = new System.Drawing.Point(0, 0);
            this.KeyPriGroupBox.Name = "KeyPriGroupBox";
            this.KeyPriGroupBox.Size = new System.Drawing.Size(1020, 244);
            this.KeyPriGroupBox.TabIndex = 0;
            this.KeyPriGroupBox.TabStop = false;
            this.KeyPriGroupBox.Text = "Key Priority";
            // 
            // PresetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1272, 691);
            this.Controls.Add(this.Main_SplitCon);
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
            this.Nested_SplitCon.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Nested_SplitCon)).EndInit();
            this.Nested_SplitCon.ResumeLayout(false);
            this.customGrpBox1.ResumeLayout(false);
            this.customGrpBox1.PerformLayout();
            this.CurrentKey_GroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer Main_SplitCon;
        private CustomGrpBox KeyPriGroupBox;
        private CustomGrpBox CurrentKey_GroupBox;
        private System.Windows.Forms.Button Preview_Button;
        private System.Windows.Forms.TreeView MainTreeView;
        private System.Windows.Forms.SplitContainer Nested_SplitCon;
        private System.Windows.Forms.Button ViewKeys_Button;
        private System.Windows.Forms.Button ExpandNodes_Button;
        private System.Windows.Forms.Button CollapseNodes_Button;
        private CustomGrpBox customGrpBox1;
        private System.Windows.Forms.Button CurrentPreset_Button;
        private System.Windows.Forms.Button ExpandTree_Button;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label PresetDesc_Label;
        private System.Windows.Forms.Label PresetCode_Label;
        private System.Windows.Forms.TextBox textBox1;
    }
}

