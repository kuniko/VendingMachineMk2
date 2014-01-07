using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachineMk2;
using VendingMachineMk2.Core;
using VendingMachineMk2.Data;



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

            // 商品の種類を商品コードから取得
            //Shohin shohinType = ShohinMaster.SelectShohin(shohinCode);

            // 結びつき設定を持つマップを取得
            Dictionary<Object, Shohin> btnNumLinkShouhinMap = MakeMapOfBtnLinkShohin();

            // 商品の種類から対応するボタンを取得
            Object btn = GetBtnByShohinType(btnNumLinkShouhinMap, shohinCode);

            // ボタンの有効無効切り替えを行う（Viewへ）
            _view.RefleshView_CanBuyShohin(btn, canBuy);

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


        /// <summary>
        /// 取得したボタンから、管理商品の商品コードを取得する。 
        /// </summary>
        /// <param name="btnName">押下したボタン</param>
        /// <returns>管理商品の商品コードを返す。</returns>
        public Shohin GetManagementShohin(object pushBtn)
        {
            // 結びつき設定を持つマップを取得
            Dictionary<Object, Shohin> btnNameLinkBtnNumMap = MakeMapOfBtnLinkShohin();

            // 押下されたボタンから管理商品を取得
            Shohin managementShohin = btnNameLinkBtnNumMap[pushBtn];

            return managementShohin;
        }


        /// <summary>
        /// ハッシュマップの逆引きをする（値からキーを取得する）
        /// 商品マスターの商品コードを判断値にし、値を判定、値と対となるキーを返す
        /// </summary>
        /// <param name="dictionaries">逆引き対象ハッシュマップ</param>
        /// <param name="shohinCode">判断値とする商品コード</param>
        /// <returns>値と対となるキーを返す。</returns>
        public Object GetBtnByShohinType(Dictionary<Object, Shohin> dictionaries, String shohinCode)
        {
            return dictionaries.FirstOrDefault(x => x.Value.ShohinCode == shohinCode).Key;
        }


        /// <summary>
        /// ボタンと管理商品を結びつける設定資料を作成する 
        /// （20131226：とりあえず結びつきの設定をハッシュマップで強引に設定）
        /// （Todo：値の設定資料はDataフォルダのなかに入れたいんだけど、ディクショナリーさんがうまく使えなくなるのでひとまずここ）
        /// </summary>
        /// <returns>btnNameLinkBtnNumMap:ボタンと管理商品を結びつける設定資料</returns>
        public Dictionary<Object, Shohin> MakeMapOfBtnLinkShohin()
        {
            Dictionary<Object, Shohin> btnLinkShouhinMap = new Dictionary<Object, Shohin>();       // インスタンスの生成

            // ボタンと管理商品を結びつける設定資料
            btnLinkShouhinMap.Add(_view.btnShohin01, ShohinMaster.Otya());
            btnLinkShouhinMap.Add(_view.btnShohin02, ShohinMaster.Conpota());
            btnLinkShouhinMap.Add(_view.btnShohin03, ShohinMaster.Coke());
            btnLinkShouhinMap.Add(_view.btnShohin04, ShohinMaster.Otyada());

            return btnLinkShouhinMap;
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

