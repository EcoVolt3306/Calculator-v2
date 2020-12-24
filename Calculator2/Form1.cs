using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator2
{

    public partial class Frame : Form
    {
        
        public Frame()
        {
            InitializeComponent();

            // 최초 스탠다드 초기화
            this.AreaResult.Controls.Add(STN.resStn);
            this.AreaKeypad.Controls.Add(STN.keyStn);

            PGM.keyPgm.ActivePgmKey(2);
            PGM.outType = 2;
            PGM.lastOutType = 2;

            for (int i = 0; i < HIS.loopNow; i++)
            {
                Label HisExp = new Label();
                HisExp.Font = new System.Drawing.Font("넥슨Lv2고딕", 9F);
                HisExp.Location = new System.Drawing.Point(0, 11 + (70 * i));
                HisExp.Name = "HisExp";
                HisExp.Size = new System.Drawing.Size(247, 19);
                HisExp.TabIndex = 0;
                HisExp.Text = "";
                HisExp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                HistoryNow.Controls.Add(HisExp);
                Console.WriteLine(HisExp.Name.ToString());

                Label HisRes = new Label();
                HisRes.Font = new System.Drawing.Font("넥슨Lv2고딕", 16F);
                HisRes.Location = new System.Drawing.Point(0, 30 + (70 * i));
                HisRes.Name = "HisRes";
                HisRes.Size = new System.Drawing.Size(247, 29);
                HisRes.TabIndex = 1;
                HisRes.Text = "";
                HisRes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                HistoryNow.Controls.Add(HisRes);

                // Dictionary 인덱스 연결
                HIS.dicExp.Add(i, HisExp);
                HIS.dicRes.Add(i, HisRes);
            }
            for (int i = 0; i < HIS.loopMemory; i++)
            {
                Label HisMemExp = new Label();
                Label HisMemRes = new Label();

                HisMemExp.Font = new System.Drawing.Font("넥슨Lv2고딕", 9F);
                HisMemExp.Location = new System.Drawing.Point(0, 11 + (70 * i));
                HisMemExp.Name = "HisMemExp";
                HisMemExp.Size = new System.Drawing.Size(232, 19);
                HisMemExp.TabIndex = 0;
                HisMemExp.Text = "";
                HisMemExp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                HisMemExp.Click += new System.EventHandler(Data_Click);
                HistoryMemory.Controls.Add(HisMemExp);


                
                HisMemRes.Font = new System.Drawing.Font("넥슨Lv2고딕", 16F);
                HisMemRes.Location = new System.Drawing.Point(0, 30 + (70 * i));
                HisMemRes.Name = "HisMemRes";
                HisMemRes.Size = new System.Drawing.Size(232, 29);
                HisMemRes.TabIndex = 1;
                HisMemRes.Text = "";
                HisMemRes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                HisMemRes.Click += new System.EventHandler(Data_Click);
                HistoryMemory.Controls.Add(HisMemRes);

                // Dictionary 인덱스 연결
                HIS.dicMemExp.Add(i, HisMemExp);
                HIS.dicMemRes.Add(i, HisMemRes);
                Console.WriteLine("i는용" + i);
                void Data_Click(object sender, EventArgs e)
                {
                    //MessageBox.Show(HisMemExp.Text);
                    
                    if (COM.pgm == false)
                    {
                        STN.resStn.SetExpLoad(HisMemExp.Text);
                        STN.resStn.SetResLoad(HisMemRes.Text);
                    }
                    else
                    {
                        PGM.resPgm.SetExpLoad(HisMemExp.Text);
                        int data = int.Parse(HisMemRes.Text);
                        string dataPGM = null;

                        switch (PGM.outType)    // 기존 데이터를 10진수로 변환
                        {
                            case 1:
                                dataPGM = Convert.ToString(data, 16);
                                break;
                            case 2:
                                dataPGM = data.ToString();
                                break;
                            case 3:
                                dataPGM = Convert.ToString(data, 8);
                                break;
                            case 4:
                                dataPGM = Convert.ToString(data, 2);
                                break;
                        }

                        PGM.resPgm.SetResLoad(dataPGM);

                    }
                }
            }

            DB_SelectAll();
            CntDB();
            DB.ExpRead();

        }


        public static void DB_InsertData(double op1, double op2, double op3, int ot1, int ot2, double result)
        {
            // 1. DB 연결
            string connStr = "user id=DEV_ORA_TEST;password=DEV_ORA_TEST;" +
                "data source=(DESCRIPTION=(ADDRESS=" +
                "(PROTOCOL=tcp)(HOST=192.168.0.110)" +
                "(PORT=1521))(CONNECT_DATA=" +
                "(SID=orcl)))";

            OracleConnection conn = new OracleConnection(connStr);

            try
            {
                conn.Open();
                Console.WriteLine("DB Connection Successful!");
            }
            catch (OracleException ex)
            {
                Console.WriteLine("--- DB ERROR!!! ---");
                Console.WriteLine(ex.ToString());
            }

            // 2. DB 명령어 실행
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "insert into TB_TEST_SEUNG values(" +
                op1 + "," + op2 + "," + op3 + "," + ot1 + "," + ot2 + "," + result +
                ", sysdate)";
            cmd.ExecuteNonQuery();
            Console.WriteLine("인서트 햇어용~");

            // 3. DB 종료
            conn.Close();
            conn.Dispose();
        }

        // 조회하기
        public static void DB_SelectAll()
        {
            // 1. DB 연결
            string connStr = "user id=DEV_ORA_TEST;password=DEV_ORA_TEST;" +
                "data source=(DESCRIPTION=(ADDRESS=" +
                "(PROTOCOL=tcp)(HOST=192.168.0.110)" +
                "(PORT=1521))(CONNECT_DATA=" +
                "(SID=orcl)))";

            OracleConnection conn = new OracleConnection(connStr);

            try
            {
                conn.Open();
                Console.WriteLine("DB Connection Successful!");
            }
            catch (OracleException ex)
            {
                Console.WriteLine("--- DB ERROR!!! ---");
                Console.WriteLine(ex.ToString());
            }

            // 2. DB 명령어 실행
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "SELECT * FROM TB_TEST_SEUNG ORDER BY SAVE_TIME DESC";
            //cmd.ExecuteReader();

            OracleDataReader reader = cmd.ExecuteReader();



            Console.WriteLine("일단 20개만 불러볼게용~");
            for (int i=0; reader.Read(); i++)
            {
                if (i >= HIS.loopMemory) break;
                DB.op1[i] = reader.GetDouble(0);
                DB.op2[i] = reader.GetDouble(1);
                DB.op3[i] = reader.GetDouble(2);
                DB.ot1[i] = reader.GetInt32(3);
                DB.ot2[i] = reader.GetInt32(4);
                DB.result[i] = reader.GetDouble(5);
                DB.date[i] = reader.GetDateTime(6).ToString();
                

                Console.WriteLine(DB.op1[i] + "\t" + DB.op2[i] + "\t" + DB.op3[i]
                    + "\t" + DB.ot1[i] + "\t" + DB.ot2[i] + "\t" + DB.result[i] + "\t" + DB.date[i]);
            }

            Console.WriteLine("셀렉트 햇어용~");
            // 3. DB 종료
            reader.Close();
            conn.Close();
            conn.Dispose();

        }

        public static void DB_ClearAll()
        {
            // 1. DB 연결
            string connStr = "user id=DEV_ORA_TEST;password=DEV_ORA_TEST;" +
                "data source=(DESCRIPTION=(ADDRESS=" +
                "(PROTOCOL=tcp)(HOST=192.168.0.110)" +
                "(PORT=1521))(CONNECT_DATA=" +
                "(SID=orcl)))";

            OracleConnection conn = new OracleConnection(connStr);

            try
            {
                conn.Open();
                Console.WriteLine("DB Connection Successful!");
            }
            catch (OracleException ex)
            {
                Console.WriteLine("--- DB ERROR!!! ---");
                Console.WriteLine(ex.ToString());
            }

            // 2. DB 명령어 실행
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "DELETE FROM TB_TEST_SEUNG";
            cmd.ExecuteNonQuery();
            Console.WriteLine("딜리트 햇어용~");

            // 3. DB 종료
            conn.Close();
            conn.Dispose();
        }
       

        public static void CntDB()
        {
            // 1. DB 연결
            string connStr = "user id=DEV_ORA_TEST;password=DEV_ORA_TEST;" +
                "data source=(DESCRIPTION=(ADDRESS=" +
                "(PROTOCOL=tcp)(HOST=192.168.0.110)" +
                "(PORT=1521))(CONNECT_DATA=" +
                "(SID=orcl)))";

            OracleConnection conn = new OracleConnection(connStr);

            try
            {
                conn.Open();
                Console.WriteLine("DB Connection Successful!");
            }
            catch (OracleException ex)
            {
                Console.WriteLine("--- DB ERROR!!! ---");
                Console.WriteLine(ex.ToString());
            }

            // 2. DB 명령어 실행
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "SELECT COUNT(*) FROM TB_TEST_SEUNG ORDER BY SAVE_TIME DESC";
            //cmd.ExecuteReader();

            OracleDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                DB.cntDB = reader.GetInt32(0);
            }
            Console.WriteLine("DB Count list : " + DB.cntDB);

            reader.Close();
            conn.Close();
            conn.Dispose();
        }


        private void MenuStn_Click(object sender, EventArgs e)  // 메뉴 : 스탠다드
        {
            PGM.resPgm.ClearAll();
            COM.ClearCOM();
            COM.pgm = false; // 스탠다드 활성화
            COM.cntOperand = 0;

            // 결과 영역
            if (this.AreaResult.Controls.Count > 0) this.AreaResult.Controls.Clear();   // 패널 초기화
            this.AreaResult.Controls.Add(STN.resStn);

            // 키패드 영역
            if (this.AreaKeypad.Controls.Count > 0) this.AreaKeypad.Controls.Clear();   // 패널 초기화
            this.AreaKeypad.Controls.Add(STN.keyStn);

        }

        private void MenuPgm_Click(object sender, EventArgs e)   // 메뉴 : 프로그래머
        {
            STN.resStn.ClearData();
            STN.resStn.ClearOut();

            COM.pgm = true;    // 스탠다드 비활성화
            COM.cntOperand = 0;

            // 결과 영역
            if (this.AreaResult.Controls.Count > 0) this.AreaResult.Controls.Clear();   // 패널 초기화
            this.AreaResult.Controls.Add(PGM.resPgm);

            // 키패드 영역
            if (this.AreaKeypad.Controls.Count > 0) this.AreaKeypad.Controls.Clear();   // 패널 초기화
            this.AreaKeypad.Controls.Add(PGM.keyPgm);
                // Keypad Default : DEC(10)

            
            
        }

        private void Button_DB_ClearAll_Click(object sender, EventArgs e)
        {
            DialogResult clearDB = MessageBox.Show("DB 내역들을 초기화 하시겠습니까?", "DB 초기화", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (clearDB == DialogResult.Yes)
            {
                DB_ClearAll();
                DB.cntDB = 0;
                DB_SelectAll();
                DB.ExpRead();
                DB.ClearlistNow();
                DB.ClearlistMem();
                MessageBox.Show("초기화 되었습니다.");
            }
            
        }
    }
}
