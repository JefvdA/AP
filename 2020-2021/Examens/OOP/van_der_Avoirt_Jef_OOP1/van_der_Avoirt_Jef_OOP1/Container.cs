using System;
using System.Collections.Generic;
using System.Text;

namespace van_der_Avoirt_Jef_OOP1
{
    class Container
    {
        // AUTO PROPERTIES
        public string Firma { get; private set; }
        public string Beschrijving { get; private set; }
        public DateTime LaatstAangepast { get; private set; }
        public DateTime GemaaktOp { get; private set; }


        //FULL PROPERTIES
        private int gewicht;
        public int Gewicht
        {
            get { return gewicht; }
            set {
                if(value >= 0 && value <= 100)
                    gewicht = value;
                else
                {
                    Console.WriteLine("Fout gewicht. Ingesteld op 100");
                    gewicht = 100;
                }

                LaatstAangepast = LaatstAangepast.AddDays(1);
            }
        }


        // CONSTRUCTORS
        public Container(string _firma, string _beschrijving, int _gewicht)
        {
            Firma = _firma;
            Beschrijving = _beschrijving;
            Gewicht = _gewicht;

            GemaaktOp = DateTime.Now;
            LaatstAangepast = DateTime.Now;
        }


        // METHODS
        public void Ledig()
        {
            Beschrijving = "leeg";
            Gewicht = 0;
        }

        public TimeSpan ActiefSinds()
        {
            return LaatstAangepast - GemaaktOp;
        }

        public void VoegContainerToe(Container meegegevenContainer)
        {
            // Check of container van dezelfde firma is, en niet teveel weegt
            if(meegegevenContainer.Firma != Firma)
            {
                Console.WriteLine("Containers zijn niet van zelfde firma. Kan niet samenvoegen.");
                return;
            }

            if((Gewicht + meegegevenContainer.gewicht) > 100)
            {
                Console.WriteLine("Kan container niet toevoegen. Dit zou gewicht boven de 100 brengen");
                return;
            }

            // Container kan toegevoegd worden
            Gewicht += meegegevenContainer.Gewicht;
            Beschrijving += $" en {meegegevenContainer.Beschrijving}";

            meegegevenContainer.Ledig();
        }

    }
}
