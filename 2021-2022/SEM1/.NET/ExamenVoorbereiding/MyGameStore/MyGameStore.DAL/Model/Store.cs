using System.Collections.Generic;

namespace MyGameStore.DAL.Model
{
    public class Store
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Addition { get; set; }
        public string Zipcode { get; set; }
        public string City { get; set; }
        public bool IsFranchiseStore { get; set; }

        public List<Person> People { get; set; }

        public Store()
        {
        }

        public Store(int id, string name, string street, string number, string addition, string zipcode, string city, bool isFranchiseStore)
        {
            Id = id;
            Name = name;
            Street = street;
            Number = number;
            Addition = addition;
            Zipcode = zipcode;
            City = city;
            IsFranchiseStore = isFranchiseStore;
        }
    }
}
