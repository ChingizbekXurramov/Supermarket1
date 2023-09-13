using Supermarket.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {    ProductDbService dbService = new ProductDbService();
          
            dbService.CreateProduct("Fanta",12000,1);

        }
    }
}
