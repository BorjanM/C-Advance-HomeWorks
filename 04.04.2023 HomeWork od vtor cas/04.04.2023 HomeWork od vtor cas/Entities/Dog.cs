using _04._04._2023_HomeWork_od_vtor_cas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._04._2023_HomeWork_od_vtor_cas.Entities
{
    public class Dog : Animal, IDog
    {
        public Dog(string fullName, int age) : base(fullName, age)
        {
            this.Age = age;
            this.FullName = fullName;
        }

        public string FullName { get; set; } = string.Empty;

        public int Age { get; set; }


        public void Bark()
        {
            Console.WriteLine($"Dog with name {FullName} and age {Age} barks very loud");
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"This Dog is with name {FullName} and age {Age}");
        }
    }
}

//Create class Dog that implements IDog and inherits from Animal. Implement PrintAnimal but also Bark.