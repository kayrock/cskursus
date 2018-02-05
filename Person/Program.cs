using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    {
        static void Main(string[] args)
        {
            Person p = new Person();

            p.Fornavn = "Karsten";
            p.Efternavn = "Hansen";

            Console.WriteLine(p.FuldtNavn());


            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }
        

    }

        public string Fornavn { get; set; }

        private string efternavn;

        public string Efternavn
        {
            get { return efternavn; }
            set
            {

                if (value.Length < 3)
                {

                    efternavn = "";
                }
                else
                {
                    efternavn = value;
                }
            }
        }

       public string FuldtNavn()
        {

            return Fornavn + " " + Efternavn;
        }


    }

    
    
    



}
