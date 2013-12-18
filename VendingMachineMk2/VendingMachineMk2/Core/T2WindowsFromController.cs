using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachineMk2;


namespace VendingMachineMk2.Core {
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Printing;
    using System.Runtime.CompilerServices;

    using VendingMachineMk2.Data;

    /// <summary>
    /// このクラスはね、ViewModelの役目を果たしたいよ！
    /// 
    /// WindowsFormに依存するロジックはここに集めるよ！
    /// </summary>
    class T2WindowsFormController/*: INotifyPropertyChanged*/ {

        private static T2WindowsFormController _instance;

        private static VendingMachine _view;


        private T2WindowsFormController() {
        }

        public static T2WindowsFormController GetInstance() {
            if (_instance == null) {
                _instance = new T2WindowsFormController();
            }

            return _instance;
        }


        /// <summary>
        /// あきらめてお決まりにする。
        /// </summary>
        /// <param name="view"></param>
        public static void SetView(VendingMachine view) {
            _view = view;
        }


        /// <summary>
        /// こいん いっこ いれる
        /// </summary>
        /// <param name="yen"></param>
        public void InsertYen(int yen) {
            VendingCore core = VendingCore.GetInstance();
            core.InsertYen(yen);
        }

        /// <summary>
        /// しょうひん かう
        /// </summary>
        /// <param name="shohinCode"></param>
        public void PushShohinButton(string shohinCode) {
            VendingCore core = VendingCore.GetInstance();
            core.PushShohinButton(shohinCode);
        }

        /// <summary>
        /// かね かえせ
        /// </summary>
        /// <param name="shohinCode"></param>
        public void PushOtsuriButton() {
            VendingCore core = VendingCore.GetInstance();
            core.PushOtsuriButton();
        }


        /// <summary>
        /// binding用.
        /// 今、客によって投入されている金額。
        /// </summary>
        private string _totalInsertedYen = "";
        public string LblTotalInsertedYenBinder {
            set {
                _totalInsertedYen = value;
                RefleshView_TotalInsertedYen(_totalInsertedYen);
            }
        }

        /// <summary>
        /// binding用.
        /// 今、おつりBoxにある金額。
        /// </summary>
        private string _totalReturnedYen = "";
        public string LblTotalOtsuriYenBinder {
            set {
                _totalReturnedYen = value;
                RefleshView_LblTotalOtsuriYenBinder(_totalReturnedYen);
            }
        }



        /// <summary>
        /// binding用...だけど、もう直で操作してしまう。
        /// 商品コードから、VIEWの商品ボタンの有効(買える)/無効(買えない)を制御する。
        /// </summary>
        /// <param name="shohinCode"></param>
        /// <param name="canBuy"></param>
        public void BtnShohinBinder(string shohinCode, bool canBuy) {
            //todo 商品のボタンと、内部のロジックをつなぎ合わせるManagerを作る。ボタンの数だけ作るのは酷い。

            if (string.IsNullOrWhiteSpace(shohinCode)) {
                throw new ArgumentNullException("商品コードにNULLや空文字は使えないんですけど？");
            }

            if (string.Equals(shohinCode, ShohinMaster.Otya().ShohinCode)) {
                RefleshView_CanBuyShohin01(canBuy);
                return;
            }
            if (string.Equals(shohinCode, ShohinMaster.Conpota().ShohinCode)) {
                RefleshView_CanBuyShohin02(canBuy);
                return;
            }
            if (string.Equals(shohinCode, ShohinMaster.Coke().ShohinCode)) {
                RefleshView_CanBuyShohin03(canBuy);
                return;
            }

        }


        /// <summary>
        /// はー･･･全て作るのかぁ。。。
        /// 
        /// プロパティ監視にしたいけど･･･
        /// Text指定という凄く残念な事になるので、諦めて個別に作る。
        /// しかも、VMにViewへの操作を持たせます。諦めます。
        /// </summary>
        /// <param name="totalInsertedYen"></param>
        private void RefleshView_TotalInsertedYen(string totalInsertedYen) {
            _view.lblInsertedYen2.Text = totalInsertedYen;
        }
        private void RefleshView_LblTotalOtsuriYenBinder(string totalOtsuriYen) {
            _view.lblTotalOtsuriYen.Text = totalOtsuriYen;
        }

        private void RefleshView_CanBuyShohin01(bool canBuy) {
            _view.btnShohin01.Enabled = canBuy;
        }

        private void RefleshView_CanBuyShohin02(bool canBuy) {
            _view.btnShohin02.Enabled = canBuy;
        }

        private void RefleshView_CanBuyShohin03(bool canBuy) {
            _view.btnShohin03.Enabled = canBuy;
        }


        /// <summary>
        /// ピンポーン。ご利用ありがとうございました。
        /// </summary>
        /// <param name="shohin"></param>
        public void RefleshView_OutputShohinBox(Shohin shohin) {
            _view.pictOutputShohinBox.Image = shohin.ShohinImage;
            _view.pictOutputShohinBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
        }



    }
}
