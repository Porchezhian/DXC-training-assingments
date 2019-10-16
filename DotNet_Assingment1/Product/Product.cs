using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Product
    {
        string[] productlist;
        int[] qty;
        int sum = 0;
        public Product(int num)
        {
            productlist = new string[num];
            qty = new int[num];
        }
        enum cost {Apple=50, Mango=60, Banana=30, Orange=45, Pomegranate=60}
        
        public void cart(int i, string name, int quantity)
        {
            this.productlist[i] = name;
            this.qty[i] = quantity;
        }

        public void bill()
        {
            Console.WriteLine("\nYour bill\n---------\n");
            Console.WriteLine("Product        Cost\n-------        ----\n");
            for (int i=0; i<productlist.Length; i++)
            {
                int rate = qty[i] * (int)Enum.Parse(typeof(cost), productlist[i]);
                Console.Write("{0}", productlist[i]);
                Console.CursorLeft = 13;
                Console.WriteLine("- Rs {0}", rate);
                Console.CursorLeft = 0;
                this.sum = this.sum + rate;
            }
            Console.WriteLine("\nTotal = Rs {0}", this.sum);
        }

    }
}
