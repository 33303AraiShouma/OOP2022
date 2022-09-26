using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleEntitiyFramework.Models {
    public class Author {
        public int ID { get; set; }//主キー
        public string Name { get; set; }
        public string Title { get; set; }
        public DateTime Birthday { get; set; }
        public string Gender { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
