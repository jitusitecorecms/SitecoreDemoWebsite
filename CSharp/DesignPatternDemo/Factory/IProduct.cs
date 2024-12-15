using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.Factory
{
    public interface IProduct
    {
        double GetPrice();
        string GetProductName();
    }
}
