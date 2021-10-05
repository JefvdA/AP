using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Core_Deel1.Classes
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }

        public Person(int ID, string Name, string FirstName, DateTime BirthDate)
        {
            this.ID = ID;
            this.Name = Name;
            this.FirstName = FirstName;
            this.BirthDate = BirthDate;
        }
    }
}
