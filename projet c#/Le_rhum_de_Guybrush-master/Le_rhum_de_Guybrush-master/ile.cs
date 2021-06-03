using System;
using System.Collections.Generic;
using System.IO;

namespace ile //appel par ile.chifrement
{
    class InitCarte
    {
        public string[,] TabCarte = new string[10, 10];

        public void Carte()
        {
            try
            {
                //StreamReader pour lire le fichier
                using (StreamReader Carte = new StreamReader(@"A:\Tom\IUT\S2\projet c#\map.claire.txt"))
                {
                    string line;
                    // Lire les lignes du fichier jusqu'à la fin.
                    while ((line = Carte.ReadLine()) != null)
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            // LIGNES (1 à 10)
                            for (int j = 0; j < 10; j++)
                            {
                                TabCarte[i, j] = line;
                            }
                        }
                        // affichage tableau
                       // Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Le fichier n'a pas pu être lu.");
                Console.WriteLine(e.Message);
            }
        }
    }
    class Ile
    {
        
    }
    
    class Chifrement : Ile
    {
       
        static void Main(string[] args)
        {
            
        int x = 0;
          
        string[] Carte = new string[12]; // carte 
            int[] CarteX = new int[12]; // carte x+
            int[] CarteXm = new int[12];// carte x-


            //tableau test
            Carte[1] = "a";
            Carte[2] = "a";
            Carte[3] = "M";
            Carte[4] = "M";
            Carte[5] = "M";
            Carte[6] = "F";
            Carte[7] = "F";
            Carte[8] = "F";
            Carte[9] = "M";
            Carte[10] = "M";



            for (x = 1; x <= 10; x++) // pour ouest
            {
                if (Carte[x] == Carte[x + 1])
                {
                    CarteX[x] = 0;

                }
                if (Carte[x] == "M" && Carte[x] == Carte[x + 1] && Carte[x] != "F")
                {
                    CarteX[x] = 64;
                }
                if (Carte[x] == "F" && Carte[x] == Carte[x + 1] && Carte[x] != "M")
                {
                    CarteX[x] = 32;
                }

                if (Carte[x] == "M" && Carte[x] != Carte[x + 1] && Carte[x] != "F")
                {
                    CarteX[x] = 72;
                }

                if (Carte[x] == "F" && Carte[x] != Carte[x + 1] && Carte[x] != "M")
                {
                    CarteX[x] = 40;
                }

                if (Carte[x] != "M" && Carte[x] != Carte[x + 1] && Carte[x] != "F" || x == 10 && Carte[x] != "M" && Carte[x] != "F")
                {
                    CarteX[x] = 8;
                }

            }

            for (x = 1; x <= 10; x++) // pour EST
            {
                if (Carte[x] == Carte[x - 1])
                {
                    CarteXm[x] = 0;
                }
                if (Carte[x] == "M" && Carte[x] == Carte[x - 1] || Carte[x] == "F" && Carte[x] == Carte[x - 1])
                {
                    CarteXm[x] = 0;
                }

                if (Carte[x] == "M" && Carte[x] != Carte[x - 1] || Carte[x] == "F" && Carte[x] != Carte[x - 1])
                {
                    CarteXm[x] = 2;
                }

                if (Carte[x] != "M" && Carte[x] != Carte[x - 1] || Carte[x] != "F" && Carte[x] != Carte[x - 1])
                {
                    CarteXm[x] = 2;
                }

            }
             
            for (x = 1; x <= 9; x++) //afichage 
            {
                CarteX[x] = CarteX[x] + CarteXm[x]; //fusion valeur est + ouest      

                Console.Write("{0}:", CarteX[x]);
            }
            Console.Write("{0}|", CarteX[10]);//affichage de fin de ligne
        }
    }


}
