using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class User
    {
        private int choice;
        private int id;

        public User() { }

        public int Choice { get => choice; set => choice = value; }
        public int Id { get => id; set => id = value; }

        public void getUserChoice()
        {
            Choice = Convert.ToInt32(Console.ReadLine());
        }
    }
}
