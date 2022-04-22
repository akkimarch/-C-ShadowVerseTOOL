using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace JCGkaiseki_GUI
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            // アーキタイプ分類用 XMLの読み取り
            XElement xml = XElement.Load(@"C:\Users\aki\Desktop\Programs\【C#】ブログ用ツール\MakeBrog\MakeBrog\bin\Debug\ArchKizyun_AND.xml");
            IEnumerable<XElement> infos2 = from item in xml.Elements("SERCH") select item;
            List<ArchKizyunAND> archKizyuns = new List<ArchKizyunAND>();

            foreach (XElement info in infos2)
            {   // 取得したSERCHタグの中身を全部洗う
                ArchKizyunAND __work = new ArchKizyunAND(info.Element("CARD1").Value, info.Element("HASH1").Value, info.Element("MAISUU1").Value, info.Element("CARD2").Value, info.Element("HASH2").Value, info.Element("MAISUU2").Value, info.Element("ARCH").Value, info.Element("CLASS").Value);
                archKizyuns.Add(__work);
            }

            foreach (ArchKizyunAND work in archKizyuns)
            {
                switch (work.Class)
                {
                    case "エルフ":
                        if (E_comboBox.Items.Contains(work.CardName1) != true)
                        {
                            E_comboBox.Items.Add(work.CardName1);
                        }
                        break;
                    case "ロイヤル":
                        if (R_comboBox.Items.Contains(work.CardName1) != true)
                        {
                            R_comboBox.Items.Add(work.CardName1);
                        }
                        break;
                    case "ウィッチ":
                        if (W_comboBox.Items.Contains(work.CardName1) != true)
                        {
                            W_comboBox.Items.Add(work.CardName1);
                        }
                        break;
                    case "ドラゴン":
                        if (D_comboBox.Items.Contains(work.CardName1) != true)
                        {
                            D_comboBox.Items.Add(work.CardName1);
                        }
                        break;
                    case "ネクロ":
                        if (Nc_comboBox.Items.Contains(work.CardName1) != true)
                        {
                            Nc_comboBox.Items.Add(work.CardName1);
                        }
                        break;
                    case "ヴァンパイア":
                        if (V_comboBox.Items.Contains(work.CardName1) != true)
                        {
                            V_comboBox.Items.Add(work.CardName1);
                        }
                        break;
                    case "ビショップ":
                        if (B_comboBox.Items.Contains(work.CardName1) != true)
                        {
                            B_comboBox.Items.Add(work.CardName1);
                        }
                        break;
                    case "ネメシス":
                        if (Nm_comboBox.Items.Contains(work.CardName1) != true)
                        {
                            Nm_comboBox.Items.Add(work.CardName1);
                        }
                        break;
                    default:
                        break;
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

            return;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void E_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();

            return;

        }
    }

    /// <summary>
    /// AND検索用
    /// </summary>
    public class ArchKizyunAND
    {
        public string CardName1;             // カード名(未使用) コメント的立ち位置
        public string Hash1;                 // ハッシュ値
        public string Maisuu1;               // 枚数 X枚以上入っているならアーキタイプに分類
        public string CardName2;             // カード名(未使用) コメント的立ち位置
        public string Hash2;                 // ハッシュ値
        public string Maisuu2;               // 枚数 X枚以上入っているならアーキタイプに分類
        public string Arch;                 // アーキタイプ名
        public string Class;                // 属するクラス名
        public int CountW;                  // そのアーキタイプの数(未使用)
        public ArchKizyunAND(string CardNameW1, string HashW1, string MaisuuW1, string CardNameW2, string HashW2, string MaisuuW2, string ArchW, string ClassW)
        {   // 初期化
            CardName1 = CardNameW1;
            Hash1 = HashW1;
            Maisuu1 = MaisuuW1;
            CardName2 = CardNameW2;
            Hash2 = HashW2;
            Maisuu2 = MaisuuW2;
            Arch = ArchW;
            Class = ClassW;
            CountW = 0;
        }
    }



}
