using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShoppingServices;

namespace Shopping
{
    class Program
    {
        Customer customer;
        Services service;

        static void display()
        {
            Console.WriteLine("Welcome!\n1.Show Catalog\n2.Buy\n3.Bill\n4.Exit\n");
            Console.WriteLine("Enter an option\n");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.Clear();
            Services service = new Services();
            while (true)
            {
                display();
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        p.catalog();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        p.buy();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        p.bill();
                        Console.Clear();
                        break;
                    case 4:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("\nInvalid option");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
            }
        }

        public void catalog()
        {
            service = new Services();
            service.ShowCatalog();
        }

        public void buy()
        {
            customer = new Customer();
            service = new Services();
            service.ShowCatalog();
            Console.WriteLine("\nEnter Customer Id\n");
            customer.CustomerId = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter Customer Name\n");
            customer.CustomerName = Console.ReadLine();
            Console.WriteLine("\nEnter Product Id\n");
            customer.ProductId = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter no.of Products\n");
            customer.NoOfProducts = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter Supplier Id\n");
            customer.SupplierId = int.Parse(Console.ReadLine());
            bool cond = service.SearchSupplier(customer.SupplierId, customer.ProductId);
            if (!cond)
            {
                Console.WriteLine($"\nSupplier Id {customer.SupplierId} does not have Product Id {customer.ProductId}\n");
                Console.ReadLine();
                Console.Clear();

            }
            else
            {
                Console.Clear();
                service.Buy(customer);
            }
        }

        public void bill()
        {
            customer = new Customer();
            service = new Services();
            Console.WriteLine("\nEnter Cutomer Id\n");
            int id = int.Parse(Console.ReadLine());
            service.Bill(id);
        }
    }
}
