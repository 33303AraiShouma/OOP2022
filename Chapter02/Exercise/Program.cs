using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    class Program {
        static void Main(string[] args) {

            /*var songs = new List<Song>();

             songs.Add( new Song("a","b",6));
             songs.Add(new Song("c", "d", 7));
             songs.Add(new Song("e", "f", 8));
             songs.Add(new Song("g", "h", 9));
             */
            //2.1.3
            var songs = new Song[] {
            new Song("a","b",250),
            new Song("c", "j", 240),
            new Song("e", "f", 382),
            };
            PrintSongs(songs);
          }

        //2.1.4.
       private static void PrintSongs(Song[] songs) {
            foreach (var song in songs) {
                /* var t = TimeSpan.FromSeconds(song.Length);
                 var result = (int)t.TotalMinutes + ":" + t.Seconds;
                 Console.WriteLine("{0},{1},{2}"
                     ,song.Title,song.ArtistName,result);*/
                Console.WriteLine("{0},{1},{2:m\\:ss}",song.Title,song.ArtistName,TimeSpan.FromSeconds(song.Length));
       


            }
        }
        private static void PrintSongs(List<Song> songs) { 
        }
    }
}
