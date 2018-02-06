using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vare
{
    class Program
    {
        static void Main(string[] args)
        {
            Vare v = new Vare();
            v.Navn = "Vare #1";
            v.Pris = 100;
            Console.WriteLine("    " +v.Navn);
            Console.WriteLine("    " + v.Pris + ".- uden moms");
            Console.WriteLine("    " + v.PrisMedMoms() + ".- med moms ");

            Vare v2 = new Vare("vare #2", 200);
            Console.WriteLine("    " + v2.Navn);
            Console.WriteLine("    " + v2.Pris + ".- uden moms");
            Console.WriteLine("    " + v2.PrisMedMoms() + ".- med moms ");

            Console.Read();
        }
    }

   
    class Vare

    {
        //Custom constructor
        public Vare(string navn, double pris)
        {
            this.Pris = pris;
            this.Navn = navn;
        }

        //Åben constructor (ctor to gange tab)
        public Vare()
        {
        }



        private string navn;

        public string Navn
        {
            get {
                Console.WriteLine("Nu aflæses der navn:");
                return navn; }
            set {
                Console.WriteLine("Nu tildeles der et navn:");
                navn = value; }
        }

        private double pris;

        public double Pris
        {
            get {
                Console.WriteLine("Nu aflæses der pris:");
                return pris; }
            set {
                Console.WriteLine("Nu tildeles der en pris:");
                pris = value; }
        }

       public double PrisMedMoms()
        {
            Console.WriteLine("Nu lægges moms til prisen");
            return this.pris * 1.25;
        }

        
    }
}
