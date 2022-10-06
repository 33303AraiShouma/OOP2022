using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args){
            Exercise1_2();
            Console.WriteLine();
            Exercise1_3();
            Console.WriteLine();
            Exercise1_4();
            Console.WriteLine();
            Exercise1_5();
            Console.WriteLine();
            Exercise1_6();
            Console.WriteLine();
            Exercise1_7();
            Console.WriteLine();
            Exercise1_8();

            Console.ReadLine();
        }

        private static void Exercise1_2()
        {
            var max = Library.Books.Max(b=> b.Price);
            var book = Library.Books.First(b=>b.Price == max);
            Console.WriteLine(book);
        }

        private static void Exercise1_3()
        {
            var d = Library.Books.GroupBy(b => b.PublishedYear)
                                     .Select(c => new {
                                         Year = c.Key,
                                         count = c.Count()
                                     });
            foreach (var item in d)
            {
                Console.WriteLine($"{item.Year}年　{item.count}冊");
            }
        }

        private static void Exercise1_4(){

            var x = Library.Books.OrderByDescending(a => a.PublishedYear)
                                 .ThenByDescending(b => b.Price)
                                 .Join(Library.Categories,
                                       book => book.CategoryId,
                                       category => category.Id,
                                       (book, category) => new
                                       {
                                           Title = book.Title,
                                           category = category.Name,
                                           PublishYear = book.PublishedYear,
                                           Price = book.Price
                                       }
                                    );
            foreach (var item in x)
            {
                Console.WriteLine($"{item.PublishYear}年 {item.Price}円 {item.Title}({item.category})");
            }
        }

        private static void Exercise1_5()
        {
            var names = Library.Books.Where(b => b.PublishedYear == 2016)
                        .Join(Library.Categories,
                              Book => Book.CategoryId,
                              Category => Category.Id,
                              (Book, Category) => Category.Name)
                              .Distinct();
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }

        private static void Exercise1_6()
        { 
        }

        private static void Exercise1_7()
        {
            
        }

        private static void Exercise1_8()
        {
            
        }
    }
}
