using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Preset_Maintenance
{
    public class Preset : INotifyPropertyChanged
    {
        private PresetData _presetData;
        private Preset defaultPreset;

        public PresetData Data { get { return _presetData; } set { _presetData = value; } }
        public string Legend { get { return this.Data.CurrentPresetData.PresetLegend; } }
        public string KeyCode => this._presetData.CurrentPresetData.KeyCode;
        public string PresetCode => this._presetData.CurrentPresetData.PresetCode;
        public int Priority { get { return this._presetData.CurrentPresetData.PresetPriority; } set { this._presetData.CurrentPresetData.PresetPriority = value; } }
        public int Color { get { return this._presetData.CurrentPresetData.PresetColor; } set { _presetData.CurrentPresetData.PresetColor = value; } }
        public string BitMap { get { return this._presetData.CurrentPresetData.PresetPicture; } }


        public Preset()
        {
            if (this.Data == null)
                CreateDefaultPreset(this);
        }
        public Preset(Preset preset, PresetData data)
        {
            defaultPreset = preset;
            //_presetData = new PresetData(this, data);

        }
        public Preset(jartrekDataSet.PresetMasterRow data)
        {
            _presetData = new PresetData(this, data);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChange([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private Preset CreateDefaultPreset(Preset defaultPreset)
        {
            //defaultPreset.Data = new PresetData(defaultPreset, new PresetData());

            defaultPreset.Data.DefaultPresetData = new PresetData().DefaultPresetData;

            return defaultPreset;
        }
        public class PresetData
        {
            #region - Variable Declarations

            private Preset _currentPreset;//The preset itself.
            private jartrekDataSet.PresetMasterRow _presetData;//has everything i would need to insert into dataset
            private jartrekDataSet.PresetMasterRow _defaultPresetData;

            #endregion

            public jartrekDataSet.PresetMasterRow CurrentPresetData { get { return _presetData; } set { _presetData = value; } }
            public jartrekDataSet.PresetMasterRow DefaultPresetData
            {
                get
                {

                    _defaultPresetData.PresetDesc = "Default Description";//
                    _defaultPresetData.PresetCode = " ";//
                    _defaultPresetData.PresetPriority = 0;
                    _defaultPresetData.PresetColor = 6;
                    _defaultPresetData.PresetLegend = "Default Legend";
                    _defaultPresetData.PresetPrint = "N";
                    _defaultPresetData.PresetMtdQty = 0;
                    _defaultPresetData.PresetMtdAmt = 0;
                    _defaultPresetData.PresetYtdAmt = 0;
                    _defaultPresetData.PresetYtdQty = 0;
                    _defaultPresetData.PresetTax = "N";
                    _defaultPresetData.PresetReceipt = "Default Text";
                    _defaultPresetData.PreRemPrt1 = "N";
                    _defaultPresetData.PreRemPrt2 = "N";
                    _defaultPresetData.PresetPicture = "<None>";
                    _defaultPresetData.PresetChip = "N";
                    _defaultPresetData.PresetChippable = "Y";
                    _defaultPresetData.PresetChitScan = "N";
                    _defaultPresetData.PresetPrintChit = "N";
                    _defaultPresetData.PresetChitToggle = "N";

                    return _defaultPresetData;
                }
                set
                {
                    _defaultPresetData = value;
                }
            }

            public PresetData() { }
            public PresetData(Preset preset)
            {
                preset.Data.DefaultPresetData = DefaultPresetData;
            }
            public PresetData(Preset preset, jartrekDataSet.PresetMasterRow data)
            {
                _currentPreset = preset;
                if (data.IsNull(0))
                    DefaultPresetData = data;
                else
                    CurrentPresetData = data as jartrekDataSet.PresetMasterRow;//not a new row..
            }

        }
    }
}
