using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileWatch
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = (@"C:\temp\demo.txt");

            // Create the file.

            if (!System.IO.File.Exists(path))
            {

                using (System.IO.FileStream fs = System.IO.File.Create(path))
                {
                    Byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
                    // Add some information to the file.
                    fs.Write(info, 0, info.Length);
                }
            }


            




            System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");
            w.EnableRaisingEvents = true;
            w.NotifyFilter = System.IO.NotifyFilters.FileName | System.IO.NotifyFilters.Size;
            w.Changed += W_Changed;
            do
            {

            } while (true);


            
        }

        

        private static void W_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine("Filen: " + e.Name + " er blivet ændret kl " + DateTime.Now.ToShortTimeString());
            
        }
    }

}
