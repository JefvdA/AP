using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoRace.Model
{
    public class Pilot
    {
        public int ID { get; set; }
        public int TeamID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string NickName { get; set; }
        public string LicenseNumber { get; set; }
        public string PhotoPath { get; set; }
        public int Gender { get; set; }
        public string BirthDate { get; set; }
        public float Length { get; set; }
        public float Weigth { get; set; }

        public Team Team { get; set; }
    }
}
