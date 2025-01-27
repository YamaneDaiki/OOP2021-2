﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverter {
    class Program {
        static void Main(string[] args) {
            if (args.Length >= 1 && args[0] == "-tom") {
                //フィールドからメートルへの対応差を出力
                PrintFeetToMeterList(1,10);
            } else {
                //メートルからフィートへの対応表を出力
                PrintMeterToFeetList(1,10);
            }
        } 
        //フィールドからメートルへの対応差を出力
        private static void PrintFeetToMeterList (int start, int stop) {
            //FeetConverter feet1 = new FeetConverter();
            for (int feet = start; feet <= stop; feet++) {
                double meter = DistanceConverter.ToMeter(feet);
                Console.WriteLine("{0} ft = {1:0.0000}m", feet, meter);
            }
        }
        //メートルからフィートへの対応表を出力
        private static void PrintMeterToFeetList(int start,int stop) {
            //FeetConverter feet1 = new FeetConverter();
            for (int meter = start; meter <= stop; meter++) {
                double feet = DistanceConverter.FromMeter(meter);
                Console.WriteLine("{0} m = {1:0.0000}ft", meter, feet);
            }
        }
       

        

    }
}
