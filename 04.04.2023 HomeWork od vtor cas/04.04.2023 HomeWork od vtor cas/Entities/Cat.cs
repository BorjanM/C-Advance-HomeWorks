using _04._04._2023_HomeWork_od_vtor_cas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._04._2023_HomeWork_od_vtor_cas.Entities
{
    public class Cat : Animal, ICat
    {
       

        public Cat(string fullName, int age) : base(fullName, age)
        {
            this.Age = age; 
            this.FullName = fullName;   
        }

        


        public void Eat(string food)
        {
            Console.WriteLine($"Cat eat only {food}");
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"This Cat is with name {FullName} and age {Age}");
        }
    }
}
//Create class Cat that implements ICat and inherits from Animal. Implement PrintAnimal but also Eat.