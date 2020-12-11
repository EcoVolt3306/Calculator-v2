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
    public class a1
    {
        public static string dd = null;
    }
    public partial class Frame : Form
    {
        ResultStandard resStn = new ResultStandard();
        KeypadStandard keyStn = new KeypadStandard();
        ResultProgrammer resPgm = new ResultProgrammer();
        KeypadProgrammer keyPgm = new KeypadProgrammer();

        public Frame()
        {
            InitializeComponent();

            // 최초 스탠다드 초기화
            this.AreaResult.Controls.Add(resStn);
            this.AreaKeypad.Controls.Add(keyStn);
        }

        private void MenuStn_Click(object sender, EventArgs e)  // 메뉴 : 스탠다드
        {
            // 결과 영역
            if (this.AreaResult.Controls.Count > 0) this.AreaResult.Controls.Clear();   // 패널 초기화
            this.AreaResult.Controls.Add(resStn);

            // 키패드 영역
            if (this.AreaKeypad.Controls.Count > 0) this.AreaKeypad.Controls.Clear();   // 패널 초기화
            this.AreaKeypad.Controls.Add(keyStn);
        }

        private void MenuPgm_Click(object sender, EventArgs e)   // 메뉴 : 프로그래머
        {
            // 결과 영역
            if (this.AreaResult.Controls.Count > 0) this.AreaResult.Controls.Clear();   // 패널 초기화
            this.AreaResult.Controls.Add(resPgm);

            // 키패드 영역
            if (this.AreaKeypad.Controls.Count > 0) this.AreaKeypad.Controls.Clear();   // 패널 초기화
            this.AreaKeypad.Controls.Add(keyPgm);
        }

    }
}
