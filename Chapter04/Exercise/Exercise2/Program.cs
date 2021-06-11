using Exercise1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2 {
    class Program {
        static void Main(string[] args) {
            //4.2.1
            var ymCollection = new YearMonth[] {
                new YearMonth(1980,1),
                new YearMonth(1990,4),
                new YearMonth(2000,7),
                new YearMonth(2010,9),
                new YearMonth(2020,12),
            };
            //4.2.2
            Exception2_2(ymCollection);
            Console.WriteLine("-----");

            //4.2.4
            Exception2_4(ymCollection);
            Console.WriteLine("-----");

            //4.2.5
            Exception2_5(ymCollection);
            Console.WriteLine("-----");

        }

        private static void Exception2_2(YearMonth[] ymCollection) {
            foreach (var n in ymCollection) {
                Console.WriteLine(n);
            }
            
        }

        //4.2.3
        static YearMonth FindFirst21C(YearMonth[] ymCollection) {
            foreach (var i in ymCollection) {
                if (i.Is21Century)
                    return i;
            }
            return null;
        }

        private static void Exception2_4(YearMonth[] ymCollection) {
            var yesrmonth = FindFirst21C(ymCollection);
            var s = yesrmonth != null ? yesrmonth.Year.ToString() : "21世紀のデータはありません";
            Console.WriteLine(s);
        }

        private static void Exception2_5(YearMonth[] ymCollection) {
            var ones = ymCollection.Select( x => x.AddOneMonth()).OrderBy ( x => x.Year );
            foreach (var item in ones) Console.WriteLine(item);
        }
    }
}