using System;
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
    public partial class OldPresetPriority : Form
    {
        public OldPresetPriority()
        {
            InitializeComponent();
        }

        private void assignButtonTags()
        {
            var form = Application.OpenForms;
            var buttons = form[1].Controls[2].Controls.OfType<Button>().ToArray();

            foreach (Button btn in buttons)
            {
                btn.Click += Btn_Click;
                var buttonName = int.Parse(btn.Name.Substring(btn.Name.Length - 2, 2));
                var row = buttonName % 6;
                var col = Math.Floor((double)buttonName / 6) + 1;
                var pri = (((col - 1) * 6) + row);

                btn.Tag = pri.ToString();
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            //PriorityLabel.Text = getIndex(int.Parse((sender as Button).Tag.ToString())).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            assignButtonTags();
        }

        private int getIndex(int dbIndex)
        {
            var row = dbIndex % 6;
            var col = Math.Floor((double)dbIndex / 6) + 1;
            int pri = (int)(((col - 1) * 6) + row);

            return pri;
        }
    }
}
