using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternDemo.Decorators
{
    public interface IProduct
    {
        string GetProductName();
        double GetCost();
    }
}
