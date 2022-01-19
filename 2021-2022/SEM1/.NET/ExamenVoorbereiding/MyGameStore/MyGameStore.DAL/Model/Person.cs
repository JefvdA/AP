namespace MyGameStore.DAL.Model
{
    public class Person
    {
        public int Id { get; set; }
        public int StoreId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Gender { get; set; }
        public string Email { get; set; }

        public Store Store { get; set; }

        public Person()
        {
        }

        public Person(int id, int storeId, string lastName, string firstName, int gender, string email)
        {
            Id = id;
            StoreId = storeId;
            LastName = lastName;
            FirstName = firstName;
            Gender = gender;
            Email = email;
        }
    }
}
