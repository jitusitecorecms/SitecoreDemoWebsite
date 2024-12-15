using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.Decorators
{
    public class WarrantyDecorator : ProductDecorator
    {
        public WarrantyDecorator(IProduct product) : base(product) { }

        public override string GetProductName()
        {
            return base.GetProductName() + " With Extended Warranty";
        }

        public override double GetCost()
        {
            return base.GetCost() + 20.0;
        }
    }
}
