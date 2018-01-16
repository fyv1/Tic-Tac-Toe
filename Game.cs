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

        public Game(User u) 
        {
            Description();
            CreateGrid(uAr);
            u.whoseTurn();
            u.getUserChoice();
            changeArrayElement(u);
        }

        private void CreateGrid(char[] uAr)
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
                if (u.Id % 2 == 0)
                     uAr[u.Choice] = 'X';
                else
                    uAr[u.Choice] = 'O';
                
                u.Id++;
                refreshDisplay(u);
                u.getUserChoice();

            }
            else Console.Write("Zakres ID planszy to 1-9!"); //throw new ArgumentOutOfRangeException("Zakres ID planszy to 1-9!");
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
            CreateGrid(uAr);
            u.whoseTurn();
            u.getUserChoice();
            changeArrayElement(u);
        }

    }

}
