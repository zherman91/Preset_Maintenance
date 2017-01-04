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
}

