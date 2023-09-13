using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Model
{
    internal class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }

        public Product(int id, string productName, decimal price,int categoryId)
        {
            Id = id;
            ProductName = productName;
            Price = price;
            CategoryId = categoryId;
        }
    }
}
