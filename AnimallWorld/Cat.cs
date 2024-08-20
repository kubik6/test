using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimallWorld
{
    public class Cat : Animal
    {
        public string Gender;

        public Cat(string name, int age, string color, string gender) : base(name, age, color) 
        {
            this.Gender = gender;
        }
    }
}
