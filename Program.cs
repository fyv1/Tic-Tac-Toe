using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {            
            User u = new User();
            Game g = new Game(u);

           // g.CreateGrid(g);

            Console.ReadKey();
        }
    }
}
