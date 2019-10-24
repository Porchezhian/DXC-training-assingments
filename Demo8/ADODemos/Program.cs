using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace ADODemos
{
    class Program
    {
        Employee employee;
        public void Display()
        {
            Console.WriteLine("CRUD Operations:\n1.Create an Employee\n2.Update an Employee\n3.Get All Employees\n4.Get an Employee\n5.Delete an Employee\n6.Exit");
            Console.WriteLine("\nEnter an Operation to perform\n");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            while (true)
            {
                p.Display();
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        p.CreateEmployee();
                        Console.ReadLine();
                        Console.Clear();
                        p.ReadAllEmployee();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        p.UpdateEmployee();
                        Console.ReadLine();
                        Console.Clear();
                        p.ReadAllEmployee();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        p.ReadAllEmployee();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        p.ReadEmployee();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 5:
                        Console.Clear();
                        p.DeleteEmployee();
                        Console.ReadLine();
                        Console.Clear();
                        p.ReadAllEmployee();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 6:
                        System.Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }
            }
        }

        public void CreateEmployee()
        {
            Console.WriteLine("Enter the Name, Gender, Location, Salary");
            employee = new Employee();
            employee.Name = Console.ReadLine();
            employee.Gender = Console.ReadLine();
            employee.Location = Console.ReadLine();
            employee.Salary = int.Parse(Console.ReadLine());
            int count = employee.InsertNewEmployee(employee);
            if(count>0)
                Console.WriteLine("Employee Details Inserted");
            else
                Console.WriteLine("Something went wrong");
        }

        public void ReadAllEmployee()
        {
            employee = new Employee();
            employee.RetriveAllEmployee();
        }

        public void ReadEmployee()
        {
            employee = new Employee();
            employee.RetriveEmployee(employee);
        }

        public void UpdateEmployee()
        {
            employee = new Employee();
            Console.WriteLine("Enter the Id");
            employee.Id = int.Parse(Console.ReadLine());
            object id = employee.GetId(employee);
            if(id!=null)
            {
                Console.WriteLine("Enter the Name, Gender, Location, Salary");
                employee.Name = Console.ReadLine();
                employee.Gender = Console.ReadLine();
                employee.Location = Console.ReadLine();
                employee.Salary = int.Parse(Console.ReadLine());
                int count = employee.UpdateEmployee(employee);
                if (count > 0)
                    Console.WriteLine("Employee Details Updated");
                else
                    Console.WriteLine("Something went wrong");
            }
            else
                Console.WriteLine("Id does not exist");            
        }

        public void DeleteEmployee()
        {
            employee = new Employee();
            Console.WriteLine("Enter the Id");
            employee.Id = int.Parse(Console.ReadLine());
            object id = employee.GetId(employee);
            if (id != null)
            {
                int count = employee.DeleteEmployee(employee);
                if (count > 0)
                    Console.WriteLine("Employee Deleted");
                else
                    Console.WriteLine("Something went wrong");
            }
            else
                Console.WriteLine("Id does not exist");
        }
    }
}
