using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class KeypadProgrammer : UserControl
    {
        public KeypadProgrammer()
        {
            InitializeComponent();
        }

        private void KeyStn_Click(object sender, EventArgs e)   // 기본 키패드
        {
            if (this.AreaPgmKey.Controls.Count > 0) this.AreaPgmKey.Controls.Clear();   // 패널 초기화
            KeyStandard keyStn = new KeyStandard();
            this.AreaPgmKey.Controls.Add(keyStn);
        }

        private void KeyBit_Click(object sender, EventArgs e)   // 비트 키패드
        {
            if (this.AreaPgmKey.Controls.Count > 0) this.AreaPgmKey.Controls.Clear();   // 패널 초기화
            KeyBit keyBit = new KeyBit();
            this.AreaPgmKey.Controls.Add(keyBit);
        }
    }
}
