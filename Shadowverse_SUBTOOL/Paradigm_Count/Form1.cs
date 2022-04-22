using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paradigm_Count
{
    public partial class Form1 : Form
    {
        public int count = 0;   // カウンター個数
        public List<Label> labels = new List<Label>(); // ラベル格納

        public Form1()
        {
            InitializeComponent();
            labels.Add(label1);
            labels.Add(label2);
            labels.Add(label3);
            labels.Add(label4);
            labels.Add(label5);
            labels.Add(label6);
            labels.Add(label7);
            labels.Add(label8);
            labels.Add(label9);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(count == 9)
            {   // すでに限界
                MessageBox.Show("これ以上増やせません");
                return;
            }
            count++;                                // 個数追加

            labels[count - 1].Text = "7";           // 初期値7

            return;
        }

        private void button3_Click(object sender, EventArgs e)
        {   // DOWN
            for (int i = 0; i < count; i++)
            {   // 追加してる分だけ繰り返し
                labels[i].Text = (int.Parse(labels[i].Text) - 1).ToString();        // 1引く
                if(labels[i].Text == "-1")
                {   // -1以下にはしない
                    labels[i].Text = "0";
                }
            }
        }

        private void label1_DoubleClick(object sender, EventArgs e)
        {
            label1.Text = "      ";  // 戻す
            count--;                    // カウントダウン
            LabelListClear(label1);
        }

        private void label2_DoubleClick(object sender, EventArgs e)
        {
            label2.Text = "      ";  // 戻す
            count--;                    // カウントダウン
            LabelListClear(label2);

        }

        private void label3_DoubleClick(object sender, EventArgs e)
        {
            label3.Text = "      ";  // 戻す
            count--;                    // カウントダウン
            LabelListClear(label3);

        }

        private void label4_DoubleClick(object sender, EventArgs e)
        {
            label4.Text = "      ";  // 戻す
            count--;                    // カウントダウン
            LabelListClear(label4);

        }

        private void label5_DoubleClick(object sender, EventArgs e)
        {
            label5.Text = "      ";  // 戻す
            count--;                    // カウントダウン
            LabelListClear(label5);

        }

        private void label6_DoubleClick(object sender, EventArgs e)
        {
            label6.Text = "      ";  // 戻す
            count--;                    // カウントダウン
            LabelListClear(label6);

        }

        private void label7_DoubleClick(object sender, EventArgs e)
        {
            label7.Text = "      ";  // 戻す
            count--;                    // カウントダウン
            LabelListClear(label7);

        }

        private void label8_DoubleClick(object sender, EventArgs e)
        {
            label8.Text = "      ";  // 戻す
            count--;                    // カウントダウン
            LabelListClear(label8);

        }

        private void label9_DoubleClick(object sender, EventArgs e)
        {
            label9.Text = "      ";  // 戻す
            count--;                    // カウントダウン
            LabelListClear(label9);
        }

        /// <summary>
        /// ラベルをリストから削除して再登録
        /// </summary>
        /// <param name="labelWK"></param>
        void LabelListClear(Label labelWK)
        {
            labels.RemoveAll(A => A.Equals(labelWK));        // labelをリストから削除
            labels.Add(labelWK);         // リストに再追加
        }

    }
}
