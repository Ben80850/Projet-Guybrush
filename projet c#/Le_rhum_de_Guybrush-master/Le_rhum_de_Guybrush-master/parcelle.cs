using System;
using System.Collections.Generic;
using System.Text;

namespace Le_rhum_de_Guybrush_master
{
    class parcelle
    {
        public char[] parcelles;
        private string Nom;
        private string type;
        private double taille;

        char[,] TabCarte = new char[12, 12];

        public void Affichage_liste_parcelle(string carte)
        {
            char[] CarteChar = carte.ToCharArray();
            char[] parcelles;
            int x;
            int n = 0;
            int i = 0;
            int compt = 0;

            parcelles = new char[50];

            for (x = 0; x < 99; x++)
            {
                while (CarteChar[n] == '\n' || CarteChar[n] == '\r') n++;

                if (CarteChar[n] == 'a' + i)

                {
                    parcelles[i] = CarteChar[n];
                    i++;
                    n++;
                }
                else
                    n++;
            }

            Console.Write(parcelles);
            Console.WriteLine();

            for (x = 0; x < 99; x++)
            {
                if (CarteChar[x] == 'a')
                {
                    compt++;

                }

            }
            Console.Write("il y'a {0} unité a", compt);
            Console.WriteLine();
        }
    }         
}



