using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.Factory
{
    public class ProductFactory
    {
        public static IProduct GetProduct(int productType)
        {
            IProduct product = null;

            switch (productType)
            {
                case 1:
                    product = new ProductA();
                    break;
                case 2:
                    product = new ProductB();
                    break;
                default:
                    product = new ProductA();
                    break;
            }

            return product;
        }
    }

    


}
