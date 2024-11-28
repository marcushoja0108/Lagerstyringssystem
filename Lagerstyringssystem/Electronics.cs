using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyringssystem
{
    internal class Electronics : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Warranty { get; set; }

        public Electronics(string name, double price, int warranty)
        {
            Name = name;
            Price = price;
            Warranty = warranty;
        }

        public void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Name:               {Name}");
            Console.WriteLine($"Price               {Price}");
            Console.WriteLine($"Warranty(Months)    {Warranty}");
        }
    }
}
