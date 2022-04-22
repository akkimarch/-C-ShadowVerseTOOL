using System;
using System.IO;
using System.Xml.Linq;
using System.Linq;
using System.Collections.Generic;

namespace JCGkaiseki
{
    class Program
    {
        static public List<Result> ResultList = new List<Result>();

        static void Main(string[] args)
        {
            Console.WriteLine("jsonファイルを入力");
            string str = Console.ReadLine();
            int Ecount = 0;
            int Lcount = 0;
            int Wcount = 0;
            int Dcount = 0;
            int NCcount = 0;
            int Vcount = 0;
            int Bcount = 0;
            int NMcount = 0;

            XElement xml2 = XElement.Load("ArchKizyun.xml");
            IEnumerable<XElement> infos2 = from item in xml2.Elements("SERCH") select item;
            List<ArchKizyun> archKizyuns = new List<ArchKizyun>();

            foreach (XElement info in infos2)
            {   // 取得したSERCHタグの中身を全部洗う

                ArchKizyun work = new ArchKizyun(info.Element("CARD").Value, info.Element("HASH").Value, info.Element("MAISUU").Value, info.Element("ARCH").Value, info.Element("CLASS").Value);
                archKizyuns.Add(work);
            }

            StreamReader sr = new StreamReader(str);

            // 読み取り
            string Rstr = sr.ReadLine();
            sr.Close();

            int Tousenindex = 0;        // 当選の人
            int indexClass = 0;         // クラス番号の直前まで(当選してる人のをみる)
            int indexClass2 = 0;         // クラス番号の直前まで(当選してる人のをみる)
            int TosenNinzuu = 0;

            while (true)
            {
                //               string hoge = "\"result\":1\"";
                Tousenindex = Rstr.IndexOf("\"result\":1", indexClass);     // 当選してる人(前回見つけた次の位置から探す)
                if (Tousenindex == -1)
                {
                    break;                       // 見つからないならループは終わり
                }
                else
                {
                    TosenNinzuu++;
                }

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

                /*                   */
                /*   製作中 */
                // 中のカードを分ける

                // jsonファイルから、デッキリスト部分を取得
                int indexCard = Rstr.IndexOf("\"hash\":", indexClass + 1);          // クラス番号直後の文字から検索。 "hash"を探す。
                                                                                    // 構成は、"hash":"3.5.6ujq2.・・・となっていて、6ujq2からがカード名なので、
                                                                                    // 11文字先からみる "を[0]としたら[12]から参照開始。→indexCard+12から参照開始。

                string Deck = Rstr.Substring(indexCard + 12, 239);                  // デッキ内容取得 239文字分(=40枚)
                string[] Cards = Deck.Split('.');                                   // カード一枚ごとに分割 (.で区切られてる)
                string ClassName = "";

                switch(int.Parse(ClassNo) )
                {
                    case 1: ClassName = "エルフ";break;
                    case 2: ClassName = "ロイヤル";break;
                    case 3: ClassName = "ウィッチ";break;
                    case 4: ClassName = "ドラゴン";break;
                    case 5: ClassName = "ネクロ";break;
                    case 6:ClassName = "ヴァンパイア";break;
                    case 7:ClassName = "ビショップ"; break;
                    case 8:ClassName = "ネメシス";break;
                }
                // Cardsの中には40枚のカード ここから、①ハッシュ対応付けがあるカードを探す。 ② ①のカードがアーキタイプ判定に使われているなら、枚数を数えて特定。
                Archkaiseki(Cards, ClassName, archKizyuns);
                /*                    */


                // クラス2
                indexClass2 = Rstr.IndexOf("\"clan\":", indexClass + 1); // クラス番号の直前まで 
                string ClassNo2 = Rstr.Substring(indexClass2 + 7, 1);   // "clan": の次の文字を取得

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

                Archkaiseki(Cards2, ClassName2, archKizyuns);
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
            }
                Console.WriteLine("エルフ：{0}", Ecount);
                Console.WriteLine("ロイヤル：{0}", Lcount);
                Console.WriteLine("ウィッチ：{0}", Wcount);
                Console.WriteLine("ドラゴン：{0}", Dcount);
                Console.WriteLine("ネクロ：{0}", NCcount);
                Console.WriteLine("ヴァンパイア：{0}", Vcount);
                Console.WriteLine("ビショップ：{0}", Bcount);
                Console.WriteLine("ネメシス：{0}", NMcount);
                Console.WriteLine("当選人数：{0}", TosenNinzuu);

                // 結果表示
                foreach (Result ret in ResultList)
                {
                    Console.WriteLine("アーキタイプ{0}の数は{1}個", ret.ArchName, ret.count);
                }

                return;
         }

        public class ArchKizyun
        {
            public string CardName;
            public string Hash;
            public string Maisuu;
            public string Arch;
            public string Class;
            public int CountW;      // そのアーキタイプの数
            public ArchKizyun(string CardNameW, string HashW, string MaisuuW, string ArchW, string ClassW)
            {
                CardName = CardNameW;
                Hash = HashW;
                Maisuu = MaisuuW;
                Arch = ArchW;
                Class = ClassW;
                CountW = 0;
            }


        }

        /// <summary>
        /// 指定した文字列がいくつあるか
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

        /// <summary>
        /// アーキタイプを解析する
        /// </summary>
        /// <param name="Cards">40枚のカードデッキ</param>
        /// <param name="archKizyuns">結果を入れるリスト</param>
        public static void Archkaiseki(string[] Cards , string ClassName, List<ArchKizyun> archKizyuns)
        {

           // List<Result> ResultList = new List<Result>();


            foreach(ArchKizyun XMLdata in archKizyuns)
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
                if(debug == 2) { Console.WriteLine(""); }

                // ハッシュ一致あり?
                if(Cards.Any(A => A==XMLdata.Hash) == false )
                {
                    continue;               // 不一致は見ない
                }

                // 一致の枚数は規定以上?
                if (CountOf(XMLdata.Hash, Cards) < int.Parse(XMLdata.Maisuu) )
                {   // 枚数未満ならみない
                    continue;
                }

                // アーキタイプリストに追加
                Result work = new Result();
                work.ArchName = XMLdata.Arch;   // アーキタイプ名

                int index = ResultList.FindIndex(A => A.ArchName==work.ArchName);   // アーキタイプ名一致するのがあるか探す
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

        public class Result
        {
            public string ArchName=""; // アーキタイプ名
            public int count = 0;   // 数
        }
        /* */

    }
}
