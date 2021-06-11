using System;
using System.IO;

namespace Le_rhum_de_Guybrush_master
{
             class Program
        {
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
            static void Main(string[] args)
            {
                bool menu = true;
                while (menu == true)
                {
                    Deco();
                    Console.WriteLine("-----------------Voulez vous codez ou décoder ? (1/2)-------------");
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
                    string carte = File.ReadAllText(@"../../../../../map.claire.txt");
                    ile AfficherTableau = new ile();
                    AfficherTableau.Carte(carte);

                    Console.WriteLine();

                    //Carte Chiffré
                    ile Chiffré = new ile();
                    Chiffré.Chiffrement();
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
                            Console.WriteLine("---------------------Erreur  ----------------");
                            Deco();
                        }

                    }
                    else if (choix == 2)
                    {
                        Deco();
                        Console.WriteLine("------Salutation  Elaine votre carte sera décrypter dans 5 sec----");
                        Deco();

                    //System.Threading.Thread.Sleep(5000);/*A remettre avant rendue*/
                    /*--------------------------------------------------------------------------------------*/
                    /*--------------------------------  Carte chiffré---------------------------------------*/
                    /*--------------------------------------------------------------------------------------*/

                    ile Dechiffrer = new ile();
                    Dechiffrer.Dechiffrement();

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


