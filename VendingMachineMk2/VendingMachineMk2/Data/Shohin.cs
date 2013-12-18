using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineMk2.Data {
    using System.Drawing;

    public  class Shohin {
        public Shohin(string shohinCode, string shohinName, int sellingYen, Image shohinImage) {
            this.ShohinCode = shohinCode;
            this.ShohinName = shohinName;
            this.SellingYen = sellingYen;
            this.ShohinImage = shohinImage;
        }

        public int SellingYen { get; set; }
        public string ShohinCode { get; set; }
        public string ShohinName { get; set; }

        /// <summary>
        /// 商品画像
        /// </summary>
        public Image ShohinImage { get; set; }
    }
}
