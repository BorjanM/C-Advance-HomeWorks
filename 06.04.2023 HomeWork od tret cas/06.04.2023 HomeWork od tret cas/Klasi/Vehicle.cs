using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _06._04._2023_HomeWork_od_tret_cas.Klasi
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int YearOfProduction { get; set; }
        public int BatchNumber { get; set; }

        public Vehicle(int id, string type, int yearOfProduction, int batchNumber)
        {
            Id = id;
            Type = Type;
            YearOfProduction = yearOfProduction;
            BatchNumber = batchNumber;

           }

        public void PrintVehicle ()
        {
            Console.WriteLine($"This Vehicle has {Id} and type is {Type} and it is produced in {YearOfProduction});
        }


    }
}

//*Create a class Vehicle with properties Id, Type, YearOfProduction, BatchNumber.
//* Create two classes Car and Bike that inherit from Vehicle. Car has property FuelTank (int) and Countries in which it is produced and Bike has property Color.
//* Class Vehicle has method PrintVehicle that prints Id, Type and YearOfProduction.
//* Class Car also has method PrintVehicle that prints the Type and the Countries in which it is produced.
//* Class Bike also has method PrintVehicle that Prints the YearOfProduction and the Color.
//* Create a static class that serves as a DB, that has list of Vehicles. In this list put objects of type Car, Bike and Vehicle. 
//* In the main program call PrintVehicle for each object in the list in the db.
//* Create a static class called Validator, that contains a method Validate, that receives a Vehicle and validates is Id is not 0, that Type is not empty and YearOfProduction is not 0.
//* Call Validate from main Program with a couple of objects.