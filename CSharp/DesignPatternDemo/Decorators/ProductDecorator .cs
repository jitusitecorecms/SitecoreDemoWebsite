using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.Decorators
{
    public abstract class ProductDecorator : IProduct
    {
        protected IProduct _decoratedProduct;

        public ProductDecorator(IProduct product)
        {
            _decoratedProduct = product;
        }

        public virtual string GetProductName()
        {
            return _decoratedProduct.GetProductName();
        }

        public virtual double GetCost()
        {
            return _decoratedProduct.GetCost();
        }
    }
}
