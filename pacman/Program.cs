using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pacman
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int aukstis = 16;
            int plotis = 11;
            int saldainiai = 0;
            string[,] lentele = new string[aukstis, plotis]; 
            lentele[0, 0] = " X ";
            for (int i = 0; i < aukstis ; i++)
            {
                for (int j = 0; j < plotis ; j++)
                {
                    int Atsitiktinis = rnd.Next(0, 2);

                    if (Atsitiktinis == 1)
                    {
                        lentele[i, j] = " O ";
                        if (lentele[i, j] == " O ")
                            saldainiai++;
                    }
                    else if (Atsitiktinis == 0)
                        lentele[i, j] = "   ";   
                }
            } // RANDOM IDEJIMAS I MASYVA
            int x = 0;
            int y = 0;
            int a = 15;
            int b = 10;
            int taskai = 0;
            int skirtumas = 0;
            int skirtumas1 = 0;
            lentele[x, y] = " X ";
          //  lentele[a, b] = " # ";
            while (saldainiai != 0)
            {
                Console.Clear();
                Console.WriteLine("#########   *PACMAN*   #########");
                Console.WriteLine();
                Console.WriteLine("Jusu taskai: {0}  Liko saldainiu: {1}" , taskai, saldainiai);
                Console.WriteLine();
                for (int i = 0; i < aukstis; i++)
                {
                    for (int j = 0; j < plotis; j++)
                    {
                        Console.Write(lentele[i, j]);              
                    }
                    Console.WriteLine();
                }
                ConsoleKeyInfo mygtukas = Console.ReadKey();
                //Console.Clear();

                if (mygtukas.Key.ToString() == "UpArrow")
                {
                    lentele[x, y] = "   ";
                    if (x - 1 == -1)
                    {
                        x = 15;
                        if (lentele[x, y] == " O ")
                        {
                            taskai++;
                            saldainiai--;
                        }
                    }
                    else
                    {
                        x--;
                        if (lentele[x, y] == " O ")
                        {
                            taskai++;
                            saldainiai--;
                        }
                    }
                }
                else if (mygtukas.Key.ToString() == "DownArrow")
                {
                    
                    lentele[x, y] = "   ";
                    if (x + 1 == aukstis)
                    {
                        x = 0;
                        if (lentele[x, y] == " O ")
                        {
                            taskai++;
                            saldainiai--;
                        }
                    }
                    else
                    {
                        x++;
                        if (lentele[x, y] == " O ")
                        {
                            taskai++;
                            saldainiai--;
                        }
                    }
                }
                else if (mygtukas.Key.ToString() == "LeftArrow")
                {   
                    lentele[x, y] = "   ";
                    if (y - 1 == -1)
                    {
                        y = 10;
                        if (lentele[x, y] == " O ")
                        {
                            taskai++;
                            saldainiai--;
                        }
                    }
                    else
                    {
                        y--;
                        if (lentele[x, y] == " O ")
                        {
                            taskai++;
                            saldainiai--;
                        }
                    }
                }
                else if (mygtukas.Key.ToString() == "RightArrow")
                {
                    lentele[x, y] = "   ";
                    if (y + 1 == plotis)
                    {
                        y = 0;
                        if (lentele[x, y] == " O ")
                        {
                            taskai++;
                            saldainiai--;
                        }
                    }
                    else
                    {
                        y++;
                        if (lentele[x, y] == " O ")
                        {
                            taskai++;
                            saldainiai--;
                        }
                    }
                }
                lentele[x, y] = " X ";
            }
        }
    }
}
