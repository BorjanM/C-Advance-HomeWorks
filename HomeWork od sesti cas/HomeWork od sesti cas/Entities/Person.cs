using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_od_sesti_cas.Entities
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public int NumberOfDogs { get; set; }

        public List<Person> ToList()
        {
            throw new NotImplementedException();
        }
    }

}