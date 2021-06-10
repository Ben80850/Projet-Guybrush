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
            for (y = 0; y < 10; y++)
            {
                for (x = 0; x < 10; x++)
                {

                    TabCarte[y, x] = CarteChar[n];
                    n++;
                }


            }
        }
        public void Chiffrement()
        {
            int x = 0, y = 0;

            int[,] CarteX = new int[12, 12]; // carte x+
            int[,] CarteXm = new int[12, 12];// carte x-

            int[,] CarteY = new int[12, 12]; // carte y+
            int[,] CarteYm = new int[12, 12];// carte y--


            //tableau test



            for (y = 1; y <= 10; y++)
            {
                for (x = 1; x <= 10; x++) // pour ouest
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

                    if (TabCarte[y,x] == 'M' && TabCarte[y, x] != TabCarte[y + 1, x] && TabCarte[y, x] != 'F')
                    {
                        CarteX[y, x] = 72;
                    }

                    if (TabCarte[y, x] == 'F' && TabCarte[y, x] != TabCarte[y + 1, x] && TabCarte[y, x] != 'M')
                    {
                        CarteX[y, x] = 40;
                    }

                    if (TabCarte[y, x] != 'M' && TabCarte[y, x] != TabCarte[y + 1, x] && TabCarte[y, x] != 'F' || y== 10 && TabCarte[y, x] != 'M' && TabCarte[y, x] != 'F')
                    {
                        CarteX[y, x] = 8;
                    }
                }
            }

            for (y = 1; y <= 10; y++)
            {
                for (x = 1; x <= 10; x++) // pour EST
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




            for (y = 1; y <= 10; y++)
            {
                for (x = 1; x <= 10; x++) // haut
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


            for (y = 1; y <= 10; y++)
            {
                for (x = 1; x <= 10; x++) //afichage 
                {
                    CarteX[y, x] = CarteX[y, x] + CarteXm[y, x]; //fusion valeur est + ouest 
                    CarteX[y, x] = CarteX[y, x] + CarteY[y, x];
                    Console.Write("{0};", CarteX[y, x], y);
                    //Console.WriteLine("| ligne {0}", y);
                }
                Console.WriteLine();
            }
        }
    }
    


}
