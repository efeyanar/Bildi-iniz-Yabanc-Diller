using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            if (checkBox1.Checked == true)
            {
                label2.Text += "İngilizce";
            }
            if (checkBox2.Checked == true)
            {
                if (label2.Text != "") 
                {
                    label2.Text += ",";
                }
                label2.Text += " Almanca";
            }
            if (checkBox3.Checked == true)
            {
                if (label2.Text != "")
                {
                    label2.Text += ",";
                }
                label2.Text += " Fransızca";
            }
            if (checkBox4.Checked == true)
            {
                if (label2.Text != "")
                {
                    label2.Text += ",";
                }
                label2.Text += " Rusça";
            }
        }
    }
}
