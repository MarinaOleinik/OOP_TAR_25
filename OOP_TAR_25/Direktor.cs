using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_TAR_25
{
    public class Direktor : Õpetaja
    {
        // Omadus Lisatasu
        public double Lisatasu { get; set; }

        // Konstruktor (vajalik, kui Õpetaja klassil on parameetritega konstruktor)
        public Direktor(string nimi, double baaspalk, double lisatasu) 
        {
            Lisatasu = lisatasu;
        }

        // Meetodi ArvutaPalk ülekirjutamine
        public override double ArvutaPalk()
        {
            // Kasutame ülemklassi (base) meetodit ja liidame sellele lisatasu
            return base.ArvutaPalk() + Lisatasu;
        }
        public override string Kirjelda()
        {
            return base.Kirjelda();
        }
    }
}
