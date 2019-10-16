using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("ProductList     Cost per Kg");
            Console.WriteLine("-----------     -----------\n");
            Console.WriteLine("1.Apple \t- Rs 50\n2.Mango \t- Rs 60\n3.Banana \t- Rs 30\n4.Orange \t- Rs 45\n5.Pomegranate \t- Rs 60\n");
            Console.WriteLine("Enter the no.of products you want to purchase");
            num = int.Parse(Console.ReadLine());
            Product product = new Product(num);
            Console.WriteLine("Enter the product with its quantity one by one");
            for (int i=0; i<num; i++)
            {
                string name="";
                bool set = true;
                while (set)
                {
                    name = Console.ReadLine();
                    if (name.ToLower() != "apple" && name.ToLower() != "mango" && name.ToLower() != "banana" && name.ToLower() != "orange" && name.ToLower() != "pomegranate")
                        Console.WriteLine("Enter a valid product");
                    else
                        set = false;
                }
                int qty = int.Parse(Console.ReadLine());
                product.cart(i, char.ToUpper(name[0])+name.Substring(1).ToLower(), qty);
            }
            product.bill();
            Console.ReadKey();
        }
    }
}
