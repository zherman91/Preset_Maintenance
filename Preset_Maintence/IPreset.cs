using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preset_Maintenance
{
    interface IPreset
    {
        Preset.PresetData defaultPresetData { get; set; }



        Preset CreateDefaultPreset(jartrekDataSet.PresetMasterRow data);


    }
}
