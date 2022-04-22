using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trerance_Count
{
    public partial class Form1 : Form
    {
        public int[] SumCost = new int[12];         // 合計コスト
        public int Tern        = 1;            // ターン数 初期値は1
        public int NowCost     = 0;         // このターンのコスト

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// １ダメ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            PulseCount(1);           // カウントを+
            NowCost += 1;
            Genzaiti.Text = NowCost.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PulseCount(2);           // カウントを+
            NowCost += 2;
            Genzaiti.Text = NowCost.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PulseCount(3);           // カウントを+
            NowCost += 3;
            Genzaiti.Text = NowCost.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PulseCount(4);           // カウントを+
            NowCost += 4;
            Genzaiti.Text = NowCost.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PulseCount(5);           // カウントを+
            NowCost += 5;
            Genzaiti.Text = NowCost.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PulseCount(6);           // カウントを+
            NowCost += 6;
            Genzaiti.Text = NowCost.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PulseCount(7);           // カウントを+
            NowCost += 7;
            Genzaiti.Text = NowCost.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PulseCount(8);           // カウントを+
            NowCost += 8;
            Genzaiti.Text = NowCost.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            PulseCount(9);           // カウントを+
            NowCost += 9;
            Genzaiti.Text = NowCost.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            PulseCount(10);           // カウントを+
            NowCost += 10;
            Genzaiti.Text = NowCost.ToString();
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            // テキストボックスから取り込み
            int work = int.Parse(textBox1.Text);

            PulseCount(work);           // カウントを+
            NowCost += work;
            Genzaiti.Text = NowCost.ToString();
        }

        /// <summary>
        ///  ターン終了ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ENDbutton_Click(object sender, EventArgs e)
        {
            // ターン数に応じて結果を入れる
            switch (Tern)
            {
                case 12:
                    Cost_12.Text = (30 - SumCost[11]).ToString();
                    LabelChack(Cost_12);
                    goto case 11;
                case 11:
                    Cost_11.Text = (30 - SumCost[10]).ToString();
                    LabelChack(Cost_11);
                    goto case 10;
                case 10:
                    Cost_10.Text = (30 - SumCost[9]).ToString();
                    LabelChack(Cost_10);
                    goto case 9;
                case 9:
                    Cost_9.Text = (30 - SumCost[8]).ToString();
                    LabelChack(Cost_9);
                    goto case 8;
                case 8:
                    Cost_8.Text = (30 - SumCost[7]).ToString();
                    LabelChack(Cost_8);
                    goto case 7;
                case 7:
                    Cost_7.Text = (30 - SumCost[6]).ToString();
                    LabelChack(Cost_7);
                    goto case 6;
                case 6:
                    Cost_6.Text = (30 - SumCost[5]).ToString();
                    LabelChack(Cost_6);
                    goto case 5;
                case 5:
                    Cost_5.Text = (30 - SumCost[4]).ToString();
                    LabelChack(Cost_5);
                    goto case 4;
                case 4:
                    Cost_4.Text = (30 - SumCost[3]).ToString();
                    LabelChack(Cost_4);
                    goto case 3;
                case 3:
                    Cost_3.Text = (30 - SumCost[2]).ToString();
                    LabelChack(Cost_3);
                    goto case 2;
                case 2:
                    Cost_2.Text = (30 - SumCost[1]).ToString();
                    LabelChack(Cost_2);
                    goto case 1;
                case 1:
                    Cost_1.Text = (30 - SumCost[0]).ToString();
                    LabelChack(Cost_1);
                    break;
                default:
                    break;
            }

            // ターン数をUP
            Tern++;         // ターン数UP
            Ternsuu.Text = Tern.ToString() + "ターン目";

            // このターンのコストはクリア
            NowCost = 0;

            // 現在値表示をもとに戻す
            Genzaiti.Text = "(現在値)";

        }

        /// <summary>
        /// カウンタを＋する
        /// </summary>
        /// <param name="pulse"></param>
        public void PulseCount(int pulse)
        {
            switch (Tern)
            {
                case 12:
                    SumCost[11] += pulse;
                    goto case 11;
                case 11:
                    SumCost[10] += pulse;
                    goto case 10;
                case 10:
                    SumCost[9] += pulse;
                    goto case 9;
                case 9:
                    SumCost[8] += pulse;
                    goto case 8;
                case 8:
                    SumCost[7] += pulse;
                    goto case 7;
                case 7:
                    SumCost[6] += pulse;
                    goto case 6;
                case 6:
                    SumCost[5] += pulse;
                    goto case 5;
                case 5:
                    SumCost[4] += pulse;
                    goto case 4;
                case 4:
                    SumCost[3] += pulse;
                    goto case 3;
                case 3:
                    SumCost[2] += pulse;
                    goto case 2;
                case 2:
                    SumCost[1] += pulse;
                    goto case 1;
                case 1:
                    SumCost[0] += pulse;
                    break;
                default:
                    break;
            }
        }

        public void LabelChack(Label label)
        {
            if(int.Parse(label.Text) < 0)
            {
                label.Text = (0).ToString();
            }
        }


    }


}
