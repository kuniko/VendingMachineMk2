using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineMk2.Core {

    /// <summary>
    /// このクラスはね、ViewModelの役目を果たしたいよ！
    /// 
    /// WindowsFormに依存するロジックはここに集めるよ！
    /// </summary>
    class T2WindowsFormController {

        private static T2WindowsFormController _instance;

        private VendingMachine _ui;

        private T2WindowsFormController() { 
        }

        public static T2WindowsFormController GetInstance(VendingMachine uiForm) {
            if (uiForm == null) {
                throw new ArgumentNullException("オイ、ダメですよ。");
            }

            if (_instance == null) {
                _instance = new T2WindowsFormController();
            }

            // 毎回になるんだよなぁ･･･。でも、SetUIForm();とか作ってInitialize時に呼ぶのも･･･微妙･･･
            _instance._ui = uiForm;
            return _instance;
        }
 

        public void UIReflesh(){
            RefleshInsertedMoneyLCD();
        }

        private void RefleshInsertedMoneyLCD() {
            
        }

        private void RefleshShohinButton() { 

        }

        private void RefleshShohinOutputBox() { 

        }

    }
}
