using System;
using System.IO;
using ExecPropostoConj.Entities;

namespace ExecPropostoConj
{
    class Program
    {
        static void Main(string[] args)
        {

            HashSet<Students> student = new HashSet<Students>();

            Console.Write("How many students for course A ? ");
            int a = int.Parse(Console.ReadLine());

            for(int i = 0; i < a; i++)
            {
                student.Add(new Students(int.Parse(Console.ReadLine())));
            }

            Console.Write("How many students for course B ? ");
            int b = int.Parse(Console.ReadLine());

            for (int i = 0; i < b; i++)
            {
                student.Add(new Students(int.Parse(Console.ReadLine())));
            }
            Console.Write("How many students for course C ? ");
            int c = int.Parse(Console.ReadLine());

            for (int i = 0; i < c; i++)
            {
                student.Add(new Students(int.Parse(Console.ReadLine())));
            }

            Console.WriteLine($"Total students: {student.Count}");

        }
    }
}