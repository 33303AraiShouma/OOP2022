using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args)    {
            var numbers = new int[] { 5, 10, 17, 9, 3, 21, 10, 40, 21, 3, 35 };

            Exercise1_1(numbers);
            Console.WriteLine("-----");

            Exercise1_2(numbers);
            Console.WriteLine("-----");

            Exercise1_3(numbers);
            Console.WriteLine("-----");

            Exercise1_4(numbers);
            Console.WriteLine("-----");  

            Exercise1_5(numbers);

        }

        private static void Exercise1_1(int[] numbers)
        {
            //最大値
            var max = numbers.Max();
            Console.WriteLine(max);
        }

        private static void Exercise1_2(int[] numbers)
        {
            //最後から二つの要素を取り出し
            foreach (var item in numbers.Skip(numbers.Length -2)) {
                Console.WriteLine(item);
            } 
        }

        private static void Exercise1_3(int[] numbers)
        {
            //数値を文字列へ変換
            foreach (var number in numbers)   {
                string str = number.ToString();
                Console.WriteLine(str);
            }
        }

        private static void Exercise1_4(int[] numbers)
        {
            //小さい順に並べて先頭の３つを出力
            var a = numbers.OrderBy(n => n).ToArray();
            for (int i = 0; i < 3; i++) {
                Console.WriteLine(a[i]);
            }
        }

        private static void Exercise1_5(int[] numbers)
        {
            //重複を排除し10より大きい数がいくつあるか
        }
    }
}
