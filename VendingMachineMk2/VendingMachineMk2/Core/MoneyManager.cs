using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineMk2.Core {

    /// <summary>
    /// 『お金』を管理するManager
    /// </summary>
    class MoneyManager {
        private static MoneyManager _instance;

        int _totalInsertedYen;

        private MoneyManager() { }

        public static MoneyManager GetInstance() {
            if (_instance == null) {
                _instance = new MoneyManager();
            }
            return _instance;
        }

        /// <summary>
        /// お金を追加する。投入された金額の計を返す。
        /// </summary>
        /// <param name="yen"></param>
        /// <returns></returns>
        public int InsertYen(int yen) {            
            _totalInsertedYen += yen;

            return _totalInsertedYen;
        }

        /// <summary>
        /// 投入されている金額から、指定した商品金額を引く。
        /// 
        /// ・0以下の値を入れると絶叫します。
        /// 
        /// ・投入金額 ＜ 商品金額 の場合、投入金額に変動はありません。
        ///   実際の自販機も、10円だけ入れてボタン押せるからです。
        ///   ※ 今はボタンのEnabledを弄っているので押せないですけど...
        /// 
        /// ・残りの金額を返します。
        /// </summary>
        /// <param name="shohinYen"></param>
        /// <returns></returns>
        public int MinusTotalInsertedYen(int shohinYen) {
            if (shohinYen <= 0) {
                throw new InvalidProgramException("タダで買えるとか、お金が貰えるとかどういうこと？サービス？");
            }

            if (_totalInsertedYen >= shohinYen) {
                _totalInsertedYen = _totalInsertedYen - shohinYen;
            }
            return _totalInsertedYen;
        }

        /// <summary>
        /// 投入されたお金を返却する。投入された金額は0円になる。
        /// </summary>
        /// <returns></returns>
        public int ReleaseYen() {
            var releaseYen = _totalInsertedYen;
            _totalInsertedYen = 0;

            return releaseYen;
        }

        public int TotalInsertedYen {
            get {
                return _totalInsertedYen;
            }
        }


    }
}