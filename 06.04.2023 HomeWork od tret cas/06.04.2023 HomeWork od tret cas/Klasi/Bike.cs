using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._04._2023_HomeWork_od_tret_cas.Klasi
{
    public class Bike : Vehicle
    {
       
        public string Colour { get; set; }
        public Bike(int id, string type, int yearOfProduction, int batchNumber) : base(id, type, yearOfProduction, batchNumber)
        {
        }

       

        public void PrintVehicle(int yearOfProduction, string Colour)
        {
            Console.WriteLine($"Bike is produced in {yearOfProduction} with {Colour} colour");
        }

    }

}
