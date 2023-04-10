using _04._04._2023_HomeWork_od_vtor_cas.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _04._04._2023_HomeWork_od_vtor_cas.Entities
{
    public abstract class Animal : IAnimal
    {
        public string FullName { get; set; } = string.Empty;
        public int Age { get; set; }

        public  Animal(string fullName, int age)
        {
            FullName = fullName;
            Age = age;
        }

         public abstract void PrintAnimal();

        void IAnimal.Animal()
        {
            Console.WriteLine($"This is animal with {FullName} and age of {Age}");
        }
    }
}


//Create interfaces called IAnimal, IDog, ICat
//IAnimal : Contains method PrintAnimal
//IDog - Contains method Bark
//ICat - Contains method Eat that gets parameter food of type string
//Create an abstract class Animal (you choose the properties) that implements IAnimal, with abstract method PrintAnimal

//Create class Dog that implements IDog and inherits from Animal. Implement PrintAnimal but also Bark.

//Create class Cat that implements ICat and inherits from Animal. Implement PrintAnimal but also Eat.
//Create several objects and test the method calls
//The implementation for the methods is on your choice.
