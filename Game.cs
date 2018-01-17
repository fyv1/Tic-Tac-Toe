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

        public bool IsOver { get => isOver;  set => isOver = value; }

        public Game(User u)
        {
            Description();
            CreateGrid();
            whoseTurn(u);
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

            if (isOver != true)
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
                        if (!IsOver) u.getUserChoice();
                        checkIfWon(u);

                    }
                    else
                    {
                        Console.WriteLine("Pole o nr {0} jest juz zajete znakiem {1}", u.Choice, uAr[u.Choice]);
                        refreshDisplay(u);
                        if (!IsOver) u.getUserChoice();
                        checkIfWon(u);
                    }

                }
                else throw new ArgumentOutOfRangeException("Zakres ID planszy to 1-9!");
            }
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
            whoseTurn(u);
            if(!IsOver) u.getUserChoice();
            changeArrayElement(u);

        }

        private void whoseTurn(User u)
        {
            if (!IsOver)
            {
                if (u.Id % 2 == 0) Console.Write("Kolej gracza 1: ");
                else Console.Write("Kolej gracza 2: ");
            }
            else Console.ReadKey();
        }

        private void checkIfWon(User u)
        {
            int winnerId = u.Id % 2;

            if (winnerId == 0) winnerId = 2;

            if(uAr[1] == uAr[2] && uAr[2] == uAr[3] || //Pierwszy wiersz
               uAr[4] == uAr[5] && uAr[5] == uAr[6] || //Drugi wiersz
               uAr[7] == uAr[8] && uAr[8] == uAr[9] || //Trzeci wiersz
               uAr[1] == uAr[4] && uAr[4] == uAr[7] || //Pierwsza kolumna
               uAr[2] == uAr[5] && uAr[5] == uAr[8] || //Druga kolumna
               uAr[3] == uAr[6] && uAr[6] == uAr[9]  ) //Trzecia kolumna
            {
                IsOver = true;
                Console.Write("Wygral gracz {0}", winnerId);
            }
            else if (uAr[1] != '1' && uAr[2] != '2' && uAr[3] != '3' && uAr[4] != '4' && uAr[5] != '5' && uAr[6] != '6' && uAr[7] != '7' && uAr[8] != '8' && uAr[9] != '9') ) //Remis
            {
                IsOver = true;
                Console.Write("Remis!");
            }

        }

    }

}
