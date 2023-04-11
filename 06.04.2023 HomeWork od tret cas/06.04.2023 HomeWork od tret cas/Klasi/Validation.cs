using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06._04._2023_HomeWork_od_tret_cas.Klasi
{
    public static class Validator { 
    
        public static void Validate(Vehicle vozilo)
        {
            if (vozilo.Id == 0)
            {
                System.Console.WriteLine("Kolata e bez karoseriski ID broj");
            }
            if (vozilo.Type == "")
            {
                System.Console.WriteLine("Ne se znae sto model ti e voziloto");
            }
            if (vozilo.YearOfProduction == 0)
            {
                System.Console.WriteLine("nemoze da ti e 0 godina proizvedeno");
            }
            else
            {
                System.Console.WriteLine("Teraj bate");
            }
        }
    }
}
