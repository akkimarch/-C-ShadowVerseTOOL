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
using System.Net;
using System.IO;

namespace JCGkaiseki_GUI
{
    public partial class Form1 : Form
    {
        static public List<Result> ResultList = new List<Result>(); // アーキタイプ解析結果格納

        List<string> E_arch = new List<string>();        // アーキタイプを入れる (過去結果)
        List<string> L_arch = new List<string>();        // アーキタイプを入れる (過去結果)
        List<string> W_arch = new List<string>();        // アーキタイプを入れる (過去結果)
        List<string> D_arch = new List<string>();        // アーキタイプを入れる (過去結果)
        List<string> NC_arch = new List<string>();       // アーキタイプを入れる (過去結果)
        List<string> V_arch = new List<string>();        // アーキタイプを入れる (過去結果)
        List<string> B_arch = new List<string>();        // アーキタイプを入れる (過去結果)
        List<string> NM_arch = new List<string>();       // アーキタイプを入れる (過去結果)


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> urls = new List<string>();
            if (UrlTextBox1.Text != "") { urls.Add(UrlTextBox1.Text); }
            if (UrlTextBox2.Text != "") { urls.Add(UrlTextBox2.Text); }
            if (UrlTextBox3.Text != "") { urls.Add(UrlTextBox3.Text); }

            JCGkaiseki(urls);

            // アーキタイプの分析結果をセット

            // アーキタイプ
            foreach (Result ret in ResultList)
            {
                string temp = string.Format("{0}：  {1}人\r\n", ret.ArchName, ret.count);

                // クラス名に応じたリストに追加
                switch (ret.ClassName)
                {
                    case "エルフ": E_arch.Add(temp); break;
                    case "ロイヤル": L_arch.Add(temp); break;
                    case "ウィッチ": W_arch.Add(temp); break;
                    case "ドラゴン": D_arch.Add(temp); break;
                    case "ネクロ": NC_arch.Add(temp); break;
                    case "ヴァンパイア": V_arch.Add(temp); break;
                    case "ビショップ": B_arch.Add(temp); break;
                    case "ネメシス": NM_arch.Add(temp); break;
                }
            }

            // テキストボックスへ書き込み
            TextBoxSet(E_textBox, E_arch);
            TextBoxSet(L_textBox, L_arch);
            TextBoxSet(W_textBox, W_arch);
            TextBoxSet(D_textBox, D_arch);
            TextBoxSet(NC_textBox, NC_arch);
            TextBoxSet(V_textBox, V_arch);
            TextBoxSet(B_textBox, B_arch);
            TextBoxSet(NM_textBox, NM_arch);


            ResultList.Clear();         // リストクリア (ボタン複数押すと重複してしまうため)

            return;

        }

