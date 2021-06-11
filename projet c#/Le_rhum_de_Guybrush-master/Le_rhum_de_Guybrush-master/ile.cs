using System;
using System.Collections.Generic;
using System.IO;

namespace Le_rhum_de_Guybrush_master
{
    class ile
    {
        char[,] TabCarte = new char[12, 12];

        public void Carte(string carte)
        {
            char[] CarteChar = carte.ToCharArray();

            int x = 0;
            int y = 0;
            int n = 0;
            for (y = 1; y < 11; y++)
            {
                for (x = 1; x < 11; x++)
                {
                    while (CarteChar[n] == '\n' || CarteChar[n] == '\r') n++;
                    TabCarte[y, x] = CarteChar[n];
                    n++;
                }
            }

            for (y = 1; y < 11; y++)
            {
                for (x = 1; x < 11; x++) //afichage 
                {
                    Console.Write(TabCarte[y, x]);
                }
                Console.WriteLine();
            }

        }
        public void Chiffrement()
        {
            int x = 0, y = 0;

            int[,] CarteX = new int[12, 12]; // carte x+
            int[,] CarteXm = new int[12, 12];// carte x-

            int[,] CarteY = new int[12, 12]; // carte y+
            int[,] CarteYm = new int[12, 12];// carte y--

            for (y = 1; y < 11; y++)
            {
                for (x = 1; x < 11; x++) // pour ouest
                {
                    if (TabCarte[y, x] == TabCarte[y + 1, x])
                    {
                        CarteX[y, x] = 0;

                    }
                    if (TabCarte[y, x] == 'M' && TabCarte[y, x] == TabCarte[y + 1, x] && TabCarte[y, x] != 'F')
                    {
                        CarteX[y, x] = 64;
                    }
                    if (TabCarte[y, x] == 'F' && TabCarte[y, x] == TabCarte[y + 1, x] && TabCarte[y, x] != 'M')
                    {
                        CarteX[y, x] = 32;
                    }

                    if (TabCarte[y, x] == 'M' && TabCarte[y, x] != TabCarte[y + 1, x] && TabCarte[y, x] != 'F')
                    {
                        CarteX[y, x] = 72;
                    }

                    if (TabCarte[y, x] == 'F' && TabCarte[y, x] != TabCarte[y + 1, x] && TabCarte[y, x] != 'M')
                    {
                        CarteX[y, x] = 40;
                    }

                    if (TabCarte[y, x] != 'M' && TabCarte[y, x] != TabCarte[y + 1, x] && TabCarte[y, x] != 'F' || y == 10 && TabCarte[y, x] != 'M' && TabCarte[y, x] != 'F')
                    {
                        CarteX[y, x] = 8;
                    }
                }
            }

            for (y = 1; y < 11; y++)
            {
                for (x = 1; x < 11; x++) // pour EST
                {
                    if (TabCarte[y, x] == TabCarte[y - 1, x])
                    {
                        CarteXm[y, x] = 0;
                    }
                    if (TabCarte[y, x] == 'M' && TabCarte[y, x] == TabCarte[y - 1, x] || TabCarte[y, x] == 'F' && TabCarte[y, x] == TabCarte[y - 1, x])
                    {
                        CarteXm[y, x] = 0;
                    }

                    if (TabCarte[y, x] == 'M' && TabCarte[y, x] != TabCarte[y - 1, x] || TabCarte[y, x] == 'F' && TabCarte[y, x] != TabCarte[y - 1, x])
                    {
                        CarteXm[y, x] = 2;
                    }

                    if (TabCarte[y, x] != 'M' && TabCarte[y, x] != TabCarte[y - 1, x] || TabCarte[y, x] != 'F' && TabCarte[y, x] != TabCarte[y - 1, x])
                    {
                        CarteXm[y, x] = 2;
                    }
                }
            }

            for (y = 1; y < 11; y++)
            {
                for (x = 1; x < 11; x++) // haut
                {
                    if (TabCarte[y, x] != TabCarte[y, x + 1])
                    {
                        CarteY[y, x] = 0;

                    }

                    if (TabCarte[y, x] == TabCarte[y, x + 1])
                    {
                        CarteY[y, x] = 1;

                    }


                }
            }


            for (y = 1; y < 11; y++)
            {
                for (x = 1; x < 11; x++) //afichage 
                {

                    /*
                     CarteX[y, x] = CarteX[y, x] + CarteXm[y, x]; //fusion valeur est + ouest 
                     CarteX[y, x] = CarteX[y, x] + CarteY[y, x];
                     Console.Write("{0};", CarteX[y, x], y);
                     Console.WriteLine("| ligne {0}", y);

                     */
                }
                // Console.WriteLine();
            }
        }
    }

    public void Déchiffrement()
    {


        int x = 0;
        int y = 0;


        int[,] Carte = new int[10, 10]; // carte 
        char[,] CarteX = new char[10, 10];


        for (y = 0; y < 10; y++)
        {
            for (x = 0; x < 10; x++)
            {

                if (Carte[y, x] >= 64)
                {
                    CarteX[y, x] = 'M';
                }
                if (Carte[y, x] >= 32 && Carte[y, x] < 64)
                {
                    CarteX[y, x] = 'F';
                }

                if (Carte[y, x] > 0 && Carte[y, x] < 15)
                {
                    if (Carte[y, x] == 1 + 2 | Carte[y, x] == 2 | Carte[y, x] == 4 + 2) //1= 2^0 et 2= 2^1
                    {
                        CarteX[y, x] = 'a';
                        CarteX[y, x + 1] = 'a';
                    }
                    if (Carte[y, x] == 8 + 4 | Carte[y, x] == 8 + 1) //8= 2^3 et 4= 2^2
                    {
                        CarteX[y, x] = 'b';

                    }
                    if (Carte[y, x] == 8 + 2 || Carte[y, x] == 8 + 2 + 1) //8= 2^3 et 4= 2^2
                    {
                        CarteX[y, x] = 'c';

                    }

                    if (Carte[y, x] == 8 + 4 + 4 | Carte[y, x] == 8 + 2 + 4) //8= 2^3 et 4= 2^2
                    {
                        CarteX[y, x] = 'j';

                    }
                    if (Carte[y, x] == 1 + 4 + 2 | Carte[y, x] == 8 + 4 + 1)
                    {
                        CarteX[y, x] = 'h';

                    }




                }

            }
        }


        for (y = 0; y < 10; y++)
        {
            for (x = 0; x < 10; x++)
            {

                Console.Write("{0}", CarteX[y, x]);
            }
            Console.WriteLine();


        }

    
    }
}
    }
    


}
