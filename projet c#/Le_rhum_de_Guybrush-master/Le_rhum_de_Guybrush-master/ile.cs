using System;
using System.Collections.Generic;
using System.IO;

namespace Le_rhum_de_Guybrush_master 
{
    class ile
    {
        char[,] TabCarte = new char[12, 12];

        public void Carte()
        {

            
            string carte = File.ReadAllText(@"../../../../../map.claire.txt");
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
                    if (TabCarte[x, y] == TabCarte[x + 1, y])
                    {
                        CarteX[x, y] = 0;

                    }
                    if (TabCarte[x, y] == 'M' && TabCarte[x, y] == TabCarte[x + 1, y] && TabCarte[x, y] != 'F')
                    {
                        CarteX[x, y] = 64;
                    }
                    if (TabCarte[x, y] == 'F' && TabCarte[x, y] == TabCarte[x + 1, y] && TabCarte[x, y] != 'M')
                    {
                        CarteX[x, y] = 32;
                    }

                    if (TabCarte[x, y] == 'M' && TabCarte[x, y] != TabCarte[x + 1, y] && TabCarte[x, y] != 'F')
                    {
                        CarteX[x, y] = 72;
                    }

                    if (TabCarte[x, y] == 'F' && TabCarte[x, y] != TabCarte[x + 1, y] && TabCarte[x, y] != 'M')
                    {
                        CarteX[x, y] = 40;
                    }

                    if (TabCarte[x, y] != 'M' && TabCarte[x, y] != TabCarte[x + 1, y] && TabCarte[x, y] != 'F' || x == 10 && TabCarte[x, y] != 'M' && TabCarte[x, y] != 'F')
                    {
                        CarteX[x, y] = 8;
                    }
                }
            }

            for (y = 1; y <= 10; y++)
            {
                for (x = 1; x <= 10; x++) // pour EST
                {
                    if (TabCarte[x, y] == TabCarte[x - 1, y])
                    {
                        CarteXm[x, y] = 0;
                    }
                    if (TabCarte[x, y] == 'M' && TabCarte[x, y] == TabCarte[x - 1, y] || TabCarte[x, y] == 'F' && TabCarte[x, y] == TabCarte[x - 1, y])
                    {
                        CarteXm[x, y] = 0;
                    }

                    if (TabCarte[x, y] == 'M' && TabCarte[x, y] != TabCarte[x - 1, y] || TabCarte[x, y] == 'F' && TabCarte[x, y] != TabCarte[x - 1, y])
                    {
                        CarteXm[x, y] = 2;
                    }

                    if (TabCarte[x, y] != 'M' && TabCarte[x, y] != TabCarte[x - 1, y] || TabCarte[x, y] != 'F' && TabCarte[x, y] != TabCarte[x - 1, y])
                    {
                        CarteXm[x, y] = 2;
                    }
                }
            }




            for (y = 1; y <= 10; y++)
            {
                for (x = 1; x <= 10; x++) // haut
                {
                    if (TabCarte[x, y] != TabCarte[x, y + 1])
                    {
                        CarteY[x, y] = 0;

                    }

                    if (TabCarte[x, y] == TabCarte[x, y + 1])
                    {
                        CarteY[x, y] = 1;

                    }


                }
            }


            for (y = 1; y <= 10; y++)
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
