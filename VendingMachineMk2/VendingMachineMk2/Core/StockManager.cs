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

        private static StockManager _instance;

        private List<Shohin> _stockList = new List<Shohin>();

        
        private StockManager() {
            Initiaize();
        }

        public static StockManager GetInstance() {
            if (_instance == null) {
                _instance = new StockManager();
            }
            return _instance;
        }

        /// <summary>
        /// どーしようかな。
        /// </summary>
        private void Initiaize() {
            _stockList.Add(ShohinMaster.Otya());
            _stockList.Add(ShohinMaster.Otya());
            _stockList.Add(ShohinMaster.Otya());
            _stockList.Add(ShohinMaster.Conpota());
            _stockList.Add(ShohinMaster.Coke());
        }

        public bool CanBuy(string shohinCode, int insertedYen) {

            var canBuy = _stockList.Any(stock =>   (stock.ShohinCode == shohinCode) 
                                                && (insertedYen >= stock.SellingYen));

            return canBuy;
        }

        public void ShohinDasu(string shohinCode) {
            if (!_stockList.Any(stock => stock.ShohinCode == shohinCode)) {
                throw new InvalidProgramException("在庫ないのに商品出せるってどういうプログラムですか？");
            }

            Shohin shouhin = _stockList.First(stock => stock.ShohinCode == shohinCode);
            _stockList.Remove(shouhin);
        }


    }


}