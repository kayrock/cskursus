using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arv
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person    = new Person(){Efternavn ="Hansen",Fornavn ="Karsten"};
            Elev elev = new Elev() { KlasseLokale="Lokale45", Efternavn = "Koefoed",Fornavn = "Kenn" };
            Instruktør instrktør = new Instruktør() { NøgleId=554496 ,Efternavn = "Henriksen", Fornavn = "Niels"};
            
            Console.WriteLine(person.FuldtNavn());
            Console.WriteLine(elev.FuldtNavn()+ " Klasselokale = " +  elev.KlasseLokale);
            Console.WriteLine(instrktør.FuldtNavn()+" NøgleID= " + instrktør.NøgleId);

            Console.Read();
        }

       public class Person
        {
            public string Fornavn { get; set; }

            public string Efternavn { get; set; }

            public string FuldtNavn()
            {
                return $"{Fornavn}  {Efternavn}";
            }

        }

       class Elev : Person
        {
            public string KlasseLokale { get; set; }

        }

        class Instruktør : Person
        {
            public int NøgleId { get; set; }

        }
    }
}
