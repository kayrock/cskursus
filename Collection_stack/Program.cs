﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Bunke b = new Bunke();
            b.TilføjKort(new Kort() { Kulør = "Spar", Værdi = 2 });
            b.TilføjKort(new Kort() { Kulør = "Hjerter", Værdi = 14 });
            b.TilføjKort(new Kort() { Kulør = "Ruder", Værdi = 3 });
            // b.TilføjKort(new Kort() { Kulør = "Kløver", Værdi = 6 });
            b.Vis();

            var k = b.Fjernkort();
            Console.WriteLine();
            Console.WriteLine(k);
            Console.WriteLine();

            b.Vis();

            /*resultat

            //Alle kort
                Ruder 3
                Hjerter 14
                Spar 2

            //Fjerner kort
                Ruder 3

            //Udskriver resterende
                Hjerter 14
                Spar 2

            */



            Console.Read();
        }
    }

    public class Kort
    {

        public string Kulør { get; set; }
        public int Værdi { get; set; }

        public override string ToString()
        {
            return this.Kulør + " " + this.Værdi;
        }

        

        
    }

    public class Bunke
    {
        private Stack<Kort> bunke = new Stack<Kort>();

        
        public void TilføjKort(Kort k)
        {
            bunke.Push(k);
        }

        public Kort Fjernkort()
        {
            if (bunke.Count > 0)
                return bunke.Pop();
            return null;
            
        }

        public void Vis()
        {
            foreach (var item in bunke)
            {
                Console.WriteLine(item);
            }

            
        }
    }
}