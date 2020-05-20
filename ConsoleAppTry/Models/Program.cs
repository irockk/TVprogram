using System;

namespace ConsoleAppTry.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TVprogram tvprogram = new TVprogram();
            tvprogram.FillTestData(100);
            tvprogram.Save();
            tvprogram.Load();
        }
    }
}
