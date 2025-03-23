using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPModul6_103022300023;

namespace TPModul6_103022300023
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentException("Judul tidak boleh kosong.");
            }

            if (title.Length > 100)
            {
                throw new ArgumentException("Judul maksimal 100 karakter.");
            }

            Random random = new Random();
            this.id = random.Next(10000, 90000);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            if (count <= 0)
            {
                Console.WriteLine("Play count tidak boleh nol atau negatif!");
                return;
            }

            if (count > 10000000)
            {
                Console.WriteLine("Maksimal play count adalah 10.000.000.");
                return;
            }

            try
            {
                checked
                {
                    this.playCount += count;
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"{ex.Message}");
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("====================================");
            Console.WriteLine($"ID          : {this.id}");
            Console.WriteLine($"Title       : {this.title}");
            Console.WriteLine($"Play Count  : {this.playCount}");
            Console.WriteLine("====================================\n");
        }
    }
}
