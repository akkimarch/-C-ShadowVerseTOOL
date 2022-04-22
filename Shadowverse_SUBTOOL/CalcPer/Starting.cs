using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcPer
{
    public partial class Starting : Form
    {
        public Starting()
        {
            InitializeComponent();
        }

        private void Result_Click(object sender, EventArgs e)
        {

        }

        private void Starting_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   // 計算開始ボタン

            int DeckNum = 40;     // デッキ残り枚数(初期値40)
            int InNum = int.Parse(Num_Box.Text);    // デッキに入れてる枚数
            int Modosi = int.Parse(Redraw_Box.Text);   // 引き直し枚数
            int Tern = int.Parse(Tern_Box.Text);     // 目標ターン数
            int Modosi_XX = int.Parse(Redraw2_Box.Text); // 引き直しで目当てのカードを戻した数
            double Per = 0.0;   // 確率

            // 初手で引けている確率
            int work = 3;   // 初手で引く枚数
            if( SecondButton.Checked==true )
            {   // 後攻
                work++; // 1枚増やす
            }


            for (int i = 0; i < work; i++)
            {
                Per += (double)InNum / (DeckNum - i);          // num/40 num/39 num/38を計算
            }

            // マリガンで引いた確率

            // 〇ターン目で引いた確率
        }
    }
}
