using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using System.Diagnostics;
using System.Drawing;

namespace Battle_Manage
{
    public class Sub
    {
        // サブ関数
        static public void AddCombo(ComboBox com, object deckclass)
        {   // コンボボックスにアーキタイプを追加する

            // ファイルからアーキタイプ読み込み
            // デッキタイプに応じて開くファイルは変える
            string filepath = "アーキタイプ\\" + deckclass + ".txt";                    // ファイルパス
            if (File.Exists(filepath) == false)
            {   // ファイルなし
                return;                                                         // 終了
            }

            StreamReader sr = new StreamReader(filepath, Encoding.GetEncoding("UTF-8"));

            com.FormattingEnabled = true;
            while (sr.Peek() != -1)
            {   // ファイルの中身を全部コンボボックスに追加
                com.Items.Add(sr.ReadLine());
            }
            sr.Close();     // 閉じる
        }

        static public void AddList(ListBox list,string deckclass)
        {   // リストボックスにアーキタイプを追加する

            // リストボックス内容をクリア
            list.Items.Clear();
            // ファイルからアーキタイプ読み込み
            // デッキタイプに応じて開くファイルは変える
            string filepath = "アーキタイプ\\" + deckclass + ".txt";                    // ファイルパス
            if (File.Exists(filepath) == false)
            {   // ファイルなし
                return;                                                         // 終了
            }

            StreamReader sr = new StreamReader(filepath, Encoding.GetEncoding("UTF-8"));

            while (sr.Peek() != -1)
            {   // ファイルの中身を全部リストに追加
                list.Items.Add(sr.ReadLine());
            }
            sr.Close();     // 閉じる

        }

        static public void MemoryRegist(BattleDeck mydeck, BattleDeck opendeck, String FirstSecond, String WinLose, String Env)
        {   // コンボボックスの内容を戦績ファイルに追加する

            /*****************************
             XMLを追記しながらつくる処理
            *****************************/

            // 戦績ファイルを開く 
            bool newflg = File.Exists("DATA\\BattleLog.xml");                   // 新規作成フラグ

            if (newflg == true)
            {   // すでにファイルがある
                // 最後の1行を消しておく (最後の1行は、XMLを閉じる</LOOT>)
                string[] lines = System.IO.File.ReadAllLines("DATA\\BattleLOG.xml");
                // 全行取得
                lines = lines.Take(lines.Length - 1).ToArray();                 // 最後の1行を消す
                System.IO.File.WriteAllLines("DATA\\BattleLOG.xml", lines);     // 上書き保存
            }

            StreamWriter sw_senseki = new StreamWriter("DATA\\BattleLOG.xml", true, Encoding.GetEncoding("UTF-8"));
            // ファイルオープン 追記モード
            if (newflg == false)
            {   // ファイルが新規作成だった場合
                // 最初の2行を書く
                sw_senseki.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
                sw_senseki.WriteLine("<LOOT>");                                 // ルート
            }

            // 要素をそれぞれ書き込み
            // 要素番号
            sw_senseki.WriteLine("<SENSEKI>");

            // 自分のデッキとアーキタイプ
            sw_senseki.WriteLine("   <MYCLASS>" + mydeck.Class + "</MYCLASS>");
            sw_senseki.WriteLine("   <MYTYPE>" + mydeck.Archetype + "</MYTYPE>");

            // 相手のデッキとアーキタイプ
            sw_senseki.WriteLine("   <OPENCLASS>" + opendeck.Class + "</OPENCLASS>");
            sw_senseki.WriteLine("   <OPENTYPE>" + opendeck.Archetype + "</OPENTYPE>");

            // 先攻後攻
            sw_senseki.WriteLine("   <SAKIATO>" + FirstSecond + "</SAKIATO>");

            // 勝敗
            sw_senseki.WriteLine("   <WINLOSE>" + WinLose + "</WINLOSE>");

            // 日付
            sw_senseki.WriteLine("   <DATE>" + DateTime.Now.ToString() + "</DATE>");

            // 環境
            sw_senseki.WriteLine("   <ENV>" + Env + "</ENV>");

            // 要素を閉じる
            sw_senseki.WriteLine("</SENSEKI>");

            // 閉じる前に、</ROOT>を書く
            sw_senseki.WriteLine("</LOOT>");

            // 閉じる
            sw_senseki.Close();
        }

