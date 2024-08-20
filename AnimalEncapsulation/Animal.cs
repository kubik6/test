using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalEncapsulation
{
    internal class Animal
    {
        private string name;
        private int age;
        private bool hasOwner;

        public string Name
        { 
            get { return name; } 
            set { name = value; } 
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public bool HasOwner
        {
            get { return hasOwner; }
            set { hasOwner = value; }
        }

        public virtual void Eat()
        {
            Console.WriteLine();
        }

        public virtual void Sleep()
        {
            Console.WriteLine();
        }
    }
}
