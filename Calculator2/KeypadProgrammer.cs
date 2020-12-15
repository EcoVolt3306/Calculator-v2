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
            // 프로그래머 : 기본 키패드 초기화

            //PGM.keyPgm.ActivePgmKey(2);

        }

        private void KeyStn_Click(object sender, EventArgs e)   // 프로그래머 : 기본 키패드
        {
            if (this.AreaPgmKey.Controls.Count > 0) this.AreaPgmKey.Controls.Clear();   // 패널 초기화
            KeyHEX keyStn = new KeyHEX();
            this.AreaPgmKey.Controls.Add(keyStn);
        }

        private void KeyBit_Click(object sender, EventArgs e)   // 프로그래머 : 비트 키패드
        {
            if (this.AreaPgmKey.Controls.Count > 0) this.AreaPgmKey.Controls.Clear();   // 패널 초기화
            KeyBit keyBit = new KeyBit();
            this.AreaPgmKey.Controls.Add(keyBit);
        }

        public void ActivePgmKey(int type)
        {
            switch (type)
            {
                case 1:
                    this.AreaPgmKey.Controls.Add(PGM.keyHEX);
                    break;
                case 2:
                    this.AreaPgmKey.Controls.Add(PGM.keyDEC);
                    break;
                case 3:
                    this.AreaPgmKey.Controls.Add(PGM.keyOCT);
                    break;
                case 4:
                    this.AreaPgmKey.Controls.Add(PGM.keyBIN);
                    break;
            }
        }

    }
}