        static public void Scope_Make(int BackTime, string EnvName)
        {
            // BackTime: -1 は環境全日指定とみなす
            /*********************************************************************************************
            <処理の流れ>
            (1)XMLを開いて、現環境のものを全てピックアップする。
            (2)対戦総数を保存する。
            (3)相手クラス・アーキタイプを取り出し、 List<Deck>に入れる
               クラス毎\アーキタイプ毎 でループする。
               List.FindAll()をつかって、クラスとアーキタイプが一致するものを全部抽出。
               とってきたListのCount()で、数を算出。
            (4){クラス、アーキタイプ、数、割合(引数：総数)}という構成のクラスをつくって、それぞれ設定。”数”にはCount()を入れる。
                割合()はメソッド。
            (5) (4)のクラスを使い、割合をグラフに落とす。
            *********************************************************************************************/

            // ファイルチェック
            if (File.Exists("DATA\\BattleLog.xml") == false)
            {   // 戦績ファイルがない
                MessageBox.Show("戦績ファイルがありません (DATA\\BattleLog.xml)");
                return;
            }

            // XMLからデータを取得
            XElement xml = XElement.Load("DATA\\BattleLog.xml");
            IEnumerable<XElement> infos = from item in xml.Elements("SENSEKI") select item;
            // "SENSEKI"タグの中からデータを取り出す
            int sum=0;                                                    // 割合算出の分母
            // 現在設定中の環境でバトルした数を取得する
            List<Deck> decks = new List<Deck>();                      // デッキリスト
            List<PercentDeck> PerDecks = new List<PercentDeck>();               // 割合算出用インスタンス

            // XMLから相手クラス・アーキタイプを取り出してリストに入れる
            foreach (XElement info in infos)
            {   // 取得したSENSEKIタグの中身を全部洗う

                // 日数の指定範囲に応じて検索対象を絞る
                if (BackTime != -1)
                {   // -1(環境全日)以外
                    // 指定されている日数に応じて検索対象を絞る
                    foreach (XElement A in infos)
                    {
                        if (A.Element("ENV").Value == EnvName)
                        {   // 環境一致
                            DateTime BattleDate = DateTime.Parse(info.Element("DATE").Value);  // 日付を取得
                            DateTime today = DateTime.Now;
                            DateTime AddDate = today.AddDays(-1 * BackTime);               // 指定時刻分遡る

                            // 遡った時刻以内なら検索
                            if (BattleDate > AddDate)
                            {
                                Deck work = new Deck();                                         // 一時エリア
                                work.Class = info.Element("OPENCLASS").Value;                   // クラスを一時エリアへ
                                work.Archetype = info.Element("OPENTYPE").Value;                // アーキタイプを一時エリアへ

                                decks.Add(work);                                                // リストに入れる
                                sum++;                                                          // 分母を+1
                            }
                        }
                    }
                }
                else
                {   // -1(環境全日)の場合
                    // 環境が一致なら、すべて検索対象とする
                    foreach(XElement A in infos)
                    {
                        if(A.Element("ENV").Value == EnvName)
                        {   // 環境一致
                            Deck work = new Deck();                                         // 一時エリア
                            work.Class = A.Element("OPENCLASS").Value;                   // クラスを一時エリアへ
                            work.Archetype = A.Element("OPENTYPE").Value;                // アーキタイプを一時エリアへ

                            decks.Add(work);                                                // リストに入れる
                            sum++;
                        }
                    }
                }
            }

            // クラス毎＆アーキタイプ毎でループし、各組み合わせを全て抽出
            // デッキクラスとアーキタイプをまとめる
            string[] declclass = new string[8] { "ヴァンパイア", "ウィッチ", "エルフ", "ドラゴン", "ネクロマンサー", "ネメシス", "ビショップ", "ロイヤル" };

            foreach (string deckclass_wk in declclass)
            {   // デッキクラス毎に検索

                // ①ＸＭＬから取得した要素(クラス)で検索し、ヒットしたものを全部リストに入れる
                List<string> type = new List<string>();                         // アーキタイプ リスト

                // アーキタイプを検索する
                // 検索対象 アーキタイプ(ファイルから取り出す)
                StreamReader sr = new StreamReader("アーキタイプ\\" + deckclass_wk + ".txt", Encoding.GetEncoding("UTF-8"));

                while (sr.Peek() != -1)
                {   // 中身全部読む
                    type.Add(sr.ReadLine());                                    // リストに入れる
                }
                sr.Close();                                                     // 閉じる

                // ここで、typeには、検索中クラスのアーキタイプが全部入っている
                foreach (string SERCH_type in type)
                { // リストから全アーキタイプ検索
                    List<Deck> works = decks.FindAll(delegate (Deck A) { return (A.Class == deckclass_wk) && (A.Archetype == SERCH_type); });
                    // クラスとアーキタイプが一致するものを抜き出す(数を把握するため)

                    if (works.Count() == 0)
                    {   // 1個もない
                        continue;                                               // 次のループへ
                    }

                    // 割合算出用リストに入れる
                    // クラス・アーキタイプ・戦った数 どのケースをみてもクラスとアーキタイプは同じなので、代表として[0]をみる 
                    // また、[1]以降は入ってない可能性もあるため
                    PercentDeck Perwork = new PercentDeck();                    // 一時エリア
                    Perwork.Class = works[0].Class;
                    Perwork.Archetype = works[0].Archetype;
                    Perwork.BattleCount = works.Count();

                    PerDecks.Add(Perwork);                                      // 割合算出用リストに入れる
                }
            }

            // PerDecksには、各クラス/アーキタイプと、戦った数が入っている
            // 中を全部見て、それぞれの比率を計算
            foreach (PercentDeck Perdeck in PerDecks)
            {
                Scope work = new Scope();                                       // 一時エリア
                work.per = Perdeck.Percent(sum);                                // 全体との比率
                work.ClassName = Perdeck.Class;         // クラス
                work.TypeName = Perdeck.Archetype;     // アーキタイプ

                BattleMan.scopes.Add(work);                                               // リストに入れる(form2で使用)
            }

            string title;          // タイトル名
            if( BackTime == -1)
            {   // 全日指定
                title = "環境全日";
            }
            else
            {   // 範囲指定あり
                title = BackTime + "日前まで";
            }

            PieChart pie = new PieChart();                                    // フォーム２のインスタンス
            pie.Text = EnvName + " (" + title + ")";                          // フォーム２のウィンドウ名を環境名にする
            pie.Show();                                                       // モーダレスダイアログとして出す

            // 表示後は、割合情報はクリア (もう一度解析したときにゴミが残らないように、消す)
            BattleMan.scopes.Clear();                                                     // リストクリア
        }

        static public void BackColor_Reset(GroupBox groupBox)
        {   // 画像の背景色をリセットする。
            // グループボックスの中は、全部 pictureboxなのが前提。
            foreach (Control control in groupBox.Controls)
            {
                control.BackColor = Color.Empty;        // 背景色なし
            }
        }

    }
}
