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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "ドロー率計算";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Starting_Click(object sender, EventArgs e)
        {   // 「マリガン」ボタン

            /*******************************************************************************
            初手の引き直し含めて、〇枚入ってるカードが〇ターン目までに引ける確率を出す
            入力： 先攻/後攻
                   〇枚入れている
                   〇ターン目まで
                   引き直しの枚数
                   引き直しで対象カードを何枚返したか (例えば2コスのカードを「他の引けるだろう」の考えで返していいかどうか
            出力： 確率
            *********************************************************************************/

            Starting starting = new Starting();
            starting.Show();
        }

        private void OnBattle_Click(object sender, EventArgs e)
        {   // 「バトル内」ボタン
            // バトル中に気になったときとか

            /*******************************************************************************
            入力： 残りデッキ枚数
                   〇枚残っている
                   〇枚引いた時の確率
            出力： 確率
            *********************************************************************************/
            OnBattle onBattle = new OnBattle();
            onBattle.Show();


        }
    }
}
