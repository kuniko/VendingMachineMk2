using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachineMk2;


namespace VendingMachineMk2.Core {

    /// <summary>
    /// このクラスはね、ViewModelの役目を果たしたいよ！
    /// 
    /// WindowsFormに依存するロジックはここに集めるよ！
    /// </summary>
    class T2WindowsFormController {

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
 

        public void UIReflesh(){
            RefleshInsertedMoneyLCD();
        }

        private void RefleshInsertedMoneyLCD() {
            MoneyManager moneyManager = MoneyManager.GetInstance();
            _view.lblInsertedYen.Text = moneyManager.InsertYen(0).ToString();
        }

        private void RefleshShohinButton() { 

        }

        private void RefleshShohinOutputBox() { 

        }

    }
}
