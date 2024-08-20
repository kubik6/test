using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AnimalEncapsulation
{
    internal class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine($"{Name} dayanmadan yeyir");
        }

        public override void Sleep()
        {
            Console.WriteLine($"{Name} {Age} yuxu gorur");
        }
    }
}
