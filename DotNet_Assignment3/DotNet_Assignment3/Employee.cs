using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet_Assignment3
{
    class Employee
    {
        private int id, salary;
        private string name, designation, location;

        public int Id { get => id; set => id = value; }
        public int Salary { get => salary; set => salary = value; }
        public string Name { get => name; set => name = value; }
        public string Designation { get => designation; set => designation = value; }
        public string Location { get => location; set => location = value; }
    }
}
