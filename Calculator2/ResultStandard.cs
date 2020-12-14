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

    public partial class ResultStandard : UserControl
    {

        public ResultStandard()
        {
            InitializeComponent();
        }

        public void PressNum(string num)
        {
            outResult.Text = num;   // 스탠다스 수식 결과에 누른 버튼을 출력
        }
    }
}
