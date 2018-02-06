using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nedarvning_Polymporfi
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning[] terninger = new Terning[4];
            terninger[0] = new Terning();
            terninger[1] = new Terning();
            terninger[2] = new LudoTerning();
            terninger[3] = new LudoTerning();
                
                
                foreach (var item in terninger)
            {
                item.Skriv();
            }

            Console.Read();
        }

        public class Terning
        {
            private int værdi;
            private static System.Random rnd;

            public int Værdi
            {
                get { return this.værdi; }
                set {
                    if (value < 0 || value > 6)
                        value = 1;
                    this.værdi = value;                    
                 }
            }

             public virtual void Skriv()
            {
                Console.WriteLine("Du slog: [ " +this.værdi + "]"  );
            }


            public void Ryst()
            {
                this.værdi = rnd.Next(1, 7);
            }

            public Terning()
            {
                this.Ryst();
            }

            public Terning(int værdi)
             {
              this.værdi = værdi;
              }

            static Terning()
            {
                rnd = new Random();
            }



           

            
            
        }


        //arver fra terning
        public class LudoTerning : Terning
        {
            public bool ErGlobus()
            {
                return this.Værdi == 3;

            }

            public bool ErStjerne()
            {
                return this.Værdi == 5;

            }

            public LudoTerning() : base()
            {}
        
        public LudoTerning(int værdi) : base(værdi)
            { }

            public override void Skriv()
            {

               switch (this.Værdi)
                {
                    case 1:
                        Console.WriteLine("Ludo -> Du slog en: [1'er]");
                        break;
                    case 2:
                        Console.WriteLine("Ludo -> Du slog en: [2'er]");
                        break;
                    case 3:
                        Console.WriteLine("Ludo -> Du slog en: [Stjerne]");
                        break;
                    case 4:
                        Console.WriteLine("Ludo -> Du slog en: [4'er]");
                        break;
                    case 5:
                        Console.WriteLine("Ludo -> Du slog en: [Globus]");
                        break;
                    default:
                        base.Skriv();
                        break;
                }
            }


        }
    }

}
