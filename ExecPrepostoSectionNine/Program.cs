using System;
using ExecPrepostoSectionNine.Entities;
using ExecPrepostoSectionNine.Entities.Enums;

namespace ExecPrepostoSectionNine
{
    class Program
    {
        static void Main(string[] args)
        {
            //Client
            Console.WriteLine("Enter Cliente data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.WriteLine("How many items to this order? ");
            int totalItems = int.Parse(Console.ReadLine());

            Order order = new Order(DateTime.Now, status, client);

            for (int i = 1; i <= totalItems; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product Name: ");
                string productName = Console.ReadLine();
                Console.WriteLine("Product price: ");
                double productPrice = double.Parse(Console.ReadLine());
                Console.WriteLine("Quantity: ");
                int qntd = int.Parse(Console.ReadLine());

                
                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(qntd, productPrice, product);
                order.AddItem(orderItem);
            }
            

        }
    }
}
