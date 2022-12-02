using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PinyinToChinese
{
    public partial class Form1 : Form
    {
        private string pinyin;
        //private Dictionary<string, string> englishToPinyin = new Dictionary<string, string>() 
        //{ 
        //    { "a1", "\u0101" } , { "a2", "\u00E1" } , { "a3", "\u01CE" } , { "a4", "\u00E0" } ,
        //    { "e1", "\u0101" } , { "a2", "\u00E1" } , { "a3", "\u01CE" } , { "a4", "\u00E0" } ,
        //    { "a1", "\u0101" } , { "a2", "\u00E1" } , { "a3", "\u01CE" } , { "a4", "\u00E0" } ,
        //    { "a1", "\u0101" } , { "a2", "\u00E1" } , { "a3", "\u01CE" } , { "a4", "\u00E0" } ,
        //    { "a1", "\u0101" } , { "a2", "\u00E1" } , { "a3", "\u01CE" } , { "a4", "\u00E0" } ,
        //    { "a1", "\u0101" } , { "a2", "\u00E1" } , { "a3", "\u01CE" } , { "a4", "\u00E0" } ,
        //};

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text = ((TextBox)sender).Text;
        }

        #region buttonClicks

        private void a1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "\u0101";
            textBox1.Focus();
        }

        private void a2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "\u00E1";
        }

        private void a3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "\u01CE";
        }

        private void a4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "\u00E0";
        }

        private void e1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "\u0113";
        }

        private void e2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "\u00E9";
        }

        private void e3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "\u011B";
        }

        private void e4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "\u00E8";
        }

        private void i1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "\u012B";
        }

        private void i2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "\u00ED";
        }

        private void i3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "\u01D0";
        }

        private void i4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "\u00EC";
        }

        private void o1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "\u014D";
        }

        private void o2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "\u00F3";
        }

        private void o3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "\u01D2";
        }

        private void o4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "\u00F2";
        }

        private void u1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "\u016B";
        }

        private void u2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "\u00FA";
        }

        private void u3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "\u01D4";
        }

        private void u4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "\u00F9";
        }

        private void l1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "\u00FC";
        }

        private void l2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "\u01D6";
        }

        private void l3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "\u01D8";
        }

        private void l4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "\u01DA";
        }

        private void l5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "\u01DC";
        }

        #endregion
    }
}
