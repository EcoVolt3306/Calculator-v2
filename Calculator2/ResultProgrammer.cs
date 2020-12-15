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
    public partial class ResultProgrammer : UserControl
    {
        public ResultProgrammer()
        {
            InitializeComponent();
        }

        private void ViewHEX_CheckedChanged(object sender, EventArgs e)
        {
            if (ViewHEX.Checked == true)
            {
                PGM.keyPgm.ActivePgmKey(1);
                PGM.outType = 1;
                PGM.data = null;
            }
            else return;
        }

        private void ViewDEC_CheckedChanged(object sender, EventArgs e)
        {
            if (ViewDEC.Checked == true)
            {
                PGM.keyPgm.ActivePgmKey(2);
                PGM.outType = 2;
                PGM.data = null;
            }
            else return;
        }

        private void ViewOCT_CheckedChanged(object sender, EventArgs e)
        {
            if (ViewOCT.Checked == true)
            {
                PGM.keyPgm.ActivePgmKey(3);
                PGM.outType = 3;
                PGM.data = null;
            }
            else return;
        }

        private void ViewBIN_CheckedChanged(object sender, EventArgs e)
        {
            if (ViewBIN.Checked == true)
            {
                PGM.keyPgm.ActivePgmKey(4);
                PGM.outType = 4;
                PGM.data = null;
            }
            else return;

            if(outResult.Text != null || outResult.Text != "")
            {
                outResult.Text = PGM.resPgm.C10to2(outResult.Text);
            }
        }

        public void PressNum(string data)    // 입력 값
        {
            outResult.Text = PGM.data;   // 스탠다스 수식 결과에 누른 버튼을 출력
        }

        public void AddSub(string data)
        {
            // 양수, 음수 전환
            PGM.data = (-(double.Parse(PGM.data))).ToString();
            outResult.Text = PGM.data;
        }

        public void Clear()
        {
            outExp.Text = "";
            outResult.Text = "0";
            Console.WriteLine("Clear : 초기화 되었습니다.");
        }
        public void ClearCE()
        {
            PGM.data = null;
            outResult.Text = "0";
        }
        public void ClearData()
        {
            PGM.data = null;
            PGM.calTypeA = 0;
            PGM.calTypeB = 0;
            PGM.operand = 0;
            PGM.answer = 0;
        }

        public void DataDelete()
        {
            PGM.data = PGM.data.Remove(PGM.data.Length - 1);

            if (PGM.data == "")   // Null Exception
            {
                PGM.data = null;
                outResult.Text = "0";
            }
            else outResult.Text = PGM.data;
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
            outResult.Text = PGM.operand.ToString();
        }

        public void PressOperatorFirst(string data, int calTypeA)
        {
            PGM.operand = double.Parse(data);
            PGM.calTypeA = calTypeA;

            outExp.Text = data;
            Exp(calTypeA);
        }

        public void PressOperator(string data, double operand, int calTypeB)
        {
            switch (PGM.calTypeA)
            {
                case 1: // 덧셈
                    PGM.operand += double.Parse(data);
                    break;
                case 2: // 뺄셈
                    PGM.operand -= double.Parse(data);
                    break;
                case 3: // 곱셈
                    PGM.operand *= double.Parse(data);
                    break;
                case 4: // 나눗셈
                    PGM.operand /= double.Parse(data);
                    break;
            }

            outExp.Text += data;
            Exp(calTypeB);

            PGM.calTypeA = calTypeB;
            PGM.calTypeB = 0;
        }

        public void ExceNullOperand() 
        {
            // 연산자는 있으나, 피연산자가 없을 경우, 입력 값에 피연산자를 넣어 오류를 방지합니다.
            PGM.data = PGM.operand.ToString();
        }

        public void PressResult(string data, int calTypeA)
        {
            switch (PGM.calTypeA)
            {
                case 1: // 덧셈
                    PGM.operand += double.Parse(PGM.data);
                    break;
                case 2: // 뺄셈
                    PGM.operand -= double.Parse(PGM.data);
                    break;
                case 3: // 곱셈
                    PGM.operand *= double.Parse(PGM.data);
                    break;
                case 4: // 나눗셈
                    PGM.operand /= double.Parse(PGM.data);
                    break;
            }

            outExp.Text += PGM.data + " = ";
            outResult.Text = PGM.operand.ToString();
            PGM.data = PGM.operand.ToString();
        }

        public void SaveOriginalData()
        {
            if (PGM.data != null)
            {
                switch (PGM.outType)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                }
            }
            else { return; }
        }

        public string C10to2(string data) // 10진수 -> 2진수
        {
            string result = Convert.ToString(int.Parse(data), 2);
            return result;
        }

        public string C2to10(string data) // 10진수 -> 2진수
        {
            int result = Convert.ToInt32(data, 2);
            return result.ToString();
        }

    }
}
