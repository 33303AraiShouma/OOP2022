using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    class Song {
        //プロパティー
        public string Title { get; set; }
        public string ArtistName { get; set; }
        public int Length { get; set; }

        //コンストラクタ
        public Song(string title,string artistname,int length) {
            title = Title;
            artistname = ArtistName;
            length = Length;
        }
    }
}
