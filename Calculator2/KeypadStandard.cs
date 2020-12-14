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
        public static string num, exp, result = null;     // 입력, 수식, 결과
        public static int countOperand = 0;   // 피연산자 카운트
        public static double[] operand = new double[20];     // 피연산자


        public KeypadStandard()
        {
            InitializeComponent();
        }

        private void StnKey1_Click(object sender, EventArgs e)
        {
            num += "1";
            Standard.resStn.PressNum(num);
        }

        private void StnKey2_Click(object sender, EventArgs e)
        {
            num += "2";
            Standard.resStn.PressNum(num);
        }

        private void StnKey3_Click(object sender, EventArgs e)
        {
            num += "3";
            Standard.resStn.PressNum(num);
        }

        private void StnKey4_Click(object sender, EventArgs e)
        {
            num += "4";
            Standard.resStn.PressNum(num);
        }

        private void StnKey5_Click(object sender, EventArgs e)
        {
            num += "5";
            Standard.resStn.PressNum(num);
        }

        private void StnKey6_Click(object sender, EventArgs e)
        {
            num += "6";
            Standard.resStn.PressNum(num);
        }

        private void StnKey7_Click(object sender, EventArgs e)
        {
            num += "7";
            Standard.resStn.PressNum(num);
        }

        private void StnKey8_Click(object sender, EventArgs e)
        {
            num += "8";
            Standard.resStn.PressNum(num);
        }

        private void StnKey9_Click(object sender, EventArgs e)
        {
            num += "9";
            Standard.resStn.PressNum(num);
        }

        private void StnKey0_Click(object sender, EventArgs e)
        {
            num += "0";
            Standard.resStn.PressNum(num);
        }

        private void StnKeyDot_Click(object sender, EventArgs e)
        {
            num += ".";
            Standard.resStn.PressNum(num);
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
            operand[countOperand] = double.Parse(num);
            
            //Console.WriteLine("op1:" + operand[0] + "\top2:" + operand[1] + "\top3:" + operand[2]);

            countOperand++;
            num = null;
        }

        private void StnKeySub_Click(object sender, EventArgs e)
        {

        }

        private void StnKeyMul_Click(object sender, EventArgs e)
        {

        }

        private void StnKeyDiv_Click(object sender, EventArgs e)
        {

        }

        private void StnKeyRes_Click(object sender, EventArgs e)
        {

        }

    }
}
