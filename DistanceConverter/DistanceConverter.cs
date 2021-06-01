using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
     //インチとメートルの単位変更クラス(静的ラス)
     public static class DistanceConverter {
        private const double ratio = 0.3048;
         //メートルからインチを求める
         public static double FromMeter(double meter) {
             return meter / ratio;
         }

         //インチからメートルを求める
         public static double ToMeter(double feet) {
             return feet * ratio;
         }
     }
}

