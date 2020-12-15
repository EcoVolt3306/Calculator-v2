using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator2
{
    class PGM
    {
        public static ResultProgrammer resPgm = new ResultProgrammer();
        public static KeypadProgrammer keyPgm = new KeypadProgrammer();

        // 키패드
        public static KeyHEX keyHEX = new KeyHEX();
        public static KeyDEC keyDEC = new KeyDEC();
        public static KeyOCT keyOCT = new KeyOCT();
        public static KeyBIN keyBIN = new KeyBIN();

        public static string data = null;     // 입력 값
        public static int calTypeA, calTypeB, answer, cntUse = 0;   // 연산기호 종류
        public static double operand = 0;     // 피연산자

    }
}
