using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Mon application";
            bool valeurBooleene = true;
            int entier = 5;
            string chaine = "Hi!";
            DateTime date = new DateTime(2018, 07, 30);
            
            Console.WriteLine("Bool:" + valeurBooleene);
            Console.WriteLine("Entier:" + entier);
            Console.WriteLine("chaine:" + chaine);
            Console.WriteLine("Date:" + date);

            ArrayList prénomsDynamiques = new List<string>();

            Console.WriteLine("Nom 1?"; );
            prenomsDynamiqeus.Add(Console.ReadLine());

            Console.WriteLine("Nom 2?"; );
            prenomsDynamiqeus.Add(Console.ReadLine());

            Console.WriteLine("Nom 3?"; );
            prenomsDynamiqeus.Add(Console.ReadLine());

            Console.WriteLine(prenomsDynamiqeus[0]);
            Console.WriteLine(prenomsDynamiqeus[1]);
            Console.WriteLine(prenomsDynamiqeus[2]);
           

            Console.ReadKey();
        }
    }
}
