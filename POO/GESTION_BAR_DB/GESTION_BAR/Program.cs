using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using Google.Protobuf.WellKnownTypes;
using System.Collections;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;
using MySqlX.XDevAPI.Relational;

namespace GESTION_BAR
{
    internal class Program
    {
        static string DefinirCheminBD()
        {
            string server = "localhost";
            string database = "barcocktail";
            string uid = "root";
            string password = "root";
            string connectionString;

            return "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

        }

        static bool ChercherInfos(string table, out DataSet infos)
        {
            MySqlConnection maConnection = new MySqlConnection(DefinirCheminBD());
            bool ok = true;
            string query = "";
            try
            {
                maConnection.Open();

                query = "select * from " + table + ";";

                MySqlDataAdapter da = new MySqlDataAdapter(query, maConnection);
                infos = new DataSet();
                da.Fill(infos, "table");
                maConnection.Close();
                return ok;

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw;
            }
        }

        public bool ChercheRecetteCocktail(int numCocktail, out DataSet recettes)
        {
            bool ok = false;
            MySqlConnection maConnection = new MySqlConnection(DefinirCheminBD());
            string query = "";
            try
            {
                maConnection.Open();

                query = "SELECT * FROM Recettes WHERE cocktailId=" + numCocktail + ";";

                MySqlDataAdapter da = new MySqlDataAdapter(query, maConnection);
                recettes = new DataSet();
                da.Fill(recettes, "infos");

                if (recettes.Tables[0].Rows.Count >= 1)
                {
                    ok = true;
                }
                maConnection.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                throw;
            }

            return ok;
        }
            static void Main(string[] args)
            {
                string choixUser;   // récupération info user
                bool instanciationsOk = true;   // témoin récupération des données dans BDD
                Modele monModele = new Modele();    // accès au modèle
                DataSet infosTable = new DataSet(); // contenu de toute une table
                DataSet infosRecettes = new DataSet(); // contenu d'une recette pour un cocktail donné


                //_________________________________________________listes des objets manipulés____________________________
                // Création des Liquides disponibles (via ChatGpt)
                List<Liquide> liquidesBar = new List<Liquide>();
                List<Bouteille> bouteillesBar = new List<Bouteille>();
                Bar barAsty;
                List<Cocktail> cocktails = new List<Cocktail>();

                //_________________________________________________________________________________________________________

                #region instanciations
                // instanciations des éléments du Bar, et des Recettes
                if (monModele.ChercheInfos("Liquides", out infosTable))
                    {
                        // parcourt du dataSet des liquides
                        for (int i = 0; i < infosTable.Tables[0].Rows.Count; i++)
                        {
                            // ajout d'un liquide dans la liste
                            liquidesBar.Add(new Liquide(infosTable.Tables[0].Rows[i]["liquideNom"].ToString(), infosTable.Tables[0].Rows[i]["liquideType"].ToString()));
                        }

                        // test Vérification des instanciations des liquides : affichage des liquides disponibles
                        Console.WriteLine("Liste des liquides");
                        foreach (Liquide liquide in liquidesBar)
                        {
                            Console.WriteLine($"Nom: {liquide.Nom}, Type: {liquide.Type}");
                        }

                        // On crée une bouteille par liquide disponible
                        foreach (Liquide liquide in liquidesBar)
                        {
                            // Assuming each bottle has a capacity of 75cl tout est exprimé en litres
                            Bouteille bouteille = new Bouteille(liquide, 0.75);
                            bouteillesBar.Add(bouteille);
                        }

                        // test Vérification des instanciations : affichage des Bouteilles disponibles

                        Console.WriteLine("Liste des bouteilles");
                        foreach (Bouteille bouteille in bouteillesBar)
                        {
                            Console.WriteLine($"Contenu: {bouteille.Contenu.Nom}, Contenance: {bouteille.Contenance} litre(s)");
                        }

                        // récupération des noms des cocktails
                        if (monModele.ChercheInfos("Cocktails", out infosTable))
                        {
                            // pour chaque cocktail, récupérer la recette associée
                            for (int i = 0; i < infosTable.Tables[0].Rows.Count; i++)
                            {
                                // création d'une liste d'ingrédients pour une recette de cocktail
                                List<Portion> portionsRecette = new List<Portion>();
                                // récupération d'un recette
                                if (monModele.ChercheRecetteCocktail((int)infosTable.Tables[0].Rows[i]["cocktailId"], out infosRecettes))
                                {
                                    // ajout des ingrédients un à un dans la liste des portions constituant la recette
                                    for (int j = 0; j < infosRecettes.Tables[0].Rows.Count; j++)
                                    {
                                        portionsRecette.Add(new Portion(liquidesBar[(int)infosRecettes.Tables[0].Rows[j]["liquideId"]], (double)infosRecettes.Tables[0].Rows[j]["recetteQuantite"]));
                                    }
                                    // attribution de la liste à une recette
                                    Recette uneRecette = new Recette(portionsRecette);
                                    // ajout de la recette à un cocktail
                                    cocktails.Add(new Cocktail(infosTable.Tables[0].Rows[i]["cocktailNom"].ToString(), uneRecette));
                                }
                                else
                                {
                                    Console.WriteLine("Problème de connexion à la base de données !");
                                    instanciationsOk = false;
                                }
                            }
                            // test Vérification des instanciations : affichage des Cocktails disponibles
                            //----------------------------------------------------------------------------

                            foreach (Cocktail cocktail in cocktails)
                            {
                                Console.WriteLine(cocktail.AfficherRecette());
                            }
                        }
                        else
                        {
                            Console.WriteLine("Problème de connexion à la base de données !");
                            instanciationsOk = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Problème de connexion à la base de données !");
                        instanciationsOk = false;
                    }


                    // Cocktail 1: Screwdriver
                    // liste de portions
                    List<Portion> screwdriverPortions = new List<Portion>
                {
                new Portion(liquidesBar[2], 0.5),  // Orange Juice
                new Portion(liquidesBar[9], 0.5)   // Vodka
                };
                    // attribution de la liste à une recette
                    Recette screwdriverIngredients = new Recette(screwdriverPortions);
                    // ajout de la recette à un cocktail
                    cocktails.Add(new Cocktail("Screwdriver", screwdriverIngredients));

                    // Cocktail 2: Rum and Coke
                    List<Portion> rumAndCokePortions = new List<Portion>
                {
                new Portion(liquidesBar[11], 0.5),  // Rum
                new Portion(liquidesBar[3], 0.5)    // Cola
                };
                    Recette rumAndCokeIngredients = new Recette(rumAndCokePortions);
                    cocktails.Add(new Cocktail("rumAndCoke", rumAndCokeIngredients));

                    // Cocktail 3: White Russian
                    List<Portion> whiteRussianPortions = new List<Portion>
                {
                new Portion(liquidesBar[9], 0.5),   // Vodka
                new Portion(liquidesBar[1], 0.25),  // Milk
                new Portion(liquidesBar[12], 0.25)  // Coffee
                };
                    Recette whiteRussianIngredients = new Recette(whiteRussianPortions);
                    cocktails.Add(new Cocktail("whiteRussian", whiteRussianIngredients));

                    // Cocktail 4: Whiskey Sour
                    List<Portion> whiskeySourPortions = new List<Portion>
                {
                new Portion(liquidesBar[10], 0.5),  // Whiskey
                new Portion(liquidesBar[6], 0.25),  // Lemonade
                new Portion(liquidesBar[0], 0.25)   // Water
                };
                    Recette whiskeySourIngredients = new Recette(whiskeySourPortions);
                    cocktails.Add(new Cocktail("whiskeySourPortions", whiskeySourIngredients));

                    // Cocktail 5: Beer Margarita
                    List<Portion> beerMargaritaPortions = new List<Portion>
                {
                new Portion(liquidesBar[8], 0.25),  // Beer
                new Portion(liquidesBar[7], 0.25),  // Wine
                new Portion(liquidesBar[12], 0.25), // Coffee
                new Portion(liquidesBar[5], 0.25)   // Tea
                };
                    Recette beerMargaritaIngredients = new Recette(beerMargaritaPortions);
                    cocktails.Add(new Cocktail("beerMargarita", beerMargaritaIngredients));

                    // test Vérification des instanciations : affichage des Cocktails disponibles
                    //----------------------------------------------------------------------------

                    foreach (Cocktail cocktail in cocktails)
                    {
                        Console.WriteLine(cocktail.AfficherRecette());
                    }

                    //création du shaker
                    //-------------------------

                    Shaker monShaker = new Shaker(0.5d);

                    //Création du Barman
                    //-------------------------

                    Barman john = new Barman("John");

                    #endregion

                    #region fonctionnement du bar
                    // Fonctionnement du bar :
                    //-------------------------

                    Console.WriteLine("\nBienvenue au Bar Asty-Moulin !");
                    Console.WriteLine("==============================");
                    do
                    {
                        // Préparer le menu
                        string menu = "";
                        int i = 1;
                        foreach (Cocktail cocktail in cocktails)
                        {
                            menu += i + ". Cocktail " + cocktail.Nom + "\n";
                            i++;
                        }

                        //Prendre la commande
                        int numCocktail = john.Commander(menu, cocktails.Count) - 1;

                        //Voir la recette du cocktail choisi
                        Console.WriteLine(cocktails[numCocktail].AfficherRecette());

                        //créer le cocktail
                        bool fabriqueOk = john.Fabriquer(cocktails[numCocktail], ref monShaker, barAsty);
                        if (fabriqueOk)
                        {
                            monShaker.MelangerContenu();
                        }
                        //servir
                        Console.WriteLine(john.Servir(cocktails[numCocktail], fabriqueOk, ref monShaker));

                        //nouvelle commande ?
                        Console.WriteLine("\nUn autre cocktail ? (oui = espace, non  autre)");
                        choixUser = Console.ReadLine();
                    } while (choixUser == " ");
                    #endregion
                }
        }
    }
