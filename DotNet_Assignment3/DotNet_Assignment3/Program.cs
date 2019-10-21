using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Assignment3
{
    class Program
    {
        public static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("CRUD Operations for Employee Record:\n1.Create\n2.Read\n3.Update\n4.Delete\n5.Exit\n");
        }
        static void Main(string[] args)
        {
            int choice;
            bool set = true;
            Employee emp1 = new Employee { Id = 1, Name = "Porsche", Salary = 40000, Designation = "Programmer", Location = "Bangalore"};
            Employee emp2 = new Employee { Id = 2, Name = "Sam", Salary = 50000, Designation = "Architect", Location = "Chennai" };
            Employee emp3 = new Employee { Id = 4, Name = "Yuva", Salary = 60000, Designation = "Analyst", Location = "Bangalore" };
            List<Employee> emplist = new List<Employee>();
            emplist.Add(emp1);
            emplist.Add(emp2);
            emplist.Add(emp3);
            DisplayMenu();
            while (set)
            {
                Console.WriteLine("Enter an operation to perform\n");
                choice = int.Parse(Console.ReadLine());
                DisplayMenu();
                switch (choice)
                {
                    case 1:
                        crud.CreateEmployee(ref emplist);
                        Console.ReadKey();
                        DisplayMenu();
                        break;
                    case 2:
                        crud.ReadEmployee(emplist);
                        Console.ReadKey();
                        DisplayMenu();
                        break;
                    case 3:
                        crud.UpdateEmployee(ref emplist);
                        Console.ReadKey();
                        DisplayMenu();
                        break;
                    case 4:
                        crud.DeleteEmployee(ref emplist);
                        Console.ReadKey();
                        DisplayMenu();
                        break;
                    case 5:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\nInvalid option");
                        Console.ReadKey();
                        DisplayMenu();
                        break;
                }
            }
        }
    }
}
