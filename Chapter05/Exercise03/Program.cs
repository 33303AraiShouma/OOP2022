using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise03 {
    class Program {
        static void Main(string[] args) {
            var text = "Jackdaws love my big sphinx of quartz";

            Exercise3_1(text);
            Exercise3_2(text);
            Exercise3_3(text);
            Exercise3_4(text);
            Exercise3_5(text);
        }

        

        private static void Exercise3_1(String text) {

            var spaces = text.Count(c => c  == ' ' );
            Console.WriteLine("空白数;{0}",spaces);
        }

        private static void Exercise3_2(String text) {
            var replaced = text.Replace("big","small");
            Console.WriteLine(replaced);
        }
        private static void Exercise3_3(String text) {
            var a = text.Split(' ');
            var b = a.Count();
            Console.WriteLine(b);
        }
        private static void Exercise3_4(String text) {
            var a = text.Split(' ');
            foreach (var f in a) {
                if (f.Length <= 4) {
                    Console.WriteLine(f);
                }
            }
        }
        private static void Exercise3_5(string text) {
            var array = text.Split(' ').ToArray();
            if(array.Length > 0)   {
                var sb = new StringBuilder(array[0]);
                foreach (var word in array.Skip(1)) {
                    sb.Append(' ');
                    sb.Append(word);
                }
                var str = sb.ToString();
                Console.WriteLine(str);
            }
           /* var a = text.Split(' ');
            var sb = new StringBuilder();
            foreach (var f in a) {
                sb.Append(f);
                sb.Append(' ');
           */
            }
            /*var d = sb.ToString();
            Console.WriteLine(d);*/
    }
}
