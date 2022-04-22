using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Manage
{
    // デッキ

    public class Deck
    {   // デッキ 基底クラス
        public string Class { get; set; }   // デッキクラス
        public string Archetype { get; set; }   // アーキタイプ
    }


    public class BattleDeck : Deck
    {   // バトル用デッキ
        public int WinCount { get; set; }   // 勝った数
        public int LoseCount { get; set; }  // 負けた数

        public int FirstWinCount { get; set; }  // 先攻で勝った数
        public int SecondWinCount { get; set; } // 後攻で勝った数
        // 戦績を保存するメソッド
        public void battle(BattleDeck _deck)
        {
        }

        // 戦績を分析するメソッド
        void Scope()
        {
        }


    }

    public class PercentDeck : Deck
    {   // 割合算出用デッキ
        public int BattleCount { get; set; }    // 対戦した回数

        public double Percent(int sum)
        {   // 割合を求める
            // パーセントで返す (割合が0.1なら10と返す)
            double ret = Math.Round((double)BattleCount / sum, 2, MidpointRounding.AwayFromZero); // 割合を求める 四捨五入して少数点以下は1桁
            return ret*100 ;  // パーセントで返す
        }


    }

    // 内訳表示用クラス
    public class Scope
    {
        public double per { get; set; }     // 比率
        public string ClassName { get; set; }    // クラス
        public string TypeName { get; set; }     // アーキタイプ
    }


}
