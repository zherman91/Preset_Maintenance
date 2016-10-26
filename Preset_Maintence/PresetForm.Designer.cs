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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.MainTreeView = new System.Windows.Forms.TreeView();
            this.SubPanel = new System.Windows.Forms.Panel();
            this.KeyPriGroupBox = new Preset_Maintenance.CustomGrpBox();
            this.customGrpBox1 = new Preset_Maintenance.CustomGrpBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SubPanel.SuspendLayout();
            this.customGrpBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(-1, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.customGrpBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.MainTreeView);
            this.splitContainer1.Size = new System.Drawing.Size(1209, 428);
            this.splitContainer1.SplitterDistance = 790;
            this.splitContainer1.TabIndex = 0;
            // 
            // MainTreeView
            // 
            this.MainTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTreeView.Location = new System.Drawing.Point(0, 0);
            this.MainTreeView.Name = "MainTreeView";
            this.MainTreeView.Size = new System.Drawing.Size(415, 428);
            this.MainTreeView.TabIndex = 0;
            this.MainTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.MainTreeView_AfterSelect);
            // 
            // SubPanel
            // 
            this.SubPanel.Controls.Add(this.KeyPriGroupBox);
            this.SubPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SubPanel.Location = new System.Drawing.Point(0, 431);
            this.SubPanel.Name = "SubPanel";
            this.SubPanel.Size = new System.Drawing.Size(1208, 253);
            this.SubPanel.TabIndex = 1;
            // 
            // KeyPriGroupBox
            // 
            this.KeyPriGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KeyPriGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPriGroupBox.Location = new System.Drawing.Point(3, 3);
            this.KeyPriGroupBox.Name = "KeyPriGroupBox";
            this.KeyPriGroupBox.Size = new System.Drawing.Size(1202, 247);
            this.KeyPriGroupBox.TabIndex = 0;
            this.KeyPriGroupBox.TabStop = false;
            this.KeyPriGroupBox.Text = "Key Priority";
            // 
            // customGrpBox1
            // 
            this.customGrpBox1.Controls.Add(this.button1);
            this.customGrpBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customGrpBox1.Location = new System.Drawing.Point(13, 12);
            this.customGrpBox1.Name = "customGrpBox1";
            this.customGrpBox1.Size = new System.Drawing.Size(115, 121);
            this.customGrpBox1.TabIndex = 1;
            this.customGrpBox1.TabStop = false;
            this.customGrpBox1.Text = "Key";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.SpringGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(5, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 92);
            this.button1.TabIndex = 0;
            this.button1.Text = "Bottled Beer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PresetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1208, 684);
            this.Controls.Add(this.SubPanel);
            this.Controls.Add(this.splitContainer1);
            this.Name = "PresetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Window";
            this.Load += new System.EventHandler(this.PresetForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.SubPanel.ResumeLayout(false);
            this.customGrpBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView MainTreeView;
        private CustomGrpBox customGrpBox1;
        private System.Windows.Forms.Panel SubPanel;
        private CustomGrpBox KeyPriGroupBox;
    }
}

