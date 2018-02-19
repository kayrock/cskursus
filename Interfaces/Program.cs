using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Program
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();



        static void Main(string[] args)
        {
            IDbFunktioner[] array = new IDbFunktioner[4];
            array[0] = new Hund();
            array[1] = new Ubåd();
            array[2] = new Hund();
            array[3] = new Ubåd();
            foreach (var item in array)
            {
                item.Gem();
            }

         

            logger.Debug("Start af program");





            Console.ReadLine();
        }

        class Hund : IDbFunktioner
        {
            public string Navn { get; set; }

            public void Gem()
            {
                Console.WriteLine("Gemmer hund.....");
            }

            
                        


        }
        class Ubåd : IDbFunktioner  
        {
            public string Nummer { get; set; }
            public double Tubine { get; set; }

            public void Gem()
            {

                Console.WriteLine("Gemmer ubåd");
            }

            
        }

        interface IDbFunktioner
        {
            void Gem();
        }
    }
}
