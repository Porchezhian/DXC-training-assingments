using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ShoppingServices
{
    public class Services
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        string connectionstring = @"data source=IN5CG9214XJ0\MSSQLSERVER01; database=DotNet_Assessment1; integrated security=true;";

        public void ShowCatalog()
        {
            con.ConnectionString = connectionstring;
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_ShowCatalog";
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine("ProductId | ProductName | SupplierId | SupplierName | Location | Price\n");
            while (reader.Read())
            {
                Console.WriteLine($"{reader[0]} | {reader[1]} | {reader[2]} | {reader[3]} | {reader[4]} | Rs.{reader[5]}");
            }
            con.Close();
        }

        public void Buy(Customer customer)
        {
            con.ConnectionString = connectionstring;
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_Buy";
            cmd.Parameters.AddWithValue("id", customer.CustomerId);
            cmd.Parameters.AddWithValue("name",customer.CustomerName);
            //cmd.Parameters.AddWithValue("productid",customer.ProductId);
            cmd.Parameters.AddWithValue("noofproducts",customer.NoOfProducts);
            //cmd.Parameters.AddWithValue("supplierid",customer.SupplierId);
            customer.Total = 0;
            cmd.Parameters.AddWithValue("price", customer.Total);
            con.Open();
            int rowcount = cmd.ExecuteNonQuery();
            if(rowcount>0)
                Console.WriteLine("added to billing");
            else
                Console.WriteLine("something is wrong");
            con.Close();
            Console.ReadKey();
        }

        public void Bill(int id)
        {
            con.ConnectionString = connectionstring;
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_GetCustomer";
            cmd.Parameters.AddWithValue("id", id);
            con.Open();
            object count = cmd.ExecuteScalar();
            if ((int)count > 0)
            {
                con.Close();
                cmd.CommandText = "sp_GetBill";
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                Console.WriteLine("\nProduct | Quantity | Price\n");
                while (reader.Read())
                {
                    Console.WriteLine($"{reader[0]} | {reader[1]} | {reader[2]}");
                }
                con.Close();
                con.Open();
                cmd.CommandText = "sp_Bill";
                object sum = cmd.ExecuteScalar();
                Console.WriteLine($"\nYour Bill Amount is Rs.{sum}");
                con.Close();
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\nGiven Id has not added any product to billing");
                con.Close();
                Console.ReadKey();
            }
        }

        public bool SearchSupplier(int supplierid, int productid)
        {
            con.ConnectionString = connectionstring;
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_GetSupplier";
            cmd.Parameters.AddWithValue("supplierid", supplierid);
            cmd.Parameters.AddWithValue("productid", productid);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            bool val = reader.Read();
            con.Close();
            if (!val)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
