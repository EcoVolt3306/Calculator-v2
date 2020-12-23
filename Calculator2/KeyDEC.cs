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
            PGM.resPgm.AddSub(PGM.resPgm.OutResult(), PGM.outType);
        }

        private void PgmKeyCE_Click(object sender, EventArgs e)
        {
            if (PGM.data == null) PGM.resPgm.ClearOut();
            PGM.resPgm.ClearCE();
        }

        private void PgmKeyC_Click(object sender, EventArgs e)
        {
            PGM.resPgm.ClearAll();
        }

        private void PgmKeyDelete_Click(object sender, EventArgs e)
        {
            if (PGM.data != null) PGM.resPgm.DataDelete();
        }

        private void PgmKeyAdd_Click(object sender, EventArgs e)
        {
            PGM.resPgm.ExDataNull();
            if (PGM.answer == 0) PGM.resPgm.PressOperatorFirst(PGM.data, 1, PGM.outType);
            else if (PGM.answer > 0) PGM.resPgm.PressOperator(PGM.data, 1, PGM.outType);

            PGM.answer += 1;
            PGM.data = null;
        }

        private void PgmKeySub_Click(object sender, EventArgs e)
        {
            PGM.resPgm.ExDataNull();
            if (PGM.answer == 0) PGM.resPgm.PressOperatorFirst(PGM.data, 2, PGM.outType);
            else if (PGM.answer > 0) PGM.resPgm.PressOperator(PGM.data, 2, PGM.outType);

            PGM.answer += 1;
            PGM.data = null;
        }

        private void PgmKeyMul_Click(object sender, EventArgs e)
        {
            PGM.resPgm.ExDataNull();
            if (PGM.answer == 0) PGM.resPgm.PressOperatorFirst(PGM.data, 3, PGM.outType);
            else if (PGM.answer > 0) PGM.resPgm.PressOperator(PGM.data, 3, PGM.outType);

            PGM.answer += 1;
            PGM.data = null;
        }

        private void PgmKeyDiv_Click(object sender, EventArgs e)
        {
            PGM.resPgm.ExDataNull();
            if (PGM.answer == 0) PGM.resPgm.PressOperatorFirst(PGM.data, 4, PGM.outType);
            else if (PGM.answer > 0) PGM.resPgm.PressOperator(PGM.data, 4, PGM.outType);

            PGM.answer += 1;
            PGM.data = null;
        }

        private void PgmKeyResult_Click(object sender, EventArgs e)
        {
            if (PGM.data == null)
            {
                if (PGM.calTypeA != 0) PGM.resPgm.ExceNullOperand();    // 피연산자 오류 방지
                else if (PGM.resPgm.OutResult() == "0") return;  // 0 상태로 합산시 예외처리
            }

            PGM.resPgm.PressResult(PGM.data, PGM.calTypeA, PGM.outType); // 계산

            Frame.CntDB();  // DB 데이터 수 새로고침

            // History
            if (KeypadStandard.cntUse == 0)
            {
                PGM.resPgm.SaveHistoryFirst();

                if (DB.cntDB != 0) PGM.resPgm.SaveHistoryLoopMemoryDB();
                PGM.resPgm.SaveMemoryFirst();
            }
            else if (KeypadStandard.cntUse > 0)
            {
                PGM.resPgm.SaveHistoryLoopNow();
                PGM.resPgm.SaveHistoryFirst();

                PGM.resPgm.SaveHistoryLoopMemoryDB();
                PGM.resPgm.SaveMemoryFirst();
            }



            PGM.resPgm.ClearPGMdata();

            KeypadStandard.cntUse++;
        }
    }
}
