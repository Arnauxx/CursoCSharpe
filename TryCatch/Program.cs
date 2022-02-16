using System;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    int n1 = int.Parse(Console.ReadLine());
            //    int n2 = int.Parse(Console.ReadLine());

            //    int result = n1 / n2;
            //    Console.WriteLine(result);
            //}

            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Division by zero is not allowed");
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine("Format error! ");
            //}

            int a, b, s, i;

            a = 1;

            Console.WriteLine("Digite um numero inteiro");
            b = int.Parse(Console.ReadLine());

            s = a;
            i = a;

            while(i < b)
            {
                i = i + 1;
                s = s + i;
            }

            Console.WriteLine(s);





            
        }
    }
}
