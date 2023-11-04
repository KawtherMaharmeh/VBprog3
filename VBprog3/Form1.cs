using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VBprog3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string First = txtname.Text;
            string Family = txtfamily.Text;
            txtname.Text = Family;
            txtfamily.Text = First;
        }

        private void lbl4_Click(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            lbl3.Text = txtname.Text.Length.ToString(); 
        }

        private void txtfamily_TextChanged(object sender, EventArgs e)
        {
            lbl4.Text = txtfamily.Text.Length.ToString();
        }
    }
}
