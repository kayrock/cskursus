﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvRandom
{


    class Program
    {
        static void Main(string[] args)
        {
            UdvidetRandom r = new UdvidetRandom();
            Console.WriteLine(r.NextBool());

            Console.Read();
        }
    }

    class UdvidetRandom : System.Random
    {
       public bool NextBool()
        {
            return this.Next(1, 1002) < 500;
        }
    }
}
