using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_Korrekt_afslutning
{
    class Program
    {
        
       
        static void Main(string[] args)
        {
            // lukning korret med using:


         

            using (StreamReader filereader = System.IO.File.OpenText(@"X:\dyrenavne.txt"))

            {





                while (filereader.Peek() != -1)
                {
                    string navn = filereader.ReadLine();


                    Console.WriteLine(navn);
                }


                Console.ReadLine();

            }

            //Lukning ukorrekt:

            //StreamReader filereader = System.IO.File.OpenText(@"X:\dyrenavne.txt");
            //while (filereader.Peek() != -1)
            //{
            //    string navn = filereader.ReadLine();


            //    Console.WriteLine(navn.ToUpper());
            //}
            //filereader.Close();
            //filereader = null;


            Console.ReadLine();
        }


       
        

    }
}