        void JCGkaiseki(List<string> urls)
        {
            int Ecount = 0;
            int Lcount = 0;
            int Wcount = 0;
            int Dcount = 0;
            int NCcount = 0;
            int Vcount = 0;
            int Bcount = 0;
            int NMcount = 0;

            // アーキタイプ分類用 XMLの読み取り
            XElement xml2 = XElement.Load(@"C:\Users\aki\Desktop\Programs\【C#】ブログ用ツール\MakeBrog\MakeBrog\bin\Debug\ArchKizyun.xml");
            IEnumerable<XElement> infos2 = from item in xml2.Elements("SERCH") select item;
            List<ArchKizyun> archKizyuns = new List<ArchKizyun>();

            foreach (XElement info in infos2)
            {   // 取得したSERCHタグの中身を全部洗う
                ArchKizyun __work = new ArchKizyun(info.Element("CARD").Value, info.Element("HASH").Value, info.Element("MAISUU").Value, info.Element("ARCH").Value, info.Element("CLASS").Value);
                archKizyuns.Add(__work);
            }

            // アーキタイプ分類用 AND検索用 XMLの読み取り
            XElement xml3 = XElement.Load(@"C:\Users\aki\Desktop\Programs\【C#】ブログ用ツール\MakeBrog\MakeBrog\bin\Debug\ArchKizyun_AND.xml");
            IEnumerable<XElement> infos3 = from item in xml3.Elements("SERCH") select item;
            List<ArchKizyunAND> archKizyunsAND = new List<ArchKizyunAND>();

            foreach (XElement info in infos3)
            {   // 取得したSERCHタグの中身を全部洗う
                ArchKizyunAND __work = new ArchKizyunAND(info.Element("CARD1").Value, info.Element("HASH1").Value, info.Element("MAISUU1").Value, info.Element("CARD2").Value, info.Element("HASH2").Value, info.Element("MAISUU2").Value, info.Element("ARCH").Value, info.Element("CLASS").Value);
                archKizyunsAND.Add(__work);
            }

            // URLからWEBへとび、HTML取得
            WebClient webClient = new WebClient();

            foreach (var url in urls)
            {   // URLの数だけループ

                int flg = 0;
                string text = webClient.DownloadString(url);        // HTMLダウンロード
                StringReader Rtext = new StringReader(text);        // テキスト
                string Rstr = "";

                // 読み取り
                // HTMLから
                while (true)
                {
                    Rstr = Rtext.ReadLine();
                    if (Rstr.Contains("list: ["))
                    {   // 見つけた
                        flg = 1;
                        break;
                    }
                }

                if (flg == 0) { continue; }            // なかった


                int Tousenindex = 0;        // 当選の人
                int indexClass = 0;         // クラス番号の直前まで(当選してる人のをみる)
                int indexClass2 = 0;         // クラス番号の直前まで(当選してる人のをみる)
                int TosenNinzuu = 0;

                while (true)
                {
                    Tousenindex = Rstr.IndexOf("\"result\":1", indexClass);     // 当選してる人(前回見つけた次の位置から探す)
                    if (Tousenindex == -1)
                    {
                        break;                       // 見つからないならループは終わり
                    }
                    else
                    {
                        TosenNinzuu++;      // 当選人数 (未使用)
                    }

                    /**********************  1デッキ目 START         *************************/
                    // クラス1
                    indexClass = Rstr.IndexOf("\"clan\":", Tousenindex); // クラス番号の直前まで 
                    string ClassNo = Rstr.Substring(indexClass + 7, 1);   // "clan": の次の文字を取得

                    // クラス毎のカウントアップ
                    if (ClassNo == "1")
                    {
                        Ecount++;
                    }
                    if (ClassNo == "2")
                    {
                        Lcount++;
                    }
                    if (ClassNo == "3")
                    {
                        Wcount++;
                    }
                    if (ClassNo == "4")
                    {
                        Dcount++;
                    }
                    if (ClassNo == "5")
                    {
                        NCcount++;
                    }
                    if (ClassNo == "6")
                    {
                        Vcount++;
                    }
                    if (ClassNo == "7")
                    {
                        Bcount++;
                    }
                    if (ClassNo == "8")
                    {
                        NMcount++;
                    }

                    // デッキリスト部分の取得
                    int indexCard = Rstr.IndexOf("\"hash\":", indexClass + 1);          // クラス番号直後の文字から検索。 "hash"を探す。
                                                                                        // 構成は、"hash":"3.5.6ujq2.・・・となっていて、6ujq2からがカード名なので、
                                                                                        // 11文字先からみる "を[0]としたら[12]から参照開始。→indexCard+12から参照開始。

                    string Deck = Rstr.Substring(indexCard + 12, 239);                  // デッキ内容取得 239文字分(=40枚)
                    string[] Cards = Deck.Split('.');                                   // カード一枚ごとに分割 (.で区切られてる)
                    string ClassName = "";

                    switch (int.Parse(ClassNo))
                    {
                        case 1: ClassName = "エルフ"; break;
                        case 2: ClassName = "ロイヤル"; break;
                        case 3: ClassName = "ウィッチ"; break;
                        case 4: ClassName = "ドラゴン"; break;
                        case 5: ClassName = "ネクロ"; break;
                        case 6: ClassName = "ヴァンパイア"; break;
                        case 7: ClassName = "ビショップ"; break;
                        case 8: ClassName = "ネメシス"; break;
                    }

                    // Cardsの中には40枚のカード XMLに書いてあるとおりに分類
                    // アーキタイプの解析
                    Archkaiseki(Cards, ClassName, archKizyuns);                                 // OR検索
                    Archkaiseki_AND(Cards, ClassName, archKizyunsAND);                             // AND検索

                    /**********************  1デッキ目 END         *************************/



                    /**********************  2デッキ目 START         *************************/
                    // クラス2
                    indexClass2 = Rstr.IndexOf("\"clan\":", indexClass + 1); // クラス番号の直前まで 
                    string ClassNo2 = Rstr.Substring(indexClass2 + 7, 1);   // "clan": の次の文字を取得

                    // クラス毎のカウントアップ
                    if (ClassNo2 == "1")
                    {
                        Ecount++;
                    }
                    if (ClassNo2 == "2")
                    {
                        Lcount++;
                    }
                    if (ClassNo2 == "3")
                    {
                        Wcount++;
                    }
                    if (ClassNo2 == "4")
                    {
                        Dcount++;
                    }
                    if (ClassNo2 == "5")
                    {
                        NCcount++;
                    }
                    if (ClassNo2 == "6")
                    {
                        Vcount++;
                    }
                    if (ClassNo2 == "7")
                    {
                        Bcount++;
                    }
                    if (ClassNo2 == "8")
                    {
                        NMcount++;
                    }

                    // アーキタイプの分類
                    // jsonファイルから、デッキリスト部分を取得
                    int indexCard2 = Rstr.IndexOf("\"hash\":", indexClass2 + 1);          // クラス番号直後の文字から検索。 "hash"を探す。
                                                                                          // 構成は、"hash":"3.5.6ujq2.・・・となっていて、6ujq2からがカード名なので、
                                                                                          // 11文字先からみる "を[0]としたら[12]から参照開始。→indexCard+12から参照開始。

                    string Deck2 = Rstr.Substring(indexCard2 + 12, 239);                  // デッキ内容取得 239文字分(=40枚)
                    string[] Cards2 = Deck2.Split('.');                                   // カード一枚ごとに分割 (.で区切られてる)
                    string ClassName2 = "";

                    switch (int.Parse(ClassNo2))
                    {
                        case 1: ClassName2 = "エルフ"; break;
                        case 2: ClassName2 = "ロイヤル"; break;
                        case 3: ClassName2 = "ウィッチ"; break;
                        case 4: ClassName2 = "ドラゴン"; break;
                        case 5: ClassName2 = "ネクロ"; break;
                        case 6: ClassName2 = "ヴァンパイア"; break;
                        case 7: ClassName2 = "ビショップ"; break;
                        case 8: ClassName2 = "ネメシス"; break;
                    }

                    // アーキタイプの解析
                    Archkaiseki(Cards2, ClassName2, archKizyuns);
                    Archkaiseki_AND(Cards2, ClassName2, archKizyunsAND);               // AND検索

                    /**********************  2デッキ目 END         *************************/
                }
            }

            /************************* テキストボックスに書き込み *******************************/
            List<SiyourituW> siyouritu = new List<SiyourituW>();
            SiyourituW work = new SiyourituW(Ecount, "エルフ");
            siyouritu.Add(work);

            SiyourituW work2 = new SiyourituW(Lcount, "ロイヤル");
            siyouritu.Add(work2);

            SiyourituW work3 = new SiyourituW(Wcount, "ウィッチ");
            siyouritu.Add(work3);

            SiyourituW work4 = new SiyourituW(Dcount, "ドラゴン");
            siyouritu.Add(work4);

            SiyourituW work5 = new SiyourituW(NCcount, "ネクロ");
            siyouritu.Add(work5);

            SiyourituW work6 = new SiyourituW(Vcount, "ヴァンパイア");
            siyouritu.Add(work6);

            SiyourituW work7 = new SiyourituW(Bcount, "ビショップ");
            siyouritu.Add(work7);

            SiyourituW work8 = new SiyourituW(NMcount, "ネメシス");
            siyouritu.Add(work8);

            // 並べ替え
            var c = new Comparison<SiyourituW>(Compare);
            siyouritu.Sort(c);

            string str = "";
            // セット
            for (int i = 0; i < 8; i++)
            {
                str += string.Format("{0}：{1}人\r\n", siyouritu[i].ClassName, siyouritu[i].Ninzuu);
            }

            Kekka.Text = str;                       // テキスト書き込み

            return;
        }

