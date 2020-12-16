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
    public partial class KeyDEC : UserControl
    {
        public KeyDEC()
        {
            InitializeComponent();
        }

        private void PgmKey1_Click(object sender, EventArgs e)
        {
            PGM.data += "1";
            PGM.resPgm.PressNum(PGM.data);
        }

        private void PgmKey2_Click(object sender, EventArgs e)
        {
            PGM.data += "2";
            PGM.resPgm.PressNum(PGM.data);
        }

        private void PgmKey3_Click(object sender, EventArgs e)
        {
            PGM.data += "3";
            PGM.resPgm.PressNum(PGM.data);
        }

        private void PgmKey4_Click(object sender, EventArgs e)
        {
            PGM.data += "4";
            PGM.resPgm.PressNum(PGM.data);
        }

        private void PgmKey5_Click(object sender, EventArgs e)
        {
            PGM.data += "5";
            PGM.resPgm.PressNum(PGM.data);
        }

        private void PgmKey6_Click(object sender, EventArgs e)
        {
            PGM.data += "6";
            PGM.resPgm.PressNum(PGM.data);
        }

        private void PgmKey7_Click(object sender, EventArgs e)
        {
            PGM.data += "7";
            PGM.resPgm.PressNum(PGM.data);
        }

        private void PgmKey8_Click(object sender, EventArgs e)
        {
            PGM.data += "8";
            PGM.resPgm.PressNum(PGM.data);
        }

        private void PgmKey9_Click(object sender, EventArgs e)
        {
            PGM.data += "9";
            PGM.resPgm.PressNum(PGM.data);
        }

        private void PgmKey0_Click(object sender, EventArgs e)
        {
            PGM.data += "0";
            PGM.resPgm.PressNum(PGM.data);
        }

        private void PgmKeyDot_Click(object sender, EventArgs e)
        {
            // Programmer Keypad에서 .(Dot)은 구현되지 않음.
        }

        private void PgmKeyAddSub_Click(object sender, EventArgs e)
        {
            PGM.resPgm.AddSub(PGM.data);    // DEC 기준
        }

        private void PgmKeyCE_Click(object sender, EventArgs e)
        {
            if (PGM.data == null) PGM.resPgm.Clear();
            PGM.resPgm.ClearCE();
        }

        private void PgmKeyC_Click(object sender, EventArgs e)
        {
            PGM.resPgm.ClearData();
            PGM.resPgm.Clear();
        }

        private void PgmKeyDelete_Click(object sender, EventArgs e)
        {
            if (PGM.data != null) PGM.resPgm.DataDelete();
        }

        private void PgmKeyAdd_Click(object sender, EventArgs e)
        {
            if (PGM.answer == 0) PGM.resPgm.PressOperatorFirst(PGM.data, 1, PGM.outType);
            else if (PGM.answer > 0) PGM.resPgm.PressOperator(PGM.data, 1, PGM.outType);

            PGM.answer += 1;
            PGM.data = null;
        }

        private void PgmKeySub_Click(object sender, EventArgs e)
        {
            if (PGM.answer == 0) PGM.resPgm.PressOperatorFirst(PGM.data, 2, PGM.outType);
            else if (PGM.answer > 0) PGM.resPgm.PressOperator(PGM.data, 2, PGM.outType);

            PGM.answer += 1;
            PGM.data = null;
        }

        private void PgmKeyMul_Click(object sender, EventArgs e)
        {
            if (PGM.answer == 0) PGM.resPgm.PressOperatorFirst(PGM.data, 3, PGM.outType);
            else if (PGM.answer > 0) PGM.resPgm.PressOperator(PGM.data, 3, PGM.outType);

            PGM.answer += 1;
            PGM.data = null;
        }

        private void PgmKeyDiv_Click(object sender, EventArgs e)
        {
            if (PGM.answer == 0) PGM.resPgm.PressOperatorFirst(PGM.data, 4, PGM.outType);
            else if (PGM.answer > 0) PGM.resPgm.PressOperator(PGM.data, 4, PGM.outType);

            PGM.answer += 1;
            PGM.data = null;
        }

        private void PgmKeyResult_Click(object sender, EventArgs e)
        {
            if (PGM.data == null && PGM.calTypeA != 0) PGM.resPgm.ExceNullOperand();    // 피연산자 오류 방지
            PGM.resPgm.PressResult(PGM.data, PGM.calTypeA, PGM.outType); // 계산
            STN.resStn.ClearData();

            PGM.cntUse++;
        }
    }
}
