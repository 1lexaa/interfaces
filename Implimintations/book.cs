using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Implimintations
{
    internal class Book : Product, Interfaces.IPrintable
    {
        public void Print()
        {
            Console.WriteLine($"The Book : {Name}");
        }
    }
}