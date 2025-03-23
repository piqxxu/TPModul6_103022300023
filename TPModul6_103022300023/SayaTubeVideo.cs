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
            Random random = new Random();
            this.id = random.Next(10000, 90000);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            this.playCount += count;
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
