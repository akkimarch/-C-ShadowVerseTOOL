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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            // アーキタイプ分類用 XMLの読み取り
            XElement xml = XElement.Load(@"C:\Users\aki\Desktop\Programs\【C#】ブログ用ツール\MakeBrog\MakeBrog\bin\Debug\ArchKizyun.xml");
            IEnumerable<XElement> infos2 = from item in xml.Elements("SERCH") select item;
            List<ArchKizyun> archKizyuns = new List<ArchKizyun>();

            foreach (XElement info in infos2)
            {   // 取得したSERCHタグの中身を全部洗う
                ArchKizyun __work = new ArchKizyun(info.Element("CARD").Value, info.Element("HASH").Value, info.Element("MAISUU").Value, info.Element("ARCH").Value, info.Element("CLASS").Value);
                archKizyuns.Add(__work);
            }

            foreach (ArchKizyun work in archKizyuns)
            {
                switch (work.Class)
                {
                    case "エルフ":
                        E_comboBox.Items.Add(work.CardName);
                        break;
                    case "ロイヤル":
                        R_comboBox.Items.Add(work.CardName);
                        break;
                    case "ウィッチ":
                        W_comboBox.Items.Add(work.CardName);
                        break;
                    case "ドラゴン":
                        D_comboBox.Items.Add(work.CardName);
                        break;
                    case "ネクロ":
                        Nc_comboBox.Items.Add(work.CardName);
                        break;
                    case "ヴァンパイア":
                        V_comboBox.Items.Add(work.CardName);
                        break;
                    case "ビショップ":
                        B_comboBox.Items.Add(work.CardName);
                        break;
                    case "ネメシス":
                        Nm_comboBox.Items.Add(work.CardName);
                        break;
                    default:
                        break;
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();

            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();

            return;

        }
    }



    public class ArchKizyun
    {
        public string CardName;             // カード名(未使用) コメント的立ち位置
        public string Hash;                 // ハッシュ値
        public string Maisuu;               // 枚数 X枚以上入っているならアーキタイプに分類
        public string Arch;                 // アーキタイプ名
        public string Class;                // 属するクラス名
        public int CountW;                  // そのアーキタイプの数(未使用)
        public ArchKizyun(string CardNameW, string HashW, string MaisuuW, string ArchW, string ClassW)
        {   // 初期化
            CardName = CardNameW;
            Hash = HashW;
            Maisuu = MaisuuW;
            Arch = ArchW;
            Class = ClassW;
            CountW = 0;
        }
    }

}
