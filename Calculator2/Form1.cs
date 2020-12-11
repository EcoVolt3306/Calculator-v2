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
            ResultStandard resStn = new ResultStandard();
            KeypadStandard keyStn = new KeypadStandard();
            this.AreaResult.Controls.Add(resStn);
            this.AreaKeypad.Controls.Add(keyStn);
        }

        private void MenuStn_Click(object sender, EventArgs e)  // 메뉴 : 스탠다드
        {
            // 결과 영역
            if (this.AreaResult.Controls.Count > 0) this.AreaResult.Controls.Clear();   // 패널 초기화
            ResultStandard resStn = new ResultStandard();
            this.AreaResult.Controls.Add(resStn);

            // 키패드 영역
            if (this.AreaKeypad.Controls.Count > 0) this.AreaKeypad.Controls.Clear();   // 패널 초기화
            KeypadStandard keyStn = new KeypadStandard();
            this.AreaKeypad.Controls.Add(keyStn);
        }

        private void MenuPgm_Click(object sender, EventArgs e)   // 메뉴 : 프로그래머
        {
            // 결과 영역
            if (this.AreaResult.Controls.Count > 0) this.AreaResult.Controls.Clear();   // 패널 초기화
            ResultProgrammer resPgm = new ResultProgrammer();
            this.AreaResult.Controls.Add(resPgm);

            // 키패드 영역
            if (this.AreaKeypad.Controls.Count > 0) this.AreaKeypad.Controls.Clear();   // 패널 초기화
            KeypadProgrammer keyPgm = new KeypadProgrammer();
            this.AreaKeypad.Controls.Add(keyPgm);

        }

        private void AreaResult_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frame_Load(object sender, EventArgs e)
        {

        }
    }
}
