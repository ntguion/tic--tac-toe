using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeForeal
{
    class Com
    {

        public int move;
        public int ComPlayspace()
        {
            Random random = new Random();
            move = random.Next(9);
            return move;
        }


    }
}
