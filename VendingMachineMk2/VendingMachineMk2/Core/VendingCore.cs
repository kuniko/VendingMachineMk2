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
            RefleshTotalInsertedYen(totalYen);


            CanBuyShohin(totalYen);
        }

        public void CanBuyShohin(int totalYen) {
            StockManager stockManager = StockManager.GetInstance();

            foreach (Shohin shouhin in ShohinMaster.ShouhinCatalogue()) {
                bool canBuy = stockManager.CanBuy(shouhin.ShohinCode, totalYen);

                T2WindowsFormController viewModel = T2WindowsFormController.GetInstance();
                viewModel.BtnShohin01Binder = canBuy; //todo いっこしか かえない。
            }

        }

        public void PushShohinButton(string shohinCode) {
            MoneyManager moneyManager = MoneyManager.GetInstance();
            StockManager stockManager = StockManager.GetInstance();

            Shohin toriaezuKoreKau = ShohinMaster.Otya(); //todo もちろん、好きな商品を買えるようにしないとね。

            bool canBuy = stockManager.CanBuy(shohinCode, moneyManager.TotalInsertedYen);
            if (canBuy) {
                int totalYen = moneyManager.BuyShohin(toriaezuKoreKau.SellingYen);
                RefleshTotalInsertedYen(totalYen);
                CanBuyShohin(totalYen); //todo PropertyChangedを独自実装する。

                //todo 買えたんだから、商品出さないとね。
            }
        }

        private void RefleshTotalInsertedYen(int totalYen) {
            T2WindowsFormController viewModel = T2WindowsFormController.GetInstance();
            viewModel.LblTotalInsertedYenBinder = totalYen.ToString() + "円"; // yey!
        }

        private void RefleshOutputShohinBox() {
        }
    }
}
