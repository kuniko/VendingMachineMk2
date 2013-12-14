using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachineMk2.Data {
    /// <summary>
    /// 商品マスタですけど･･･仮です。
    /// DBにしようかなぁ、txtファイルにしようかなぁ。
    /// </summary>
    public static class ShouhinMaster {

        static public Shouhin Otya() {
            return new Shouhin("Otya-001", "わーいお茶", 120);
        }
        static public Shouhin Conpota() {
            return new Shouhin("Conpota-001", "コンポタ☆", 120);
        }
        static public Shouhin Coke() {
            return new Shouhin("Coke-001", "コカ", 120);
        }
    }
}
