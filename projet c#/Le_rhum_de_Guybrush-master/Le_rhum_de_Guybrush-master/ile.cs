using System;
using System.Collections.Generic;
using System.IO;

namespace Le_rhum_de_Guybrush_master 
{
    class InitCarte
    {
        public string[,] TabCarte = new string[12, 12];

        public void Carte()
        {
            try
            {
                //StreamReader pour lire le fichier
                using (StreamReader Carte = new StreamReader(@"../../../../../map.claire.txt"))
                {
                    string line;
                    // Lire les lignes du fichier jusqu'� la fin.
                    while ((line = Carte.ReadLine()) != null)
                    {
                        for (int i = 1; i < 10; i++)
                        {
                            // LIGNES (1 � 10)
                            for (int j = 0; j < 10; j++)
                            {
                                TabCarte[i, j] = line;
                            }
                        }
                        // affichage tableau
                      Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Le fichier n'a pas pu �tre lu.");
                Console.WriteLine(e.Message);
            }
        }
    }
    
    
    class Chiffrement :InitCarte
    {

        public void chiffrement()
        {
            int x = 0, y = 0;

            string[,] Carte = new string[12, 12]; // carte 

            //Carte[x,y] = Tabcarte[x,y];
            int[,] CarteX = new int[12, 12]; // carte x+
            int[,] CarteXm = new int[12, 12];// carte x-

            int[,] CarteY = new int[12, 12]; // carte y+
            int[,] CarteYm = new int[12, 12];// carte y--


            //tableau test
            


            for (y = 1; y <= 10; y++)
            {
                for (x = 1; x <= 10; x++) // pour ouest
                {
                    if (Carte[x, y] == Carte[x + 1, y])
                    {
                        CarteX[x, y] = 0;

                    }
                    if (Carte[x, y] == "M" && Carte[x, y] == Carte[x + 1, y] && Carte[x, y] != "F")
                    {
                        CarteX[x, y] = 64;
                    }
                    if (Carte[x, y] == "F" && Carte[x, y] == Carte[x + 1, y] && Carte[x, y] != "M")
                    {
                        CarteX[x, y] = 32;
                    }

                    if (Carte[x, y] == "M" && Carte[x, y] != Carte[x + 1, y] && Carte[x, y] != "F")
                    {
                        CarteX[x, y] = 72;
                    }

                    if (Carte[x, y] == "F" && Carte[x, y] != Carte[x + 1, y] && Carte[x, y] != "M")
                    {
                        CarteX[x, y] = 40;
                    }

                    if (Carte[x, y] != "M" && Carte[x, y] != Carte[x + 1, y] && Carte[x, y] != "F" || x == 10 && Carte[x, y] != "M" && Carte[x, y] != "F")
                    {
                        CarteX[x, y] = 8;
                    }
                }
            }

            for (y = 1; y <= 10; y++)
            {
                for (x = 1; x <= 10; x++) // pour EST
                {
                    if (Carte[x, y] == Carte[x - 1, y])
                    {
                        CarteXm[x, y] = 0;
                    }
                    if (Carte[x, y] == "M" && Carte[x, y] == Carte[x - 1, y] || Carte[x, y] == "F" && Carte[x, y] == Carte[x - 1, y])
                    {
                        CarteXm[x, y] = 0;
                    }

                    if (Carte[x, y] == "M" && Carte[x, y] != Carte[x - 1, y] || Carte[x, y] == "F" && Carte[x, y] != Carte[x - 1, y])
                    {
                        CarteXm[x, y] = 2;
                    }

                    if (Carte[x, y] != "M" && Carte[x, y] != Carte[x - 1, y] || Carte[x, y] != "F" && Carte[x, y] != Carte[x - 1, y])
                    {
                        CarteXm[x, y] = 2;
                    }
                }
            }




            for (y = 1; y <= 10; y++)
            {
                for (x = 1; x <= 10; x++) // haut
                {
                    if (Carte[x, y] != Carte[x, y + 1])
                    {
                        CarteY[x, y] = 0;

                    }

                    if (Carte[x, y] == Carte[x, y + 1])
                    {
                        CarteY[x, y] = 1;

                    }


                }
            }


            for (y = 1; y <= 2; y++)
            {
                for (x = 1; x <= 10; x++) //afichage 
                {
                    CarteX[x, y] = CarteX[x, y] + CarteXm[x, y]; //fusion valeur est + ouest 
                    CarteX[x, y] = CarteX[x, y] + CarteY[x, y];
                    Console.Write("{0};", CarteX[x, y], x);
                    //Console.WriteLine("| ligne {0}", y);
                }
                Console.WriteLine();
            }
        }
    }


}
