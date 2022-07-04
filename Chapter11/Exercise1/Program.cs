using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise1 {
    class Program {
        static void Main(string[] args){
            var file = "Sample.xml";
            Exercise1_1(file);
            Console.WriteLine();
            Exercise1_2(file);
            Console.WriteLine();
            Exercise1_3(file);
            Console.WriteLine();

            var newfile = "sports.xml";
            Exercise1_4(file, newfile);
        }

        private static void Exercise1_1(string file) {
            var xdoc = XDocument.Load(file);
            var xelements = xdoc.Root.Elements()
                                .Select(x => new {
                                    Name = (string)x.Element("name"),
                                    number = (int)x.Element("teammembers")
                                });
            foreach (var xelement in xelements){
                Console.WriteLine("{0}{1}",xelement.Name,xelement.number);
            }
        }

        private static void Exercise1_2(string file){
            var xdoc = XDocument.Load(file);
            var xelements = xdoc.Root.Elements()
                               .Select(x => new {
                                   Name = (string)x.Element("name").Attribute("kanji"),
                                   Date = (int)x.Element("firstplayed")

                               });
            foreach (var xelement in xelements.OrderBy(x => x.Date)){
                Console.WriteLine("{0}({1})",xelement.Name,xelement.Date);
            }
        }

        private static void Exercise1_3(string file){
            var xdoc = XDocument.Load(file);
            var xelements = xdoc.Root.Elements().Max(x =>(int)x.Element("teammembers").Element("name"));
           
        }

        private static void Exercise1_4(string file, string newfile){
           
        }
    }
}
