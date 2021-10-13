using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGameStore.Models
{
    public enum Gender { MALE, FEMALE, OTHER }

    public class Person
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; }
        public int? StoreID { get; set; }

        public Person(int iD, string lastName, string firstName, Gender gender)
        {
            ID = iD;
            LastName = lastName;
            FirstName = firstName;
            Gender = gender;
        }
    }
}
