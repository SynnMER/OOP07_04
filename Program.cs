using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP07_04
{
    internal class Program
    {
        static List<Person> Ask_N_Times(int n)
        {
            var ans2 = new List<Person>();
            for (int i = 0; i < n; i++)
            {
                ans2.Add(CreatePerson());
            }
            return ans2;
        }
        static public Person CreatePerson()
        {
            string name;
            int age = 0;
            Console.WriteLine("Введите имя ");
            name = Console.ReadLine();
            do
            {
                try
                {
                    Console.WriteLine("Введите возраст");
                    age = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Возраст введен некоpректно");
                }

            }
            while ( age <=0 && age > 10);
            
            
            var person = new Person(name);
            person.Age = age;
            return person;
        }

        static void Main(string[] args)
        {
            var PersonList = Ask_N_Times(3);
            PersonList.Sort();
            foreach (Person person in PersonList)
            {
                Console.WriteLine($"Имя {person.Name},"+$" Возраст {person.Age}");
            }

        }
    }
}
