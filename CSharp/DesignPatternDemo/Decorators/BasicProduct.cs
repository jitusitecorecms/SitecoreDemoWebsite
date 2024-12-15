using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.Decorators
{
    public class BasicProduct : IProduct
    {
        public string GetProductName()
        {
            return "Basic Product";
        }

        public double GetCost()
        {
            return 50.0;
        }
    }
}
