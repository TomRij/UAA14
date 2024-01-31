using System.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using Google.Protobuf.WellKnownTypes;

namespace CRUDsurBDDimmo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] donneers = new string[5];
            DataSet immoUsers;
            MethodesDuModule MonModule = new MethodesDuModule;
            Console.WriteLine("Liste des utilisateurs");
            Console.WriteLine("----------------------");
            if (MonModule.ChercheUtilisateurs(out immoUsers))
            {
                string listeUser = MonModule.AfficheDataUsers(immoUsers);
                Console.WriteLine(listeUser);
            }
            else
            {
                Console.WriteLine("Pb lors de la lecture des données");
            }
            Console.WriteLine("Ajout d'un utilisateur :");
            Console.WriteLine("------------------------");
            Console.WriteLine("Nom ? ");
            donneers[0] = Console.ReadLine();
            Console.WriteLine("Prénom ? ");
            donneers[1] = Console.ReadLine();
            Console.WriteLine("Login ? ");
            donneers[2] = Console.ReadLine();
            Console.WriteLine("Mot de Passe ? ");
            donneers[3] = Console.ReadLine();
            Console.WriteLine("Rôle ? ");
            donneers[4] = Console.ReadLine();

            if (MonModule.AjouterUser(donneers))
            {
                Console.WriteLine("Utilisateur ajouté :");
            }
            else
            {
                Console.WriteLine("Problème lors de l'ajout !");
            }
            Console.ReadLine();

            static string DefinirCheminBD() // détermine la chaîne de connexion
            {
                return "server=10.10.51.98;database=immo;port=3306;User Id=root;password=root";
            }
        }
    }
}