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
        public static double result = 0;

        public static double op1, op2, op3 = 0;
        public static int ot1, ot2 = 0;

        // Standard 활성화 구분
        // 초기값 true 선언, STN - PGM 버튼으로 변경 (Form1.cs 참조)
        public static bool pgm = false;


        public static void ClearCOM()
        {
            cntOperand = 0;
            data = null;
            op1 = 0;
            op2 = 0;
            op3 = 0;
            ot1 = 0;
            ot2 = 0;
        }
        
    }
}
