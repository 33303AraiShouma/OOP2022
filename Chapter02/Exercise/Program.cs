using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    class Program {
        static void Main(string[] args) {
            var songs = new Song[] {
                new Song("a","b",13),
                new Song("c","d",14)

            };
            PrintSongs(songs);
        }
         static void PrintSongs(IEnumerable<Song> songs) {
            foreach (var song in songs) {
                Console.WriteLine("{0},{1},{2:m\\:ss}",song.Title,song.ArtistName,TimeSpan.FromSeconds(song.Length));
            }
        }
    }
}
