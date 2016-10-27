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
            this.MainTreeView = new System.Windows.Forms.TreeView();
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
            this.Main_SplitCon.Name = "Main_SplitCon";
            // 
            // Main_SplitCon.Panel1
            // 
            this.Main_SplitCon.Panel1.Controls.Add(this.Nested_SplitCon);
            // 
            // Main_SplitCon.Panel2
            // 
            this.Main_SplitCon.Panel2.Controls.Add(this.MainTreeView);
            this.Main_SplitCon.Size = new System.Drawing.Size(2335, 1223);
            this.Main_SplitCon.SplitterDistance = 1795;
            this.Main_SplitCon.TabIndex = 0;
            // 
            // Nested_SplitCon
            // 
            this.Nested_SplitCon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Nested_SplitCon.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.Nested_SplitCon.Location = new System.Drawing.Point(0, 0);
            this.Nested_SplitCon.Name = "Nested_SplitCon";
            this.Nested_SplitCon.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // Nested_SplitCon.Panel1
            // 
            this.Nested_SplitCon.Panel1.Controls.Add(this.CurrentKey_GroupBox);
            // 
            // Nested_SplitCon.Panel2
            // 
            this.Nested_SplitCon.Panel2.AccessibleName = "";
            this.Nested_SplitCon.Panel2.Controls.Add(this.KeyPriGroupBox);
            this.Nested_SplitCon.Panel2MinSize = 100;
            this.Nested_SplitCon.Size = new System.Drawing.Size(1795, 1223);
            this.Nested_SplitCon.SplitterDistance = 626;
            this.Nested_SplitCon.TabIndex = 2;
            // 
            // MainTreeView
            // 
            this.MainTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTreeView.Location = new System.Drawing.Point(0, 0);
            this.MainTreeView.Margin = new System.Windows.Forms.Padding(6);
            this.MainTreeView.Name = "MainTreeView";
            this.MainTreeView.Size = new System.Drawing.Size(536, 1223);
            this.MainTreeView.TabIndex = 0;
            // 
            // CurrentKey_GroupBox
            // 
            this.CurrentKey_GroupBox.Controls.Add(this.button1);
            this.CurrentKey_GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentKey_GroupBox.Location = new System.Drawing.Point(75, 52);
            this.CurrentKey_GroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.CurrentKey_GroupBox.Name = "CurrentKey_GroupBox";
            this.CurrentKey_GroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.CurrentKey_GroupBox.Size = new System.Drawing.Size(201, 228);
            this.CurrentKey_GroupBox.TabIndex = 1;
            this.CurrentKey_GroupBox.TabStop = false;
            this.CurrentKey_GroupBox.Text = "Current Key";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 43);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 179);
            this.button1.TabIndex = 0;
            this.button1.Text = "Bottled Beer";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // KeyPriGroupBox
            // 
            this.KeyPriGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyPriGroupBox.BackColor = System.Drawing.SystemColors.Control;
            this.KeyPriGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPriGroupBox.Location = new System.Drawing.Point(0, 0);
            this.KeyPriGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.KeyPriGroupBox.Name = "KeyPriGroupBox";
            this.KeyPriGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.KeyPriGroupBox.Size = new System.Drawing.Size(1795, 593);
            this.KeyPriGroupBox.TabIndex = 0;
            this.KeyPriGroupBox.TabStop = false;
            this.KeyPriGroupBox.Text = "Key Priority";
            // 
            // PresetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(2335, 1223);
            this.Controls.Add(this.Main_SplitCon);
            this.Margin = new System.Windows.Forms.Padding(6);
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
    }
}

