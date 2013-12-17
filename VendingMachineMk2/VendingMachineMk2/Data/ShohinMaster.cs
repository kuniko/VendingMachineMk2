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
    public static class ShohinMaster {

        public const string ShohinCode_Otya = "Otya-001";
        public const string ShohinCode_Conpota = "Conpota-001";
        public const string ShohinCode_Coke = "Coke-001";


        public static IEnumerable<Shohin> ShouhinCatalogue() {
            yield return Otya();
            yield return Conpota();
            yield return Coke();
        }

        static public Shohin Otya() {
            return new Shohin(ShohinCode_Otya, "わーいお茶", 120);
        }
        static public Shohin Conpota() {
            return new Shohin(ShohinCode_Conpota, "コンポタ☆", 120);
        }
        static public Shohin Coke() {
            return new Shohin(ShohinCode_Coke, "コカ", 120);
        }
    }
}
