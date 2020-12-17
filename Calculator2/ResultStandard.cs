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
            KeypadStandard.data = KeypadStandard.operand.ToString();


        }

        public void ExceNullOperand()
        {   // 연산자는 있으나, 피연산자가 없을 경우, 입력 값에 피연산자를 넣어 오류를 방지합니다.
            KeypadStandard.data = KeypadStandard.operand.ToString();
        }
        public void DataDelete()
        {
            KeypadStandard.data = KeypadStandard.data.Remove(KeypadStandard.data.Length - 1);

            if (KeypadStandard.data == "")   // Null Exception
            {
                KeypadStandard.data = null;
                outResult.Text = "0";
            }
            else outResult.Text = KeypadStandard.data;
        }

        public void ClearOut()
        {
            outExp.Text = "";
            outResult.Text = "0";
            Console.WriteLine("Clear : 초기화 되었습니다.");
        }

        public void ClearData()
        {
            KeypadStandard.data = null;
            KeypadStandard.calTypeA = 0;
            KeypadStandard.calTypeB = 0;
            KeypadStandard.operand = 0;
            KeypadStandard.answer = 0;
        }

        public void ClearCE()
        {
            if (KeypadStandard.data != null)
            {
                outResult.Text = "0";
                KeypadStandard.data = null;
            } else
            {
                ClearOut();
                ClearData();
            }
        }
        public void AddSub(string data)
        {   // 양수, 음수 전환
            KeypadStandard.data = (-(double.Parse(data))).ToString();
            outResult.Text = KeypadStandard.data;
        }

        // History 

        public void SaveHistoryFirst()
        {
            HIS.dicExp[0].Text = outExp.Text;
            HIS.dicRes[0].Text = outResult.Text;
        }
        public void SaveMemoryFirst()
        {
            HIS.dicMemExp[0].Text = outExp.Text;
            HIS.dicMemRes[0].Text = outResult.Text;
        }
        public void SaveHistoryLoopNow()
        {
            for(int i=KeypadStandard.cntUse; i>0; i--)  // Array 초과 Exception
            {
                if (i >= HIS.loopNow)
                {
                    i = HIS.loopNow-1;
                }

                HIS.dicExp[i].Text = HIS.dicExp[i-1].Text;
                HIS.dicRes[i].Text = HIS.dicRes[i-1].Text;
            }
        }
        public void SaveHistoryLoopMemory()
        {
            for (int i = KeypadStandard.cntUse; i > 0; i--)  // Array 초과 Exception
            {
                if (i >= HIS.loopMemory)
                {
                    i = HIS.loopMemory - 1;
                }

                HIS.dicMemExp[i].Text = HIS.dicMemExp[i - 1].Text;
                HIS.dicMemRes[i].Text = HIS.dicMemRes[i - 1].Text;
            }
        }

        public string OutResult()
        {
            string text = outResult.Text;
            return text;
        }
    }
}
