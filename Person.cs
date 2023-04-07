using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP07_04
{
    internal class Person
    {
        private string name;
        //private int age;
        public string Name { /*set;*/ get { return name; } }
        public int Age { get; set; }
        public void Print()
        {
            Console.WriteLine($"Имя {Name} Возраст{Age}");
        }
        public Person(string _name)
        {
            name = _name;
        }
    }
}
