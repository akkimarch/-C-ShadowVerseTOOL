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
    /// <summary>
    /// 単体フィルタ
    /// </summary>
    public partial class Form4 : Form
    {
        public Form4()
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
            bool newflg = File.Exists("ArchKizyun.xml");                   // 新規作成フラグ

            if (newflg == true)
            {   // すでにファイルがある
                // 最後の1行を消しておく (最後の1行は、XMLを閉じる</LOOT>)
                string[] lines = System.IO.File.ReadAllLines("ArchKizyun.xml");
                // 全行取得
                lines = lines.Take(lines.Length - 1).ToArray();                 // 最後の1行を消す
                System.IO.File.WriteAllLines("ArchKizyun.xml", lines);     // 上書き保存
            }

            StreamWriter sw_senseki = new StreamWriter("ArchKizyun.xml", true, Encoding.GetEncoding("UTF-8"));
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

            // カード名
            sw_senseki.WriteLine("   <CARD>" + CardName_textBox.Text + "</CARD>");

            // ハッシュ値
            sw_senseki.WriteLine("   <HASH>" + Hash_textBox.Text + "</HASH>");

            // 枚数
            sw_senseki.WriteLine("   <MAISUU>" + Maisuu_textBox.Text + "</MAISUU>");

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


    }
}
