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
                ClearChange();
                PGM.outType = 1;

                if (outResult.Text != "0") outResult.Text = PGM.resPgm.ConvertResult(PGM.resPgm.outResult.Text, PGM.outType, PGM.lastOutType);

                PGM.keyPgm.ActivePgmKey(1);
                PGM.data = null;
            }
            else if (ViewHEX.Checked == false) PGM.lastOutType = 1;
            else return;
        }

        private void ViewDEC_CheckedChanged(object sender, EventArgs e)
        {
            if (ViewDEC.Checked == true)
            {
                ClearChange();
                PGM.outType = 2;

                if (outResult.Text != "0") outResult.Text = PGM.resPgm.ConvertResult(PGM.resPgm.outResult.Text, PGM.outType, PGM.lastOutType);

                PGM.keyPgm.ActivePgmKey(2);
                PGM.data = null;
            }
            else if (ViewDEC.Checked == false) PGM.lastOutType = 2;
            else return;
        }

        private void ViewOCT_CheckedChanged(object sender, EventArgs e)
        {
            if (ViewOCT.Checked == true)
            {
                ClearChange();
                PGM.outType = 3;

                if (outResult.Text != "0") outResult.Text = PGM.resPgm.ConvertResult(PGM.resPgm.outResult.Text, PGM.outType, PGM.lastOutType);

                PGM.keyPgm.ActivePgmKey(3);
                PGM.data = null;
            }
            else if (ViewOCT.Checked == false) PGM.lastOutType = 3;
            else return;
        }

        private void ViewBIN_CheckedChanged(object sender, EventArgs e)
        {
            if (ViewBIN.Checked == true)
            {
                ClearChange();
                PGM.outType = 4;

                if (outResult.Text != "0") outResult.Text = PGM.resPgm.ConvertResult(PGM.resPgm.outResult.Text, PGM.outType, PGM.lastOutType);

                PGM.keyPgm.ActivePgmKey(4);
                PGM.data = null;
            }
            else if (ViewBIN.Checked == false) PGM.lastOutType = 4;
            else return;
        }

        public void PressNum(string data)    // 입력 값
        {
            outResult.Text = PGM.data;   // 스탠다스 수식 결과에 누른 버튼을 출력
        }

        public void ClearAll()
        {
            ClearOut();

            PGM.calTypeA = 0;
            PGM.calTypeB = 0;
            PGM.answer = 0;
            PGM.cntUse = 0;
            //PGM.outType = 0;
            PGM.lastOutType = PGM.outType;

            PGM.data = null;
            PGM.dataHEX = null;
            PGM.dataDEC = 0;
            PGM.dataOCT = null;
            PGM.dataBIN = null;
        }

        public void ClearOut()
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


        public void ClearChange()
        {
            PGM.calTypeA = 0;
            PGM.calTypeB = 0;
            PGM.answer = 0;
            //PGM.cntUse = 0;
            //PGM.outType = 0;

            PGM.dataHEX = null;
            PGM.dataDEC = 0;
            PGM.dataOCT = null;
            PGM.dataBIN = null;

            outExp.Text = null;
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

        public void PressResult(string data, int calTypeA, int outType)
        {
            if(data == null || data == "0") { return; }

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

            PGM.calTypeA = 0;
            PGM.calTypeB = 0;
            PGM.answer = 0;
            PGM.data = null;
            //PGM.cntUse = 0;
            //PGM.outType = 0;

        }

        public string ConvertResult(string text, int outType, int lastOutType)
        {   // 각 타입의 결과값을 선택한 형태로 변환하여 재출력
            int dec = 0;
            string result = null;

            // text = outResult.Text
            switch (lastOutType)    // 기존 데이터를 10진수로 변환
            {
                case 1:
                    dec = Convert.ToInt32(text, 16);
                    break;
                case 2:
                    dec = int.Parse(text);
                    break;
                case 3:
                    dec = Convert.ToInt32(text, 8);
                    break;
                case 4:
                    dec = Convert.ToInt32(text, 2);
                    break;
            }

            switch (outType)
            {
                case 1:
                    result = Convert.ToString(dec, 16);
                    break;
                case 2:
                    result = dec.ToString();
                    break;
                case 3:
                    result = Convert.ToString(dec, 8);
                    break;
                case 4:
                    result = Convert.ToString(dec, 2);
                    break;
            }

            return result;
        }

        public void AddSub(string text, int outType)
        {
            int neg = 0;
            string result = null;

            // 양수, 음수 전환

            // text = outResult.Text
            switch (outType)    // 기존 데이터를 10진수로 변환
            {
                case 1:
                    neg = Convert.ToInt32(text, 16);
                    break;
                case 2:
                    neg = int.Parse(text);
                    break;
                case 3:
                    neg = Convert.ToInt32(text, 8);
                    break;
                case 4:
                    neg = Convert.ToInt32(text, 2);
                    break;
            }

            neg = -(neg);
            Console.WriteLine("neg : " + neg);

            switch (outType)
            {
                case 1:
                    result = Convert.ToString(neg, 16);
                    break;
                case 2:
                    result = neg.ToString();
                    break;
                case 3:
                    result = Convert.ToString(neg, 8);
                    break;
                case 4:
                    result = Convert.ToString(neg, 2);
                    break;
            }

            outResult.Text = result;
        }

        // Histroy for PGM

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
            for (int i = KeypadStandard.cntUse; i > 0; i--)  // Array 초과 Exception
            {
                if (i >= HIS.loopNow)
                {
                    i = HIS.loopNow - 1;
                }

                HIS.dicExp[i].Text = HIS.dicExp[i - 1].Text;
                HIS.dicRes[i].Text = HIS.dicRes[i - 1].Text;
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

        public void ExDataNull()
        {
            if (PGM.data == null)
                PGM.data = outResult.Text;
        }

        public string OutResult()
        {
            return outResult.Text;
        }


    }
}
