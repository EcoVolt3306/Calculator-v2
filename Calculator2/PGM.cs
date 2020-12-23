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

        public static int calTypeA, calTypeB, answer, cntUse, outType, lastOutType = 0;   // 연산기호 종류
        public static double dataDEC = 0;
        public static string data, dataHEX, dataOCT, dataBIN = null;

        public static string hisExp, hisRes = null; // DEC 기록용


    }
}
