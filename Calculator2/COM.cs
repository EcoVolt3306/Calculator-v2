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

        // 연산자를 눌렀을 때
        public static void PressOperator(string data, int otType)
        {
            switch (cntOperand)
            {
                case 0:
                    op1 = double.Parse(data);
                    break;
                case 1:
                    op2 = double.Parse(data);
                    break;
                case 2:
                    op3 = double.Parse(data);
                    break;
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
            int dec;

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

        public static string outExp()
        {   // Exp 출력
            string exp = null;
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
            return exp;
        }

        public static string OutOperator(int operatorType)
        {   // ot1, ot2를 활용하여 Exp에 출력할 연산자를 반환
            string text = null;
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
