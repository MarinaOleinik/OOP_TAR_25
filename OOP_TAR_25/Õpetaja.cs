using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_TAR_25
{
    // Õpetaja pärib klassist Isik (koolon tähistab pärimist)
    public class Õpetaja : Isik, ITööline
    {
        public string Aine { get; set; }
        public double Tunnitasu { get; set; }
        public int Tunnidkuus { get; set; }
        public TööTüüp VäljamakseTüüp { get; set; } = TööTüüp.Palk; // Õpetaja puhul on väljamakse tüüp alati palk

        public Õpetaja() : base() // Kutsume baasklassi konstruktorit
        {
            // Siin saame teha täiendavaid initsialiseerimisi, kui vaja
        }
        public Õpetaja(string nimi, string aine, double tunnitasu) : base(nimi)
        {
            Nimi = nimi;
            Aine = aine;
            Tunnitasu = tunnitasu;
        }
        public void Õpeta()
        {
            Console.WriteLine($"{Nimi} õpetab ainet: {Aine}.");
        }
        // override kirjutab abstraktse meetodi üle
        public override string Kirjelda()
        {
            return $"Mina olen õpetaja {Nimi} ja ma õpetan: {Aine}.";
        }
        // ITööline liidese meetodi realiseerimine
        public virtual double ArvutaPalk()
        {
            return Tunnitasu * Tunnidkuus;// Palk arvutatakse tunnitasu ja töötatud tundide korrutisena
        }
        // IHindaja liidese rakendamine
        public void Hinda(string hinne)
        {
            Console.WriteLine($"Õpetaja {Nimi} pani hindeks: {hinne}");
        }
    }
}
