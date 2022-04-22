using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeBlog
{
    public partial class Form2 : Form
    {
        //private int flg = 0;    // デッキ名を入力済みかのフラグ

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // 最初の行をつくる
            Blog.Yuuri.Append("<h3> 有利な相手 </h3>\n");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   // 完了ボタン押下

            this.regist();                  // HTML文字列作成
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {   // 追加で書くボタン

            this.regist();              // HTML文字列作成

            // 最後に入力内容はクリアする
            // (同じ内容を2回書かないようにするため)
            textBox1.Text = ""; // クラスのクリア
            textBox2.Text = ""; // アーキタイプクリア
            textBox3.Text = ""; // 本文クリア
        }

        private void regist()
        {   // 文字列を生成する

            // デッキ名
            string deck = string.Format("<h5>{0}({1})</h5>\n", textBox1.Text, textBox2.Text);
            Blog.Yuuri.Append(deck);

            // 内容
            string buff = string.Format("<h6>{0}</h6>\n", textBox3.Text);
            Blog.Yuuri.Append(buff);

        }

    }
}
