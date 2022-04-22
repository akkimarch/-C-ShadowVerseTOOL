using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MakeBlog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   // 採用カードなど説明部分
            //Form2 form2 = new Form2();
            //form2.ShowDialog();
            ////string moji = string.Format("<h5>{0}</h5>\n",Blog.blog);   // 書き込み文字列

            //StreamWriter sw = new StreamWriter("FILE.html");

            //sw.WriteLine("<h3>採用カード</h3>");
            //sw.WriteLine(moji);


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {   // 有利な相手について書くボタン
            Form2 form2 = new Form2();
            DialogResult ret = form2.ShowDialog();

            if(ret == DialogResult.OK)
            {   // OKが返った (完了ボタンで閉じた)
                checkBox1.Checked = true;       // チェックOKにする
            }

            return;
        }

        private void button4_Click(object sender, EventArgs e)
        {   // 完了ボタン

            // ファイルをつくる
            StreamWriter sw = new StreamWriter("BLOG.html");

            // 内容をファイルに書き込み
            sw.Write(string.Format("<h3>{0}</h3>\n", textBox1.Text) );
            sw.Write(Blog.Yuuri);       // 有利相手のこと
            sw.Write(Blog.Huri);        // 不利相手のこと


            // 閉じる
            sw.Close();

            MessageBox.Show("HTML作成しました");
        }

        private void button6_Click(object sender, EventArgs e)
        {   // 不利な相手について書くボタン
            Form3 form3 = new Form3();
            DialogResult ret = form3.ShowDialog();

            if (ret == DialogResult.OK)
            {   // OKが返った (完了ボタンで閉じた)
                checkBox2.Checked = true;       // チェックOKにする
            }

            return;


        }

        private void button5_Click(object sender, EventArgs e)
        {   // デッキの動き紹介ボタン
            Form7 form7 = new Form7();
            DialogResult ret = form7.ShowDialog();

            if(ret == DialogResult.OK)
            {   // OKが返った(完了ボタンで閉じた)
                checkBox6.Checked = true;
            }

            return;
        }
    }
}
