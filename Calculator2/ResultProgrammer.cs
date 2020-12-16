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
            PGM.dataDEC = 0;
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

        public void Exp(string data, int type)
        {
            outExp.Text = data; // 타입 관계없이 Exp 수식에 출력

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

            outResult.Text = data;
        }

        public void PressOperatorFirst(string data, int calTypeA, int outType)
        {   // 타입 관계없이 10진수(DEC)로 변환 및 저장
            switch (outType)
            {
                case 1:
                    PGM.dataDEC = Convert.ToInt32(data, 16);
                    break;
                case 2:
                    PGM.dataDEC = double.Parse(data);
                    break;
                case 3:
                    PGM.dataDEC = Convert.ToInt32(data, 8);
                    break;
                case 4:
                    PGM.dataDEC = Convert.ToInt32(data, 2);
                    break;
            }

            PGM.calTypeA = calTypeA;
            Exp(data, calTypeA);
        }

        public void PressOperator(string data, int calTypeB, int outType)
        {
            double tmpData = 0;
            switch (outType)    // 기존 데이터를 10진수로 변환
            {
                case 1:
                    tmpData = Convert.ToInt32(data, 16);
                    break;
                case 2:
                    tmpData = double.Parse(data);
                    break;
                case 3:
                    tmpData = Convert.ToInt32(data, 8);
                    break;
                case 4:
                    tmpData = Convert.ToInt32(data, 2);
                    break;
            }

            switch (PGM.calTypeA)   // 10진수로 변환된 데이터를 기존 데이터와 연산
            {
                case 1: // 덧셈
                    PGM.dataDEC += tmpData;
                    break;
                case 2: // 뺄셈
                    PGM.dataDEC -= tmpData;
                    break;
                case 3: // 곱셈
                    PGM.dataDEC *= tmpData;
                    break;
                case 4: // 나눗셈
                    PGM.dataDEC /= tmpData;
                    break;
            }

            switch (outType)    // 연산된 10진수 데이터를 타입에 맞게 반환
            {
                case 1:
                    PGM.dataHEX = Convert.ToString((int)PGM.dataDEC, 16);
                    break;
                case 2:
                    //PGM.dataDEC = PGM.dataDEC;
                    break;
                case 3:
                    PGM.dataOCT = Convert.ToString((int)PGM.dataDEC, 8);
                    break;
                case 4:
                    PGM.dataBIN = Convert.ToString((int)PGM.dataDEC, 2);
                    break;
            }

            Exp(PGM.data, calTypeB);

            PGM.calTypeA = calTypeB; PGM.calTypeB = 0;  // 연산자 2 초기화
        }

        public void ExceNullOperand() 
        {
            // 연산자는 있으나, 피연산자가 없을 경우, 입력 값에 피연산자를 넣어 오류를 방지합니다.

            switch (PGM.outType)
            {
                case 1:
                    PGM.data = Convert.ToString((int)PGM.dataDEC, 16);
                    break;
                case 2:
                    PGM.data = PGM.dataDEC.ToString();
                    break;
                case 3:
                    PGM.data = Convert.ToString((int)PGM.dataDEC, 8);
                    break;
                case 4:
                    PGM.data = Convert.ToString((int)PGM.dataDEC, 2);
                    break;
            }
        }

        public void PressResult(string data, int calTypeA, int outType)
        {

            double tmpData = 0;
            switch (outType)    // 기존 데이터를 10진수로 변환
            {
                case 1:
                    tmpData = Convert.ToInt32(data, 16);
                    break;
                case 2:
                    tmpData = double.Parse(data);
                    break;
                case 3:
                    tmpData = Convert.ToInt32(data, 8);
                    break;
                case 4:
                    tmpData = Convert.ToInt32(data, 2);
                    break;
            }

            switch (PGM.calTypeA)   // 10진수로 변환된 데이터를 기존 데이터와 연산
            {
                case 1: // 덧셈
                    PGM.dataDEC += tmpData;
                    break;
                case 2: // 뺄셈
                    PGM.dataDEC -= tmpData;
                    break;
                case 3: // 곱셈
                    PGM.dataDEC *= tmpData;
                    break;
                case 4: // 나눗셈
                    PGM.dataDEC /= tmpData;
                    break;
            }

            outExp.Text += PGM.data + " = ";

            switch (outType)    // 연산된 10진수 데이터를 타입에 맞게 반환
            {
                case 1:
                    PGM.dataHEX = Convert.ToString((int)PGM.dataDEC, 16);
                    outResult.Text = PGM.dataHEX.ToString();
                    PGM.data = PGM.dataHEX.ToString();
                    break;
                case 2:
                    //PGM.dataDEC = PGM.dataDEC;
                    outResult.Text = PGM.dataDEC.ToString();
                    PGM.data = PGM.dataDEC.ToString();
                    break;
                case 3:
                    PGM.dataOCT = Convert.ToString((int)PGM.dataDEC, 8);
                    outResult.Text = PGM.dataOCT.ToString();
                    PGM.data = PGM.dataOCT.ToString();
                    break;
                case 4:
                    PGM.dataBIN = Convert.ToString((int)PGM.dataDEC, 2);
                    outResult.Text = PGM.dataBIN.ToString();
                    PGM.data = PGM.dataBIN.ToString();
                    break;
            }

        }



        public string C10to2(string data) // 10진수 -> 2진수
        {
            string result = Convert.ToString(int.Parse(data), 2);
            return result;
        }

        public string C2to10(string data) // 2진수 -> 10진수
        {
            int result = Convert.ToInt32(data, 2);
            return result.ToString();
        }

    }
}
