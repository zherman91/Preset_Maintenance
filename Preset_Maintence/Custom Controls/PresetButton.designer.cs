using System.Windows.Forms;

namespace Preset_Maintenance
{
    partial class PresetButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPreset_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainPreset_Button
            // 
            this.MainPreset_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPreset_Button.Location = new System.Drawing.Point(0, 0);
            this.MainPreset_Button.Name = "MainPreset_Button";
            this.MainPreset_Button.Size = new System.Drawing.Size(58, 57);
            this.MainPreset_Button.TabIndex = 0;
            this.MainPreset_Button.Text = "I am a Preset";
            this.MainPreset_Button.UseVisualStyleBackColor = true;
            // 
            // MyPresetButton
            // 
            this.Controls.Add(this.MainPreset_Button);
            this.Name = "MyPresetButton";
            this.Size = new System.Drawing.Size(58, 57);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button MainPreset_Button;
    }
}
