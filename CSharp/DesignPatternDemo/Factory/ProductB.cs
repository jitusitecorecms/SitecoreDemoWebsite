using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.Factory
{
    public class ProductB : IProduct
    {
        public double GetPrice()
        {
            return 15.50;
        }

        public string GetProductName()
        {
            return "Product B";
        }
    }
}
