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

        // TODO Singletonはいいんだけど、メソッド毎にGetInstance()してるのをなんとかしよう。

        public VendingMachine() {
            InitializeComponent();
            Initialize();
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
        /// 押下されたボタン名を取得し、取得したボタン名をVMに渡す。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        private void BtnShohin_OnClick(object sender, EventArgs e)
        {
            T2WindowsFormController viewModel = T2WindowsFormController.GetInstance();
            
            // ボタン名 GET!
            String btnName = ((Button)sender).Name;

            // ボタン名→ボタン番号
            int btnNumber = viewModel.GetBtnNumber(btnName);

            // ボタン番号→管理商品
            Shohin managementShohin = viewModel.GetManagementShohin(btnNumber);

            // 管理商品商品コードを内部処理へ送る
            viewModel.PushShohinButton(managementShohin.ShohinCode); 
        }

    }
}