        /// <summary>
        /// アーキタイプを解析する
        /// </summary>
        /// <param name="Cards">40枚のカードデッキ</param>
        /// <param name="archKizyuns">結果を入れるリスト</param>
        public static void Archkaiseki(string[] Cards, string ClassName, List<ArchKizyun> archKizyuns)
        {

            foreach (ArchKizyun XMLdata in archKizyuns)
            {
                int debug = 0;

                // クラス名一致?
                if (ClassName != XMLdata.Class)
                {
                    continue;                   // 不一致はみない
                }
                else
                {
                    debug = 0;
                }
                if (debug == 2) { Console.WriteLine(""); }

                // ハッシュ一致あり?
                if (Cards.Any(A => A == XMLdata.Hash) == false)
                {
                    continue;               // 不一致は見ない
                }

                // 一致の枚数は規定以上?
                if (CountOf(XMLdata.Hash, Cards) < int.Parse(XMLdata.Maisuu))
                {   // 枚数未満ならみない
                    continue;
                }

                // アーキタイプリストに追加
                Result work = new Result();
                work.ArchName = XMLdata.Arch;   // アーキタイプ名
                work.ClassName = XMLdata.Class; // クラス名

                int index = ResultList.FindIndex(A => A.ArchName == work.ArchName);   // アーキタイプ名一致するのがあるか探す
                if (index >= 0)
                {   // アーキタイプ名被りあり
                    ResultList[index].count++;      // 数を+
                }
                else
                {   // 被りなし
                    work.count = 1;                 // 1つめ
                    ResultList.Add(work);           // 追加

                }
            }
        }

