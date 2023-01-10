using System;
using System.Globalization;
using FixacaoComp.Entities;
using FixacaoComp.Entities.Enums;
using System.Collections.Generic;

class URI
{

    static void Main(string[] args)
    {

        Console.WriteLine("Enter cliente data:");
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Email: ");
        string email = Console.ReadLine();
        Console.Write("Birth date (DD/MM/YYYY): ");
        DateTime birthDate = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("Enter order data:");
        Console.Write("Status: ");
        OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

        ClientBase clientBase = new ClientBase(name, email, birthDate);
        Order order = new Order(DateTime.Now, status,clientBase);

        Console.Write("How many item to  thi order? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Enter #{i} item data: ");
            Console.Write("Product name: ");
            string product = Console.ReadLine();
            Console.Write("Product price: ");
            double price = double.Parse(Console.ReadLine());

            Product product1 = new Product(product, price);
            

            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            OrderItem orderItem = new OrderItem(quantity, price, product1);
           
            order.AddItems(orderItem);

        }

        Console.WriteLine();
        Console.WriteLine("Order Sumary:");
        Console.WriteLine(order);


    }



}

