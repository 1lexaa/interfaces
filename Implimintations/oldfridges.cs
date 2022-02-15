using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Implimintations
{
    internal class OldFridges : Fridge, Interfaces.IDiscountable
    {
        public float Discount { get; set; }
        
    }
}