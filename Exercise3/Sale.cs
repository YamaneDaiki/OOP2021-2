﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3 {
    //売上クラス
    public class Sale {
        //店舗名
        public string ShopName{ get; set; }
           
        //商品カテゴリ
        public string ProductCategory { get; set; }

        //売り上げ高
        public int Amount { get; set; }
    }
}
