using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Assignment3
{
    class crud
    {
        public static void ReadEmployee(List<Employee> employeelist)
        {
            foreach (Employee item in employeelist)
                Console.WriteLine($"{item.Id} - {item.Name} - {item.Location} - {item.Salary} - {item.Designation}");
        }

        public static void CreateEmployee(ref List<Employee> employeelist)
        {
            int id, salary;
            string name, location, designation;
            Console.WriteLine("Enter Employee Id:");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEnter Employee Name:");
            name = Console.ReadLine();
            Console.WriteLine("\nEnter Employee Location:");
            location = Console.ReadLine();
            Console.WriteLine("\nEnter Employee Designation:");
            designation = Console.ReadLine();
            Console.WriteLine("\nEnter Employee Salary:");
            salary = int.Parse(Console.ReadLine());
            Employee new_employee = new Employee { Id = id, Name = name, Designation = designation, Location = location, Salary = salary };
            employeelist.Add(new_employee);
            Console.Clear();
            Program.DisplayMenu();
            ReadEmployee(employeelist);
        }

        public static void UpdateEmployee(ref List<Employee> employeelist)
        {
            int id, index, int_value = 0;
            string str_value = "";
            string field;
            Employee employee, new_employee;
            Console.WriteLine("Enter the Id of the Employee to be updated:\n");
            id = int.Parse(Console.ReadLine());
            employee = employeelist.Find(e => e.Id == id);
            if (employee == null)
            {
                Console.WriteLine("\nId does not exist");
                return;
            }
            new_employee = employee;
            Console.WriteLine("Enter the field you want to update:\n(Id, Name, Salary, Designation, Location)\n");
            field = Console.ReadLine().ToLower();
            if (field != "id" && field != "name" && field != "salary" && field != "designation" && field != "location")
            {
                Console.WriteLine("Invalid Field");
                return;
            }
            Console.WriteLine("Enter the value:\n");
            if (field == "id")
            {
                int_value = int.Parse(Console.ReadLine());
                new_employee.Id = int_value;
            }
            else if (field == "name")
            {
                str_value = Console.ReadLine();
                new_employee.Name = str_value;
            }
            else if (field == "salary")
            {
                int_value = int.Parse(Console.ReadLine());
                new_employee.Salary = int_value;
            }
            else if (field == "designation")
            {
                str_value = Console.ReadLine();
                new_employee.Designation = str_value;
            }
            else if (field == "location")
            {
                str_value = Console.ReadLine();
                new_employee.Location = str_value;
            }
            else
            {
                Console.WriteLine("Field does not exist");
                return;
            }
            index = employeelist.FindIndex(e => e == employee);
            employeelist.Remove(employee);
            employeelist.Insert(index, new_employee);
            Console.Clear();
            Program.DisplayMenu();
            ReadEmployee(employeelist);
        }

        public static void DeleteEmployee(ref List<Employee> employeelist)
        {
            int id;
            Console.WriteLine("Enter the Id of the employee to be deleted");
            id = int.Parse(Console.ReadLine());
            employeelist.Remove(employeelist.Find(e => e.Id == id));
            Console.Clear();
            Program.DisplayMenu();
            ReadEmployee(employeelist);
        }
    }
}
