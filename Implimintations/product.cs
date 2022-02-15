using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Implimintations
{
    internal class Product
    {
        public float Price { get; set; }
        public String Name { get; set; }
        public override string ToString()
        {
            return $"{Name} - {Price}";
        }
    }
}