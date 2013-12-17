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



        /// <summary>
        /// はー･･･全て作るのかぁ。。。
        /// </summary>
        /// <param name="totalInsertedYen"></param>
        private void RefleshView_TotalInsertedYen(string totalInsertedYen) {
            _view.lblInsertedYen2.Text = totalInsertedYen;
        }

        


    }
}
