using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace Calculator2
{
    
    public static class DB
    {
        public static double[] op1 = new double[HIS.loopMemory];
        public static double[] op2 = new double[HIS.loopMemory];
        public static double[] op3 = new double[HIS.loopMemory];
        public static int[] ot1 = new int[HIS.loopMemory];
        public static int[] ot2 = new int[HIS.loopMemory];
        public static double[] result = new double[HIS.loopMemory];
        public static string[] date = new string[HIS.loopMemory];

        public static string[] strExp = new string[20];
        public static int cntDB = 0;

        public static void ExpRead()
        {
            for (int i = 0; i < HIS.loopMemory; i++)
            {
                if (DB.op1[i] == 0) return;

                strExp[i] += DB.op1[i].ToString();   // a
                switch (DB.ot1[i])    // a + 
                {
                    case 0: return;
                    case 1:
                        strExp[i] += " + ";
                        break;
                    case 2:
                        strExp[i] += " - ";
                        break;
                    case 3:
                        strExp[i] += " × ";
                        break;
                    case 4:
                        strExp[i] += " ÷ ";
                        break;
                }
                strExp[i] += DB.op2[i].ToString();   // a + b
                switch (DB.ot2[i])    // a + b x
                {
                    case 0: break;
                    case 1:
                        strExp[i] += " + ";
                        break;
                    case 2:
                        strExp[i] += " - ";
                        break;
                    case 3:
                        strExp[i] += " × ";
                        break;
                    case 4:
                        strExp[i] += " ÷ ";
                        break;
                }
                if (DB.op3[i] != 0) strExp[i] += DB.op3[i].ToString(); // a + b x c

                strExp[i] += " = ";    // a + b x c = 

                HIS.dicMemExp[i].Text = strExp[i];
                HIS.dicMemRes[i].Text = DB.result[i].ToString();
                //return strExp;
            }
        }

        public static void ClearlistNow()
        {
            for (int i = 0; i < HIS.loopNow; i++)
            {
                HIS.dicExp[i].Text = null;
                HIS.dicRes[i].Text = null;
            }
            return;
        }

        public static void ClearlistMem()
        {
            for (int i = 0; i < HIS.loopMemory; i++)
            {
                HIS.dicMemExp[i].Text = null;
                HIS.dicMemRes[i].Text = null;
            }
            return;
        }

    }
}
