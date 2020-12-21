using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator2
{
    class COM
    {
        /* 피연산자 카운트(cntOperand)
         Data를 가진 상태에서 Operator Key를 누르면 1씩 증가
         해당 값이 2가 되면, Operator Key 사용 불가
         해당 값이 3이 되면, Result Key 사용 불가
         ClearAll을 통해 0으로 초기화 가능 */
        public static int cntOperand = 0;
        public static string data = null;

        public static double op1, op2, op3 = 0;
        public static int ot1, ot2 = 0;

        public static double result = 0;

        // Standard 활성화 구분
        // 초기값 true 선언, STN - PGM 버튼으로 변경 (Form1.cs 참조)
        public static bool stn = false;

        // 연산자를 눌렀을 때
        public static void PressOperator(string data, int operatorNum)
        {
            string exp = null, res = null;

            switch (cntOperand)
            {
                case 0:
                    if (data == null) return;   // Null 처리

                    op1 = double.Parse(data);
                    ot1 = operatorNum;

                    break;
                case 1:
                    if (data == null) data = COM.op1.ToString();    // Null 처리

                    op2 = double.Parse(data);
                    ot2 = operatorNum;
                    break;
                case 2:
                    if (data == null) data = COM.op2.ToString();    // Null 처리

                    op3 = double.Parse(data);
                    break;
            }

            // STN 활성화 여부
            if(COM.stn == true)
            {
                // 처리된 데이터 출력
                switch (cntOperand)
                {
                    case 0:
                        exp = op1.ToString() + OutOperator(ot1);
                        break;
                    case 1:
                        exp = op1.ToString() + OutOperator(ot1);
                        exp += op2.ToString() + OutOperator(ot2);
                        break;
                    case 2:
                        return;
                        break;
                }
                STN.resStn.SetOutExp(exp);

            }
            

            COM.cntOperand++;
        }

        // Func
        public static void InData(string data)
        {   // 버튼의 데이터를 문자열 변수에 저장
            COM.data += data;
        }

        public static void ConvertTypePGM(string data, int outType)
        {   // PGM의 자료일 경우 Type에 따라 DEC(10) 형태로 변환
            int dec;    // 10진수로 받을 변수

            switch (outType)
            {
                case 0:
                    break;
                case 1:
                    dec = Convert.ToInt32(data, 16);
                    break;
                case 2:
                    dec = int.Parse(data);
                    break;
                case 3:
                    dec = Convert.ToInt32(data, 8);
                    break;
                case 4:
                    dec = Convert.ToInt32(data, 2);
                    break;
            }
        }

        public static string OutResult()
        {   // Exp 출력
            string exp = null;  // 문자열로 차곡차곡 받을 변수

            switch (cntOperand)
            {
                case 0:
                    break;
                case 1:
                    exp = op1.ToString() + OutOperator(COM.ot1);
                    exp += op2.ToString() + " = ";
                    break;
                case 2:
                    exp = op1.ToString() + OutOperator(COM.ot1);
                    exp += op2.ToString() + OutOperator(COM.ot2);
                    exp += op3.ToString() + " = ";
                    break;
            }

            //if (COM.stn == true)    // 스탠다드 출력
            //    STN.resStn.SetOutExp(exp);


            return exp;
        }

        public static string OutOperator(int operatorType)
        {   // ot1, ot2를 활용하여 Exp에 출력할 연산자를 반환
            string text = null; // 연산자 기호 담을 변수

            switch (operatorType)
            {
                case 1:
                    text = "+";
                    break;
                case 2:
                    text = "-";
                    break;
                case 3:
                    text = "×";
                    break;
                case 4:
                    text = "÷";
                    break;
            }
            return text;
        }

    }
}
