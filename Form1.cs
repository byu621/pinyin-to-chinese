using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Pinyin4net;
using Pinyin4net.Format;

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
        }
        private void Call_Click(object sender, EventArgs e)
        {
            TextBox[] textBoxes = new[] { textBox2, textBox3 };
            string[] array = textBox1.Text.Split(' ');
            if (array.Length > 2)
            {
                return;
            }

            for (int i = 0; i < array.Length; i++)
            {
                string pinyin = array[i];
                CallApi(pinyin, textBoxes[i]);
            }
        }

        private void CallApi(string text, TextBox textBox)
        {
            string textWithNoTones = Regex.Replace(text, @"[\d-]", string.Empty);

            textBox.Text = string.Empty;
            using (var client = new HttpClient())
            {
                var endpoint = $"https://www.google.com/inputtools/request?ime=pinyin&ie=utf-8&oe=utf-8&app=translate&num=20&text={textWithNoTones}";
                var result = client.GetStringAsync(endpoint).Result;
                var json = JsonConvert.DeserializeObject<dynamic>(result);
                var chineseTranslations = json[1][0][1];

                foreach (string chineseTranslation in chineseTranslations)
                {
                    if (chineseTranslation.Length > 1)
                    {
                        continue;
                    }

                    var chineseCharacter = chineseTranslation[0];
                    string[] pinyin = PinyinHelper.ToHanyuPinyinStringArray(chineseCharacter);

                    if (pinyin == null)
                    {
                        continue;
                    }

                    foreach (string pinyinAlternative in pinyin)
                    {
                        if (pinyinAlternative == text || pinyinAlternative == $"{text}5")
                        {
                            textBox.Text += chineseTranslation;
                        }
                    }
                }
            }
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
