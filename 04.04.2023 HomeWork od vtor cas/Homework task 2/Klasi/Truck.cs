using Homework_task_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_task_2.Klasi
{
    public class Truck : Vehicle, IGasPump, ICarWashICarWash
    {


        public string Model { get; set; } = string.Empty;
        public int Age { get; set; }

        public Truck(string model, int age)
        {
            Model = model;
            Age = age;

        }
        public override void Drive()
        {
            throw new NotImplementedException();
        }

        public void PumpGas()
        {
            throw new NotImplementedException();
        }
    }
}
