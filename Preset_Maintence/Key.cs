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
    //DO I NEED INHERITANCE??
    public class Key
    {
        #region Variable Declarations

        private KeyData _keyData;

        #endregion

        public KeyData Data { get { return _keyData; } set { _keyData = value; } }

        public string KeyCode { get { return this.Data.KeyRow.KeyCode; } }

        public string KeyDescription { get { return this.Data.KeyRow.KeyDesc; } }

        public Key(jartrekDataSet.KeyMasterRow keyRow)
        {
            this._keyData = new KeyData(this, keyRow);
        }

        public class KeyData
        {
            #region - Variable Declarations

            Key _key;
            jartrekDataSet.KeyMasterRow _keyData;

            #endregion

            public jartrekDataSet.KeyMasterRow KeyRow { get { return _keyData; } }

            public KeyData(Key key, jartrekDataSet.KeyMasterRow keyData)
            {
                _key = key;
                this._keyData = keyData;
            }
        }

        public class Preset : INotifyPropertyChanged
        {
            private Key _parentKey;
            private PresetData _presetData;
            public event PropertyChangedEventHandler PropertyChanged;

            public Key ParentKey { get { return _parentKey; } }

            #region Preset Properties

            public PresetData Data { get { return _presetData; } set { _presetData = value; } }
            public string Legend { get { return this.Data.CurrentPresetData.PresetLegend; } }
            public string Description { get { return this.Data.CurrentPresetData.PresetDesc; } }
            public string KeyCode => this._parentKey.KeyCode;
            public string PresetCode => this._presetData.CurrentPresetData.PresetCode;
            public int Priority { get { return this._presetData.CurrentPresetData.PresetPriority; } set { this._presetData.CurrentPresetData.PresetPriority = value; } }
            public int Color { get { return this._presetData.CurrentPresetData.PresetColor; } set { _presetData.CurrentPresetData.PresetColor = value; } }
            public string BitMap { get { return this._presetData.CurrentPresetData.PresetPicture; } }

            #endregion

            public Preset(jartrekDataSet.PresetMasterRow data)
            {
                this._presetData = new PresetData(this, data);
                this._parentKey = new Key(data.KeyMasterRow);
            }

            private void OnPropertyChange([CallerMemberName] string propertyName = null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            //private Preset CreateDefaultPreset(Preset defaultPreset)
            //{
            //    //defaultPreset.Data = new PresetData(defaultPreset, new PresetData());

            //    defaultPreset.Data.DefaultPresetData = new PresetData().DefaultPresetData;

            //    return defaultPreset;
            //}
            public class PresetData
            {
                //#region - Variable Declarations

                private Preset _currentPreset { get; set; }//The preset itself.
                private jartrekDataSet.PresetMasterRow _presetRow;//has everything i would need to insert into dataset

                //#endregion

                public jartrekDataSet.PresetMasterRow CurrentPresetData { get { return _presetRow; } set { _presetRow = value; } }

                public PresetData() { }
                public PresetData(Preset preset, jartrekDataSet.PresetMasterRow data)
                {
                    _currentPreset = preset;
                    CurrentPresetData = data as jartrekDataSet.PresetMasterRow;//not a new row..
                }
            }

            public class Modifier
            {                
                private ModifierData _modifierData;
                private Preset _modPreset;

                public Modifier(jartrekDataSet.ModifierRow modifierRow)
                {
                    // this.modifierRow = modifierRow;
                    this._modPreset = new Key.Preset(modifierRow.PresetMasterRow);
                    this._modifierData = new ModifierData(this, modifierRow);
                }

                private class ModifierData
                {
                    private Modifier _currentModifier;
                    jartrekDataSet.ModifierRow _currentModRow;

                    public ModifierData(Modifier mod, jartrekDataSet.ModifierRow data)
                    {
                        this._currentModifier = mod;
                        this._currentModRow = data;

                    }
                }
            }
        }
    }
}

