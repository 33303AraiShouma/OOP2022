using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02{
    class Program {
        static void Main(string[] args){

            Console.WriteLine("入力；");
            var inputString1 =Console.ReadLine();
            Console.WriteLine("入力；");
            var inputString2 = Console.ReadLine();

            if (String.Compare(inputString1, inputString2, true) == 0)
            {
                Console.WriteLine("等しい");
            }
            else {
                Console.WriteLine("等しくない");
            }
        }
    }
}
