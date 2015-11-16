using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighLow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- S T A R T  G A M E --\n\n");
            Game g1 = new Game();
            g1.Start();

            Console.ReadKey();



        }
    }
}
