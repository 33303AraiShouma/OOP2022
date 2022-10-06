using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter15 {
    class Program {
        static void Main(string[] args)
        {
            var years = new List<int>();
            int year;

            Console.WriteLine("出力したい西暦を入力　終了：-１");
            year = int.Parse(Console.ReadLine());
            while (year != -1)
            {
                years.Add(year);
                year = int.Parse(Console.ReadLine());
            }
            var books = Library.Books
                                .Where(b=>years.Contains(b.PublishedYear))
                               .OrderByDescending(b => b.PublishedYear);
            Console.Write("昇順:1 降順:2  ");
            var number = int.Parse(Console.ReadLine());
            if (number ==1)
            {
                foreach (var book in books.OrderBy(a => a.PublishedYear))
                {
                    Console.WriteLine(book);
                }
            }
            if (number == 2) {
                foreach (var book in books.OrderByDescending(a => a.PublishedYear))
                {
                    Console.WriteLine(book);
                }
            }
            Console.WriteLine(" ");

            var selected =  Library.Books
                         .Where(b=>years.Contains(b.PublishedYear))
                         .Join(Library.Categories,//結合する2番目のシーケンス
                         　　　book => book.CategoryId,//対象シーケンスの結合キー
                         　　　category => category.Id,//２番目のシーケンスキー
                         　　　(book, category) => new
                         　　　{
                             　　　Title = book.Title,
                             　　　Category = category.Name,
                             　　　PublishedYear = book.PublishedYear,
                                   price = book.Price,
                         }
                         ).ToList() ;
            foreach (var g in selected.OrderByDescending(x=>x.PublishedYear).ThenBy(x=>x.Category))
            {
                Console.WriteLine($"{g.PublishedYear},{g.Title},{g.Category},{g.price}");
                //var category = Library.Categories.Where(b => b.Id == g.CategoryId).First();
                //Console.WriteLine($"タイトル:{g.Title},価格:{g.Price},カテゴリ:{category.Name}");
            }
            Console.WriteLine($"金額の合計{selected.Sum(b=>b.price)}円");

            /*while (true)
            {
                years.Add(int.Parse(Console.ReadLine()));
                if (years.Contains(-1))
                {
                    var books = Library.Books
                                     .Where(b => years.Contains(b.PublishedYear));
                    var number = int.Parse(Console.ReadLine());

                    if (number == 1)
                    {
                        foreach (var book in books.OrderBy(b => b.PublishedYear))
                        {
                            Console.WriteLine(book);
                        }
                    }
                    else {
                        foreach (var book in books.OrderByDescending(a => a.PublishedYear))
                        {
                            Console.WriteLine(book);
                        }
                    }
                    
                    break;
                }
            }*/
        }
    }
}