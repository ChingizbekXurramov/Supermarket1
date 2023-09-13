using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket.Model
{
    internal class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int NumberOfProducts { get; set; }

        public Category() { }
        public Category(int id, string categoryName, int numberOfProducts)
        {
            Id = id;
            CategoryName = categoryName;
            NumberOfProducts = numberOfProducts;
        }
    }
}
