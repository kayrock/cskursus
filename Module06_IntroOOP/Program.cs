using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module06_IntroOOP
{
    class Program
    {
        static void Main(string[] args)
        {

            //Lav en ny person og beregn alder

            Person p1 = new Person();
            p1.Efternavn = "Hansen"; //Console.ReadLine();
            p1.Fornavn = "Karsten"; //Console.ReadLine();
            p1.Fødselsår = 1983;
            Console.WriteLine(p1.FuldtNavn());
            Console.WriteLine(p1.BeregnetAlder());


            

            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        }
    }

    class Person
        {

        public string Fornavn;
        public string Efternavn;
        public int Fødselsår;
        

            public string FuldtNavn()
            {

            return $"{Fornavn} {Efternavn}";

        
            }

            public int BeregnetAlder()
               {

                 int år = DateTime.Now.Year;
                return år - this.Fødselsår;

                 }
     
            //default constructor

            public Person()
            {
                 this.Fornavn = "";

                this.Efternavn = "";

            }

        //Custom constructor

        public Person(String efternavn, string fornavn, int fødselsår)
        {
            this.Fødselsår = fødselsår;
            this.Fornavn = fornavn.ToUpper();
            this.Efternavn = efternavn.ToUpper();
        }

     }

}



