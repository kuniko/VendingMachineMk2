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

        private const string ShohinCode_Otya = "Otya-001";
        private const string ShohinCode_Conpota = "Conpota-001";
        private const string ShohinCode_Coke = "Coke-001";


        public static IEnumerable<Shohin> ShouhinCatalogue() {
            yield return Otya();
            yield return Conpota();
            yield return Coke();
        }

        static public Shohin Otya() {
            return new Shohin(ShohinCode_Otya, "わーいお茶", 120, Properties.Resources.Can03);
        }
        static public Shohin Conpota() {
            return new Shohin(ShohinCode_Conpota, "コンポタ☆", 120, Properties.Resources.Can04);
        }
        static public Shohin Coke() {
            return new Shohin(ShohinCode_Coke, "コカ", 120, Properties.Resources.Can02);
        }

        /// <summary>
        /// 商品が無い時はException吐きますよ。
        /// </summary>
        /// <param name="shohinCode"></param>
        /// <returns></returns>
        public static Shohin SelectShohin(string shohinCode) {
            Shohin selectedShohin = ShouhinCatalogue().Single(shohin => string.Equals(shohin.ShohinCode, shohinCode));
            return selectedShohin;
        }
    }
}
