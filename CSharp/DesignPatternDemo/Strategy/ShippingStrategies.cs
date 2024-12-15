using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.Strategy
{
    public class StandardShippingStrategy : IShippingStrategy
    {
        public double CalculateShippingCost(double packageWeight)
        {
            return packageWeight * 1.0; 
        }
    }

    public class ExpressShippingStrategy : IShippingStrategy
    {
        public double CalculateShippingCost(double packageWeight)
        {
            return packageWeight * 2.0; 
        }
    }

    public class InternationalShippingStrategy : IShippingStrategy
    {
        public double CalculateShippingCost(double packageWeight)
        {
            return packageWeight * 3.0; 
        }
    }

}
