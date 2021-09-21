using ClassLibrary.Tree.Binary.Generic;
using DLL = ClassLibrary.DLL.Generic;
using System;
using ClassLibrary.Tree.BST.Generic;

namespace ConsoleClient
{
    public class Oefening1
    {
        /// <summary>
        /// Startpunt van oef1: BST, DLL en recursie
        /// zie opgave pdf voor meer info
        /// </summary>
        public void Start()
        {
            //Vul deze code aan. In de classlibrary vind je reeds een 'Binary Search Tree' die je kan gebruiken.
            //(Je mag ook je eigen Tree class in dit project toevoegen en gebruiken)
            Tree<int> tree = new Tree<int>();

            Console.WriteLine("Welkom bij oef 1. Geef na elkaar 5 verschillende gehele getallen in");
            int counter = 1;
            int getal = 0;
            while (counter <= 5)
            {
                var text = Console.ReadLine();
                if (int.TryParse(text, out getal))
                {
                    //TODO: voeg het getal telkens toe aan de BST
                    tree.Insert(getal);
                    counter++;
                }
                else
                    Console.WriteLine("een GEHEEL GETAL ingeven AUB.");
            }

            //Opdracht A: gebruik hiervoor de methode ZoekMax()
            Console.WriteLine($"Het grootste getal dat u heeft ingevoerd is : {ZoekMax(tree.Root)}");// + ZoekMax());

            //Opdracht B: gebruik hiervoor de methode Som()
            Console.WriteLine($"De som van alle getallen die u heeft ingegeven is: {Som(tree.Root)}");// + Som());

            //Opdracht C: gebruik hiervoor de methode Convert()

            //var list = Convert(...);
            var list = Convert(tree.Root);
            Console.WriteLine($"Hieronder worden alle getallen weergegeven in stijgende volgorde");
            //TODO: toon alle getallen in de lijst.

            var node = list.First;
            while(node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }

        /// <summary>
        /// Opdracht A: Haal de hoogste waarde uit de gegeven BST.
        /// Doe dit op een iteratieve manier !
        /// </summary>
        /// <returns>de hoogste waarde</returns>
        private int ZoekMax(Node<int> rootNode)
        {
            var node = rootNode;
            int max = rootNode.Value;
            while(node.Right != null)
            {
                node = node.Right;
                if (node.Value > max)
                    max = node.Value;
            }
            return max;
        }

        /// <summary>
        /// Opdracht B: Bereken de Som van alle waarden in de BST
        /// Doe dit op een recursieve manier
        /// </summary>
        /// <returns></returns>
        private int Som(Node<int> rootNode)
        {
            if (rootNode == null) return 0; // Base case

            return rootNode.Value + Som(rootNode.Left) + Som(rootNode.Right);
        }

        /// <summary>
        /// Opdracht C: Zet de BST om naar een DLL, waarbij alle nodes ineens in volgorde staan van klein naar groot.
        /// Doe dit bij voorkeur op een recursieve manier. 
        /// Indien het je niet lukt mag het ook iteratief maar dat kost je enkele punten.
        /// </summary>
        /// <returns></returns>
        private DLL.List<int> Convert(Node<int> rootNode)
        {
            DLL.List<int> list = new DLL.List<int>();

            if (rootNode.Left != null)
            {
                var leftList = Convert(rootNode.Left);
                int length = 0;
                var node = leftList.First;
                while(node != null)
                {
                    length++;
                    node = node.Next;
                }
                for (int i = 0; i < length; i++)
                {
                    list.AddLast(leftList.Last.Value);
                }
            }
            if(rootNode.Left == null)
                list.AddLast(rootNode.Value);
            if (rootNode.Right != null)
            {
                var rightList = Convert(rootNode.Right);
                int length = 0;
                var node = rightList.First;
                while (node != null)
                {
                    length++;
                    node = node.Next;
                }
                for (int i = 0; i < length; i++)
                {
                    list.AddLast(rightList.Last.Value);
                }
            }

            return list;
        }
    }
}
