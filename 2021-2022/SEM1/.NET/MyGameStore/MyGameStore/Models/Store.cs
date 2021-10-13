using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGameStore.Models
{
    public class Store
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Addition { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public bool IsFranchiseStore { get; set; }

        public List<Person> personList { get; set; }
    }
}
