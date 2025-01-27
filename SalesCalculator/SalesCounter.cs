﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {
    //売上げ集計クラス
    class SalesCounter {
        private List<Sale> _sales;

        //コンストラクタ
        public SalesCounter(string filePath) {
            _sales = ReadSales(filePath);
        }

        //LIst 2-15
        //売り上げデータを読み込み、Saleオブジェクトのリストを返す
        private static List<Sale> ReadSales(string filePath) {
            List<Sale> sales = new List<Sale>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines) {
                string[] items = line.Split(',');
                Sale sale = new Sale {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amoount = int.Parse(items[2])
                };
                sales.Add(sale);
            }
            return sales;
        }

        //LIst 2-17
        //売上データを読み込み、Saleオブジェクトのリストを返す
        public Dictionary<string, int> GetPerStoreSales() {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (Sale sale in _sales) {
                if (dict.ContainsKey(sale.ShopName))
                    //既にコレクションに店舗が設定されている
                    dict[sale.ShopName] += sale.Amoount;
                else
                    //コレクションへ店舗を登録
                    dict[sale.ShopName] = sale.Amoount;
            }
            return dict;
        }

    }
}
