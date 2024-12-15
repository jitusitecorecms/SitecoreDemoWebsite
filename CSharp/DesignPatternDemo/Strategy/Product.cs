using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.Strategy
{
    public class Product
    {
        public string Name { get; set; }
        public double Weight { get; set; }

        private IShippingStrategy _shippingStrategy;

        public void SetShippingStrategy(IShippingStrategy shippingStrategy)
        {
            _shippingStrategy = shippingStrategy;
        }

        public double CalculateShippingCost()
        {
            return _shippingStrategy.CalculateShippingCost(Weight);
        }
    }

}
