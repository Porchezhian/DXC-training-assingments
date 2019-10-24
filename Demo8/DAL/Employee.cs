using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class Employee
    {
        private int id, salary;
        private string name, location, gender;

        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string connectionstring = @"data source=IN5CG9214XJ0\MSSQLSERVER01; database=ADODemo; integrated security=true;";

        public int Id { get => id; set => id = value; }
        public int Salary { get => salary; set => salary = value; }
        public string Name { get => name; set => name = value; }
        public string Location { get => location; set => location = value; }
        public string Gender { get => gender; set => gender = value; }

        public int InsertNewEmployee(Employee employee)
        {
            con.ConnectionString = connectionstring;
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_InsertEmployee";
            cmd.Parameters.AddWithValue("name", employee.Name);
            cmd.Parameters.AddWithValue("gender", employee.Gender);
            cmd.Parameters.AddWithValue("location", employee.Location);
            cmd.Parameters.AddWithValue("salary", employee.Salary);
            con.Open();
            int rowcount = cmd.ExecuteNonQuery();
            con.Close();
            return rowcount;
        }

        public void RetriveAllEmployee()
        {
            con.ConnectionString = connectionstring;
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_RetriveAllEmployee";
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine("\n");
            while (reader.Read())
            {
                Console.WriteLine($"{reader[0]} - {reader[1]} - {reader[2]} - {reader[3]} - {reader[4]}");
            }
            con.Close();
        }

        public void RetriveEmployee(Employee employee)
        {
            con.ConnectionString = connectionstring;
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_RetriveEmployeeById";
            Console.WriteLine("Enter the Id");
            employee.Id = int.Parse(Console.ReadLine());
            cmd.Parameters.AddWithValue("id", employee.Id);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            Console.WriteLine("\n");
            Console.WriteLine($"{reader[0]} - {reader[1]} - {reader[2]} - {reader[3]} - {reader[4]}");
            con.Close();
        }

        public int UpdateEmployee(Employee employee)
        {
            con.ConnectionString = connectionstring;
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_UpdateEmployee";
            
            cmd.Parameters.AddWithValue("name", employee.Name);
            cmd.Parameters.AddWithValue("gender", employee.Gender);
            cmd.Parameters.AddWithValue("location", employee.Location);
            cmd.Parameters.AddWithValue("salary", employee.Salary);
            con.Open();
            int rowcount = cmd.ExecuteNonQuery();
            con.Close();
            return rowcount;
        }

        public object GetId(Employee employee)
        {
            con.ConnectionString = connectionstring;
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_RetriveEmployeeById";
            cmd.Parameters.AddWithValue("id", employee.Id);
            con.Open();
            object id = cmd.ExecuteScalar();
            con.Close();
            return id;
        }

        public int DeleteEmployee(Employee employee)
        {
            con.ConnectionString = connectionstring;
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_DeleteEmployeeById";
            con.Open();
            int rowcount = cmd.ExecuteNonQuery();
            con.Close();
            return rowcount;
        }
    }
}
