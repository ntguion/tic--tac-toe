using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeForeal
{
    class Turn
    {
        private int turn = 0;



        // Choose Who Goes First
        public int ChooseTurn()
        {
            Random random = new Random();
            turn = random.Next(2);
            //Console.WriteLine(turn);
            return turn;

        }


        public int NextTurn()
        {
            if (turn == 1)
            { 
                turn = 0; // Computer's Turn
            }
            else
            { 
                turn = 1; // Players Turn
            }
            return turn;
        }
    }
}
