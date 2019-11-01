using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingServices
{
    public class Customer
    {
        int customerId, productId, noOfProducts, supplierId, total;
        string customerName;

        public int CustomerId { get => customerId; set => customerId = value; }
        public int ProductId { get => productId; set => productId = value; }
        public int NoOfProducts { get => noOfProducts; set => noOfProducts = value; }
        public int SupplierId { get => supplierId; set => supplierId = value; }
        public int Total { get => total; set => total = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
    }
}
