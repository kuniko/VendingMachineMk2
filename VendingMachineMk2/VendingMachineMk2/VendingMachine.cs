using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VendingMachineMk2.Core;

namespace VendingMachineMk2 {
    public partial class VendingMachine : Form {

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



        private void BtnShohin01_OnClick(object sender, EventArgs e) {
            T2WindowsFormController viewModel = T2WindowsFormController.GetInstance();
            viewModel.PushButton(VendingMachineMk2.Data.ShohinMaster.Otya().ShohinCode); //todo とりあえず。
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




    }
}
