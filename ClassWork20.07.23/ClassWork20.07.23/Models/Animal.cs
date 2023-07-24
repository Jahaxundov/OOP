using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork20._07._23.Models
{
    internal class Animal
    {
        public int id;
        public string name;
        public string color;

        public Animal(string name)
        {
            this.name = name;
        }

        public void Eating()
        {
            Console.WriteLine($"{name} - eating");
        }
    }
}
