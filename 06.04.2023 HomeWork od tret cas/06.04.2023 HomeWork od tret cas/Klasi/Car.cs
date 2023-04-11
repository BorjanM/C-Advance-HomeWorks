using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._04._2023_HomeWork_od_tret_cas.Klasi
{
    public class Car : Vehicle
    {
        

        public int FuelType { get; set; }  
        public string Countries { get; set; }
        public Car(int id, string type, int yearOfProduction, int batchNumber) : base(id, type, yearOfProduction, batchNumber)
        {

        }

      

        public void PrintVehicle(string Countries, string type)
        {
            Console.WriteLine($" This car is produced in {Countries} and it is from type {type}");
        }




    }
}
