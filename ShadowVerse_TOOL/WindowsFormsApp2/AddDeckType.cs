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

namespace Battle_Manage
{
    public partial class AddDeckType : Form
    {
        string DeckClass = ""; // デッキクラス

        public AddDeckType()
        {
            InitializeComponent();
        }

        private void E_pictureBox_Click(object sender, EventArgs e)
        {   // 自デッキはエルフ
            DeckClass = "エルフ";
            Sub.AddList(DeckTypelistBox, "エルフ");

            Sub.BackColor_Reset(MyDeck_groupBox);               // 他コントロールの背景色クリア
            E_pictureBox.BackColor = Color.Red;
            DelType_label.Text = "";        // ラベルは消す

        }

        private void L_pictureBox_Click(object sender, EventArgs e)
        {   // 自デッキはロイヤル
            DeckClass = "ロイヤル";
            Sub.AddList(DeckTypelistBox, "ロイヤル");

            Sub.BackColor_Reset(MyDeck_groupBox);               // 他コントロールの背景色クリア
            L_pictureBox.BackColor = Color.Red;
            DelType_label.Text = "";        // ラベルは消す

        }

        private void W_pictureBox_Click(object sender, EventArgs e)
        {   // 自デッキはウィッチ
            DeckClass = "ウィッチ";
            Sub.AddList(DeckTypelistBox, "ウィッチ");

            Sub.BackColor_Reset(MyDeck_groupBox);               // 他コントロールの背景色クリア
            W_pictureBox.BackColor = Color.Red;
            DelType_label.Text = "";        // ラベルは消す

        }

        private void D_pictureBox_Click(object sender, EventArgs e)
        {   // 自デッキはドラゴン
            DeckClass = "ドラゴン";
            Sub.AddList(DeckTypelistBox, "ドラゴン");

            Sub.BackColor_Reset(MyDeck_groupBox);               // 他コントロールの背景色クリア
            D_pictureBox.BackColor = Color.Red;
            DelType_label.Text = "";        // ラベルは消す

        }

        private void NC_pictureBox_Click(object sender, EventArgs e)
        {   // 自デッキはネクロ 
            DeckClass = "ネクロマンサー";
            Sub.AddList(DeckTypelistBox, "ネクロマンサー");

            Sub.BackColor_Reset(MyDeck_groupBox);               // 他コントロールの背景色クリア
            NC_pictureBox.BackColor = Color.Red;
            DelType_label.Text = "";        // ラベルは消す

        }

        private void V_pictureBox_Click(object sender, EventArgs e)
        {   // 自デッキはヴァンパイア
            DeckClass = "ヴァンパイア";
            Sub.AddList(DeckTypelistBox, "ヴァンパイア");

            Sub.BackColor_Reset(MyDeck_groupBox);               // 他コントロールの背景色クリア
            V_pictureBox.BackColor = Color.Red;
            DelType_label.Text = "";        // ラベルは消す

        }

        private void B_pictureBox_Click(object sender, EventArgs e)
        {   // 自デッキはビショップ
            DeckClass = "ビショップ";
            Sub.AddList(DeckTypelistBox, "ビショップ");

            Sub.BackColor_Reset(MyDeck_groupBox);               // 他コントロールの背景色クリア
            B_pictureBox.BackColor = Color.Red;
            DelType_label.Text = "";        // ラベルは消す

        }

        private void NM_pictureBox_Click(object sender, EventArgs e)
        {   // 自デッキはネメシス
            DeckClass = "ネメシス";
            Sub.AddList(DeckTypelistBox, "ネメシス");

            Sub.BackColor_Reset(MyDeck_groupBox);               // 他コントロールの背景色クリア
            NM_pictureBox.BackColor = Color.Red;
            DelType_label.Text = "";        // ラベルは消す

        }

        private void Addbutton_Click(object sender, EventArgs e)
        {   // 追加ボタン

            // テキストファイルへ書き込み
            StreamWriter sw = new StreamWriter("アーキタイプ\\" + DeckClass + ".txt", true); // ファイルを開く(追記モード)
            sw.WriteLine(AddType_Textbox.Text); // 書き込み
            sw.Close();                         // 閉じる

            DelType_label.Text = "";        // ラベルは消す
            Sub.AddList(DeckTypelistBox, DeckClass);            // リストを表示しなおす
            return;
        }

        private void DeckTypelistBox_SelectedIndexChanged(object sender, EventArgs e)
        {   // リスト内選択
            if (DeckTypelistBox.SelectedItem != null)
            {   // 選択アイテムあり
                DelType_label.Text = DeckTypelistBox.SelectedItem.ToString() + "   を";   // ラベルを表示
            }
            return;
        }

        private void Delbutton_Click(object sender, EventArgs e)
        {   // 削除ボタン

            if (DeckTypelistBox.SelectedItem != null)
            {   // 選択アイテムあり
                string DelType = DeckTypelistBox.SelectedItem.ToString();   // 削除するアーキタイプ

                StreamReader sr = new StreamReader("アーキタイプ\\" + DeckClass + ".txt", Encoding.GetEncoding("UTF-8"));
                List<string> DeckTypes = new List<string>();            // リスト

                while (sr.Peek() != -1)
                {   // ファイルの中身を全部リストに追加
                    DeckTypes.Add(sr.ReadLine());
                }
                sr.Close();     // 閉じる

                DeckTypes.Remove(DelType);      // 指定のアーキタイプを削除

                StreamWriter sw = new StreamWriter("アーキタイプ\\" + DeckClass + ".txt", false); // ファイルを開く(上書きモード)
                foreach (string DeckType in DeckTypes)
                {   // アーキタイプの数でループ
                    sw.WriteLine(DeckType);             // アーキタイプを1つずつ書き込み
                }
                sw.Close();         // 閉じる

                DelType_label.Text = "";        // ラベルは消す
                Sub.AddList(DeckTypelistBox, DeckClass);            // リストを表示しなおす
            }
            return;
        }
    }
}
