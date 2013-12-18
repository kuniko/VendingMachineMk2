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

        // todo MoneyManagerの投入金が変化したとき、自動でここが動くなど、漏れを防ぐ仕組みが欲しい。
        public void CanBuyShohin(int totalYen) {
            StockManager stockManager = StockManager.GetInstance();

            foreach (Shohin shouhin in ShohinMaster.ShouhinCatalogue()) {
                bool canBuy = stockManager.CanBuy(shouhin.ShohinCode, totalYen);

                T2WindowsFormController viewModel = T2WindowsFormController.GetInstance();
                viewModel.BtnShohinBinder(shouhin.ShohinCode, canBuy);
            }
        }

        public void PushShohinButton(string shohinCode) {
            MoneyManager moneyManager = MoneyManager.GetInstance();
            StockManager stockManager = StockManager.GetInstance();

            Shohin buyShohin = ShohinMaster.SelectShohin(shohinCode);

            bool canBuy = stockManager.CanBuy(shohinCode, moneyManager.TotalInsertedYen);
            if (canBuy) {
                int totalYen = moneyManager.MinusTotalInsertedYen(buyShohin.SellingYen);
                RefleshTotalInsertedYen(totalYen); // 商品買ったので投入したお金が減るよ！
                CanBuyShohin(totalYen); 

                RefleshOutputShohinBox(buyShohin);
            }
        }

        public void PushOtsuriButton() {
            MoneyManager moneyManager = MoneyManager.GetInstance();
            int otsuriYen = moneyManager.ReleaseYen();
            RefleshTotalOtsuriYen(otsuriYen);

            // 絶対0だけどね。
            int totalInsertedYen = moneyManager.TotalInsertedYen;
            RefleshTotalInsertedYen(totalInsertedYen);
            CanBuyShohin(totalInsertedYen);

        }



        // todo MoneyManagerの投入金が変化したとき、自動でここが動くなど、漏れを防ぐ仕組みが欲しい。
        private void RefleshTotalInsertedYen(int totalYen) {
            T2WindowsFormController viewModel = T2WindowsFormController.GetInstance();
            viewModel.LblTotalInsertedYenBinder = totalYen + "円"; // yey!
        }

        private void RefleshTotalOtsuriYen(int totalOtusriYen) {
            T2WindowsFormController viewModel = T2WindowsFormController.GetInstance();
            viewModel.LblTotalOtsuriYenBinder = totalOtusriYen + "円"; // yey!
        }



        /// <summary>
        /// ピンポーン。ご利用ありがとうございました。
        /// </summary>
        /// <param name="shohin"></param>
        private void RefleshOutputShohinBox(Shohin shohin) {
            T2WindowsFormController viewModel = T2WindowsFormController.GetInstance();
            viewModel.RefleshView_OutputShohinBox(shohin);
        }
    }
}
