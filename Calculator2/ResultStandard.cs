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

        public void PressNum(string data)    // 입력 값
        {
            outResult.Text = data;   // 스탠다스 수식 결과에 누른 버튼을 출력
        }
        public void PressOperatorFirst(string data, int calTypeA)
        {
            KeypadStandard.operand = double.Parse(data);
            KeypadStandard.calTypeA = calTypeA;

            outExp.Text = data;
            Exp(calTypeA);

        }
        public void PressOperator(string data, double operand, int calTypeB) // 연산 기호버튼 누를 경우
        {
            switch (KeypadStandard.calTypeA)
            {
                case 1: // 덧셈
                    KeypadStandard.operand += double.Parse(data);
                    break;
                case 2: // 뺄셈
                    KeypadStandard.operand -= double.Parse(data);
                    break;
                case 3: // 곱셈
                    KeypadStandard.operand *= double.Parse(data);
                    break;
                case 4: // 나눗셈
                    KeypadStandard.operand /= double.Parse(data);
                    break;
            }

            outExp.Text += data;
            Exp(calTypeB);

            KeypadStandard.calTypeA = calTypeB;
            KeypadStandard.calTypeB = 0;
        }

        public void Exp(int type)
        {
            switch (type)
            {
                case 1: // 덧셈
                    outExp.Text += " + ";
                    break;
                case 2: // 뺄셈
                    outExp.Text += " - ";
                    break;
                case 3: // 곱셈
                    outExp.Text += " × ";
                    break;
                case 4: // 나눗셈
                    outExp.Text += " ÷ ";
                    break;
            }
            outResult.Text = KeypadStandard.operand.ToString();
        }

        public void PressResult(string data, int calTypeA) // = 계산
        {
            switch (KeypadStandard.calTypeA)
            {
                case 1: // 덧셈
                    KeypadStandard.operand += double.Parse(data);
                    break;
                case 2: // 뺄셈
                    KeypadStandard.operand -= double.Parse(data);
                    break;
                case 3: // 곱셈
                    KeypadStandard.operand *= double.Parse(data);
                    break;
                case 4: // 나눗셈
                    KeypadStandard.operand /= double.Parse(data);
                    break;
            }

            outExp.Text += data + " = ";
            outResult.Text = KeypadStandard.operand.ToString();

            KeypadStandard.calTypeA = 0;
            KeypadStandard.answer = 0;
        }

        public void Clear()
        {
            outExp.Text = "";
            outResult.Text = "0";
            Console.WriteLine("Clear : 초기화 되었습니다.");
        }
    }
}
