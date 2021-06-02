using System;

namespace ile //appel par ile.chifrement
{
    class Chifrement
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

            for (x = 1; x <= 10; x++) //afichage 
            {
                CarteX[x] = CarteX[x] + CarteXm[x]; //fusion valeur est + ouest 

                Console.WriteLine("case {1} = {0};", CarteX[x], x);
            }

        }
    }
}
