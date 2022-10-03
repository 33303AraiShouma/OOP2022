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
                                     .Where(b => years.Contains(b.PublishedYear));
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

            var groups = Library.Books
                         .Where(b => years.Contains(b.PublishedYear))
                         .GroupBy(b => b.PublishedYear)
                         .OrderBy(g => g.Key);
            foreach (var g in groups)
            {
                Console.WriteLine($"{g.Key}年");
                foreach (var book in g)
                {
                    var category = Library.Categories.Where(b => b.Id == book.CategoryId).First();
                    Console.WriteLine($"タイトル:{book.Title},価格:{book.Price},カテゴリ:{category.Name}");
                }
            }


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