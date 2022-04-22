using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace JCG_HashKaiseki
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("デッキリスト(シャドウバースポータルのURL)を書いたファイルを入力");
            string filename = Console.ReadLine();                // 読み取り

            StreamReader sr = new StreamReader(filename);       // オープン
            string str = sr.ReadLine();          // 最初の1行読み取り
            sr.Close();                         // 閉じる


            int index = str.IndexOf("deck") + 9;        // deckを0 として 9文字後ろから見始める

            List<string> cards = new List<string>();     // 結果格納用

            for(int i=0;i<40;i++)
            {  // 40枚分繰り返し

                string work = str.Substring(index, 5);      // 5文字分
                cards.Add(work);                             // リストに追加

                index += 6;                                 // インデックスを6文字分ずらす "."があるので6文字
            }

            // 出力用のリストをつくる 同じカードは1回だけ出力、枚数も出す
            // これでデッキリストと同じ順番で出力できる
            List<Regist> regist = new List<Regist>();   // 登録済みリスト
            foreach(string card in cards)
            {
                int CardIndex = regist.FindIndex(A => A.CardHash == card);  // リストに登録済みか 登録済みなら要素番号が返る
                if( CardIndex >= 0)
                {   // 出力済みリストに登録済み
                    regist[CardIndex].count++;                  // カウントアップ
                    continue;                                   // 出力せずに次へ
                }
                else
                {   // 未登録
                    Regist work = new Regist();
                    work.CardHash = card;                       // カード名(ハッシュ値)
                    work.count = 1;                             // 1枚目
                    regist.Add(work);                           // 出力済みリストへ
                }
            }

            // 出力
            foreach(Regist reg in regist)
            {
                Console.WriteLine("{0} ：{1}枚", reg.CardHash, reg.count);                    // 出力
            }

            Console.WriteLine("キー押下で終了");                    // 出力
            Console.ReadKey();                                      // 入力待ち(コンソールすぐ閉じないようにする)

            return;

        }

        /// <summary>
        /// カード名+枚数を表示できるよう整理するためのクラス
        /// </summary>
        public class Regist
        {
            public string CardHash = "";    // カード名(ハッシュ値)
            public int count = 0;           // 枚数
        }

    }
}
