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
    public partial class KeyHEX : UserControl
    {
        public KeyHEX()
        {
            InitializeComponent();
        }

        private void PgmKey1_Click(object sender, EventArgs e)
        {
            PGM.data += "1";
            PGM.resPgm.PressNum(PGM.data);
        }

        private void PgmKey2_Click(object sender, EventArgs e)
        {
            PGM.data += "2";
            PGM.resPgm.PressNum(PGM.data);
        }

        private void PgmKey3_Click(object sender, EventArgs e)
        {
            PGM.data += "3";
            PGM.resPgm.PressNum(PGM.data);
        }

        private void PgmKey4_Click(object sender, EventArgs e)
        {
            PGM.data += "4";
            PGM.resPgm.PressNum(PGM.data);
        }

        private void PgmKey5_Click(object sender, EventArgs e)
        {
            PGM.data += "5";
            PGM.resPgm.PressNum(PGM.data);
        }

        private void PgmKey6_Click(object sender, EventArgs e)
        {
            PGM.data += "6";
            PGM.resPgm.PressNum(PGM.data);
        }

        private void PgmKey7_Click(object sender, EventArgs e)
        {
            PGM.data += "7";
            PGM.resPgm.PressNum(PGM.data);
        }

        private void PgmKey8_Click(object sender, EventArgs e)
        {
            PGM.data += "8";
            PGM.resPgm.PressNum(PGM.data);
        }

        private void PgmKey9_Click(object sender, EventArgs e)
        {
            PGM.data += "9";
            PGM.resPgm.PressNum(PGM.data);
        }

        private void PgmKey0_Click(object sender, EventArgs e)
        {
            PGM.data += "0";
            PGM.resPgm.PressNum(PGM.data);
        }

        private void PgmKeyDot_Click(object sender, EventArgs e)
        {

        }

        private void PgmKeyAddSub_Click(object sender, EventArgs e)
        {

        }

        private void PgmKeyCE_Click(object sender, EventArgs e)
        {

        }

        private void PgmKeyC_Click(object sender, EventArgs e)
        {

        }

        private void PgmKeyDelete_Click(object sender, EventArgs e)
        {

        }

        private void PgmKeyAdd_Click(object sender, EventArgs e)
        {

        }

        private void PgmKeySub_Click(object sender, EventArgs e)
        {

        }

        private void PgmKeyMul_Click(object sender, EventArgs e)
        {

        }

        private void PgmKeyDiv_Click(object sender, EventArgs e)
        {

        }

        private void PgmKeyResult_Click(object sender, EventArgs e)
        {

        }

        private void HexA_Click(object sender, EventArgs e)
        {
            PGM.data += "A";
            PGM.resPgm.PressNum(PGM.data);
        }

        private void HexB_Click(object sender, EventArgs e)
        {
            PGM.data += "B";
            PGM.resPgm.PressNum(PGM.data);
        }

        private void HexC_Click(object sender, EventArgs e)
        {
            PGM.data += "C";
            PGM.resPgm.PressNum(PGM.data);
        }

        private void HexD_Click(object sender, EventArgs e)
        {
            PGM.data += "D";
            PGM.resPgm.PressNum(PGM.data);
        }

        private void HexE_Click(object sender, EventArgs e)
        {
            PGM.data += "E";
            PGM.resPgm.PressNum(PGM.data);
        }

        private void HexF_Click(object sender, EventArgs e)
        {
            PGM.data += "F";
            PGM.resPgm.PressNum(PGM.data);
        }
    }
}
