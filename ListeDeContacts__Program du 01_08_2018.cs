using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {

        static List<string> contacts = new List<string>();
        static void Main(string[] args)
        {
            do
            {
                // possibilité de mettre ici pour faire une boucle :
                //"Bool continuer = true;
                // while (continuer)
               
                AfficherMenu();

                switch (Console.ReadLine())
                {
                    case "1":
                        ListContacts();
                        break;

                    case "2":
                        AjouterContacts();
                        break;
                    case "3":
                        SupprimeContacts();
                        break;
                    case "4":
                        break;
                }
// cette action "while true" permet de faire une boucle et de revenir au "AfficherMenu".
            } while (true);
            




            Console.ReadKey();
        }











        static void AfficherMenu()
        {


            Console.WriteLine(" 1.List des contacts\n 2.Ajouter les contacts\n 3.Supprime les contacts\n 4.Quitter ");



        }

        static void ListContacts()
        {
            Console.WriteLine("Liste de contact");
            foreach (string element in contacts)
                Console.WriteLine(element);
        }

        static void AjouterContacts()
        {
            Console.WriteLine("Entrez le nom de contact");

            contacts.Add(Console.ReadLine());

        }

        static void SupprimeContacts()
        {
            Console.WriteLine("Supprimez le contact?");
            Console.Remove();



        }
        static void Quitter()
        {
        {
                Console.Clear();

        }
    }

}
