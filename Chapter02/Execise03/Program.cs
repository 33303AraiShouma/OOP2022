using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Execise03 {
    class Program {
        static void Main(string[] args) {
            while (true)
            {
                Console.WriteLine("売上高の表示選択");
                Console.WriteLine("1.店舗別");
                Console.WriteLine("2.商品カテゴリー別");
                Console.Write(">");
                int n = int.Parse(Console.ReadLine());


                if (n == 1)
                {
                    var sales = new SalesCounter("sales.csv");
                    var amountPerStore = sales.GetPerStoreSales();
                    foreach (var obj in amountPerStore)
                    {
                        Console.WriteLine("{0}{1}", obj.Key, obj.Value);
                    }
                }
                else if (n == 2)
                {
                    var sales = new SalesCounter("sales.csv");
                    var amountPerStore = sales.GetPerProductSales();
                    foreach (var obj in amountPerStore)
                    {
                        Console.WriteLine("{0}{1}", obj.Key, obj.Value);
                    }
                }
                else if (n == 999)
                {
                    break;
                }
                
            }
            Console.WriteLine("終了");
        }
    }
}
