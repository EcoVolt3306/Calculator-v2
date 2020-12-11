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
        KeypadProgrammer qw = new KeypadProgrammer();

        public ResultStandard()
        {
            InitializeComponent();
        }

        private void outExp_Click(object sender, EventArgs e)
        {

        }
        string num = null;
        
        public string addd(string num)
        {
            outResult.Text = num;
            Console.WriteLine(outResult.Text);


            qw.qwe();

            return outResult.Text;

        }

        private void outResult_Click(object sender, EventArgs e)
        {
            Console.WriteLine(outResult.Text);
            //outResult.Text = num;

        }
    }
}
