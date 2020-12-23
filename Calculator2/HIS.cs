using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator2
{
    class HIS
    {
        // 딕셔너리
        public static Dictionary<int, Label> dicExp = new Dictionary<int, Label>();
        public static Dictionary<int, Label> dicRes = new Dictionary<int, Label>();

        public static Dictionary<int, Label> dicMemExp = new Dictionary<int, Label>();
        public static Dictionary<int, Label> dicMemRes = new Dictionary<int, Label>();

        //public static string[,] historyValue = new string[20, 2];    // 2차원 배열 = 계산 기록
        //public static int cntHis = 0;

        public static int loopNow = 5;              // 현재 내역 - 최대값
        public static int loopMemory = 20;      // 저장된 내역 - 최대값


      

    }
}
