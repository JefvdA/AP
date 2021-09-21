using System;

namespace ConsoleClient
{
    public class Oefening2
    {
        /// <summary>
        /// Startpunt van oef2: sorteeralgoritme en generics
        /// zie opgave pdf voor meer info
        /// </summary>
        public void Start()
        {
            //In de classlibrary vind je een Selection Sort, maar deze is nog niet generiek.
            //Je kan deze ofwel kopiëren naar dit project en omvormen met generics (voorkeur)
            //ofwel maak je een Sort Algoritme die enkel Pokemon kan sorteren.
            //(dit kost je echter enkele punten)
            SelectionSort<string> selectionSortName = new SelectionSort<string>();
            SelectionSort<int> selectionSortHeight = new SelectionSort<int>();

            Pokemon[] list = CreateList();

            string[] nameList = new string[list.Length]; // Create a list with all pokemon names, to sort them
            for (int i = 0; i < nameList.Length; i++)
            {
                nameList[i] = list[i].Name;
            }

            int[] heightList = new int[list.Length];    // Create a list with all pokemon heights, to sort them
            for (int i = 0; i < heightList.Length; i++)
            {
                heightList[i] = list[i].Height;
            }


            //TODO: sorteer de lijst hier eerst volgens 'Name' in alfabetische volgorde
            //Zorg dat de pokemon klasse zelf de volgorde bepaalt.
            // Pokemon klasse heeft static waarde "ASC" or "DESC" deze zal kiezen hoe het gesorteerd moet worden
            selectionSortName.Sort(nameList); // Sorteer nameList op ASC volgorde
            for (int i = 0; i < nameList.Length; i++)   // Loop door nameList 
            {
                string name = nameList[i];  // Houd huidige naam bij
                for (int j = 0; j < list.Length; j++)   // Loop door pokemonList
                {
                    if(list[j].Name == name)    // Check of dit de pokemon is met de huidige naam in "name"
                    {
                        SwitchElements(list, i, j);     // Zo ja, zet deze pokemon op de index van zijn naam uit nameList
                        break;
                    }
                }
            }
            if (Pokemon.NameSortMethod != "ASC")    // TODO : DESC volgorde
            {
                list = ReverseList(list); // Reverse de nameList als deze niet op ASC volgorde moest zijn
            }

            //Weergeven van de gesorteerde lijst
            Console.WriteLine("Standaard sortering volgens 'Name'");
            ShowList(list);

            //TODO: sorteer de lijst hier eerst terug maar nu volgens Height en in dalende volgorde
            selectionSortHeight.Sort(heightList);
            for (int i = 0; i < heightList.Length; i++)   // Loop door nameList 
            {
                int height = heightList[i];  // Houd huidige naam bij
                for (int j = 0; j < list.Length; j++)   // Loop door pokemonList
                {
                    if (list[j].Height == height)    // Check of dit de pokemon is met de huidige naam in "name"
                    {
                        SwitchElements(list, i, j);     // Zo ja, zet deze pokemon op de index van zijn naam uit nameList
                        break;
                    }
                }
            }
            list = ReverseList(list);

            //weergeven van de gesorteerde lijst
            Console.WriteLine("2e sortering volgens 'Height' in dalende volgorde");
            ShowList(list);
        }

        /// <summary>
        /// Maak een lijst met Pokemons
        /// </summary>
        /// <returns></returns>
        Pokemon[] CreateList()
        {
            var list = new Pokemon[4];

            list[0] = new Pokemon()
            {
                Name = "Ivysaur",
                Weight = 130,
                Height = 10
            };
            list[1] = new Pokemon()
            {
                Name = "Bulbasaur",
                Weight = 69,
                Height = 7
            };
            list[2] = new Pokemon()
            {
                Name = "Venusaur",
                Weight = 1000,
                Height = 20
            };
            list[3] = new Pokemon()
            {
                Name = "Charmander",
                Weight = 85,
                Height = 6
            };

            return list;
        }

        /// <summary>
        /// Toon de lijst in de console
        /// </summary>
        /// <param name="list"></param>
        void ShowList(Pokemon[] list)
        {
            foreach (var p in list)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine();
        }

        T[] ReverseList<T>(T[] list)
        {
            var newList = new T[list.Length];
            for (int i = 0; i < newList.Length; i++)
            {
                newList[i] = list[list.Length - 1 - i];
            }
            return newList;
        }

        void SwitchElements<T>(T[] array, int index1, int index2)
        {
            var temp = array[index2];
            array[index2] = array[index1];
            array[index1] = temp;
        }
    }
}
