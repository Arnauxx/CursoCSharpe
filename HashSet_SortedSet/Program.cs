using System;
using System.Collections.Generic;
using HashSet_SortedSet.Entities;

namespace CursoCSharpe
{
    class Program
    {
        static void Main(string[] args)
        {

            //HashSet<string> set = new HashSet<string>();

            //set.Add("TV");
            //set.Add("Notebook");
            //set.Add("Tablet");

            //Console.WriteLine(set.Contains("Notebook"));

            //foreach(string p in set)
            //{
            //    Console.WriteLine(p);
            //}

            //    SortedSet<int> a = new SortedSet<int>() { 10, 0, 2, 4, 5, 6, 8 };
            //    SortedSet<int> b = new SortedSet<int>() { 1, 3, 5, 6, 7, 8, 9, 10};

            //    //PrintCollection(a);

            //    //union
            //    SortedSet<int> c = new SortedSet<int>(a);
            //    c.UnionWith(b);
            //    PrintCollection(c);

            //    //intersection
            //    SortedSet<int> d = new SortedSet<int>(a);
            //    d.IntersectWith(b);
            //    PrintCollection(d);

            //    //difference
            //    SortedSet<int> e = new SortedSet<int>(a);
            //    e.ExceptWith(b);
            //    PrintCollection(e);


            //    //
            //    HashSet<string> set = new HashSet<string>();

            //    set.Add("Maria");
            //    set.Add("Alex");

            //    Console.WriteLine(set.Contains("Maria"));



            //}

            //static void PrintCollection<T>(IEnumerable<T> collection)
            //{
            //    foreach(T obj in collection)
            //    {
            //        Console.Write(obj + " ");

            //    }
            //    Console.WriteLine();
            //}

            HashSet<Product> a = new HashSet<Product>();

            a.Add(new Product("TV", 900.0));
            a.Add(new Product("Notebook", 1200.0));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.0);
            Console.WriteLine(a.Contains(prod));

            Point p = new Point(5, 10);

            Console.WriteLine(b.Contains(p));


        }
    }

}