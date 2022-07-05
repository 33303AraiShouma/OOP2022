using System;
using System.Collections.Generic;
using System.IO;
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
            //確認用
            var text = File.ReadAllText(newfile);
            Console.WriteLine(text);
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
            var xelements = xdoc.Root.Elements()
                                     .OrderByDescending(x => (int)x.Element("teammembers"))
                                     .First();
            Console.WriteLine((string)xelements.Element("name"));
        }

        private static void Exercise1_4(string file, string newfile){
            var element = new XElement("ballsport",
                           new XElement("name", "サッカー",new XAttribute("kanji","蹴玉")),
                           new XElement("teammembers","11"),
                           new XElement("firstplayed", "1848")
                );
            var xdoc = XDocument.Load(file);
            xdoc.Root.Add(element);
            xdoc.Save(newfile);
            
        }
    }
}
