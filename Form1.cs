using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControl
{
    public partial class Form1 : Form
    {

        int sum, price = 115, add1, add2;
        int num, amt;

        public Form1()
        {
            InitializeComponent();
        }




        private void chkS_CheckedChanged(object sender, EventArgs e)
        {
            GetAmt();
        }

        private void chkD_CheckedChanged(object sender, EventArgs e)
        {
            GetAmt();
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            GetAmt();
        }

        private void rdbM1_CheckedChanged(object sender, EventArgs e)
        {
            price = 115;
            chkS.Checked = false;
            chkD.Checked = false;
            txtNum.Text = "1";
            GetAmt();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAmt();
        }



        private void rdbM2_CheckedChanged(object sender, EventArgs e)
        {
            price = 95;
            chkS.Checked = false;
            chkD.Checked = false;
            txtNum.Text = "1";
            GetAmt();
        }

        private void rdbS1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbS1.Checked)
            {
                chkS.Enabled = true;
            }
            else
            {
                chkS.Enabled = false;
                chkS.Checked = false;
            }
        }

        private void GetAmt()
        {
            if (chkS.Checked) add1 = 5;
            else add1 = 0;

            if (chkD.Checked) add2 = 5;
            else add2 = 0;

            sum = price + add1 + add2;
            txtSum.Text = sum.ToString();
            try
            {
                num = int.Parse(txtNum.Text);
            }
            catch
            {
                return;
            }

            if (num < 0) return;
            amt = sum * num;
            txtAmt.Text = amt.ToString();
        }
    }
}