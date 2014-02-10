using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VendingMachineMk2.Data {
    /// <summary>
    /// ボタンと管理商品を結びつける設定資料(ハッシュマップ)
    /// （20131226：とりあえず結びつきの設定をハッシュマップで強引に設定）
    /// </summary>
    public class BtnLinkShohinMap{

        private static VendingMachine _view;

        /// <summary>
        /// あきらめてお決まりにする。 ←「_View」が必要だったのでそのままコピー　orz
        /// </summary>
        /// <param name="view"></param>
        public static void SetView(VendingMachine view) {
            _view = view;
        }

        /// <summary>
        /// ボタンと管理商品を結びつける設定資料を作成する 
        /// </summary>
        /// <returns>btnNameLinkBtnNumMap:ボタンと管理商品を結びつける設定資料</returns>
        public Dictionary<Object, Shohin> MakeMapOfBtnLinkShohin(){
            Dictionary<Object, Shohin> btnLinkShohinMap = new Dictionary<Object, Shohin>();       // インスタンスの生成

            // ボタンと管理商品を結びつける設定資料
            btnLinkShohinMap.Add(_view.btnShohin01, ShohinMaster.Otya());
            btnLinkShohinMap.Add(_view.btnShohin02, ShohinMaster.Conpota());
            btnLinkShohinMap.Add(_view.btnShohin03, ShohinMaster.Coke());
            btnLinkShohinMap.Add(_view.btnShohin04, ShohinMaster.Otyada());

            return btnLinkShohinMap;
        }

    }
}
