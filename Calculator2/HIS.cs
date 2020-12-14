using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator2
{
    class HIS
    {
        

        public static string[,] historyValue = new string[20, 2];    // 2차원 배열 = 계산 기록
        public static int cntHis = 0;

        // 딕셔너리
        public static Dictionary<int, Label> dicExp = new Dictionary<int, Label>();
        public static Dictionary<int, Label> dicRes = new Dictionary<int, Label>();


    }
}
