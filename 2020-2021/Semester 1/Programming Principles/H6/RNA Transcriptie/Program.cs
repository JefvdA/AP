using System;

namespace D1_RNA_Transcriptie
{
    class Program
    {
        static void Main(string[] args)
        {
            string dnaString = "";

            string dnaInput = "";
            do
            {
                dnaString += dnaInput;

                Console.Write("Input:   >>>");
                dnaInput = Console.ReadLine().ToUpper();

            } while (dnaInput != "Q");

            /* Oplossing met while loop i.p.v do-while
            Console.Write("Input:   >>>");
            string dnaInput = Console.ReadLine().ToUpper();

            while(DnaInput != "Q")
            {
                dnaString += dnaInput;
                Console.Write("Input:   >>>");
                dnaInput = Console.ReadLine().ToUpper();
            } */

            

            string rnaString = "";
            for(int i = 0; i < dnaString.Length; i++)
            {
                char c = dnaString[i];

                switch (c)
                {
                    case 'G':
                        rnaString += 'C';
                        break;
                    case 'C':
                        rnaString += 'G';
                        break;
                    case 'T':
                        rnaString += 'A';
                        break;
                    case 'A':
                        rnaString += 'U';
                        break;
                    default:
                        Console.WriteLine("Er was een fout de DNA string naar RNA om te zetten");
                        Environment.Exit(1);
                        break;
                }
            }

            Console.WriteLine($"De DNA string '{ dnaString }' wordt '{rnaString}' als het naar RNA wordt omgezet!");

            Console.ReadKey();
        }
    }
}
