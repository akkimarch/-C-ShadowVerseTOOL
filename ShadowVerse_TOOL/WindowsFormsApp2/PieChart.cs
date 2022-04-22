using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Battle_Manage
{
    public partial class PieChart : Form
    {
        public List<string> uti = new List<string>();
        private String ClassName_wk;
        private String TypeName_wk;

        public PieChart()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // デフォルト値設定

            chart1.Series[0].Points.Clear();            // 内容のクリア

            // 並べ替えする... パーセントが大きい順(降順)
            BattleMan.scopes.Sort(delegate (Scope A1, Scope A2) { return (int)A2.per - (int)A1.per; });
            double per_chk = 0.0;                       // [その他]割合チェック用

            // 上位8デッキまでを円グラフ上に表示する。 残りは[その他]とする。
            for (int i = 0; i < 8; i++)
            {   // 5デッキ分ループ

                if(BattleMan.scopes.Count() < (i+1) )
                {   // データが足りない場合
                    break;                              // ループ脱出
                }
                string name = BattleMan.scopes[i].ClassName + " [" + BattleMan.scopes[i].TypeName + "]";
                chart1.Series[0].Points.AddXY(name, BattleMan.scopes[i].per);

                per_chk += BattleMan.scopes[i].per;         // 割合を入れる
                                                        // ループを出たあと、％が100に満たないなら[その他]として入れる
            }

            // [その他]が必要なら入れる
            if( (per_chk < 100.0) && (BattleMan.scopes.Count() > 5) )
            {   // 100%に満たない かつ 5デッキ以上あり
                chart1.Series[0].Points.AddXY("その他", (100.0 - per_chk));    // 残りはその他
            }

            // 解析画面に渡す用のデッキ名を保存する
            if (BattleMan.scopes.Count() != 0)
            { // 要素が入っているとき
                ClassName_wk = BattleMan.scopes[0].ClassName;
                TypeName_wk = BattleMan.scopes[0].TypeName;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Scope_Jump_Click(object sender, EventArgs e)
        {
            DetailForm detailForm = new DetailForm(ClassName_wk, TypeName_wk);
            detailForm.Text = BattleMan.EnvName + "環境の戦績";   // タイトル設定
            detailForm.Show();                            // 表示
        }

        private void _3days_CheckedChanged(object sender, EventArgs e)
        {
            Sub.Scope_Make( 3, BattleMan.EnvName);                           // 解析情報を表示する(環境全日指定)
            this.Dispose(true);                                      // 今開いているグラフ画面は閉じる
        }

        private void _7days_CheckedChanged(object sender, EventArgs e)
        {
            Sub.Scope_Make(7, BattleMan.EnvName);                           // 解析情報を表示する(環境全日指定)
            this.Dispose(true);                                      // 今開いているグラフ画面は閉じる
        }

        private void Alldays_CheckedChanged(object sender, EventArgs e)
        {
            Sub.Scope_Make(-1, BattleMan.EnvName);                           // 解析情報を表示する(環境全日指定)
            this.Dispose(true);                                      // 今開いているグラフ画面は閉じる
        }

        private void _1days_CheckedChanged(object sender, EventArgs e)
        {
            Sub.Scope_Make(1, BattleMan.EnvName);                           // 解析情報を表示する(環境全日指定)
            this.Dispose(true);                                      // 今開いているグラフ画面は閉じる
        }

        private void DisplayBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }

}
