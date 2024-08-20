using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimallWorld
{
    public class Animal
    {
        public string Name;
        public int Age;
        public string _Color;
        

        public Animal(string name, int age, string color)
        {
            this.Name = name;
            this.Age = age;
            _Color = color;
        }
    }
}
