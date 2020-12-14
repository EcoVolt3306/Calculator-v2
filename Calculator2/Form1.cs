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

    public partial class Frame : Form
    {
        
        public Frame()
        {
            InitializeComponent();

            // 최초 스탠다드 초기화
            this.AreaResult.Controls.Add(STN.resStn);
            this.AreaKeypad.Controls.Add(STN.keyStn);



            for (int i = 0; i < 5; i++)
            {
                Label HisExp = new Label();
                HisExp.Font = new System.Drawing.Font("넥슨Lv2고딕", 9F);
                HisExp.Location = new System.Drawing.Point(0, 11 + (70 * i));
                HisExp.Name = "HisExp";
                HisExp.Size = new System.Drawing.Size(247, 19);
                HisExp.TabIndex = 0;
                HisExp.Text = "0 x 0 x 0 = ";
                HisExp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                HistoryNow.Controls.Add(HisExp);


                Label HisRes = new Label();
                HisRes.Font = new System.Drawing.Font("넥슨Lv2고딕", 16F);
                HisRes.Location = new System.Drawing.Point(0, 30 + (70 * i));
                HisRes.Name = "HisRes";
                HisRes.Size = new System.Drawing.Size(247, 29);
                HisRes.TabIndex = 1;
                HisRes.Text = "00000";
                HisRes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                HistoryNow.Controls.Add(HisRes);

                // Dictionary 인덱스 연결
                HIS.dicExp.Add(i, HisExp);
                HIS.dicRes.Add(i, HisRes);
            }



            HIS.dicExp[0].Text = "asdsd";

        }

        private void MenuStn_Click(object sender, EventArgs e)  // 메뉴 : 스탠다드
        {
            // 결과 영역
            if (this.AreaResult.Controls.Count > 0) this.AreaResult.Controls.Clear();   // 패널 초기화
            this.AreaResult.Controls.Add(STN.resStn);

            // 키패드 영역
            if (this.AreaKeypad.Controls.Count > 0) this.AreaKeypad.Controls.Clear();   // 패널 초기화
            this.AreaKeypad.Controls.Add(STN.keyStn);
        }

        private void MenuPgm_Click(object sender, EventArgs e)   // 메뉴 : 프로그래머
        {
            // 결과 영역
            if (this.AreaResult.Controls.Count > 0) this.AreaResult.Controls.Clear();   // 패널 초기화
            this.AreaResult.Controls.Add(PGM.resPgm);

            // 키패드 영역
            if (this.AreaKeypad.Controls.Count > 0) this.AreaKeypad.Controls.Clear();   // 패널 초기화
            this.AreaKeypad.Controls.Add(PGM.keyPgm);
        }

    }
}
