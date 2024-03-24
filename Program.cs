using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MOD6_1302223146
{
    class Program
    {

        public class SayaTubeVideo
        {
            private int id;
            private string title;
            private int playCount;

            public SayaTubeVideo(String title)
            {
                this.title = title;
                Random rand = new Random();
                int min = 100000;
                int max = 999999;
                this.id = rand.Next(min, max + 1);
                this.playCount = 0;
            }

            public void IncreasePlayCount(int playCount)
            {
                this.playCount = this.playCount + playCount;
            }

            public void PrintVideoDetails()
            {
                Console.WriteLine("ID Video : " + id);
                Console.WriteLine("Title Video : " + title);
                Console.WriteLine("Jumlah Tontonan : " + playCount);
            }

            static void Main(string[] args)
            {

                String vid1 = "Tutorial Design By Contract - Fajar Ramadhan";
                SayaTubeVideo sayaTubeVideo = new SayaTubeVideo(vid1);
                sayaTubeVideo.PrintVideoDetails();
                Console.Read();

            }
        }
    }
}