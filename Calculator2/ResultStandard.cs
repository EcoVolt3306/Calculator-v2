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
    public partial class ResultStandard : UserControl
    {

        public ResultStandard()
        {
            InitializeComponent();
        }

        public void PressNum(string num)    // 입력 값
        {
            outResult.Text = num;   // 스탠다스 수식 결과에 누른 버튼을 출력
        }
        public double PressOperator(int caseOperator, double operand, double final) // 연산 기호버튼 누를 경우
        {
            outExp.Text += operand;

            switch (caseOperator)    // 연산 종류에 따라 실행
            {
                case 1: // 덧셈
                    outExp.Text += " + ";
                    final += operand;
                    break;
                case 2: // 뺄셈
                    outExp.Text += " - ";
                    final -= operand;
                    break;
                case 3: // 곱셈
                    outExp.Text += " × ";
                    final *= operand;
                    break;
                case 4: // 나눗셈
                    outExp.Text += " ÷ ";
                    final /= operand;
                    break;
            }
            outResult.Text = final.ToString();

            return final;
        }

        public void PressResult(double operand, double final, int caseOperator) // = 버튼 누를 경우
        {

            switch (caseOperator)    // 연산 종류에 따라 실행
            {
                case 1: // 덧셈

                    break;
                case 2: // 뺄셈

                    break;
                case 3: // 곱셈

                    break;
                case 4: // 나눗셈

                    break;
            }
            
        }

        public void PressC()
        {
            outExp.Text = "";
            outResult.Text = "0";
        }
    }
}
