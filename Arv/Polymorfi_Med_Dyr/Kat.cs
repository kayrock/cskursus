﻿using System;

namespace Polymorfi_Med_Dyr
{
    partial class Program
    {
        partial class Dyr
        {
            public class Kat : Dyr
            {
                public override void SigNoget()
                {
                    Console.WriteLine("Jeg er en kat og hedder...." + Navn);
                }
            }
        }

        


    }
}
