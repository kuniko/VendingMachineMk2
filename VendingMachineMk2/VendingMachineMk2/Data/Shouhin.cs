using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineMk2.Data {
   public  class Shouhin {
        public Shouhin(string itemCode, string name, int sellingYen) {
            this.ItemCode = itemCode;
            this.Name = name;
            this.SellingYen = sellingYen;
        }

        public int SellingYen { get; set; }
        public string ItemCode { get; set; }
        public string Name { get; set; }
    }
}
