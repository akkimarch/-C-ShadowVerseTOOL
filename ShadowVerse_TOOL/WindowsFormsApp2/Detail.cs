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
using System.Diagnostics;

enum 詳細モード
{
    自デッキのみ, 相手デッキのみ, 自分と相手
}

namespace Battle_Manage
{
    public partial class DetailForm : Form
    {
        private string MyDeckClass_WK = "";         // 自分デッキクラス
        private string OpenDeckClass_WK = "";       // 相手デッキクラス
        private string MyDeckType_WK = "";          // 自分デッキアーキタイプ
        private string OpenDeckType_WK = "";        // 相手デッキアーキタイプ

        public DetailForm()
        {
            InitializeComponent();
        }

        public DetailForm(String ClassName, String TypeName)
        {
            InitializeComponent();

            // デフォルトとして設定
            int nFrame = 1; // フレーム数(1は直接呼び出したスレッド）
            StackFrame objStackFrame = new StackFrame(nFrame);      // StackFrameクラスのインスタンス化
            string strMethodName = objStackFrame.GetMethod().Name;  // 呼び元のメソッド名

            if (strMethodName == "Detail_Click")
            {   // メイン画面からの起動
                MyDeckClass_WK = ClassName;
                MyDeckType_WK = TypeName;

                // 画像に背景色設定、リストボックスにクラス名設定
                // クラス名から、どのpictureboxか
                BackColor_Set(1, MyDeck_groupBox, MyDeckClass_WK);      // 画像に背景色設定
                MyTYPE_listBox.Items.Add(MyDeckType_WK);            // リストボックスにクラス名設定
            }
            else
            {   // メイン画面以外(円グラフ画面)からの起動
                OpenDeckClass_WK = ClassName;
                OpenDeckType_WK = TypeName;

                // 画像に背景色設定、リストボックスにクラス名設定
                BackColor_Set(2, OpenDeck_groupBox, OpenDeckClass_WK);      // 画像に背景色設定
                OpenType_listBox.Items.Add(OpenDeckType_WK);            // リストボックスにクラス名設定
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void OKbutton_Click(object sender, EventArgs e)
        {   // OKボタン押下時

            // モードの判別
            // ①[自デッキ]でバトルした、[全相手デッキ]への戦績を表示          自デッキのみ入力されている場合
            // ②[相手デッキ]とバトルした、[全自デッキ]の戦績を表示            相手デッキのみ入力されている場合
            // ③[自デッキ-相手デッキ]の戦績を表示                             両方入力されている場合

            if (ResultListview.Items.Count != 0)
            { // 登録あり
                ResultListview.Items.Clear();
            }

            詳細モード _mode = 0;                                           // モード
            if( (MyDeckClass_WK == "") || (MyDeckType_WK == "") )
            {   // 自デッキ内容に空あり
                _mode = 詳細モード.相手デッキのみ;
            }
            else if( (OpenDeckClass_WK == "") || (OpenDeckType_WK == ""))
            {   // 相手デッキ内容に空あり
                _mode = 詳細モード.自デッキのみ;
            }
            else
            {   // 両方入力あり
                _mode = 詳細モード.自分と相手;
            }

            XElement xml = XElement.Load("DATA\\BattleLog.xml");
            IEnumerable<XElement> infos = from item in xml.Elements("SENSEKI") select item;
            List<BattleDeck> decks = new List<BattleDeck>();                     // デッキリスト
            string ret = ("結果\n");                                              // 結果文字列
            double FirstWinPer = 0.0;           // 先攻勝率
            double SecondWinPer = 0.0;          // 後攻勝率

            switch (_mode)
            {   // 詳細モードで分岐
                case 詳細モード.自デッキのみ:
                    // 自分デッキとバトルした相手デッキを全て抜き出す

                    foreach (XElement info in infos)
                    {   // 取得したSENSEKIタグの中身を全部洗う
                        if ((info.Element("MYCLASS").Value != MyDeckClass_WK) || (info.Element("MYTYPE").Value != MyDeckType_WK))
                        {   // 条件に合致しない場合はリストに入れない
                            continue;
                        }

                        BattleDeck work = new BattleDeck();                          // 一時エリア
                        work.Class = info.Element("OPENCLASS").Value;             // クラスを一時エリアへ
                        work.Archetype = info.Element("OPENTYPE").Value;              // アーキタイプを一時エリアへ

                        if (decks.Any(delegate (BattleDeck A) { return (A.Class == work.Class) && (A.Archetype == work.Archetype); }) == true)
                        {   // すでに登録済み
                            int index = decks.FindIndex(delegate (BattleDeck A) { return (A.Class == work.Class) && (A.Archetype == work.Archetype); });
                            // 登録済み領域のインデックス番号を取得

                            // 勝ち数、負け数登録
                            if (info.Element("WINLOSE").Value == "勝ち")
                            {
                                decks[index].WinCount++;                                              // 勝ち数+1

                                if (info.Element("SAKIATO").Value == "先攻")
                                {   // 先攻の数を数える
                                    decks[index].FirstWinCount++;           // 先攻の数
                                }
                                else
                                {   // 後攻の数を数える
                                    decks[index].SecondWinCount++;          // 後攻の数
                                }

                            }
                            else if (info.Element("WINLOSE").Value == "負け")
                            {
                                decks[index].LoseCount++;                                             // 負け数+1
                            }

                        }
                        else
                        {   // 未登録
                            // 勝ち負け登録
                            if (info.Element("WINLOSE").Value == "勝ち")
                            {
                                work.WinCount++;                                              // 勝ち数+1

                                if (info.Element("SAKIATO").Value == "先攻")
                                {   // 先攻の数を数える
                                    work.FirstWinCount++;           // 先攻の数
                                }
                                else
                                {   // 後攻の数を数える
                                    work.SecondWinCount++;          // 後攻の数
                                }

                            }
                            else if (info.Element("WINLOSE").Value == "負け")
                            {
                                work.LoseCount++;                                             // 負け数+1
                            }


                            // リストに入れる
                            decks.Add(work);
                        }
                    }

                    ret += MyDeckClass_WK + "[" + MyDeckType_WK + " ]" + "で対戦したデッキ" + "\n\n";
                    // 文字列をつなげる
                    foreach (BattleDeck battleDeck in decks)
                    {
                        // 先攻勝率と後攻勝率を求める
                        if ( battleDeck.WinCount != 0)
                        { // 0勝の時は算出しない
                            FirstWinPer = Math.Round(battleDeck.FirstWinCount / (double)battleDeck.WinCount, 2, MidpointRounding.AwayFromZero)*100;
                            SecondWinPer = Math.Round(battleDeck.SecondWinCount / (double)battleDeck.WinCount, 2, MidpointRounding.AwayFromZero)*100;
                        }
                        else
                        {
                            FirstWinPer  = 0.0;
                            SecondWinPer = 0.0;
                        }

                        ResultListview.Items.Add("");
                        // 使用デッキ
                        ResultListview.Items[ResultListview.Items.Count-1].Text = MyDeckClass_WK + "[" + MyDeckType_WK +"]";
                        // 相手デッキ
                        ResultListview.Items[ResultListview.Items.Count-1].SubItems.Add(battleDeck.Class + "[" + battleDeck.Archetype +"]");
                        // 勝敗
                        ResultListview.Items[ResultListview.Items.Count - 1].SubItems.Add(battleDeck.WinCount+"勝"+ battleDeck.LoseCount+"敗");

                        // 勝った時先攻だった比率
                        if (battleDeck.WinCount != 0)
                        { // 勝利あり
                            ResultListview.Items[ResultListview.Items.Count - 1].SubItems.Add(FirstWinPer.ToString() + "%");
                        }
                        else
                        {   // 勝利なし
                            ResultListview.Items[ResultListview.Items.Count - 1].SubItems.Add("-");
                        }
                    }
                    break;

                case 詳細モード.相手デッキのみ:
                    // 相手デッキとバトルした自デッキを全て抜き出す

                    foreach (XElement info in infos)
                    {   // 取得したSENSEKIタグの中身を全部洗う
                        if ((info.Element("OPENCLASS").Value != OpenDeckClass_WK) || (info.Element("OPENTYPE").Value != OpenDeckType_WK))
                        { // 条件に合致しない場合はリストに入れない
                            continue;
                        }

                        BattleDeck work = new BattleDeck();                          // 一時エリア

                        work.Class = info.Element("MYCLASS").Value;                // クラスを一時エリアへ
                        work.Archetype = info.Element("MYTYPE").Value;             // アーキタイプを一時エリアへ


                        if ( decks.Any(delegate (BattleDeck A) { return (A.Class == work.Class) && (A.Archetype == work.Archetype); }) == true )
                        {   // すでに登録済み

                            int index = decks.FindIndex(delegate (BattleDeck A) { return (A.Class == work.Class) && (A.Archetype == work.Archetype); });
                            // 登録済み領域のインデックス番号を取得

                            // 勝ち数、負け数登録
                            if (info.Element("WINLOSE").Value == "勝ち")
                            {
                                decks[index].WinCount++;                                              // 勝ち数+1

                                if (info.Element("SAKIATO").Value == "先攻")
                                {   // 先攻の数を数える
                                    decks[index].FirstWinCount++;           // 先攻の数
                                }
                                else
                                {   // 後攻の数を数える
                                    decks[index].SecondWinCount++;          // 後攻の数
                                }

                            }
                            else if (info.Element("WINLOSE").Value == "負け")
                            {
                                decks[index].LoseCount++;                                             // 負け数+1
                            }

                        }
                        else
                        {   // 未登録

                            // 勝ち負け登録
                            if (info.Element("WINLOSE").Value == "勝ち")
                            {
                                work.WinCount++;                                              // 勝ち数+1

                                if (info.Element("SAKIATO").Value == "先攻")
                                {   // 先攻の数を数える
                                    work.FirstWinCount++;            // 先攻の数
                                }
                                else
                                {   // 後攻の数を数える
                                    work.SecondWinCount++;          // 後攻の数
                                }

                            }
                            else if (info.Element("WINLOSE").Value == "負け")
                            {
                                work.LoseCount++;                                             // 負け数+1
                            }


                            // リストに入れる
                            decks.Add(work);
                        }
                    }

                    ret += OpenDeckClass_WK + "[" + OpenDeckType_WK + " ]" + "と対戦したデッキ" + "\n\n";
                    // 文字列をつなげる
                    foreach (BattleDeck battleDeck in decks)
                    {
                        // 先攻勝率と後攻勝率を求める
                        if (battleDeck.WinCount != 0)
                        { // 0勝の時は算出しない
                            FirstWinPer = Math.Round(battleDeck.FirstWinCount / (double)battleDeck.WinCount, 2, MidpointRounding.AwayFromZero) * 100;
                            SecondWinPer = Math.Round(battleDeck.SecondWinCount / (double)battleDeck.WinCount, 2, MidpointRounding.AwayFromZero) * 100;
                        }
                        else
                        {
                            FirstWinPer = 0.0;
                            SecondWinPer = 0.0;
                        }

                        ResultListview.Items.Add("");
                        // 自分デッキ
                        ResultListview.Items[ResultListview.Items.Count - 1].Text = battleDeck.Class + "[" + battleDeck.Archetype + "]";
                        // 相手デッキ
                        ResultListview.Items[ResultListview.Items.Count - 1].SubItems.Add(OpenDeckClass_WK + "[" + OpenDeckType_WK + "]");
                        // 勝敗
                        ResultListview.Items[ResultListview.Items.Count - 1].SubItems.Add(battleDeck.WinCount + "勝" + battleDeck.LoseCount + "敗");

                        // 勝った時先攻だった比率
                        if (battleDeck.WinCount != 0)
                        { // 勝利あり
                            ResultListview.Items[ResultListview.Items.Count - 1].SubItems.Add(FirstWinPer.ToString() + "%");
                        }
                        else
                        {   // 勝利なし
                            ResultListview.Items[ResultListview.Items.Count - 1].SubItems.Add("-");
                        }
                        // 勝った時後攻だった比率
                        ResultListview.Items[ResultListview.Items.Count - 1].SubItems.Add(SecondWinPer.ToString() + "%");

                    }
                    break;

                case 詳細モード.自分と相手:
                    // 自デッキ-相手デッキ間の戦績を抜き出す

                    int WinCount = 0;                       // 勝ち数
                    int LoseCount = 0;                      // 負け数
                    int FirstWincount = 0;                  // 先攻で勝った数
                    int SecondWincount = 0;                 // 後攻で勝った数

                    foreach (XElement info in infos)
                    {   // 取得したSENSEKIタグの中身を全部洗う

                        if ((info.Element("MYCLASS").Value != MyDeckClass_WK) || (info.Element("MYTYPE").Value != MyDeckType_WK) &&
                            (info.Element("OPENCLASS").Value != OpenDeckClass_WK) || (info.Element("OPENTYPE").Value != OpenDeckType_WK))
                        {   // 合致しない場合はリストに入れない
                            continue;
                        }


                        // 勝ち数、負け数を数える
                        if (info.Element("WINLOSE").Value == "勝ち")
                        {
                            WinCount++;                                              // 勝ち数+1

                            if (info.Element("SAKIATO").Value == "先攻")
                            {   // 先攻の数を数える
                                FirstWincount++;           // 先攻の数
                            }
                            else
                            {   // 後攻の数を数える
                                SecondWincount++;          // 後攻の数
                            }

                        }
                        else if (info.Element("WINLOSE").Value == "負け")
                        {
                            LoseCount++;                                             // 負け数+1
                        }
                    }

                    // 先攻勝率と後攻勝率を求める
                    if (WinCount != 0)
                    { // 0勝の時は算出しない
                        FirstWinPer = Math.Round(FirstWincount / (double)WinCount, 2, MidpointRounding.AwayFromZero) * 100;
                        SecondWinPer = Math.Round(SecondWincount / (double)WinCount, 2, MidpointRounding.AwayFromZero) * 100;
                    }
                    else
                    {
                        FirstWinPer = 0.0;
                        SecondWinPer = 0.0;
                    }

                    // 文字列をつなげる
                    ResultListview.Items.Add("");
                    // 自分デッキ
                    ResultListview.Items[ResultListview.Items.Count - 1].Text = MyDeckClass_WK + "[" + MyDeckType_WK + "]";
                    // 相手デッキ
                    ResultListview.Items[ResultListview.Items.Count - 1].SubItems.Add(OpenDeckClass_WK + "[" + OpenDeckType_WK + "]");
                    // 勝敗
                    ResultListview.Items[ResultListview.Items.Count - 1].SubItems.Add(WinCount + "勝" + LoseCount + "敗");

                    // 勝った時先攻だった比率
                    if (WinCount != 0)
                    {   // 勝利あり
                        ResultListview.Items[ResultListview.Items.Count - 1].SubItems.Add(FirstWinPer.ToString() + "%");
                    }
                    else
                    {   // 勝利なし
                        ResultListview.Items[ResultListview.Items.Count - 1].SubItems.Add("-");
                    }
                    break;
            }

            // リセット
            MyDeckClass_WK     = "";
            MyDeckType_WK      = "";
            OpenDeckClass_WK   = "";
            OpenDeckType_WK    = "";

        }

        private void result_Click(object sender, EventArgs e)
        {
        }

        private void ResultView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private Deck FormatMake(string DeckClass, string DeckType)
        {   // 戦績を出すのにインデントをそろえた文字列を返す

            // クラスは8文字、アーキタイプは15文字分の幅をとって文字列をつくる
            Deck ret = new Deck();                  // 戻り値用

            string Class_wk = DeckClass;                   // クラス名ワーク
            string Type_wk = DeckType;                   // アーキタイプ名ワーク

            // クラスの文字数調整
            if (DeckClass.Length <= 8)
            {   // 8文字以内の時だけ

                for (int i = DeckClass.Length; i < 8; i++)
                {   // 文字列終わり位置から8文字分まで繰り返し
                    Class_wk += "　";              // 全角スペースで埋める
                }

            }

            if (DeckType.Length <= 12)
            {   // 12文字以内の時だけ

                for (int i = DeckType.Length; i < 12; i++)
                {
                    Type_wk += "　";         // 全角スペースで埋める
                }
            }

            // 戻り値セット
            ret.Class = Class_wk;
            ret.Archetype = Type_wk;

            return ret;
        }

        private void ResultListview_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void E_pictureBox_Click(object sender, EventArgs e)
        {
            MyDeckClass_WK = "エルフ";
            Sub.AddList(MyTYPE_listBox, "エルフ");

            Sub.BackColor_Reset(MyDeck_groupBox);               // 他コントロールの背景色クリア
            E_pictureBox.BackColor = Color.Red;

        }

        private void L_pictureBox_Click(object sender, EventArgs e)
        {
            MyDeckClass_WK = "ロイヤル";
            Sub.AddList(MyTYPE_listBox, "ロイヤル");

            Sub.BackColor_Reset(MyDeck_groupBox);               // 他コントロールの背景色クリア
            L_pictureBox.BackColor = Color.Red;
        }

        private void W_pictureBox_Click(object sender, EventArgs e)
        {
            MyDeckClass_WK = "ウィッチ";
            Sub.AddList(MyTYPE_listBox, "ウィッチ");

            Sub.BackColor_Reset(MyDeck_groupBox);               // 他コントロールの背景色クリア
            W_pictureBox.BackColor = Color.Red;
        }

        private void D_pictureBox_Click(object sender, EventArgs e)
        {
            MyDeckClass_WK = "ドラゴン";
            Sub.AddList(MyTYPE_listBox, "ドラゴン");

            Sub.BackColor_Reset(MyDeck_groupBox);               // 他コントロールの背景色クリア
            D_pictureBox.BackColor = Color.Red;
        }

        private void NC_pictureBox_Click(object sender, EventArgs e)
        {
            MyDeckClass_WK = "ネクロマンサー";
            Sub.AddList(MyTYPE_listBox, "ネクロマンサー");

            Sub.BackColor_Reset(MyDeck_groupBox);               // 他コントロールの背景色クリア
            NC_pictureBox.BackColor = Color.Red;
        }

        private void V_pictureBox_Click(object sender, EventArgs e)
        {
            MyDeckClass_WK = "ヴァンパイア";
            Sub.AddList(MyTYPE_listBox, "ヴァンパイア");

            Sub.BackColor_Reset(MyDeck_groupBox);               // 他コントロールの背景色クリア
            V_pictureBox.BackColor = Color.Red;

        }

        private void B_pictureBox_Click(object sender, EventArgs e)
        {
            MyDeckClass_WK = "ビショップ";
            Sub.AddList(MyTYPE_listBox, "ビショップ");

            Sub.BackColor_Reset(MyDeck_groupBox);               // 他コントロールの背景色クリア
            B_pictureBox.BackColor = Color.Red;

        }

        private void NM_pictureBox_Click(object sender, EventArgs e)
        {
            MyDeckClass_WK = "ネメシス";
            Sub.AddList(MyTYPE_listBox, "ネメシス");

            Sub.BackColor_Reset(MyDeck_groupBox);               // 他コントロールの背景色クリア
            NM_pictureBox.BackColor = Color.Red;

        }

        private void E_pictureBox_open_Click(object sender, EventArgs e)
        {
            OpenDeckClass_WK = "エルフ";
            Sub.AddList(OpenType_listBox, "エルフ");

            Sub.BackColor_Reset(OpenDeck_groupBox);               // 他コントロールの背景色クリア
            E_pictureBox_open.BackColor = Color.Red;

        }

        private void L_pictureBox_open_Click(object sender, EventArgs e)
        {
            OpenDeckClass_WK = "ロイヤル";
            Sub.AddList(OpenType_listBox, "ロイヤル");

            Sub.BackColor_Reset(OpenDeck_groupBox);               // 他コントロールの背景色クリア
            L_pictureBox_open.BackColor = Color.Red;

        }

        private void W_pictureBox_open_Click(object sender, EventArgs e)
        {
            OpenDeckClass_WK = "ウィッチ";
            Sub.AddList(OpenType_listBox, "ウィッチ");

            Sub.BackColor_Reset(OpenDeck_groupBox);               // 他コントロールの背景色クリア
            W_pictureBox_open.BackColor = Color.Red;

        }

        private void D_pictureBox_open_Click(object sender, EventArgs e)
        {
            OpenDeckClass_WK = "ドラゴン";
            Sub.AddList(OpenType_listBox, "ドラゴン");

            Sub.BackColor_Reset(OpenDeck_groupBox);               // 他コントロールの背景色クリア
            D_pictureBox_open.BackColor = Color.Red;

        }

        private void NC_pictureBox_open_Click(object sender, EventArgs e)
        {
            OpenDeckClass_WK = "ネクロマンサー";
            Sub.AddList(OpenType_listBox, "ネクロマンサー");

            Sub.BackColor_Reset(OpenDeck_groupBox);               // 他コントロールの背景色クリア
            NC_pictureBox_open.BackColor = Color.Red;

        }

        private void V_pictureBox_open_Click(object sender, EventArgs e)
        {
            OpenDeckClass_WK = "ヴァンパイア";
            Sub.AddList(OpenType_listBox, "ヴァンパイア");

            Sub.BackColor_Reset(OpenDeck_groupBox);               // 他コントロールの背景色クリア
            V_pictureBox_open.BackColor = Color.Red;

        }

        private void B_pictureBox_open_Click(object sender, EventArgs e)
        {
            OpenDeckClass_WK = "ビショップ";
            Sub.AddList(OpenType_listBox, "ビショップ");

            Sub.BackColor_Reset(OpenDeck_groupBox);               // 他コントロールの背景色クリア
            B_pictureBox_open.BackColor = Color.Red;

        }

        private void NM_pictureBox_open_Click(object sender, EventArgs e)
        {
            OpenDeckClass_WK = "ネメシス";
            Sub.AddList(OpenType_listBox, "ネメシス");

            Sub.BackColor_Reset(OpenDeck_groupBox);               // 他コントロールの背景色クリア
            NM_pictureBox_open.BackColor = Color.Red;

        }

        private void MyTYPE_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MyDeckType_WK = MyTYPE_listBox.SelectedItem.ToString();

        }

        private void OpenType_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OpenDeckType_WK = OpenType_listBox.SelectedItem.ToString();

        }

