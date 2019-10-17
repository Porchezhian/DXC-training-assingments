using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            int id;
            bool set = true;
            CustomerAccount user = new CustomerAccount();
            CustomerAccount customer1 = new CustomerAccount(101, "Porsche", 1234, 30000, 1000);
            CustomerAccount customer2 = new CustomerAccount(102, "Sam", 1235, 20000, 1000);
            CustomerAccount customer3 = new CustomerAccount(103, "Mike", 1236, 90000, 1000);
            CustomerAccount customer4 = new CustomerAccount(104, "Jim", 1237, 7000, 1000);
            CustomerAccount customer5 = new CustomerAccount(105, "Kenny", 1238, 2000, 1000);

            CustomerAccount[] customers = { customer1, customer2, customer3, customer4, customer5};
            while (true)
            {
                while (set)
                {
                    Console.WriteLine("Enter your customer Id");
                    id = int.Parse(Console.ReadLine());
                    foreach (var customer in customers)
                    {
                        if (customer.getCustomerId() == id)
                        {
                            user = customer;
                            set = false;
                            Console.Clear();
                            continue;
                        }
                    }
                    if (set == true)
                        Console.WriteLine("\nCustomer does not exist\n");
                }
                set = true;
                Console.WriteLine("\nWelcome!\n--------\n\nSelect any option to perform");
                Console.WriteLine("1. Deposit\n2. Withdraw\n3. Show Account Details\n4. Show Recent Deposits\n5. Show Recent Withdrawals\n6. Exit\n");
                option = int.Parse(Console.ReadLine());
                while (set)
                {
                    switch (option)
                    {
                        case 1:
                            set = false;
                            Console.WriteLine("\nEnter the amount");
                            int deposit = int.Parse(Console.ReadLine());
                            user.deposit(deposit);
                            break;
                        case 2:
                            set = false;
                            Console.WriteLine("\nEnter the amount");
                            int withdraw = int.Parse(Console.ReadLine());
                            user.withdraw(withdraw);
                            break;
                        case 3:
                            user.showDetails();
                            set = false;
                            break;
                        case 4:
                            user.showDeposits();
                            set = false;
                            break;
                        case 5:
                            user.showWithdrawals();
                            set = false;
                            break;
                        case 6:
                            System.Environment.Exit(1);
                            break;
                        default: Console.WriteLine("\nInvalid Option"); set = true; break;
                    }
                }
                Console.WriteLine("\nThank You!");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
