using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Preset_Maintenance
{
    public class Key
    {
        private KeyData _keyData;

        public KeyData Data { get { return _keyData; } set { _keyData = value; } }

        public Key()
        {

        }

        public Key(Key key, string keyCode)
        {
            Data = key.Data;
        }

        public Key(jartrekDataSet.KeyMasterRow _keyData)
        {
            this._keyData = new KeyData(this, _keyData);
        }

        public class KeyData : Key
        {
            #region - Variable Declarations

            Key _key;

            #endregion

            public KeyData(Key key, jartrekDataSet.KeyMasterRow keyData) : base(keyData)
            {
                _key = key;
            }
        }
    }

    public class Preset : INotifyPropertyChanged
    {
        private PresetData _presetData;
        private Preset defaultPreset;


        public PresetData Data { get { return _presetData; } set { _presetData = value; } }

        /// <summary>
        /// Initializes a new instance of the <see cref="Preset"/> class.
        /// </summary>
        public Preset() { if (this.Data == null) CreateDefaultPreset(this); }
        public Preset(Preset preset, PresetData data)
        {
            defaultPreset = preset;
            //_presetData = new PresetData(this, data);

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="Preset"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public Preset(jartrekDataSet.PresetMasterRow data)
        {
            _presetData = new PresetData(this, data);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChange([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void CreateDefaultPreset(Preset defaultPreset)
        {
            //defaultPreset.Data = new PresetData(defaultPreset, new PresetData());
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
                    /**
                     * PresetCode
                     * KeyCode
                     * PresetDesc
                     * PresetLegend
                     * PresetPriority
                     * PresetTax
                     * PresetPrice
                     * PresetPrint
                     * PresetMtdQty
                     * PresetMtdAmt
                     * PreRemPrt1
                     * PreRemPrt2
                     * PresetColor
                     * PresetPrice 1 - 8
                     * PresetReceipt
                     * PresetPicture
                     * PresetChip = N
                     * PresetChippable = Y
                     * PrestChitToggle = N
                     * PresetPrintChit = N
                     * PresetPrintScan = N
                     *  
                     * **/

                    _defaultPresetData.PresetPriority = 0;
                    _defaultPresetData.PresetColor = 0;
                    _defaultPresetData.PresetLegend = " ";
                    _defaultPresetData.PresetPrint = "N";
                    _defaultPresetData.PresetMtdQty = 0;
                    _defaultPresetData.PresetMtdAmt = 0;
                    _defaultPresetData.PresetYtdAmt = 0;
                    _defaultPresetData.PresetYtdQty = 0;
                    _defaultPresetData.PresetTax = "N";
                    _defaultPresetData.PresetReceipt = "N";
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

            public PresetData(Preset preset, jartrekDataSet.PresetMasterRow data)
            {
                _currentPreset = preset;
                if (data.IsNull(0))
                    DefaultPresetData = data;
                else
                    CurrentPresetData = data as jartrekDataSet.PresetMasterRow;
            }
        }
    }
}

