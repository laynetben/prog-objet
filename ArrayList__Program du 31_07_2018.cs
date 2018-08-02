using System;
using System.Collections;
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
            var listeChaine = new List<string>();
                      
            Console.WriteLine("Nom?");
            listeChaine.Add(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Prenom?");
            listeChaine.Add(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Age?");
            listeChaine.Add(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Bonjour " +listeChaine[1]+ " " +listeChaine[0]+",\nTu as " +listeChaine[2]+ " "+ "ans.");
                       
        
            Console.ReadKey();
        }
    }
}
