using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleEntitiyFramework.Models;

namespace SampleEntitiyFramework {
    class Program {
        static void Main(string[] args)
        {
            InsertBooks();
            AddAuthors();
             var books = GetAllBooks();
            foreach (var b in books)
            {
                Console.WriteLine("出版日:{0} タイトル:{1} 著者名:{2} ({3})", b.PublishedYear, b.Title,b.Author.Name,b.Author.Birthday);

            }
            var bookss = Exercise_03();
            foreach (var book in bookss)
            {
                Console.WriteLine(book.Title);
            }
            var old = Exercise_04();
            foreach (var oldbook in old)
            {
                Console.WriteLine($"{oldbook.Author.Name} {oldbook.Title}");
            }
            var authors = Exercise_05();
            foreach (var a in authors)
            {
                Console.WriteLine("{0}{1:yyyy/MM}",a.Name,a.Birthday);
                foreach (var aa in a.Books)
                {
                    Console.WriteLine("{0} {1}",aa.Title,aa.PublishedYear,aa.Author.Name,aa.Author.Birthday);
                }
            }
        }
        static void InsertBooks()
        {
            using (var db = new BooksDbContext())
            {
                var book1 = new Book
                {
                    Title = "坊ちゃん",
                    PublishedYear = 2003,
                    Author = new Author
                    {
                        Birthday = new DateTime(1867, 2, 9),
                        Gender = "M",
                        Name = "夏目漱石",
                    }
                };

                db.Books.Add(book1);

                var book2 = new Book
                {
                    Title = "人間失格",
                    PublishedYear = 1990,
                    Author = new Author
                    {
                        Birthday = new DateTime(1909, 6, 19),
                        Gender = "M",
                        Name = "太宰治",
                    }
                };
                db.Books.Add(book2);
                var book3 = new Book
                {
                    Title = "ココロ",
                    PublishedYear = 1991,
                    Author = new Author
                    {
                        Birthday = new DateTime(1991,6,19),
                        Gender = "M",
                        Name = "夏目漱石",
                    }
                };
                var book4 = new Book
                {
                    Title = "伊豆の踊子",
                    PublishedYear = 2003,
                    Author = new Author
                    {
                        Birthday = new DateTime(1899, 6, 14),
                        Gender = "M",
                        Name = "川端康成",
                    }
                };
                db.Books.Add(book4);
                var book5 = new Book
                {
                    Title = "真珠夫人",
                    PublishedYear = 2002,
                    Author = new Author
                    {
                        Birthday = new DateTime(1888, 12, 26),
                        Gender = "M",
                        Name = "菊池寛",
                    }
                };
                db.Books.Add(book5);
                var book6 = new Book
                {
                    Title = "注文の多い料理店",
                    PublishedYear = 2003,
                    Author = new Author
                    {
                        Birthday = new DateTime(1896, 8, 27),
                        Gender = "M",
                        Name = "宮沢賢治",
                    }
                };
                db.Books.Add(book6);
                db.SaveChanges();//データベースの更新
            }
        }
        static IEnumerable<Book> GetAllBooks()
        {
            using (var db = new BooksDbContext())
            {
                return db.Books.Include(nameof(Author)).ToList();
            }
        }
        private static void AddAuthors()
        {
            using (var db = new BooksDbContext())
            {
                /*var author1 = new Author
                {
                    Birthday = new DateTime(1878, 12, 7),
                    Gender = "F",
                    Name = "与謝野晶子"
                };
                db.Authors.Add(author1);
                var author2 = new Author
                {
                    Birthday = new DateTime(1896, 8, 27),
                    Gender = "M",
                    Name = "宮沢賢治"
                };*/
                var author3 = new Author
                {
                    Birthday = new DateTime(1888, 12, 26),
                    Gender = "M",
                    Name = "菊池寛"
                };
                var author4 = new Author
                {
                    Birthday = new DateTime(1899, 6, 14),
                    Gender = "M",
                    Name = "川端康成"
                };
                db.Authors.Add(author3);
                db.SaveChanges();
            }
        }
        // List 13-10
        private static void AddBooks()
        {
            using (var db = new BooksDbContext())
            {
                var author1 = db.Authors.Single(a => a.Name == "与謝野晶子");
                var book1 = new Book
                {
                    Title = "みだれ髪",
                    PublishedYear = 2000,
                    Author = author1,
                };
                db.Books.Add(book1);
                var author2 = db.Authors.Single(a => a.Name == "宮沢賢治");
                var book2 = new Book
                {
                    Title = "銀河鉄道の夜",
                    PublishedYear = 1989,
                    Author = author2,
                };
                db.Books.Add(book2);
                db.SaveChanges();
            }
        }
        static IEnumerable<Book> Exercise_03()
        {
            using (var db = new BooksDbContext())
            {
                return db.Books
                    .Where(b=>b.Title.Length == db.Books.Max(a=>a.Title.Length))
                    .ToList();
            }
        }
        static IEnumerable<Book> Exercise_04()
        {
            using (var db = new BooksDbContext())
            {
                return db.Books
                    .Include(nameof(Author))
                    .OrderBy(b=>b.PublishedYear)
                    .Take(3)
                    .ToList();
            }
        }
        static IEnumerable<Author> Exercise_05()
        {
            using (var db = new BooksDbContext())
            {
                return db.Authors.OrderByDescending(a => a.Birthday).ToList();
            }
        }
    }
}
