using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachineMk2.Data;

namespace VendingMachineMk2.Core {

    /// <summary>
    /// 商品の『在庫』を管理するManager
    /// </summary>
    class StockManager {

        private StockManager _instance;

        private List<Shouhin> _stockList = new List<Shouhin>();

        
        private StockManager() {
            Initiaize();
        }

        public StockManager GetInstance() {
            if (_instance == null) {
                _instance = new StockManager();
            }
            return _instance;
        }

        /// <summary>
        /// どーしようかな。
        /// </summary>
        private void Initiaize() {
            _stockList.Add(ShouhinMaster.Otya());
            _stockList.Add(ShouhinMaster.Otya());
            _stockList.Add(ShouhinMaster.Otya());
            _stockList.Add(ShouhinMaster.Conpota());
            _stockList.Add(ShouhinMaster.Coke());
        }



    }


}