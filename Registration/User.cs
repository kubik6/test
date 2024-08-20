using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration
{
    internal class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public static string Password = "admin";

        private bool check = false;

        public User(string name, string surname, int age)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || age < 0)
            {
                check = true;


            }
            else
            {
                this.Name = name;
                this.Surname = surname;
                this.Age = age;
            }
        }

        public void DisplayUser()
        {
            if (!check)
            {
                Console.WriteLine($"Name: {Name}");
                Console.WriteLine($"Surname: {Surname}");
                Console.WriteLine($"Age: {Age}");

            }
            else
            {
                Console.WriteLine("Hamsi daxil edin");
            }

        }

    }
}
