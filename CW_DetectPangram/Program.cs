using System;

namespace CW_DetectPangram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var a = new Kata();
            Console.WriteLine(a.IsPangram("Cwm fjord bank glyphs vext quiz"));
            Console.ReadKey();
        }
    }
}