        /// <summary>
        /// AND検索 ArchKizyun_AND.xmlを使用
        /// </summary>
        /// <param name="Cards"></param>
        /// <param name="ClassName"></param>
        /// <param name="archKizyuns"></param>
        public static void Archkaiseki_AND(string[] Cards, string ClassName, List<ArchKizyunAND> archKizyunsAND)
        {

            foreach (ArchKizyunAND XMLdata in archKizyunsAND)
            {
                int debug = 0;

                // クラス名一致?
                if (ClassName != XMLdata.Class)
                {
                    continue;                   // 不一致はみない
                }
                else
                {
                    debug = 0;
                }
                if (debug == 2) { Console.WriteLine(""); }

                /**************************************** 1枚目のチェックSTART ********************************/
                // ハッシュ一致あり?
                if (Cards.Any(A => A == XMLdata.Hash1) == false)
                {
                    continue;               // 不一致は見ない
                }

                // 一致の枚数は規定以上?
                if (CountOf(XMLdata.Hash1, Cards) < int.Parse(XMLdata.Maisuu1))
                {   // 枚数未満ならみない
                    continue;
                }
                /**************************************** 1枚目のチェックEND *********************************/

                /**************************************** 2枚目のチェックSTART ********************************/
                // ハッシュ一致あり?
                if (Cards.Any(A => A == XMLdata.Hash2) == false)
                {
                    continue;               // 不一致は見ない
                }

                // 一致の枚数は規定以上?
                if (CountOf(XMLdata.Hash2, Cards) < int.Parse(XMLdata.Maisuu2))
                {   // 枚数未満ならみない
                    continue;
                }
                /**************************************** 2枚目のチェックEND *********************************/


                // アーキタイプリストに追加
                Result work = new Result();
                work.ArchName = XMLdata.Arch;   // アーキタイプ名
                work.ClassName = XMLdata.Class; // クラス名

                int index = ResultList.FindIndex(A => A.ArchName == work.ArchName);   // アーキタイプ名一致するのがあるか探す
                if (index >= 0)
                {   // アーキタイプ名被りあり
                    ResultList[index].count++;      // 数を+
                }
                else
                {   // 被りなし
                    work.count = 1;                 // 1つめ
                    ResultList.Add(work);           // 追加
                }
            }
        }

        /// <summary>
        ///  並べ替え用
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Compare(SiyourituW a, SiyourituW b)
        {
            return b.Ninzuu - a.Ninzuu;                 // 人数 降順並べ替え。
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
                CardName1   = CardNameW1;
                Hash1  = HashW1;
                Maisuu1 = MaisuuW1;
                CardName2 = CardNameW2;
                Hash2 = HashW2;
                Maisuu2 = MaisuuW2;
                Arch = ArchW;
                Class = ClassW;
                CountW = 0;
            }
        }



        /// <summary>
        /// 指定した文字列がいくつあるかを返す
        /// </summary>
        public static int CountOf(string target, params string[] strArray)
        {
            int count = 0;

            foreach (string str in strArray)
            {
                int index = target.IndexOf(str, 0);
                while (index != -1)
                {
                    count++;
                    index = target.IndexOf(str, index + str.Length);
                }
            }

            return count;
        }


        public class Result
        {
            public string ArchName = ""; // アーキタイプ名
            public int count = 0;        // 数
            public string ClassName = "";   // クラス名
        }


        public class SiyourituW
        {
            public int Ninzuu;
            public string ClassName;

            public SiyourituW(int a, string b)
            {
                Ninzuu = a;
                ClassName = b;
            }

        }

        /// <summary>
        /// テキストボックスにリスト内容をすべて書き込む
        /// </summary>
        /// <param name="text"></param>
        /// <param name="list"></param>
        public void TextBoxSet(TextBox textboxWork, List<string> list)
        {
            string temp = "";

            // 連結
            foreach (string temp2 in list)
            {
                temp += temp2;
            }

            // 書き込む
            textboxWork.Text = temp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
