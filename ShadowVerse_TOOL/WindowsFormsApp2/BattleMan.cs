using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Battle_Manage
{
    public partial class BattleMan : Form
    {
        public static List<Scope> scopes    = new List<Scope>();                // 解析用リスト
        public static string EnvName = "";                            // 環境名
        public List<BattleDeck>   Mydecks   = new List<BattleDeck>();           // 使用デッキのリスト
        public List<BattleDeck>   Opendecks = new List<BattleDeck>();           // 相手デッキのリスト

        private int Myindex                 = new int();                        // 現在使用中デッキのインデックス番号
        private int Openindex               = new int();                        // 現在使用されているデッキのインデックス番号

        private string MyDeckClass_WK = "";         // 自分デッキクラス
        private string OpenDeckClass_WK = "";       // 相手デッキクラス
        private string MyDeckType_WK = "";          // 自分デッキアーキタイプ
        private string OpenDeckType_WK = "";        // 相手デッキアーキタイプ
        public BattleMan()
        {
            InitializeComponent();

            // 環境の入力欄に、前回入力文字をデフォルトとして入力する
            // イベントハンドラの追加
            EnvironBox.KeyDown += Environ_KeyDown;
            if (File.Exists("DATA\\Environment.txt") == true)
            { // ファイルあり
                StreamReader sr = new StreamReader("DATA\\Environment.txt", Encoding.GetEncoding("UTF-8"));
                EnvironBox.Text = sr.ReadLine();                                // 最初の行の内容を書き込み
                EnvName = EnvironBox.Text;                                      // 環境名セット
                sr.Close();
            }
        }

        private void Environ_KeyDown(object sender, KeyEventArgs e)
        {   // 環境入力ボックス
            // エンターが押されたら、入力文字をファイルに覚えておく

            if (e.KeyCode == Keys.Enter)
            {   // エンターキー押下
                e.SuppressKeyPress = true;                                      // エンターを押したときのビープ音抑止
                StreamWriter sw    = new StreamWriter("DATA\\Environment.txt", false, Encoding.GetEncoding("UTF-8"));
                                                                                // 上書きモード
                sw.WriteLine(EnvironBox.Text);                                  // ファイルに1行書く
                EnvName = EnvironBox.Text;                                      // 環境名をセット
                sw.Close();
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void MyDeckClass_SelectedIndexChanged(object sender, EventArgs e)
        {   // 自分のデッキクラス

            //// アーキタイプコンボボックスに項目追加
            //MyDeckType.Items.Clear();                                           // コンボボックスの中を初期化
            //object deckclass = MyDeckClass.SelectedItem;                        // 選択中のデッキクラス
            //Sub.AddCombo(this.MyDeckType, deckclass);                           // コンボボックスの選択肢セット
        }

        private void MyDeckType_SelectedIndexChanged(object sender, EventArgs e)
        {   // 自分デッキアーキタイプ

        }

        private void OpenDeckType_SelectedIndexChanged(object sender, EventArgs e)
        {   // 相手デッキアーキタイプ
            // 項目の追加
        }


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {   // 先攻後攻の入力

        }

        private void button2_Click(object sender, EventArgs e)
        {   // 結果登録ボタン

            //String FirstSecond;                                                 // 先攻後攻
            //String WinLose;                                                     // 勝敗

            //// 先攻後攻・勝敗が入力されてるか
            //if( (First.Checked==false) && (Second.Checked == false) )
            //{   // 選択されていない
            //    MessageBox.Show("先攻/後攻を選択してください");
            //    return;                                                         // 終了
            //}

            //if( (Win.Checked==false) && (Lose.Checked==false) )
            //{   // 選択されていない
            //    MessageBox.Show("勝敗を選択してください");
            //    return;                                                         // 終了
            //}

            //if(EnvironBox.Text == "")
            //{   // 環境が入力されていない
            //    MessageBox.Show("環境欄を入力してください");
            //    return;                                                         // 終了
            //}

            //// クラスとアーキタイプから、デッキのインスタンスを生成する
            //BattleDeck _mydeck = new BattleDeck();
            //BattleDeck _opendeck = new BattleDeck();

            //// デッキクラスは、イメージ画像選択時にセットしてあるのでコピー
            //_mydeck.Class = MyDeckClass_WK;                 // 自デッキクラスコピー
            //_mydeck.Archetype = MyDeckType_WK;                    // 自デッキアーキタイプコピー
            //_opendeck.Class = OpenDeckClass_WK;         // 相手デッキクラスコピー
            //_opendeck.Archetype = OpenDeckType_WK;                  // 相手デッキアーキタイプコピー

            //// クラスとアーキタイプが同じものがないなら、リストに追加
            //if (Mydecks.Any(delegate (BattleDeck A) { return ((A.Class == _mydeck.Class) && (A.Archetype == _mydeck.Archetype)); }) == false)
            //{   // かぶりなし
            //    if ((_mydeck.Class != "") && (_mydeck.Archetype != ""))
            //    {   // 空白でない
            //        Mydecks.Add(_mydeck);                                   // 自分のデッキリストに登録
            //        Myindex = Mydecks.IndexOf(_mydeck);                     // インデックス番号を取得する
            //    }
            //}
            //else
            //{   // かぶり
            //    // すでにリストに登録されているので、登録済みの中からインデックス番号を取得
            //    BattleDeck __mydeck = new BattleDeck();
            //    __mydeck = Mydecks.Find(delegate (BattleDeck A) { return ((A.Class == _mydeck.Class) && (A.Archetype == _mydeck.Archetype)); });
            //    // 登録済みの中から検索
            //    Myindex = Mydecks.IndexOf(__mydeck);                        // インデックス番号を取得する
            //}

            //if (Opendecks.Any(delegate (BattleDeck A) { return ((A.Class == _opendeck.Class) && (A.Archetype == _opendeck.Archetype)); }) == false)
            //{   // かぶりなし
            //    if ((_opendeck.Class != "") && (_opendeck.Archetype != ""))
            //    {   // 空白でない
            //        Opendecks.Add(_opendeck);                               // 相手デッキリストに登録
            //        Openindex = Opendecks.IndexOf(_opendeck);               // インデックス番号を取得する
            //    }
            //}
            //else
            //{   // かぶり
            //    // すでにリストに登録されているので、登録済みの中からインデックス番号を取得
            //    BattleDeck __opendeck = new BattleDeck();
            //    __opendeck = Opendecks.Find(delegate (BattleDeck A) { return ((A.Class == _opendeck.Class) && (A.Archetype == _opendeck.Archetype)); });
            //    // 登録済みの中から検索
            //    Openindex = Opendecks.IndexOf(__opendeck);                  // インデックス番号を取得する
            //}

            //// 先攻後攻・勝敗の確認
            //if (First.Checked == true)
            //{   // 先攻
            //    FirstSecond = "先攻";
            //}
            //else
            //{
            //    FirstSecond = "後攻";
            //}

            //if(Win.Checked == true)
            //{
            //    WinLose = "勝ち";
            //    Mydecks[Myindex].WinCount++;                                    // 勝ち数+1
            //}
            //else
            //{
            //    WinLose = "負け";
            //    Mydecks[Myindex].LoseCount++;                                   // 負け数+1
            //}

            //// 戦績ファイルへの書き込み
            //Sub.MemoryRegist(Mydecks[Myindex], Opendecks[Openindex], FirstSecond, WinLose, EnvironBox.Text);

            //// 画面の戦績を更新する
            //WinCount.Text   = "勝ち:"  + Mydecks[Myindex].WinCount;              // 今設定しているデッキの勝ち数
            //LoseCount.Text  = "負け:" + Mydecks[Myindex].LoseCount;              // 今設定しているデッキの負け数

            //// 入力項目をクリア
            //First.Checked      = false;
            //Second.Checked     = false;
            //Win.Checked        = false;
            //Lose.Checked       = false;
        }

        private void UTIWAKE_Click(object sender, EventArgs e)
        {   // 内訳ボタン

        }


        private void Scope_Click(object sender, EventArgs e)
        {   // 解析ボタン
            Sub.Scope_Make( -1, EnvName);                           // 解析情報を表示する(環境全日指定)
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Environ_TextChanged(object sender, EventArgs e)
        {
        }
        private void Environ_Enter(object sender, EventArgs e)
        {
        }

        private void Howto_Click(object sender, EventArgs e)
        {   // 使い方を表示する
            if (File.Exists("HowtoUse.txt") == true)
            { // ファイルあり
                Process.Start("HowtoUse.txt");                                  // テキストファイルを表示
            }
        }

        private void memo_Click(object sender, EventArgs e)
        {   // メモを表示する
            if (File.Exists("memo.txt") == true)
            { // ファイルあり
                Process.Start("memo.txt");                                      // テキストファイルを表示
            }

        }

        private void LoseCount_Click(object sender, EventArgs e)
        {

        }

        private void Detail_Click(object sender, EventArgs e)
        {   // 詳細をみるボタン
            // 画面に表示している戦績が、〇に対して〇勝... というのを表示する

            // 環境をコンストラクタへ     自デッキ入力 相手デッキ入力で、その相手との〇勝〇敗を出す
            //                            自デッキのみ入力で、トータルの〇勝〇敗を出す(その自デッキでバトルしたときの戦績)
            //                            相手デッキのみ入力で、トータルの〇勝〇敗を出す(その相手とバトルしたときの戦績)
            //                            戦績のインポート機能？JCG結果とかから、それはデッキ分布のほうか。。。
            //                            
            //                            円グラフの画面からも起動できるようにする そのときは、トップデッキを相手デッキに指定した状態を
            //                            デフォルトにする 知りたいのは、[今のトップデッキに有利なのは？]
            DetailForm detailForm = new DetailForm(MyDeckClass_WK, MyDeckType_WK);
            detailForm.Text = EnvironBox.Text + "環境の戦績";   // タイトル設定
            detailForm.Show();                           // 表示

        }

        private void Env_Click(object sender, EventArgs e)
        {
        }

        private void TypeRegButton_Click(object sender, EventArgs e)
        {   // アーキタイプ登録のフォルダを開く
            AddDeckType form = new AddDeckType();
            form.ShowDialog();
            form.Close();

            // 表示中のアーキタイプは出し直し
            Sub.AddList(MyTYPE_listBox, MyDeckClass_WK);    // 自分
            Sub.AddList(OpenType_listBox, OpenDeckClass_WK); // 相手

            return;
        }

        private void MirrorButton_Click(object sender, EventArgs e)
        {   // ミラーボタン

            // 相手デッキを自分デッキと同じに設定
            OpenDeckClass_WK = MyDeckClass_WK;
            OpenDeckType_WK = MyDeckType_WK;
            OpenType_listBox.Items.Add("ミラー");                  // リストボックスに表示
        }

        private void E_pictureBox_Click(object sender, EventArgs e)
        {   // 自デッキはエルフ
            MyDeckClass_WK = "エルフ";
            Sub.AddList(MyTYPE_listBox, "エルフ");

            Sub.BackColor_Reset(MyDeck_groupBox);               // 他コントロールの背景色クリア
            E_pictureBox.BackColor = Color.Red;
        }

        private void L_pictureBox_Click(object sender, EventArgs e)
        {   // 自デッキはロイヤル
            MyDeckClass_WK = "ロイヤル";
            Sub.AddList(MyTYPE_listBox, "ロイヤル");

            Sub.BackColor_Reset(MyDeck_groupBox);               // 他コントロールの背景色クリア
            L_pictureBox.BackColor = Color.Red;
        }

        private void W_pictureBox_Click(object sender, EventArgs e)
        {   // 自デッキはウィッチ
            MyDeckClass_WK = "ウィッチ";
            Sub.AddList(MyTYPE_listBox, "ウィッチ");

            Sub.BackColor_Reset(MyDeck_groupBox);               // 他コントロールの背景色クリア
            W_pictureBox.BackColor = Color.Red;
        }

        private void D_pictureBox_Click(object sender, EventArgs e)
        {   // 自デッキはドラゴン
            MyDeckClass_WK = "ドラゴン";
            Sub.AddList(MyTYPE_listBox, "ドラゴン");

            Sub.BackColor_Reset(MyDeck_groupBox);               // 他コントロールの背景色クリア
            D_pictureBox.BackColor = Color.Red;
        }

        private void NC_pictureBox_Click(object sender, EventArgs e)
        {   // 自デッキはネクロ 
            MyDeckClass_WK = "ネクロマンサー";
            Sub.AddList(MyTYPE_listBox, "ネクロマンサー");

            Sub.BackColor_Reset(MyDeck_groupBox);               // 他コントロールの背景色クリア
            NC_pictureBox.BackColor = Color.Red;
        }

        private void V_pictureBox_Click(object sender, EventArgs e)
        {   // 自デッキはヴァンパイア
            MyDeckClass_WK = "ヴァンパイア";
            Sub.AddList(MyTYPE_listBox, "ヴァンパイア");

            Sub.BackColor_Reset(MyDeck_groupBox);               // 他コントロールの背景色クリア
            V_pictureBox.BackColor = Color.Red;
        }

        private void B_pictureBox_Click(object sender, EventArgs e)
        {   // 自デッキはビショップ
            MyDeckClass_WK = "ビショップ";
            Sub.AddList(MyTYPE_listBox, "ビショップ");

            Sub.BackColor_Reset(MyDeck_groupBox);               // 他コントロールの背景色クリア
            B_pictureBox.BackColor = Color.Red;
        }

        private void NM_pictureBox_Click(object sender, EventArgs e)
        {   // 自デッキはネメシス
            MyDeckClass_WK = "ネメシス";
            Sub.AddList(MyTYPE_listBox, "ネメシス");

            Sub.BackColor_Reset(MyDeck_groupBox);               // 他コントロールの背景色クリア
            NM_pictureBox.BackColor = Color.Red;
        }

        private void E_pictureBox_open_Click(object sender, EventArgs e)
        {   // 相手デッキはエルフ
            OpenDeckClass_WK = "エルフ";
            Sub.AddList(OpenType_listBox, "エルフ");

            Sub.BackColor_Reset(OpenDeck_groupBox);               // 他コントロールの背景色クリア
            E_pictureBox_open.BackColor = Color.Red;
        }

        private void L_pictureBox_open_Click(object sender, EventArgs e)
        {   // 相手デッキはロイヤル
            OpenDeckClass_WK = "ロイヤル";
            Sub.AddList(OpenType_listBox, "ロイヤル");

            Sub.BackColor_Reset(OpenDeck_groupBox);               // 他コントロールの背景色クリア
            L_pictureBox_open.BackColor = Color.Red;
        }

        private void W_pictureBox_open_Click(object sender, EventArgs e)
        {   // 相手デッキはウィッチ
            OpenDeckClass_WK = "ウィッチ";
            Sub.AddList(OpenType_listBox, "ウィッチ");

            Sub.BackColor_Reset(OpenDeck_groupBox);               // 他コントロールの背景色クリア
            W_pictureBox_open.BackColor = Color.Red;
        }

        private void D_pictureBox_open_Click(object sender, EventArgs e)
        {   // 相手デッキはドラゴン
            OpenDeckClass_WK = "ドラゴン";
            Sub.AddList(OpenType_listBox, "ドラゴン");

            Sub.BackColor_Reset(OpenDeck_groupBox);               // 他コントロールの背景色クリア
            D_pictureBox_open.BackColor = Color.Red;
        }

        private void NC_pictureBox_open_Click(object sender, EventArgs e)
        {   // 相手デッキはネクロ
            OpenDeckClass_WK = "ネクロマンサー";
            Sub.AddList(OpenType_listBox, "ネクロマンサー");

            Sub.BackColor_Reset(OpenDeck_groupBox);               // 他コントロールの背景色クリア
            NC_pictureBox_open.BackColor = Color.Red;
        }

        private void V_pictureBox_open_Click(object sender, EventArgs e)
        {   // 相手デッキはヴァンパイア
            OpenDeckClass_WK = "ヴァンパイア";
            Sub.AddList(OpenType_listBox, "ヴァンパイア");

            Sub.BackColor_Reset(OpenDeck_groupBox);               // 他コントロールの背景色クリア
            V_pictureBox_open.BackColor = Color.Red;
        }

        private void B_pictureBox_open_Click(object sender, EventArgs e)
        {   // 相手デッキはビショップ
            OpenDeckClass_WK = "ビショップ";
            Sub.AddList(OpenType_listBox, "ビショップ");

            Sub.BackColor_Reset(OpenDeck_groupBox);               // 他コントロールの背景色クリア
            B_pictureBox_open.BackColor = Color.Red;
        }

        private void NM_pictureBox_open_Click(object sender, EventArgs e)
        {   // 相手デッキはネメシス
            OpenDeckClass_WK = "ネメシス";
            Sub.AddList(OpenType_listBox, "ネメシス");

            Sub.BackColor_Reset(OpenDeck_groupBox);               // 他コントロールの背景色クリア
            NM_pictureBox_open.BackColor = Color.Red;
        }

        private void MyTYPE_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MyTYPE_listBox.SelectedItem != null)
            {   // 選択アイテムあり
                MyDeckType_WK = MyTYPE_listBox.SelectedItem.ToString();
            }
        }

        private void OpenType_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OpenType_listBox.SelectedItem != null)
            { // 選択アイテムあり
                OpenDeckType_WK = OpenType_listBox.SelectedItem.ToString();
            }
        }


        private void Regist(string WinLose)
        {   // 結果登録のサブ

            String FirstSecond;                                                 // 先攻後攻

            // デッキ選択されているか
            // 選択済みのクラスは背景色が変わっているので、それで判断する
            // 自デッキクラス
            bool chkflg = false;         // チェック用フラグ
            foreach( Control control in MyDeck_groupBox.Controls)
            {
                if(control.BackColor != Color.Empty)
                {   // 色が変わってるのがあればOK
                    chkflg = true;
                }
            }

            // 相手デッキクラス
            bool chkflg2 = false;
            foreach (Control control in OpenDeck_groupBox.Controls)
            {
                if (control.BackColor != Color.Empty)
                {   // 色が変わってるのがあればOK
                    chkflg2 = true;
                }
            }

            // 自デッキアーキタイプ
            bool chkflg3 = false;
            if(MyTYPE_listBox.SelectedIndex > -1)
            {   // 選択ありならOK
                chkflg3 = true;
            }

            // 相手デッキアーキタイプ
            bool chkflg4 = false;
            if(OpenType_listBox.SelectedIndex > -1)
            {   // 選択ありならOK
                chkflg4 = true;
            }


            if ( ( chkflg && chkflg2 && chkflg3 && chkflg4 ) == false)
            {   // 一つでもfalseがある
                MessageBox.Show("デッキを入力してください");
                return;                                                         // 終了
            }


            if (EnvironBox.Text == "")
            {   // 環境が入力されていない
                MessageBox.Show("環境欄を入力してください");
                return;                                                         // 終了
            }

            // 先攻後攻・勝敗が入力されてるか
            if ((First.Checked == false) && (Second.Checked == false))
            {   // 選択されていない
                MessageBox.Show("先攻/後攻を選択してください");
                return;                                                         // 終了
            }

            // クラスとアーキタイプから、デッキのインスタンスを生成する
            BattleDeck _mydeck = new BattleDeck();
            BattleDeck _opendeck = new BattleDeck();

            // デッキクラスは、イメージ画像選択時にセットしてあるのでコピー
            _mydeck.Class = MyDeckClass_WK;                 // 自デッキクラスコピー
            _mydeck.Archetype = MyDeckType_WK;                    // 自デッキアーキタイプコピー
            _opendeck.Class = OpenDeckClass_WK;         // 相手デッキクラスコピー
            _opendeck.Archetype = OpenDeckType_WK;                  // 相手デッキアーキタイプコピー

            // クラスとアーキタイプが同じものがないなら、リストに追加
            if (Mydecks.Any(delegate (BattleDeck A) { return ((A.Class == _mydeck.Class) && (A.Archetype == _mydeck.Archetype)); }) == false)
            {   // かぶりなし
                if ((_mydeck.Class != "") && (_mydeck.Archetype != ""))
                {   // 空白でない
                    Mydecks.Add(_mydeck);                                   // 自分のデッキリストに登録
                    Myindex = Mydecks.IndexOf(_mydeck);                     // インデックス番号を取得する
                }
            }
            else
            {   // かぶり
                // すでにリストに登録されているので、登録済みの中からインデックス番号を取得
                BattleDeck __mydeck = new BattleDeck();
                __mydeck = Mydecks.Find(delegate (BattleDeck A) { return ((A.Class == _mydeck.Class) && (A.Archetype == _mydeck.Archetype)); });
                // 登録済みの中から検索
                Myindex = Mydecks.IndexOf(__mydeck);                        // インデックス番号を取得する
            }

            if (Opendecks.Any(delegate (BattleDeck A) { return ((A.Class == _opendeck.Class) && (A.Archetype == _opendeck.Archetype)); }) == false)
            {   // かぶりなし
                if ((_opendeck.Class != "") && (_opendeck.Archetype != ""))
                {   // 空白でない
                    Opendecks.Add(_opendeck);                               // 相手デッキリストに登録
                    Openindex = Opendecks.IndexOf(_opendeck);               // インデックス番号を取得する
                }
            }
            else
            {   // かぶり
                // すでにリストに登録されているので、登録済みの中からインデックス番号を取得
                BattleDeck __opendeck = new BattleDeck();
                __opendeck = Opendecks.Find(delegate (BattleDeck A) { return ((A.Class == _opendeck.Class) && (A.Archetype == _opendeck.Archetype)); });
                // 登録済みの中から検索
                Openindex = Opendecks.IndexOf(__opendeck);                  // インデックス番号を取得する
            }

            // 先攻後攻・勝敗の確認
            if (First.Checked == true)
            {   // 先攻
                FirstSecond = "先攻";
            }
            else
            {
                FirstSecond = "後攻";
            }

            //if (Win.Checked == true)
            //{
            //    WinLose = "勝ち";
            //    Mydecks[Myindex].WinCount++;                                    // 勝ち数+1
            //}
            //else
            //{
            //    WinLose = "負け";
            //    Mydecks[Myindex].LoseCount++;                                   // 負け数+1
            //}

            if(WinLose == "勝ち")
            {   // 勝ち
                Mydecks[Myindex].WinCount++;                                    // 勝ち数+1
            }
            else
            {   // 負け
                Mydecks[Myindex].LoseCount++;                                   // 負け数+1
            }

            // 戦績ファイルへの書き込み
            Sub.MemoryRegist(Mydecks[Myindex], Opendecks[Openindex], FirstSecond, WinLose, EnvironBox.Text);

            // 画面の戦績を更新する
            WinCount.Text = "勝ち:" + Mydecks[Myindex].WinCount;              // 今設定しているデッキの勝ち数
            LoseCount.Text = "負け:" + Mydecks[Myindex].LoseCount;              // 今設定しているデッキの負け数

            // 入力項目をクリア
            // 自分のデッキ欄はクリアしない。
            First.Checked = false;
            Second.Checked = false;
            OpenType_listBox.Items.Clear();
            Sub.BackColor_Reset(OpenDeck_groupBox);
        }

        private void Win_CheckedChanged(object sender, EventArgs e)
        {   // 勝ち 入力
            if (Win.Checked == true)
            { // チェック外したときは登録しないため
                Regist("勝ち");               // 結果登録 (まだラジオボタンにチェック入ってないため、引数で渡す)
            }
            Win.Checked = false;            // チェック外す
        }

        private void Lose_CheckedChanged(object sender, EventArgs e)
        {   // 負け 入力
            if (Lose.Checked == true)
            { // チェック外したときは登録しないため
                Regist("負け");                   // 結果登録 (まだラジオボタンにチェック入ってないため、引数で渡す)
            }
            Lose.Checked = false;             // チェック外す
        }

    }


}

