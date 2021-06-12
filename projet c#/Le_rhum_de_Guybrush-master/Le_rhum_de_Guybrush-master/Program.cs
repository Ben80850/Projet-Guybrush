using System;
using System.IO;

namespace Le_rhum_de_Guybrush_master
{ 
    /// <summary>
    /// Menu pour le Projet
    /// </summary>
    class Program
    { /// <summary>
      /// Déconnexion du menu
      /// </summary>
        public static void Quitter()
        {
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("---------------Voulez vous quittez ? oui / non -------------------");
            Console.WriteLine("------------------------------------------------------------------");
        }
        
        public static void Deco()
        {
            Console.WriteLine("------------------------------------------------------------------");
        }

        /// <summary>
        /// Page d'accueil avec séléction 
        /// </summary>
   
        static void Main(string[] args)
        {
            
            string carteClaire = File.ReadAllText(@"../../../../../map.claire.txt");
          
           
            bool menu = true;
            while (menu == true)
            {
                Deco();
                Console.WriteLine("--------------------Que voulez-vous faire ? ----------------------");
                Console.WriteLine("--------------------1.Chiffrement --------------------------------");
                Console.WriteLine("--------------------2.Déchiffrement-------------------------------");
                Console.WriteLine("--------------------3.Afficher la carte --------------------------");
                Console.WriteLine("--------------------4.Liste Parcelle -----------------------------");
                Console.WriteLine("--------------------5.Taille d'une parcelle ----------------------");
                Console.WriteLine("--------------------6.Affichage Parcelle sup a Borne -------------");
                Console.WriteLine("--------------------7.Aire de l'ile ------------------------------");

                Deco();
                double choix;
                choix = Convert.ToDouble(Console.ReadLine());
                if (choix == 1)
                {
                    Deco();
                    Console.WriteLine("------Salutation Guybrush votre carte sera crypter dans 5 sec-----");
                    Deco();

                    // System.Threading.Thread.Sleep(5000); /*A remettre avant rendue*/
                    /*--------------------------------------------------------------------------------------*/
                    /*-------------------------------- Carte clair------------------------------------------*/
                    /*--------------------------------------------------------------------------------------*/


                  
                    Console.WriteLine();

                    //Carte Chiffré
                    ile Chiffré = new ile();
                    Chiffré.Chiffrement(carteClaire);
                    /*--------------------------------------------------------------------------------------*/
                    /*-------------------------------- Fin Carte clair--------------------------------------*/
                    /*--------------------------------------------------------------------------------------*/
                    Quitter();
                    string quitter;
                    quitter = Convert.ToString(Console.ReadLine());
                    if (quitter == "oui")
                    {
                        menu = false;
                    }
                    else if (quitter == "non")
                    {
                        menu = true;
                        Console.Clear();
                    }
                    else
                    {
                        Deco();
                        Console.WriteLine("--------------------------------Erreur  --------------------------");
                        Deco();
                    }

                }
                else if (choix == 2)
                {
                    Deco();
                    Console.WriteLine("------Salutation Elaine votre carte sera déchiffré dans 5 sec-------");
                    Deco();

                    //System.Threading.Thread.Sleep(5000);/*A remettre avant rendue*/
                    /*--------------------------------------------------------------------------------------*/
                    /*--------------------------------  Carte chiffré---------------------------------------*/
                    /*--------------------------------------------------------------------------------------*/

                    //ile Dechiffrer = new ile();
                    //Dechiffrer.Dechiffrement(carteChiffre);

                    /*--------------------------------------------------------------------------------------*/
                    /*--------------------------------  Fin Carte chiffré-----------------------------------*/
                    /*--------------------------------------------------------------------------------------*/
                    Quitter();
                    string quitter;
                    quitter = Convert.ToString(Console.ReadLine());
                    if (quitter == "oui")
                    {
                        menu = false;
                    }
                    else if (quitter == "non")
                    {
                        menu = true;
                        Console.Clear();
                    }

                }
                else if (choix == 3)
                {
                    Console.WriteLine("------------------------------------------------------------------");
                    Console.WriteLine("---------------------Affichage de la carte -----------------------");
                    Console.WriteLine("------------------------------------------------------------------");

                    ile IleCouleur = new ile();
                    IleCouleur.Afficher_Ile(carteClaire);

                    Quitter();
                    string quitter;
                    quitter = Convert.ToString(Console.ReadLine());
                    if (quitter == "oui")
                    {
                        menu = false;
                    }
                    else if (quitter == "non")
                    {
                        menu = true;
                        Console.Clear();
                    }
                }

                else if (choix == 4)
                {
                    parcelle Liste = new parcelle();
                    Liste.Affichage_liste_parcelle(carteClaire);
                }

                else if (choix == 5)
                {
                    char Lettre;
                    Console.WriteLine("Entrer la lettre a rechercher");
                    Lettre = Convert.ToChar(Console.ReadLine());
                    parcelle Liste = new parcelle();
                    Liste.Taille_d_une_parcelle(carteClaire, Lettre);
                }




                else if (choix == 6)
                {
                    int Borne;
                    Console.WriteLine("Entrer votre Borne");
                    Borne = Convert.ToInt32(Console.ReadLine());
                    parcelle Liste = new parcelle();
                    Liste.Affichage_Borne_Sup(carteClaire, Borne);
                }
                else if (choix == 7)
                {

                    parcelle Liste = new parcelle();
                    Liste.Aire_de_l_ile(carteClaire);
                }










                else
                {
                    Deco();
                    Console.WriteLine("-----------------------Erreur ----------------------------------");
                    Deco();
                    System.Threading.Thread.Sleep(5000);
                    Console.Clear();
                }
            }
        }
    }
}


