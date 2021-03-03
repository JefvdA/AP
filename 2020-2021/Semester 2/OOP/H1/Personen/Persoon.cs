using System;
using System.Collections.Generic;
using System.Text;

namespace Personen
{
    class Persoon
    {
        public string name { get; set; }

        public void Introductie()
        {
            Console.WriteLine($"Hoi ik ben {name}");
        }
    }
}
