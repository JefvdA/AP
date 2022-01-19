using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// Uitlezen of samenstellen van een rijksregisternummer.  Merk op dat deze klasse enkel
    /// werkt voor geboortedata tussen 1/1/1900 en 31/12/1999.
    /// </summary>
    public class Rijksregisternummer
    {
        /// <summary>
        /// Ontleedt een RRnr in de verschillende componenten (jaar, maand, dag, geslacht en dagIndex)
        /// </summary>
        /// <param name="rrnr"></param>
        public Rijksregisternummer(string rrnr)
        {
            RRnr = rrnr.Replace(".", "").Replace("-", "");

            ConvertFromFullNumber();
        }

        /// <summary>
        /// Maak een RRnr op basis van de volgende parameters.
        /// </summary>
        /// <param name="jaar">het jaartal</param>
        /// <param name="maand">de maand</param>
        /// <param name="dag">de dag</param>
        /// <param name="gender">geslacht</param>
        /// <param name="dagNr">hoeveelste man (of vrouw) die dag reeds geboren werden</param>
        public Rijksregisternummer(int jaar, int maand, int dag, Gender gender, int dagNr)
        {
            Jaar = jaar;
            Maand = maand;
            Dag = dag;
            Gender = gender;
            DagNr = dagNr;

            ConvertFromParts();
        }

        public int Jaar { get; set; }
        public int Maand { get; set; }
        public int Dag { get; set; }
        public int DagNr { get; set; }
        public Gender Gender { get; set; }
        public int Check { get; private set; }
        public string RRnr { get; set; }


        /// <summary>
        /// RRnr omzetten naar de afzonderlijke componenten (jaar, maand,..) 
        /// </summary>
        private void ConvertFromFullNumber()
        {
            Jaar = int.Parse(RRnr.Substring(0, 2));
            Maand = int.Parse(RRnr.Substring(2, 2));
            Dag = int.Parse(RRnr.Substring(4, 2));
            var DagIndex = int.Parse(RRnr.Substring(6, 3));

            //even of oneven ?
            Gender = DagIndex % 2 == 0 ? Gender.Female : Gender.Male;
            DagNr = (Gender == Gender.Male ? DagIndex + 1 : DagIndex) / 2;
            Check = int.Parse(RRnr.Substring(9, 2));
            if (CalcCheck(RRnr.Substring(0, 9)) != Check)
                throw new ArgumentException("Checksum is onjuist");

            Jaar += 1900;
        }

        /// <summary>
        /// RRnr samenstellen adhv. de afzonderlijke componenten
        /// </summary>
        private void ConvertFromParts()
        {
            var result = string.Concat(Jaar.ToString().Substring(2, 2), Maand.ToString("00"),
                        Dag.ToString("00"),
                        (Gender == Gender.Male ? DagNr * 2 - 1 : DagNr * 2).ToString("000"));

            Check = CalcCheck(result);
            RRnr = result + Check.ToString("00");
        }

        /// <summary>
        /// Checksum berekenen
        /// </summary>
        /// <param name="Register"></param>
        /// <returns></returns>
        private int CalcCheck(string Register)
        {
            return 97 - (int)(long.Parse(Register) % 97);
        }
    }

    public enum Gender
    {
        Female = 0,
        Male = 1
    }
}