        // クラス名にあったpictureboxの、背景色を変更する
        private void BackColor_Set(int mode, GroupBox groupBox, string ClassName)
        {
            // mode 1:自分デッキ
            // mode 2:相手デッキ
            if (mode == 1)
            { // 自分デッキ
                foreach (Control control in groupBox.Controls)
                {   // コントロール全てをみる
                    if( (ClassName=="エルフ") && (control.Equals(E_pictureBox) == true) )
                    {   // エルフ
                        control.BackColor = Color.Red;
                        return;
                    }

                    if( (ClassName=="ロイヤル") && (control.Equals(L_pictureBox) == true) )
                    {   // ロイヤル
                        control.BackColor = Color.Red;
                        return;
                    }

                    if( (ClassName=="ウィッチ") && (control.Equals(W_pictureBox)==true ) )
                    {   // ウィッチ
                        control.BackColor = Color.Red;
                        return;
                    }

                    if( (ClassName=="ドラゴン") && (control.Equals(D_pictureBox)==true ) )
                    {
                        control.BackColor = Color.Red;
                        return;
                    }

                    if( (ClassName=="ネクロマンサー") && (control.Equals(NC_pictureBox)==true) )
                    {
                        control.BackColor = Color.Red;
                        return;
                    }

                    if( (ClassName=="ヴァンパイア") && (control.Equals(V_pictureBox)==true) )
                    {
                        control.BackColor = Color.Red;
                        return;
                    }

                    if( (ClassName=="ビショップ") && (control.Equals(B_pictureBox)==true) )
                    {
                        control.BackColor = Color.Red;
                        return;
                    }

                    if( (ClassName=="ネメシス") && (control.Equals(NM_pictureBox)==true) )
                    {
                        control.BackColor = Color.Red;
                        return;
                    }
                }
            }
            else
            {   // 相手デッキ
                foreach (Control control in OpenDeck_groupBox.Controls)
                {   // コントロール全てをみる
                    if ((ClassName == "エルフ") && (control.Equals(E_pictureBox_open) == true))
                    {   // エルフ
                        control.BackColor = Color.Red;
                        return;
                    }

                    if ((ClassName == "ロイヤル") && (control.Equals(L_pictureBox_open) == true))
                    {   // ロイヤル
                        control.BackColor = Color.Red;
                        return;
                    }

                    if ((ClassName == "ウィッチ") && (control.Equals(W_pictureBox_open) == true))
                    {   // ウィッチ
                        control.BackColor = Color.Red;
                        return;
                    }

                    if ((ClassName == "ドラゴン") && (control.Equals(D_pictureBox_open) == true))
                    {
                        control.BackColor = Color.Red;
                        return;
                    }

                    if ((ClassName == "ネクロマンサー") && (control.Equals(NC_pictureBox_open) == true))
                    {
                        control.BackColor = Color.Red;
                        return;
                    }

                    if ((ClassName == "ヴァンパイア") && (control.Equals(V_pictureBox_open) == true))
                    {
                        control.BackColor = Color.Red;
                        return;
                    }

                    if ((ClassName == "ビショップ") && (control.Equals(B_pictureBox_open) == true))
                    {
                        control.BackColor = Color.Red;
                        return;
                    }

                    if ((ClassName == "ネメシス") && (control.Equals(NM_pictureBox_open) == true))
                    {
                        control.BackColor = Color.Red;
                        return;
                    }
                }
            }
        }

    }
}
