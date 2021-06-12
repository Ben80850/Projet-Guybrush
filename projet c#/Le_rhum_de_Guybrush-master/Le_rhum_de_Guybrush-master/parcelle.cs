using System;
using System.Collections.Generic;
using System.Text;

namespace Le_rhum_de_Guybrush_master
{ 
    /// <summary>
    /// Class parcelle : modélise les parcelles
    /// </summary>
    class parcelle
    {
        List<char> parcelles;
        

        char[,] TabCarte = new char[12, 12];
        /// <summary>
        /// Constructeur Affichage_liste_parcelle de la class parcelle <see cref="Le_rhum_de_Guybrush_master.parcelle"/>
        /// </summary>
        /// <param name="carte"></param>
        /// Le parametre carte contient la carte Claire
        
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
                while (CarteChar[n] == '\n' || CarteChar[n] == '\r') n++;//élimination des caractéres vide

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

        /// <summary>
        /// Constructeur Taille_d_une_parcelle de la class parcelle <see cref="Le_rhum_de_Guybrush_master.parcelle"/>
        /// </summary>
        /// <param name="carte"></param>
        /// <param name="Lettre"></param>
        /// Le paramettre carte contient la carte Claire
        /// Le paramettre Lettre permet de spécifier de quelle parcelle on veut connaitre la taille
        public void Taille_d_une_parcelle(string carte, char Lettre)
        {
            char[] CarteChar = carte.ToCharArray();
            int x;
          
            int n = 0;
            int i = 0;
            int compt = 0;
            int test_valeur = 0;

            parcelles = new List<char>();




            for (x = 0; x < 99; x++)
            {
                while (CarteChar[n] == '\n' || CarteChar[n] == '\r') n++;//élimination des caractéres vide
                {
                    if (CarteChar[n] == 'a' + i)

                    {
                        parcelles.Add(CarteChar[n]);
                        i++;
                        n++;
                    }
                    else
                        n++;
                }
            }
            i = 0;


            for (n = 0; n < 99; n++)
            {

                while (CarteChar[n] == '\n' || CarteChar[n] == '\r') n++;//élimination des caractéres vide
                {
                    if ((CarteChar[n].Equals(Lettre)) == true)
                    {
                        compt++;
                        test_valeur++;

                    }

                }
            }
            if (test_valeur == 0)
            {
                Console.WriteLine("Parcelle {0} inexistante", Lettre);
            }
            else
            {
                Console.WriteLine("Parcelle {0}", Lettre);
                Console.WriteLine("Taille de la parcelle {0} : {1} unité(s)", Lettre, compt);
                compt = 0;
            }
        }

        /// <summary>
        /// Constructeur Affichage_Borne_Sup de la class parcelle <see cref="Le_rhum_de_Guybrush_master.parcelle"/>
        /// </summary>
        /// <param name="carte"></param>
        /// <param name="Borne"></param>
        /// Le paramettre carte contient la carte Claire
        /// Le paramettre Borne permet de choisir à partir de quelle taille on affiche une parcelle
        public void Affichage_Borne_Sup(string carte, int Borne)
        {

            char[] CarteChar = carte.ToCharArray();
            int x;
            int Compteur = 0;
            int n = 0;
            int i = 0;
            int compt = 0;

            parcelles = new List<char>();




            for (x = 0; x < 99; x++)
            {
                while (CarteChar[n] == '\n' || CarteChar[n] == '\r') n++;//élimination des caractéres vide 
                {
                    if (CarteChar[n] == 'a' + i)

                    {
                        parcelles.Add(CarteChar[n]);// Ajoute les parcelles dans une liste 
                        i++;
                        n++;
                    }
                    else
                        n++;
                }
            }
            i = 0;

            Console.WriteLine("Parcelle de taille supérieure a {0}", Borne);
            for (i = 0; i < parcelles.Count; i++)
            {
                for (n = 0; n < 99; n++)
                {

                    while (CarteChar[n] == '\n' || CarteChar[n] == '\r') n++;//élimination des caracteres vide 
                    {
                        if ((CarteChar[n].Equals(parcelles[i])) == true)
                        {
                            compt++;

                        }
                    }
                }
                if (compt >= Borne)//Condition pour afficher les parcelles au dessus de Borne 
                {                    
                    Console.WriteLine("Parcelle {1}: {0} unites", compt, parcelles[i]);
                     
                    compt = 0;
                    Compteur++;//nombreur de parcelle au dessus de Borne
                }
                else
                    
                compt = 0;//compteur d'unité de parcelle
                
            }
            if (Compteur == 0)
            {
                Console.WriteLine("Aucune parcelle");
            }
        }

        /// <summary>
        /// Constructeur  Aire_de_l_ile de la class parcelle <see cref="Le_rhum_de_Guybrush_master.parcelle"/>
        /// </summary>
        /// <param name="carte"></param>
        /// Le paramettre carte contient la carte Claire
        public void Aire_de_l_ile(string carte)
        {
            char[] CarteChar = carte.ToCharArray();
            int x;
            int n = 0;
            int i = 0;
            int compt = 0;
            double aire = 0;

            parcelles = new List<char>();



            //    Console.WriteLine("Quelle lettre cherchez-vous ?");
            //    char lettre = Convert.ToChar(Console.ReadLine());

            for (x = 0; x < 99; x++)
            {
                while (CarteChar[n] == '\n' || CarteChar[n] == '\r') n++;
                {
                    if (CarteChar[n] == 'a' + i)

                    {
                        parcelles.Add(CarteChar[n]);
                        i++;
                        n++;
                    }
                    else
                        n++;
                }
            }
            i = 0;



            for (i = 0; i < parcelles.Count; i++)
            {
                for (n = 0; n < 99; n++)
                {

                    while (CarteChar[n] == '\n' || CarteChar[n] == '\r') n++;
                    {
                        if ((CarteChar[n].Equals(parcelles[i])) == true)
                        {
                            compt++;

                        }
                    }
                }
                aire = aire + compt;


                compt = 0;



            }
            aire = aire / parcelles.Count;
            aire = Math.Round(aire, 2);
            Console.WriteLine("L'aire de l'ile est de {0}", aire);
        }




    }         
}



