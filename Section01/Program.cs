using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };
            var names = new List<string> { "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong", };

            // 3.1.1
            Exercise1_1(numbers);
            Console.WriteLine("-----");

            // 3.1.2
            Exercise1_2(numbers);
            Console.WriteLine("-----");

            // 3.1.3
            Exercise1_3(numbers);
            Console.WriteLine("-----");

            // 3.1.4
            Exercise1_4(numbers);
            Console.WriteLine("-----");
            // 3.2.1
            Exercise2_1(names);
            Console.WriteLine("-----");

            // 3.2.2
            Exercise2_2(names);
            Console.WriteLine("-----");

            // 3.2.3
            Exercise2_3(names);
            Console.WriteLine("-----");

            // 3.2.4
            Exercise2_4(names);
            Console.WriteLine("-----");


        }
        //できた人問題
        private static void Exercise2_5(List<string> names) {
            int count = 0;
            foreach (var name in names) {
                count += name.Count(c => char.IsLower(c));
            }
            Console.WriteLine(count);
        }



        private static void Exercise1_1(List<int> numbers) {
            var exist = numbers.Exists(n => n % 8 == 0 || n % 9 == 0);

            if (exist)
                Console.WriteLine("存在しています。");
            else
                Console.WriteLine("存在していません。");
        }

        private static void Exercise1_2(List<int> numbers) {
            numbers.ForEach(n => Console.WriteLine(n / 2.0));
        }

        private static void Exercise1_3(List<int> numbers) {
            foreach (int n in numbers.Where(n => 50 <= n))
                Console.WriteLine(n);

        }

        private static void Exercise1_4(List<int> numbers) {
            foreach (int n in numbers.Select(n => n * 2)) {
                Console.WriteLine(n);
            }
        }



        private static void Exercise2_1(List<string> names) {
            Console.WriteLine("都市名を入力");
            var line = Console.ReadLine();// 入力データの取り込み
            var index = names.FindIndex(s => s == line);
            Console.WriteLine(index);
        }

        private static void Exercise2_2(List<string> names) {
            var count = names.Count(s => s.Contains('o'));
            Console.WriteLine(count);
        }

        private static void Exercise2_3(List<string> names) {
            var where = names.Where(s => s.ToString().Contains('o'));
            foreach (var n in where) {
                Console.WriteLine(n);
            }
        }

        private static void Exercise2_4(List<string> names) {
            var where = names.Where(s => s.StartsWith("B")).Select(s => s.Length);
            foreach (var n in where) {
                Console.WriteLine(n);
            }
        }
    }
}
