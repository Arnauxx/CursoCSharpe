using System;
using Predicate.Entities;
using System.Collections.Generic;
using System.Globalization;
        
namespace Predicate
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

            //Action<Products> act = p => { p.Price += p.Price * 0.1; };

            list.ForEach(p => { p.Price += p.Price * 0.1; });
            foreach(Products p in list)
            {
                Console.WriteLine(p);
            }

            //list.RemoveAll(ProductTest);

        //    foreach(Products p in list)
        //    {
        //        Console.WriteLine(p);
        //    }

        }

        //public static bool ProductTest(Products p)
        //{
        //    return p.Price >= 100;
        //}

        //static void UpdatePrice(Products p)
        //{
        //    p.Price += p.Price * 0.1;
        //}

    }
}
