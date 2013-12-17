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
        private static VendingCore _instance;

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

            T2WindowsFormController viewModel = T2WindowsFormController.GetInstance();
            viewModel.LblTotalInsertedYenBinder = totalYen.ToString() + "円"; // yey!

            CanBuyShohin(totalYen);
        }

        public void CanBuyShohin(int totalYen) {
            StockManager stockManager = StockManager.GetInstance();

            foreach (Shohin shouhin in ShohinMaster.ShouhinCatalogue()) {
                bool canBuy = stockManager.CanBuy(shouhin.ShohinCode, totalYen);

                T2WindowsFormController viewModel = T2WindowsFormController.GetInstance();
                viewModel.BtnShohin01Binder = canBuy;
            }

        }

        public void PushShohinButton(string shohinCode) {
            MoneyManager moneyManager = MoneyManager.GetInstance();
            StockManager stockManager = StockManager.GetInstance();

            bool canBuy = stockManager.CanBuy(shohinCode, moneyManager.TotalInsertedYen);
            if (canBuy) {
                T2WindowsFormController viewModel = T2WindowsFormController.GetInstance();
                viewModel.BtnShohin01Binder = true;
            }
        }

        public void Reflesh() { 

        }

    }
}
