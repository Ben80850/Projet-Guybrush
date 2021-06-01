using System;
using System.IO;

namespace Le_rhum_de_Guybrush_master
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //StreamReader pour lire le fichier
                using (StreamReader Carte = new StreamReader(@"C:\Users\BN\Documents\Cours\S2\concept Objet\Td\Projet\projet c#\map.claire.txt"))
                {
                    string line;
                    string[,] TabCarte = new string[10, 10];
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
                        Console.WriteLine(line);
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
}
