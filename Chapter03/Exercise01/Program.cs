using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01 {
    class Program {
        static void Main(string[] args) {
            var numbers = new List<int> { 12,87,94,14,53,20,40,35,76,91,31,17,48};
            Exercise1_1(numbers);
            Console.WriteLine("-------------");
            Exercise1_2(numbers);
            Console.WriteLine("-------------");
            Exercise1_3(numbers);
            Console.WriteLine("-------------");
            Exercise1_4(numbers);
            Console.WriteLine("-------------");
            Exercise1_5(numbers);
            Console.WriteLine("-------------");
        }

        

        private static void Exercise1_1(List<int> numbers) {
            var exists = numbers.Exists(s=> s % 8  == 0 || s % 9 == 0);
            if (exists)
            {
                Console.WriteLine("存在しています");
            }
            else {
                Console.WriteLine("存在していません");
            }
        }
        private static void Exercise1_2(List<int> numbers) {
            numbers.ForEach(n => Console.WriteLine(n / 2.0));
        }
        private static void Exercise1_3(List<int> numbers) {
           
            foreach (var number in numbers.Where(i => i >= 50)) {
                Console.WriteLine(number);
            }    
        }
        private static void Exercise1_4(List<int> numbers)
        {
            foreach (var number in numbers.Select(s => s * 2)) {
                Console.WriteLine(number);
            }
        }
        private static void Exercise1_5(List<int> numbers){
            var sum = numbers.Sum(i => i);
            Console.WriteLine(sum);
        }
    }
}
