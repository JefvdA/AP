using System;

namespace D2_Verhaalgenerator
{
    class Program
    {
        static Random random = new Random();

        static void Main(string[] args)
        {
        }

        // Name generator
        static string GenerateSimpleName(int nameLength)
        {
            string name = "";
            for (int i = 0; i < nameLength; i++)
            {
                name += (char)random.Next('a', 'z' + 1);
            }
            return name;
        }

        static string GenerateBetterName(int nameLength)
        {
            string name = "";
            char vorigteken = (char)random.Next('a', 'z' + 1);
            for (int i = 0; i < nameLength; i++)
            {
                if (IsKlinker(vorigteken))
                    vorigteken = GenereerMedeklinker();
                else
                    vorigteken = GenereerKlinker();
                name += vorigteken;
            }
            return name;
        }

        static bool IsKlinker(char teken)
        {
            switch (teken)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    return true;
                default:
                    return false;
            }
        }

        static char GenereerKlinker()
        {
            int x = random.Next(0, 5);
            switch (x)
            {
                case 0: return 'a';
                case 1: return 'e';
                case 2: return 'i';
                case 3: return 'o';
                case 4: return 'u';
            }
            return ' ';
        }

        static char GenereerMedeklinker()
        {
            char medeklinker;
            do
            {
                medeklinker = (char)random.Next('a', 'z' + 1);
            } while (IsKlinker(medeklinker));
            return medeklinker;
        }

        // Zin generator
        static string GenereerWerkwoord()
        {
            switch (random.Next(0, 10))
            {
                case 0: return "roept";
                case 1: return "gooit";
                case 2: return "aait";
                case 3: return "eet";
                case 4: return "pakt";
                case 5: return "kijkt naar";
                case 6: return "ledigt";
                case 7: return "vecht met";
                case 8: return "beklimt";
                case 9: return "begraaft";
                default:
                    return "IETS ONBEKENDS";
            }
        }

        static string GenereerVoorwerp()
        {
            switch (random.Next(0, 10))
            {
                case 0: return "een bal";
                case 1: return "de hond";
                case 2: return "de kat";
                case 3: return "een lepel";
                case 4: return "het kind";
                case 5: return "het boek";
                case 6: return "de computer";
                case 7: return "een vork";
                case 8: return "het scherm";
                case 9: return "een dvd";
                default:
                    return "IETS ONBEKENDS";
            }
        }

        static string GenereerKorteZin()
        {
            string onderwerp = GenerateBetterName(6);
            string werkwoord = GenereerWerkwoord();
            string lv = GenereerVoorwerp();

            string zin = $"{onderwerp} {werkwoord} {lv}";

            return zin;
        }

        // Langere zin
        static string GenereerVoegwoord()
        {
            switch (random.Next(0, 6))
            {
                case 0: return " en ";
                case 1: return ", maar ";
                case 2: return ", echter ";
                case 3: return ", dus ";
                case 4: return ", of ";
                case 5: return ", doch";

                default:
                    return "IETS ONBEKENDS";
            }
        }

        static string GenereerLangeZin(int bijzinlengte)
        {
            string hoofdzin = GenereerKorteZin();
            for (int i = 0; i < bijzinlengte; i++)
            {
                hoofdzin += GenereerVoegwoord() + " " + GenereerKorteZin();
            }
            return hoofdzin;
        }
    }
}
