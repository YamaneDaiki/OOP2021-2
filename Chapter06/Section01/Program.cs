using Chapter06;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var books = Books.GetBooks();

            Console.WriteLine("本の平均価格は" + books.Average(x => x.Price).ToString("#,0") + "円");
            Console.WriteLine("本の総ページ数は" + books.Sum(x => x.Pages)+"ページ");
            Console.WriteLine("一番高価な本は" + books.Max(x => x.Price) + "円");
            Console.WriteLine("一番安価な本は" + books.Min(x => x.Price) + "円");
            //500円以上の本は何冊
            Console.WriteLine("500円以上の本は" + books.Where(x => 500 <= x.Price).Count() + "冊");
            //タイトルに「物語」が含まれている冊数
            Console.WriteLine("「物語」は" + books.Count(x => x.Title.Contains("物語")) + "冊");
            //タイトルに「物語」が含まれている本の一覧
            var bookData = books.Where(x => x.Title.Contains("物語")).Take(3);
            foreach (var book in bookData) {
                Console.WriteLine(book.Title);
            }
            //高額書籍ベスト3
            var rnc = books.OrderByDescending(x => x.Price).Take(3);
            foreach (var item in rnc) {
                Console.WriteLine(item.Price+ "円　" +item.Title);//
            }
            Console.WriteLine();

            var title = books.Select(x => x.Title);
            foreach (var item in title) {
                Console.WriteLine(title);
            }
        }
    }
}
