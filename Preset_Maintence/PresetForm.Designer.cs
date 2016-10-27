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
            this.ViewKeys_Button = new System.Windows.Forms.Button();
            this.MainTreeView = new System.Windows.Forms.TreeView();
            this.ExpandNodes_Button = new System.Windows.Forms.Button();
            this.CollapseNodes_Button = new System.Windows.Forms.Button();
            this.CurrentKey_GroupBox = new Preset_Maintenance.CustomGrpBox();
            this.button1 = new System.Windows.Forms.Button();
            this.KeyPriGroupBox = new Preset_Maintenance.CustomGrpBox();
            ((System.ComponentModel.ISupportInitialize)(this.Main_SplitCon)).BeginInit();
            this.Main_SplitCon.Panel1.SuspendLayout();
            this.Main_SplitCon.Panel2.SuspendLayout();
            this.Main_SplitCon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nested_SplitCon)).BeginInit();
            this.Nested_SplitCon.Panel1.SuspendLayout();
            this.Nested_SplitCon.Panel2.SuspendLayout();
            this.Nested_SplitCon.SuspendLayout();
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
            this.Main_SplitCon.Size = new System.Drawing.Size(1405, 691);
            this.Main_SplitCon.SplitterDistance = 1185;
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
            this.Nested_SplitCon.Panel2Collapsed = true;
            this.Nested_SplitCon.Panel2MinSize = 100;
            this.Nested_SplitCon.Size = new System.Drawing.Size(1185, 691);
            this.Nested_SplitCon.SplitterDistance = 400;
            this.Nested_SplitCon.SplitterWidth = 2;
            this.Nested_SplitCon.TabIndex = 2;
            // 
            // ViewKeys_Button
            // 
            this.ViewKeys_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ViewKeys_Button.Location = new System.Drawing.Point(483, 651);
            this.ViewKeys_Button.Name = "ViewKeys_Button";
            this.ViewKeys_Button.Size = new System.Drawing.Size(75, 23);
            this.ViewKeys_Button.TabIndex = 2;
            this.ViewKeys_Button.Text = "View Keys";
            this.ViewKeys_Button.UseVisualStyleBackColor = true;
            this.ViewKeys_Button.Click += new System.EventHandler(this.ViewKeys_Click);
            // 
            // MainTreeView
            // 
            this.MainTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTreeView.Location = new System.Drawing.Point(0, 0);
            this.MainTreeView.Name = "MainTreeView";
            this.MainTreeView.Size = new System.Drawing.Size(218, 691);
            this.MainTreeView.TabIndex = 0;
            this.MainTreeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.MainTreeView_NodeMouseDoubleClick);
            // 
            // ExpandNodes_Button
            // 
            this.ExpandNodes_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpandNodes_Button.Location = new System.Drawing.Point(1094, 3);
            this.ExpandNodes_Button.Name = "ExpandNodes_Button";
            this.ExpandNodes_Button.Size = new System.Drawing.Size(87, 23);
            this.ExpandNodes_Button.TabIndex = 3;
            this.ExpandNodes_Button.Text = "Expand Keys";
            this.ExpandNodes_Button.UseVisualStyleBackColor = true;
            this.ExpandNodes_Button.Click += new System.EventHandler(this.ExpandNodes_Button_Click);
            // 
            // CollapseNodes_Button
            // 
            this.CollapseNodes_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CollapseNodes_Button.Location = new System.Drawing.Point(1095, 32);
            this.CollapseNodes_Button.Name = "CollapseNodes_Button";
            this.CollapseNodes_Button.Size = new System.Drawing.Size(87, 23);
            this.CollapseNodes_Button.TabIndex = 4;
            this.CollapseNodes_Button.Text = "Collapse Keys";
            this.CollapseNodes_Button.UseVisualStyleBackColor = true;
            this.CollapseNodes_Button.Click += new System.EventHandler(this.CollapseNodes_Button_Click);
            // 
            // CurrentKey_GroupBox
            // 
            this.CurrentKey_GroupBox.Controls.Add(this.button1);
            this.CurrentKey_GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentKey_GroupBox.Location = new System.Drawing.Point(12, 12);
            this.CurrentKey_GroupBox.Name = "CurrentKey_GroupBox";
            this.CurrentKey_GroupBox.Size = new System.Drawing.Size(100, 114);
            this.CurrentKey_GroupBox.TabIndex = 1;
            this.CurrentKey_GroupBox.TabStop = false;
            this.CurrentKey_GroupBox.Text = "Current Key";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 89);
            this.button1.TabIndex = 0;
            this.button1.Text = "Bottled Beer";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // KeyPriGroupBox
            // 
            this.KeyPriGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.KeyPriGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KeyPriGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPriGroupBox.Location = new System.Drawing.Point(0, 0);
            this.KeyPriGroupBox.Name = "KeyPriGroupBox";
            this.KeyPriGroupBox.Size = new System.Drawing.Size(150, 46);
            this.KeyPriGroupBox.TabIndex = 0;
            this.KeyPriGroupBox.TabStop = false;
            this.KeyPriGroupBox.Text = "Key Priority";
            // 
            // PresetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1405, 691);
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
            this.Nested_SplitCon.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Nested_SplitCon)).EndInit();
            this.Nested_SplitCon.ResumeLayout(false);
            this.CurrentKey_GroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer Main_SplitCon;
        private CustomGrpBox KeyPriGroupBox;
        private CustomGrpBox CurrentKey_GroupBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView MainTreeView;
        private System.Windows.Forms.SplitContainer Nested_SplitCon;
        private System.Windows.Forms.Button ViewKeys_Button;
        private System.Windows.Forms.Button ExpandNodes_Button;
        private System.Windows.Forms.Button CollapseNodes_Button;
    }
}

