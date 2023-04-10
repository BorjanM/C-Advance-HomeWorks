using Homework_task_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Homework_task_2.Klasi
{
    public class Car : Vehicle, IRepairService, ICarWash
    {

        public string Model { get; set; } = string.Empty;
        public int Age { get; set; }

        public Car(string model, int age)
        {
            Model = model;
            Age = age;

        }
        public void CheckVehicle()
        {
            throw new NotImplementedException();
        }

        public override void Drive()
        {
            throw new NotImplementedException();
        }

        public void FixVehicle()
        {
            throw new NotImplementedException();
        }

        public void WashCar()
        {
            Console.WriteLine($"{Model} da go isperes");
        }

        public void WashTrailer()
        {
            throw new NotImplementedException();
        }
    }
}
