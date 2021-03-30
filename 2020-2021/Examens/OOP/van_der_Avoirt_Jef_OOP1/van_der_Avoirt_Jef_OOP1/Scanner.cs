using System;
using System.Collections.Generic;
using System.Text;

namespace van_der_Avoirt_Jef_OOP1
{
    class Scanner
    {
        public static string ScanContainer(Container container)
        {
            // In de opgave staat "Gewicht lading = [Beschrijving]" maar ik ga ervan uit dat hier natuurlijk het gewicht van de container meegegeven moet worden.
            // De lijn daaronder staat natuurlijk de beschrijving al
            string rapport =
                $"---CONTAINERREPORT {container.Firma.ToUpper()}--- \n" +
                $"          Gewicht lading={container.Gewicht} \n" +
                $"          Lading:{container.Beschrijving} \n" +
                $"---------------- \n";

            if (container.ActiefSinds().TotalDays >= 5)
                rapport += "*****Deze container heeft verdacht veel gewichtsveranderingen ondergaan \n \n";

            return rapport;
        }
    }
}
