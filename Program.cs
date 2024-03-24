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
                int max = 100;
                Contract.Requires(title.Length < max && title != null);
                try
                {
                    checked
                    {
                        if ((title == null))
                        {
                            throw new ArgumentException("Title tidak bisa kosong");
                        }
                        else if (title.Length > max)
                        {
                            throw new ArgumentException("Title tidak bisa melebihi 100 karakter");
                        }
                        this.title = title;
                        Random rand = new Random();
                        int minRand = 10000;
                        int maxRand = 99999;
                        this.id = rand.Next(minRand, maxRand + 1);
                        this.playCount = 0;
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error : {ex.Message}");
                }
                Contract.Ensures(this.title.Length < max && title != null);
            }
            public void IncreasePlayCount(int playCount)
            {
                if (this.title != null)
                {
                    int max = 10000000;
                    Contract.Requires(playCount < max);
                    try
                    {
                        checked
                        {
                            if (this.playCount + playCount > max)
                            {
                                throw new OverflowException("Jumlah PlayCount melebihi 10.000.000");
                            }
                            this.playCount += playCount;
                        }
                    }
                    catch (OverflowException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    Contract.Ensures(this.playCount < max);
                }
            }
            public void PrintVideoDetails()
            {
                if (this.title != null && this.playCount < 10000000)
                {
                    Console.WriteLine("ID Video : " + id);
                    Console.WriteLine("Title Video : " + title);
                    Console.WriteLine("Jumlah Tontonan : " + playCount);
                }

            }
            static void Main(string[] args)
            {
                String hdtv = "Tutorial Design By Contract - Fajar Ramadhan";
                SayaTubeVideo sayaTubeVideo = new SayaTubeVideo(hdtv);
                Random rand = new Random();
                int min = 1;
                int max = 10000000;
                sayaTubeVideo.IncreasePlayCount(rand.Next(min, max + 1));
                sayaTubeVideo.PrintVideoDetails();
                Console.Read();




                /*try
                {
                    SayaTubeVideo errTest = new SayaTubeVideo(hdtv);
                    sayaTubeVideo.IncreasePlayCount(rand.Next(min + 10000000, max + 10000000));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Error : {ex.Message}");
                    sayaTubeVideo.PrintVideoDetails();
                    Console.Read();
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine($"Error : {ex.Message}");
                    sayaTubeVideo.PrintVideoDetails();
                    Console.Read();
                }*/
                Console.Read();

            }
        }
    }
}