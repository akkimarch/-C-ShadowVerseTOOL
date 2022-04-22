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

namespace JCGkaiseki_GUI
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlMake();
            MessageBox.Show("追記しました");
        }


        public void XmlMake()
        {

            /*****************************
             XMLを追記しながらつくる処理
            *****************************/

            // 戦績ファイルを開く 
            bool newflg = File.Exists("ArchKizyun_AND.xml");                   // 新規作成フラグ

            if (newflg == true)
            {   // すでにファイルがある
                // 最後の1行を消しておく (最後の1行は、XMLを閉じる</LOOT>)
                string[] lines = System.IO.File.ReadAllLines("ArchKizyun_AND.xml");
                // 全行取得
                lines = lines.Take(lines.Length - 1).ToArray();                 // 最後の1行を消す
                System.IO.File.WriteAllLines("ArchKizyun_AND.xml", lines);     // 上書き保存
            }

            StreamWriter sw_senseki = new StreamWriter("ArchKizyun_AND.xml", true, Encoding.GetEncoding("UTF-8"));
            // ファイルオープン 追記モード
            if (newflg == false)
            {   // ファイルが新規作成だった場合
                // 最初の2行を書く
                sw_senseki.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                sw_senseki.WriteLine("<LOOT>");                                 // ルート
            }

            // 要素をそれぞれ書き込み
            // 要素番号
            sw_senseki.WriteLine("<SERCH>");

            // カード名1
            sw_senseki.WriteLine("   <CARD1>" + CardName1_textBox.Text + "</CARD1>");

            // ハッシュ値1
            sw_senseki.WriteLine("   <HASH1>" + Hash1_textBox.Text + "</HASH1>");

            // 枚数1
            sw_senseki.WriteLine("   <MAISUU1>" + Maisuu1_textBox.Text + "</MAISUU1>");

            // カード名2
            sw_senseki.WriteLine("   <CARD2>" + CardName2_textBox.Text + "</CARD2>");

            // ハッシュ値2
            sw_senseki.WriteLine("   <HASH2>" + Hash2_textBox.Text + "</HASH2>");

            // 枚数2
            sw_senseki.WriteLine("   <MAISUU2>" + Maisuu2_textBox.Text + "</MAISUU2>");

            // アーキタイプ名
            sw_senseki.WriteLine("   <ARCH>" + Arch_textBox.Text + "</ARCH>");

            // クラス名
            sw_senseki.WriteLine("   <CLASS>" + CLASS_textBox.Text + "</CLASS>");

            // 要素を閉じる
            sw_senseki.WriteLine("</SERCH>");

            // 閉じる前に、</ROOT>を書く
            sw_senseki.WriteLine("</LOOT>");

            // 閉じる
            sw_senseki.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Arch_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void CardName2_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Hash2_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Maisuu1_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
