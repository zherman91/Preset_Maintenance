﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Preset_Maintenance.PresetForm;

namespace PriorityControl
{
    public partial class MyPresetButton : UserControl
    {
        public Button PresetButton { get { return MainPreset_Button; } }

        public MyPresetButton()
        {
            InitializeComponent();
        }
    }
}
