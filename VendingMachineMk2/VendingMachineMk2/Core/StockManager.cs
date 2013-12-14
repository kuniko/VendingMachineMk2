using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachineMk2.Data;

namespace VendingMachineMk2.Core {
    class StockManager {

        private StockManager _instance;

        private List<SellItem> _stockList = new List<SellItem>();

        

        private StockManager() { }

        public StockManager GetInstance() {
            if (_instance == null) {
                _instance = new StockManager();
            }
            return _instance;
        }

        private void Initiaize() {
            _stockList.Add(new SellItem("KAN_0001", "", 120));
        }



    }


}