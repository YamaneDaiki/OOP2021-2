using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var Session = new Dictionary<string, object>();
            Session["MyProduct"] = new Product();
            var product = Session["MyProduct"] as Product;
            if (product == null) {
                //Productが取得できなかった時の処理
                Console.WriteLine("Productが取得できなかった");
            } else {
                //Productが取得できた時の処理
                Console.WriteLine("Productが取得できた");
            }

        }

        private static Product GetProductA() {
            Sale sale = new Sale();
            sale.Product = new Product();
            sale = null;
            return sale?.Product; //null条件演算子
        }
    }

    class Sale {
        public string ShopName { get; set; } = "abcde";
        public int Amount { get; set; } = 12340;
        public Product Product { get; set; }
    }
}
