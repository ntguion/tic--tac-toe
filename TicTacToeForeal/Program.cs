using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TicTacToeForeal
{
    class Program
    {
        static void Main(string[] args)
        {
            while (1 == 1)
            {
                // Intro to the Game [Y continues, N Terminates Program]
                Joshua joshua = new Joshua();
                joshua.Greeting();

                string ans = Console.ReadLine();

                if (ans == "Y" || ans == "y")
                {
                    joshua.Begin();
                    Console.Clear();
                }
                else
                {
                    joshua.Goodbye();
                }


                // Begin the Game
                GamePlay gameplay = new GamePlay();
                gameplay.GameTime();






            Console.ReadLine();
            }


            
        }
    }
}
