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

        public static readonly string ShohinCode_Otya = "Otya-001";
        public static readonly string ShohinCode_Conpota = "Conpota-001";
        public static readonly string ShohinCode_Coke = "Coke-001";


        public static IEnumerable<Shouhin> ShouhinCatalogue() {
            yield return Otya();
            yield return Conpota();
            yield return Coke();
        }

        static public Shouhin Otya() {
            return new Shouhin(ShohinCode_Otya, "わーいお茶", 120);
        }
        static public Shouhin Conpota() {
            return new Shouhin(ShohinCode_Conpota, "コンポタ☆", 120);
        }
        static public Shouhin Coke() {
            return new Shouhin(ShohinCode_Coke, "コカ", 120);
        }
    }
}
