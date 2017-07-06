using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeForeal
{
    class Joshua
    {
        public void Greeting()
        {
            Console.WriteLine("Shall we play a game?");
            Console.WriteLine("Y/N");
        }
        public void Taunt1()
        {
            Console.WriteLine("I thought you were better than this...");
        }
        public void Taunt2()
        {
            Console.WriteLine("Give me a break!");
        }
        public void Taunt3()
        {
            Console.WriteLine("Is that all you've got???");
        }
        public void Taunt4()
        {
            Console.WriteLine("Victory is MINE!!!");
        }
        public void Begin()
        {
            Console.WriteLine("Let the games begin!");
        }
        public void IGoFirst()
        {
            Console.WriteLine("My Turn!");
        }
        public void LadiesFirst()
        {
            Console.WriteLine("Ladies First:)  Pick a space to play [0-8]");
        }
        public void AlreadyTaken()
        {
            Console.WriteLine("This Spot is already taken, try again!");
        }
        public void InvalidSpace()
        {
            Console.WriteLine("Invalid Space! Try Again...");
        }
        public void iwin()
        {
            Console.WriteLine("I Am The CHAMPION!!!!!!");
            Console.WriteLine("Better luck next time:)");
        }
        public void yougotme()
        {
            Console.WriteLine("Never Again! :(");
        }
        public void Goodbye()
        {
            Console.WriteLine("Alright then, Goodbye");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Terminating in 3");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Terminating in 2");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Terminating in 1");
            System.Threading.Thread.Sleep(1000);
            Environment.Exit(0);

        }
    }
}
