using System;
using System.Collections.Generic;


namespace Dictionary_SortedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "Maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "5511970707070";
            cookies["phone"] = "5511960606060"; //Sobrescreve a chave

            Console.WriteLine(cookies["phone"]);

            cookies.Remove("email");

            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no 'email' key");
            }

            Console.WriteLine($"Size: {cookies.Count}");

            Console.WriteLine("All cookies:");

            foreach(var item in cookies)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

        }
    }
}