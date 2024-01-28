using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrijestupneGodine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            for (i = 1900; i <= 2100; i++)
            {
                if (i % 400 == 0)
                {
                    Console.WriteLine(i);
                }
                else if(i % 4 == 0 && i % 100 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
