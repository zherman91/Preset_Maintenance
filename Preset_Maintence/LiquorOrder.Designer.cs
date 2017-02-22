namespace Preset_Maintenance
{
    partial class LiquorOrder
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
            this.Generate_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Generate_Button
            // 
            this.Generate_Button.Location = new System.Drawing.Point(12, 12);
            this.Generate_Button.Name = "Generate_Button";
            this.Generate_Button.Size = new System.Drawing.Size(626, 197);
            this.Generate_Button.TabIndex = 0;
            this.Generate_Button.Text = "Generate Liquor Order";
            this.Generate_Button.UseVisualStyleBackColor = true;
            this.Generate_Button.Click += new System.EventHandler(this.Generate_Button_Click);
            // 
            // LiquorOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 221);
            this.Controls.Add(this.Generate_Button);
            this.Name = "LiquorOrder";
            this.Text = "LiquorOrder";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Generate_Button;
    }
}