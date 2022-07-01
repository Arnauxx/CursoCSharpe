using System;

namespace _16_Extension_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2018, 7, 1, 8, 0, 00);
            Console.WriteLine(dt.ElapsedTime());

            Console.WriteLine();

            String s1 = "Good morning dear students!";
            Console.WriteLine(s1.Cut(10));

            
        }
    }
}
