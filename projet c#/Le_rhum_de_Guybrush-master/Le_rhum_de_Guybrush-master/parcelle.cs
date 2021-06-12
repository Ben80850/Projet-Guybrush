using System;
using System.Collections.Generic;
using System.Text;

namespace Le_rhum_de_Guybrush_master
{
    class parcelle
    {
        List<char> parcelles;
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

        public void Taille_d_une_parcelle(string carte, char Lettre)
        {
            char[] CarteChar = carte.ToCharArray();
            int x;
            int y;
            int n = 0;
            int i = 0;
            int compt = 0;
            int test_valeur = 0;

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


            for (n = 0; n < 99; n++)
            {

                while (CarteChar[n] == '\n' || CarteChar[n] == '\r') n++;
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

        public void Affichage_Borne_Sup(string carte, int Borne)
        {

            char[] CarteChar = carte.ToCharArray();
            int x;
            int Compteur = 0;
            int n = 0;
            int i = 0;
            int compt = 0;

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

            Console.WriteLine("Parcelle de taille supérieure a {0}", Borne);
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
                if (compt >= Borne)
                {                    
                    Console.WriteLine("Parcelle {1}: {0} unites", compt, parcelles[i]);
                     
                    compt = 0;
                    Compteur++;
                }
                else
                    
                compt = 0;
                
            }
            if (Compteur == 0)
            {
                Console.WriteLine("Aucune parcelle");
            }
        }

        public void Aire_de_l_ile(string carte)
        {
            char[] CarteChar = carte.ToCharArray();
            int x;
            int y;
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



