using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeForeal
{
    class GamePlay
    {
        private int turn = 0;
        private int turncount = 1;
        public string playspacestring;
        public int playspace = 0;
        public int win = 0;
        private int movingon;
        public int[] GameBoard = new int[9];

        public void GameTime()
        {
            // Sets a new board
            Board board = new Board();
            board.ResetBoard(GameBoard);

            // Joshua
            Joshua joshua = new Joshua();
            

            // Chooses 1st player
            Turn playerturn = new Turn();
            turn = playerturn.ChooseTurn();

            while (win == 0)
            {
                if (turn == 1 && turncount < 10)
                {
                    //Player's Turn
                    if (turncount == 1)
                    { // Joshua Taunts opener
                        joshua.LadiesFirst();
                    }
                    else //Regular Taunt
                    {
                        joshua.Taunt1();
                    }
                    //Get PlaySpace
                    movingon = 0;
                    while (movingon == 0)
                    {
                        playspacestring = Console.ReadLine();

                        playspace = Convert.ToInt32(playspacestring);
                        if (playspace > -1 && playspace < 9)
                            {


                            if (board.CheckIfEmpty(playspace,GameBoard) == 1)
                            {
                                board.FillPlayerSpace(playspace,GameBoard);
                                board.DisplayBoard(GameBoard);
                                movingon = 1;
                            }
                            else
                            {
                                joshua.AlreadyTaken();
                            }
                        }
                        else {
                            joshua.InvalidSpace();
                        }
                    }
                    turn = playerturn.NextTurn();
                    turncount = turncount + 1;
                    

                    win = board.checkwin(GameBoard);
                    
                    
                    //Console.WriteLine("winstatus = " + win);
                }

                else {
                    if (turn == 0 && turncount < 10)
                    {
                        // Computer's Turn

                        joshua.IGoFirst();

                        // Choose a place to play
                        movingon = 0;
                        while (movingon == 0)
                        {
                            PlayMaker playmaker = new PlayMaker();
                            playmaker.AI(GameBoard,GameBoard,1);
                            playspace = playmaker.returnchoice();
                            if (board.CheckIfEmpty(playspace,GameBoard) == 1)
                            {
                                //Console.WriteLine(playspace);
                                board.FillComputerSpace(playspace,GameBoard);
                                board.DisplayBoard(GameBoard);
                                movingon = 1;
                            }

                        }
                        // Next turn
                        turn = playerturn.NextTurn();
                        turncount = turncount + 1;

                        // Check for a win
                        win = board.checkwin(GameBoard);


                        //Console.WriteLine("winstatus = " + win);

                    }
                }

            }

            if (win == 1)
            {
                joshua.yougotme();
            }
            else
            {
                joshua.iwin();
            }





        }








     
        




    }
}
