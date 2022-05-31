using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise02 {
    class Program {
        static void Main(string[] args) {
            Console.Write("入力1；");
            var inputString1 = Console.ReadLine();
            
            if (int.TryParse(inputString1,out var num)) {
                Console.WriteLine(String.Format("{0:#,0}", num));
            }
        }
    }
}
