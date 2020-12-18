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
    public partial class KeypadStandard : UserControl
    {
        public static string data = null;     // 입력 값
        public static int calTypeA, calTypeB, answer, cntUse = 0;   // 연산기호 종류
        public static double operand, operandExt = 0;     // 피연산자
        


        public KeypadStandard()
        {
            InitializeComponent();
        }

        private void StnKey1_Click(object sender, EventArgs e)
        {
            data += "1";
            STN.resStn.PressNum(data);
            COM.InData("1");
        }

        private void StnKey2_Click(object sender, EventArgs e)
        {
            data += "2";
            STN.resStn.PressNum(data);
            COM.InData("2");
        }

        private void StnKey3_Click(object sender, EventArgs e)
        {
            data += "3";
            STN.resStn.PressNum(data);
            COM.InData("3");
        }

        private void StnKey4_Click(object sender, EventArgs e)
        {
            data += "4";
            STN.resStn.PressNum(data);
            COM.InData("4");
        }

        private void StnKey5_Click(object sender, EventArgs e)
        {
            data += "5";
            STN.resStn.PressNum(data);
            COM.InData("5");
        }

        private void StnKey6_Click(object sender, EventArgs e)
        {
            data += "6";
            STN.resStn.PressNum(data);
            COM.InData("6");
        }

        private void StnKey7_Click(object sender, EventArgs e)
        {
            data += "7";
            STN.resStn.PressNum(data);
            COM.InData("7");
        }

        private void StnKey8_Click(object sender, EventArgs e)
        {
            data += "8";
            STN.resStn.PressNum(data);
            COM.InData("8");
        }

        private void StnKey9_Click(object sender, EventArgs e)
        {
            data += "9";
            STN.resStn.PressNum(data);
            COM.InData("9");
        }

        private void StnKey0_Click(object sender, EventArgs e)
        {
            if(data != null)
            {
                data += "0";
                STN.resStn.PressNum(data);
                COM.InData("10");
            }

        }

        private void StnKeyDot_Click(object sender, EventArgs e)
        {
            data += ".";
            STN.resStn.PressNum(data);
            COM.InData(".");
        }

        private void StnKeyAddSub_Click(object sender, EventArgs e)
        {
            if (data != null) STN.resStn.AddSub(data);
        }

        private void StnKeyCE_Click(object sender, EventArgs e)
        {
            //if (data == null) STN.resStn.ClearOut();
            STN.resStn.ClearCE();
        }

        private void StnKeyC_Click(object sender, EventArgs e)
        {
            STN.resStn.ClearData(); // 데이터 초기화
            STN.resStn.ClearOut();    // 수식 및 결과 초기화
        }

        private void StnKeyDelete_Click(object sender, EventArgs e)
        {
            if (data != null) STN.resStn.DataDelete();
        }
        private void StnKeyAdd_Click(object sender, EventArgs e)
        {
            if (answer == 0 && data != null) STN.resStn.PressOperatorFirst(data, 1);
            else if (answer > 0 && data != null) STN.resStn.PressOperator(data, operand, 1);

        }

        private void StnKeySub_Click(object sender, EventArgs e)
        {
            if (answer == 0 && data != null) STN.resStn.PressOperatorFirst(data, 2);
            else if (answer > 0 && data != null) STN.resStn.PressOperator(data, operand, 2);
            
        }

        private void StnKeyMul_Click(object sender, EventArgs e)
        {
            if (answer == 0 && data != null) STN.resStn.PressOperatorFirst(data, 3);
            else if (answer > 0 && data != null) STN.resStn.PressOperator(data, operand, 3);
        }

        private void StnKeyDiv_Click(object sender, EventArgs e)
        {
            if (answer == 0 && data != null) STN.resStn.PressOperatorFirst(data, 4);
            else if (answer > 0 && data != null) STN.resStn.PressOperator(data, operand, 4);

        }

        private void StnKeyRes_Click(object sender, EventArgs e)
        {
            if(data == null)
            {
                if (calTypeA != 0) STN.resStn.ExceNullOperand();    // 피연산자 오류 방지
                else return;    // 0 상태로 합산시 예외처리
            }

            STN.resStn.PressResult(data, calTypeA); // 계산


            // History
            if (KeypadStandard.cntUse == 0)
            {
                STN.resStn.SaveHistoryFirst();
                STN.resStn.SaveMemoryFirst();
            }
            else if (KeypadStandard.cntUse > 0)
            {
                STN.resStn.SaveHistoryLoopNow();
                STN.resStn.SaveHistoryFirst();

                STN.resStn.SaveHistoryLoopMemory();
                STN.resStn.SaveMemoryFirst();
            } 

            cntUse++;
        }

    }
}
