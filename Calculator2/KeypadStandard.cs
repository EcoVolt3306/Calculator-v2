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
        public static int calTypeA, calTypeB = 0;   // 연산기호 종류
        public static double operand = 0;     // 피연산자
        public static bool start, cal = false;
        


        public KeypadStandard()
        {
            InitializeComponent();
        }

        private void StnKey1_Click(object sender, EventArgs e)
        {
            data += "1";
            STN.resStn.PressNum(data);
        }

        private void StnKey2_Click(object sender, EventArgs e)
        {
            data += "2";
            STN.resStn.PressNum(data);
        }

        private void StnKey3_Click(object sender, EventArgs e)
        {
            data += "3";
            STN.resStn.PressNum(data);
        }

        private void StnKey4_Click(object sender, EventArgs e)
        {
            data += "4";
            STN.resStn.PressNum(data);
        }

        private void StnKey5_Click(object sender, EventArgs e)
        {
            data += "5";
            STN.resStn.PressNum(data);
        }

        private void StnKey6_Click(object sender, EventArgs e)
        {
            data += "6";
            STN.resStn.PressNum(data);
        }

        private void StnKey7_Click(object sender, EventArgs e)
        {
            data += "7";
            STN.resStn.PressNum(data);
        }

        private void StnKey8_Click(object sender, EventArgs e)
        {
            data += "8";
            STN.resStn.PressNum(data);
        }

        private void StnKey9_Click(object sender, EventArgs e)
        {
            data += "9";
            STN.resStn.PressNum(data);
        }

        private void StnKey0_Click(object sender, EventArgs e)
        {
            data += "0";
            STN.resStn.PressNum(data);
        }

        private void StnKeyDot_Click(object sender, EventArgs e)
        {
            data += ".";
            STN.resStn.PressNum(data);
        }

        private void StnKeyAddSub_Click(object sender, EventArgs e)
        {

        }

        private void StnKeyCE_Click(object sender, EventArgs e)
        {

        }

        private void StnKeyC_Click(object sender, EventArgs e)
        {
            data = null;
            calTypeA = 0;
            calTypeB = 0;
            operand = 0;
            start = false;

            STN.resStn.Clear();    // 수식 및 결과 초기화
        }

        private void StnKeyDelete_Click(object sender, EventArgs e)
        {

        }
        private void StnKeyAdd_Click(object sender, EventArgs e)
        {
            if (start == false) STN.resStn.PressOperatorFirst(data, 1);
            else if (start == true) STN.resStn.PressOperator(data, operand, 1);

            start = true;
            data = null;
        }

        private void StnKeySub_Click(object sender, EventArgs e)
        {
            if (start == false) STN.resStn.PressOperatorFirst(data, 2);
            else if (start == true) STN.resStn.PressOperator(data, operand, 2);

            start = true;
            data = null;
        }

        private void StnKeyMul_Click(object sender, EventArgs e)
        {
            if (start == false) STN.resStn.PressOperatorFirst(data, 3);
            else if (start == true) STN.resStn.PressOperator(data, operand, 3);

            start = true;
            data = null;
        }

        private void StnKeyDiv_Click(object sender, EventArgs e)
        {
            if (start == false) STN.resStn.PressOperatorFirst(data, 4);
            else if (start == true) STN.resStn.PressOperator(data, operand, 4);

            start = true;
            data = null;
        }

        private void StnKeyRes_Click(object sender, EventArgs e)
        {

        }

    }
}
