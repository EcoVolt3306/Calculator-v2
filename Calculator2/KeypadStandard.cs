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
        string num, exp, result = null;     // 입력, 수식, 결과

        public string gs
        {
            get
            {
                return num;
            } set
            {
                num = value;
            }
        }

        int countOperand = 0;   // 피연산자 카운트

        double[] operand = new double[20];     // 피연산자

        public KeypadStandard()
        {
            InitializeComponent();
        }

        private void StnKey1_Click(object sender, EventArgs e)
        {
            num += "1";
        }

        private void StnKey2_Click(object sender, EventArgs e)
        {
            num += "2";
        }

        private void StnKey3_Click(object sender, EventArgs e)
        {
            num += "3";
        }

        private void StnKey4_Click(object sender, EventArgs e)
        {
            num += "4";
        }

        private void StnKey5_Click(object sender, EventArgs e)
        {
            num += "5";
        }

        private void StnKey6_Click(object sender, EventArgs e)
        {
            num += "6";
        }

        private void StnKey7_Click(object sender, EventArgs e)
        {
            num += "7";
        }

        private void StnKey8_Click(object sender, EventArgs e)
        {
            num += "8";
        }

        private void StnKey9_Click(object sender, EventArgs e)
        {
            num += "9";
        }

        private void StnKey0_Click(object sender, EventArgs e)
        {
            num += "0";
        }

        private void StnKeyDot_Click(object sender, EventArgs e)
        {
            num += ".";
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
            //StnCalculation.Add(num);

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
