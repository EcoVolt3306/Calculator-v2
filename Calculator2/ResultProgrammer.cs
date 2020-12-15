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
    public partial class ResultProgrammer : UserControl
    {
        public ResultProgrammer()
        {
            InitializeComponent();
        }

        private void ViewHEX_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ViewDEC_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void ViewOCT_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ViewBIN_CheckedChanged(object sender, EventArgs e)
        {

        }

        public void PressNum(string data)    // 입력 값
        {
            outResult.Text = PGM.data;   // 스탠다스 수식 결과에 누른 버튼을 출력
        }
    }
}
