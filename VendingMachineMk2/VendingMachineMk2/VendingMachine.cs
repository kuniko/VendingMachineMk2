using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendingMachineMk2;
using VendingMachineMk2.Core;
using VendingMachineMk2.Data;

namespace VendingMachineMk2 {
    public partial class VendingMachine : Form {

        private static VendingMachine _instance;
        
        // TODO Singletonはいいんだけど、メソッド毎にGetInstance()してるのをなんとかしよう。

        public VendingMachine() {
            InitializeComponent();
            Initialize();
        }

        public static VendingMachine GetInstance() {
            if (_instance == null) {
                _instance = new VendingMachine();
            }

            return _instance;
        }

        private void Initialize() {
            T2WindowsFormController.SetView(this);

            //T2WindowsFormController viewModel = T2WindowsFormController.GetInstance();
            //viewModel.PropertyChanged += PropertyChangedLblInsertedYen;


            // プロパティを手でって最悪。XAMLじゃないとダメだ･･･
            // lblInsertedYen2.DataBindings.Add("Text", viewModel, "LblTotalInsertedYenBinder"); 
            //
            // XAMLならBindしたプロパティ名も、しっかりとIDEの参照で引っかかる。
            // Bindingをデザイナから指定する方法も、上手く動かない。XAMLだと補完してくれるっぽい･･･

            // また、INotifyPropertyChangedをT2WindowsFormControllerに実装するのも止める。
            // 結局、どのプロパティ(orメソッド)で発生したのかを、どこかでTextで受ける必要あり。
            // 工夫して避けてもしんどい。MVVM Light ToolkitやPrismも、結局はWPFと組み合わせるのが前提である。
            //
            // 諦めて、手でViewModelを再現する方向性に。
            // Bindingはしない。IDEのサポートなしとか冗談きつい。
        }

        private void BtnInsertYen1000_OnClick(object sender, EventArgs e) {
            T2WindowsFormController viewModel = T2WindowsFormController.GetInstance();
            viewModel.InsertYen(1000);
        }

        private void btnInsertYen100_OnClick(object sender, EventArgs e) {
            T2WindowsFormController viewModel = T2WindowsFormController.GetInstance();
            viewModel.InsertYen(100);
        }

        private void btnInsertYen10_OnClick(object sender, EventArgs e) {
            T2WindowsFormController viewModel = T2WindowsFormController.GetInstance();
            viewModel.InsertYen(10);
        }

        private void btnOtsuri_OnClick(object sender, EventArgs e) {
            T2WindowsFormController viewModel = T2WindowsFormController.GetInstance();
            viewModel.PushOtsuriButton();
        }


        /// <summary>
        /// ボタンの管理対象商品商品コードを内部処理へ送る。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private void BtnShohin_OnClick(object sender, EventArgs e)
        {
            T2WindowsFormController viewModel = T2WindowsFormController.GetInstance();

            // ボタンを元に、ボタンの管理商品を取得
            Shohin managementShohin = viewModel.GetManagementShohin(sender);

            // 管理商品の商品コードを内部処理へ送る
            viewModel.PushShohinButton(managementShohin.ShohinCode); 
        }


        /// <summary>
        /// 商品購入ボタンの有効無効プロパティ制御を行う。
        /// </summary>
        /// <param name="btn">制御対象となる商品購入ボタン</param>
        /// <param name="canBuy">true:購入可＝ボタン有効 / False:購入不可＝ボタン無効</param>
        public void RefleshView_CanBuyShohin(Object btn, bool canBuy)
        {
            // 制御を行うため、Object型からControl型へキャスト
            Control cFindControl = (Control)btn;

            // ボタンが存在する場合は有効無効プロパティを設定
            if (cFindControl != null)
            {
                // 購入可不可とボタン有効無効を連動させるため、canbuyを使う。
                cFindControl.Enabled = canBuy;
            }
        }

    }
}