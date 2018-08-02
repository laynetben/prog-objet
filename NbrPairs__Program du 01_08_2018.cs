using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre nombre entier");
            for (var i = 1; i <= 20; i++)          
                if (i % 2 == 0)
                    Console.WriteLine("i = " + i);
            

        }
    }
}
