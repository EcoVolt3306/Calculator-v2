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
        KeypadStandard qw = new KeypadStandard();

        public ResultStandard()
        {
            InitializeComponent();
        }


        private void outExp_Click(object sender, EventArgs e)
        {
            KeypadStandard.num = "qweqwe";
            outExp.Text = KeypadStandard.num;
        }


        private void outResult_Click(object sender, EventArgs e)
        {

        }

        
    }
}
