using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachineMk2;


namespace VendingMachineMk2.Core {
    using System.ComponentModel;
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

        public void PushButton(string shohinCode) {
            VendingCore core = VendingCore.GetInstance();
            core.PushShohinButton(shohinCode);
        }


        /// <summary>
        /// binding用
        /// </summary>
        private string _totalInsertedYen = "";
        public string LblTotalInsertedYenBinder {
            set {
                _totalInsertedYen = value;
                RefleshView_TotalInsertedYen(_totalInsertedYen);
            }
        }

        // Shohin持たせたくないな～
//        private List<Shohin> 

        private bool _canBuyShohin01;

        public bool BtnShohin01Binder {
            set {
                _canBuyShohin01 = value;
                RefleshView_CanBuyShohin01(_canBuyShohin01);
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

        private void RefleshView_CanBuyShohin01(bool canBuy) {
            _view.btnShohin01.Enabled = canBuy;
        }





    }
}
