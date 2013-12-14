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
        MoneyManager _instance;

        int _totalInsertedYen;

        private MoneyManager() { }

        public MoneyManager GetInstance() {
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
        /// 投入されたお金を返却する。投入された金額は0円になる。
        /// </summary>
        /// <returns></returns>
        public int ReleaseYen() {
            var releaseYen = _totalInsertedYen;
            _totalInsertedYen = 0;

            return releaseYen;
        }


    }
}