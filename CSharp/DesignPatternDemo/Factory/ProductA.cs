using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.Factory
{
    public class ProductA : IProduct
    {
        public double GetPrice()
        {
            return 10.50;
        }

        public string GetProductName()
        {
            return "Product A";
        }
    }
}
