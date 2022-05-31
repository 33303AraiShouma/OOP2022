using Exercise01;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            /* var ym = new YearMonth(2022,5);

             var check = ym.Is21Century;
             var test = ym.AddOneMonth();

             Console.WriteLine(ym);*/

            //4.2.1
            var ymCollection = new YearMonth[] {
                new YearMonth(1980,1),
                new YearMonth(1990,4),
                new YearMonth(2000,7),
                new YearMonth(2010,9),
                new YearMonth(2020,12),
            };
            //4.2.2
            Exercise2_2(ymCollection);
            Console.WriteLine("-----");

            Exercise2_4(ymCollection);
            Console.WriteLine("-----");

            Exercise2_5(ymCollection);
            Console.WriteLine("-----");

            Exercise2_6_1(ymCollection);
            Console.WriteLine("-----");

            Exercise2_6_2(ymCollection);

        }

       

        //4.2.3
        //最初に見つかった21世紀のオブジェクトを返す
        //見つからない場合はnullを返す

        static YearMonth FindFirst21C(YearMonth[] ymCollection) {
            foreach (var ym in ymCollection) {
                if (ym.Is21Century) {
                    return ym;
                }
            }
            return null;
        }
        private static void Exercise2_2(YearMonth[] ymCollection)  {
            foreach (var ym in ymCollection) {
                Console.WriteLine(ym);
            }
        }
        private static void Exercise2_4(YearMonth[] ymCollection)  {
            var h = FindFirst21C(ymCollection);
            if (h == null)
            {
                Console.WriteLine("21世紀のデータはありません");
            }
            else {
                Console.WriteLine(h);
            }
        }
        private static void Exercise2_5(YearMonth[] ymCollection)
        {
            var array = ymCollection.Select(ym => ym.AddOneMonth()).ToArray();
            foreach (var ym in array)
            {
                Console.WriteLine(ym);
            }
        }
        private static void Exercise2_6_1(YearMonth[] ymCollection)  {
            //①月で昇順に出力　
            foreach (var ym in ymCollection.OrderBy(ym => ym.Month)) {
                Console.WriteLine(ym);
            }
        }
        private static void Exercise2_6_2(YearMonth[] ymCollection)
        {
           //②偶数年のみ昇順に出力
            foreach (var ym in ymCollection.Where(ym => ym.Year % 4 == 0 || ym.Year % 100 ==0 && ym.Year % 400 == 0).OrderBy(ym => ym.Year))
            {
                Console.WriteLine(ym);
            }
        }
    }
}
