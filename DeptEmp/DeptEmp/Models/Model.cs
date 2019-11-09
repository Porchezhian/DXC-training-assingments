namespace DeptEmp.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class Model : DbContext
    {
      
        public Model()
            : base("name=Model")
        {
            
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
    }

    
}