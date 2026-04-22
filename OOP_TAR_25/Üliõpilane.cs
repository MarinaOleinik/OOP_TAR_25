using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_TAR_25
{
    public class Üliõpilane : Õpilane
    {
        // Omadus Eriala
        public string Eriala { get; set; }

        // Konstruktor
        /*public Üliõpilane(string nimi, string klass, string õppevorm, string eriala)
            : base(nimi, klass, õppevorm)
        {
            Eriala = eriala;
        }*/

        // Meetodi Kirjelda() ülekirjutamine
        public override string Kirjelda()
        {
            // Kutsume ülemklassi meetodi, et kuvada nimi, klass ja õppevorm
            var baseDescription = base.Kirjelda();
            // Lisame juurde eriala info
            return $"{baseDescription}\nEriala: {Eriala}";
        }
    }
}
