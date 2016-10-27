﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Preset_Maintenance
{
    public partial class PresetForm : Form
    {
        JarPriority jarPriority = new JarPriority();

        public PresetForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void PresetForm_Load(object sender, EventArgs e)
        {
            ShowJarPriorityPanel();
            DataAccessor.GetPresetAmountKeys(MainTreeView);
        }
        private void ShowJarPriorityPanel()
        {
            jarPriority.TopLevel = false;
            var left_Split = Main_SplitCon.Panel1.Controls["Nested_SplitCon"] as SplitContainer;
            Nested_SplitCon.Panel2.Controls[0].Controls.Add(jarPriority);
            jarPriority.FormBorderStyle = FormBorderStyle.None;
            jarPriority.Dock = DockStyle.Fill;
            jarPriority.Show();
        }
    }
}
