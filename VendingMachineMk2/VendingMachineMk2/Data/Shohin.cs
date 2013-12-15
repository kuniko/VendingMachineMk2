using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineMk2.Data {
   public  class Shohin {
        public Shohin(string shohinCode, string shohinName, int sellingYen) {
            this.ShohinCode = shohinCode;
            this.ShohinName = shohinName;
            this.SellingYen = sellingYen;
        }

        public int SellingYen { get; set; }
        public string ShohinCode { get; set; }
        public string ShohinName { get; set; }
    }
}
