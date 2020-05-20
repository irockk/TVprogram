using System;

namespace ConsoleAppTry.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TVprogram program = new TVprogram();
          //  program.FillTestData(60);
            program.Save();
            program.Load();
        }
    }
}
