using System;
using System.Linq;
using System.Collections.Generic;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Specify the data source

            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            //Define the query
            IEnumerable<int> result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            //Execute the querys
            foreach(int x in result)
            {
                Console.WriteLine(x);
            }

        }
    }
}
