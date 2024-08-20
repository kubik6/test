using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullNameProject
{
    internal class Person
    {
        private string FullName;

        public string name;
        public string surname;

        public string Name 
        {
            get { return name; } 
            set
            {
                name = value;
               // SumFullName();
            }
        }
        public string Surname
        {
            get { return surname; }
            set
            {
                surname = value;
               // SumFullName();
            }
        }

        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        private void SumFullName()
        {
            FullName = $"{Surname} {Name}";
        }

        public void Display()
        {
            Console.WriteLine($"Full Name: {FullName}");
        }
    }
}
