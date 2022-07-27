using System;
using Func_Select.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Func_Select
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Products> list = new List<Products>();

            list.Add(new Products("Tv", 900.00));
            list.Add(new Products("Mouse", 50.00));
            list.Add(new Products("Tablet", 350.50));
            list.Add(new Products("HD Case", 80.90));

            //Func<Products, string> func = p => p.Name.ToUpper();

            List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

           
            foreach(string p in result)
            {
                Console.WriteLine(p);
            }
                

        }
    }
}
