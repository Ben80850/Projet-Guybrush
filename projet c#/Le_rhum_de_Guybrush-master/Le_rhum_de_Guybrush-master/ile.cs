using System;
using System.Collections.Generic;
using System.IO;

namespace Le_rhum_de_Guybrush_master
{
    class ile
    {
        char[,] TabCarte = new char[12, 12];
        int[,] CarteX = new int[12, 12];
        int[,] CarteXm = new int[12, 12];
        int[,] CarteY = new int[12, 12];
        int x;
        int y;
        int n;


        public void Chiffrement(string carte)
        {
            char[] CarteChar = carte.ToCharArray();


            for (y = 1; y < 11; y++)
            {
                for (x = 1; x < 11; x++)
                {
                    while (CarteChar[n] == '\n' || CarteChar[n] == '\r') n++;
                    TabCarte[y, x] = CarteChar[n];
                    n++;
                }
            }


            for (y = 1; y < 11; y++)            //chifrement frontière est
            {
                for (x = 1; x < 11; x++)
                {
                    if ((TabCarte[y, x].Equals(TabCarte[y, x + 1]) && !TabCarte[y, x].Equals('M')) == true)

                    {
                        CarteX[y, x] = 0;
                    }

                    if (TabCarte[y, x].Equals('M') && TabCarte[y, x].Equals(TabCarte[y, x + 1]) == true)
                    {
                        CarteX[y, x] = 64;
                    }

                    if ((TabCarte[y, x].Equals('F') && TabCarte[y, x].Equals(TabCarte[y, x + 1]) && !TabCarte[y, x].Equals('M')) == true)
                    {
                        CarteX[y, x] = 32;
                    }

                    if ((TabCarte[y, x].Equals('M') && !TabCarte[y, x].Equals(TabCarte[y, x + 1]) || TabCarte[y, x].Equals('M') && TabCarte[y, x + 1].Equals("\r") == true))
                    {
                        CarteX[y, x] = 72;
                    }

                    if ((TabCarte[y, x].Equals('F') && !TabCarte[y, x].Equals(TabCarte[y, x + 1]) && !TabCarte[y, x].Equals('M')) == true)
                    {
                        CarteX[y, x] = 40;
                    }

                    if ((!TabCarte[y, x].Equals(TabCarte[y, x + 1]) && !TabCarte[y, x].Equals('F') && !TabCarte[y, x].Equals('M')) == true)

                    {
                        CarteX[y, x] = 8;
                    }

                }
            }

            for (y = 1; y < 11; y++)            //chifrement frontière Ouest
            {
                for (x = 1; x < 11; x++)
                {

                    if ((TabCarte[y, x].Equals('M') && TabCarte[y, x].Equals(TabCarte[y, x - 1]) || TabCarte[y, x].Equals('F') && TabCarte[y, x].Equals(TabCarte[y, x - 1])) == true)
                    {
                        CarteXm[y, x] = 0;
                    }

                    if ((TabCarte[y, x].Equals('M') && !TabCarte[y, x].Equals(TabCarte[y, x - 1]) || TabCarte[y, x].Equals('F') && !TabCarte[y, x].Equals(TabCarte[y, x - 1])) == true)
                    {
                        CarteXm[y, x] = 2;
                    }

                    if ((!TabCarte[y, x].Equals('M') && !TabCarte[y, x].Equals(TabCarte[y, x - 1]) || !TabCarte[y, x].Equals('F') && !TabCarte[y, x].Equals(TabCarte[y, x - 1])) == true)
                    {
                        CarteXm[y, x] = 2;
                    }


                }

            }

            for (y = 1; y < 11; y++)
            {
                for (x = 1; x < 11; x++)
                {

                    if ((!TabCarte[y, x].Equals(TabCarte[y - 1, x])) == true)
                    {
                        CarteY[y, x] = 1;

                    }
                }
            }

            for (y = 1; y < 11; y++)
            {
                for (x = 1; x < 11; x++)
                {
                    CarteX[y, x] = CarteX[y, x] + CarteXm[y, x];
                    CarteX[y, x] = CarteX[y, x] + CarteY[y, x];

                    Console.Write("{0};", CarteX[y, x]);
                }
                Console.WriteLine("|");
            }
        }
        public void Dechiffrement(string carte)
        {

            char[] CarteChar = carte.ToCharArray();


            for (y = 1; y < 11; y++)
            {
                for (x = 1; x < 11; x++)
                {
                    while (CarteChar[n] == '\n' || CarteChar[n] == '\r') n++;
                    TabCarte[y, x] = CarteChar[n];
                    n++;
                }
            }


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
        public void Afficher_Ile(string carte)
        {
            char[] CarteChar = carte.ToCharArray();


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
                for (x = 1; x < 11; x++)
                {
                    if (TabCarte[y, x] == 'M')
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                    }
                    if (TabCarte[y, x] == 'F')
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    if (TabCarte[y, x] != 'F' && TabCarte[y, x] != 'M')
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    Console.Write("{0};", TabCarte[y, x]);

                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

}