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
        public static string num = null;     // 입력 값
        public static int caseOperator = 0;   // 연산기호 종류
        public static double operand, final = 0;     // 피연산자
        


        public KeypadStandard()
        {
            InitializeComponent();
        }

        private void StnKey1_Click(object sender, EventArgs e)
        {
            num += "1";
            STN.resStn.PressNum(num);
        }

        private void StnKey2_Click(object sender, EventArgs e)
        {
            num += "2";
            STN.resStn.PressNum(num);
        }

        private void StnKey3_Click(object sender, EventArgs e)
        {
            num += "3";
            STN.resStn.PressNum(num);
        }

        private void StnKey4_Click(object sender, EventArgs e)
        {
            num += "4";
            STN.resStn.PressNum(num);
        }

        private void StnKey5_Click(object sender, EventArgs e)
        {
            num += "5";
            STN.resStn.PressNum(num);
        }

        private void StnKey6_Click(object sender, EventArgs e)
        {
            num += "6";
            STN.resStn.PressNum(num);
        }

        private void StnKey7_Click(object sender, EventArgs e)
        {
            num += "7";
            STN.resStn.PressNum(num);
        }

        private void StnKey8_Click(object sender, EventArgs e)
        {
            num += "8";
            STN.resStn.PressNum(num);
        }

        private void StnKey9_Click(object sender, EventArgs e)
        {
            num += "9";
            STN.resStn.PressNum(num);
        }

        private void StnKey0_Click(object sender, EventArgs e)
        {
            num += "0";
            STN.resStn.PressNum(num);
        }

        private void StnKeyDot_Click(object sender, EventArgs e)
        {
            num += ".";
            STN.resStn.PressNum(num);
        }

        private void StnKeyAddSub_Click(object sender, EventArgs e)
        {

        }

        private void StnKeyCE_Click(object sender, EventArgs e)
        {

        }

        private void StnKeyC_Click(object sender, EventArgs e)
        {

        }

        private void StnKeyDelete_Click(object sender, EventArgs e)
        {

        }
        private void StnKeyAdd_Click(object sender, EventArgs e)
        {
            caseOperator = 1;
            operand = double.Parse(num);
            
            final = STN.resStn.PressOperator(caseOperator, operand, final);

            num = null;
        }

        private void StnKeySub_Click(object sender, EventArgs e)
        {
            caseOperator = 2;
            operand = double.Parse(num);

            STN.resStn.PressOperator(caseOperator, operand, final);

            num = null;
        }

        private void StnKeyMul_Click(object sender, EventArgs e)
        {
            caseOperator = 3;
            operand = double.Parse(num);

            STN.resStn.PressOperator(caseOperator, operand, final);

            num = null;
        }

        private void StnKeyDiv_Click(object sender, EventArgs e)
        {
            caseOperator = 4;
            operand = double.Parse(num);

            STN.resStn.PressOperator(caseOperator, operand, final);

            num = null;
        }

        private void StnKeyRes_Click(object sender, EventArgs e)
        {

        }

    }
}
