using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Game
    {
        private char[] uAr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        private bool isOver = false;
        private bool isTie = false;

        public bool IsOver { get => isOver; set => isOver = value; }
        public bool IsTie { get => isTie; set => isTie = value; }

        public Game(User u)
        {
            Description();
            CreateGrid();
            u.whoseTurn();
            u.getUserChoice();
            changeArrayElement(u);
        }

        private void CreateGrid()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", uAr[1], uAr[2], uAr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", uAr[4], uAr[5], uAr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", uAr[7], uAr[8], uAr[9]);
            Console.WriteLine("     |     |      ");
        }


        private void changeArrayElement(User u)
        {
            if (u.Choice > 0 && u.Choice < 10)
            { 
                if (uAr[u.Choice] != 'X' && uAr[u.Choice] != 'O')
                {
                    
                    if (u.Id % 2 == 0)
                        uAr[u.Choice] = 'X';
                    else
                        uAr[u.Choice] = 'O';

                    u.Id++;
                    refreshDisplay(u);
                    u.getUserChoice();
                    checkIfWon(u);

                } else
                {
                    Console.WriteLine("Pole o nr {0} jest juz zajete znakiem {1}", u.Choice, uAr[u.Choice]);
                }

            }
            else throw new ArgumentOutOfRangeException("Zakres ID planszy to 1-9!");
        }

        private void Description()
        {
            Console.WriteLine("Kolko i krzyzyk \t Projekt na zaliczenie przedmiotu \t przygotowal: Grzegorz Nowak (11079)");
            Console.WriteLine();
            Console.WriteLine("Gracz 1: X \t Gracz 2: O");
        }

        private void refreshDisplay(User u)
        {
            Console.Clear();
            Description();
            CreateGrid();
            checkIfWon(u);
            u.whoseTurn();
            u.getUserChoice();
            changeArrayElement(u);

        }


        private void checkIfWon(User u)
        {
            if(uAr[1] == uAr[2] && uAr[2] == uAr[3]) //Pierwszy wiersz
            {
                IsOver = true;
                Console.Write("Wygral gracz {0}", u.Id % 2);
            }
            else if(uAr[4] == uAr[5] && uAr[5] == uAr[6]) //Drugi wiersz
            {
                IsOver = true;
                Console.Write("Wygral gracz {0}", u.Id % 2);
            }
            else if(uAr[7] == uAr[8] && uAr[8] == uAr[9]) //Trzeci wiersz
            {
                IsOver = true;
                Console.Write("Wygral gracz {0}", u.Id % 2);
            }
            else if(uAr[1] == uAr[4] && uAr[4] == uAr[7]) //Pierwsza kolumna
            {
                IsOver = true;
                Console.Write("Wygral gracz {0}", u.Id % 2);
            }
            else if(uAr[2] == uAr[5] && uAr[5] == uAr[8]) //Druga kolumna
            {
                IsOver = true;
                Console.Write("Wygral gracz {0}", u.Id % 2);
            }
            else if(uAr[3] == uAr[6] && uAr[6] == uAr[9]) //Trzecia kolumna
            {
                IsOver = true;
                Console.Write("Wygral gracz {0}", u.Id % 2);
            }
            else if(uAr[1] == uAr[5] && uAr[5] == uAr[9]) //Skos 1
            {
                IsOver = true;
                Console.Write("Wygral gracz {0}", u.Id % 2);
            }
            else if(uAr[3] == uAr[5] && uAr[5] == uAr[7]) //Skos 2
            {
                IsOver = true;
                Console.Write("Wygral gracz {0}", u.Id % 2);
            }

        }

    }

}
