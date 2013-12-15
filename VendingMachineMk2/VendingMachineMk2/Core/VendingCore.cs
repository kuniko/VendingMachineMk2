using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachineMk2.Data;

namespace VendingMachineMk2.Core {

    /// <summary>
    /// UIからは、常時このクラス『のみ』を呼ぶ！
    /// 呼び出された本クラスは、個々のManagerを組み合わせて処理をする旗振り役となる。
    /// 
    /// このクラスから呼ぶViewModelがほしいな～
    /// </summary>
    class VendingCore {
        static VendingCore _instance;

        private VendingMachine _ui;

        private VendingCore() { }

        public static VendingCore GetInstance() {
            if (_instance == null) {
                _instance = new VendingCore();
            }

            return _instance;
        }

        public void InsertYen(int insertedYen) {
            MoneyManager moneyManager = MoneyManager.GetInstance();
            int totalYen = moneyManager.InsertYen(insertedYen);

            CanBuyShohin(totalYen);
        }

        public void CanBuyShohin(int totalYen) {
            StockManager stockManager = StockManager.GetInstance();

            foreach (Shohin shouhin in ShohinMaster.ShouhinCatalogue()) {
                bool canBuy = stockManager.CanBuy(shouhin.ShohinCode, totalYen);

                if (canBuy) { 
                }
            }

        }

        public void PushShohinButton(string shohinCode) { 
            
        }

        public void Reflesh() { 

        }

    }
}
