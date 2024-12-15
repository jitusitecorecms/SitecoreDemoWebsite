using DesignPatternDemo.Decorators;
using DesignPatternDemo.Factory;
using DesignPatternDemo.Observer;
using DesignPatternDemo.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product { Name = "Laptop", Weight = 2.5 };

            // Using Standard Shipping
            product.SetShippingStrategy(new StandardShippingStrategy());
            Console.WriteLine($"Standard Shipping Cost: ${product.CalculateShippingCost()}");

            // Using Express Shipping
            product.SetShippingStrategy(new ExpressShippingStrategy());
            Console.WriteLine($"Express Shipping Cost: ${product.CalculateShippingCost()}");

            // Using International Shipping
            product.SetShippingStrategy(new InternationalShippingStrategy());
            Console.WriteLine($"International Shipping Cost: ${product.CalculateShippingCost()}");

            Console.ReadKey();
        }



    }
}
