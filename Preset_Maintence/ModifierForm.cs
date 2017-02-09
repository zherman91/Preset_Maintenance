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
    public partial class ModifierForm : Form
    {
        private DataRowView currentPreset { get; set; }

        public ModifierForm()
        {
            InitializeComponent();
        }
        public ModifierForm(DataRowView currentRow)
        {
            InitializeComponent();
            currentPreset = currentRow;
        }
    }
}
