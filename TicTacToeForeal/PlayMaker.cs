using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeForeal
{
    class PlayMaker
    {

        Board board = new Board();

        int choice = 0;

        public int AI(int[] NewGameboard, int[] GameBoard, int Playerturn)
        {
            // intitiate scores and moves lists
            List<int> scores = new List<int>();
            List<int> moves = new List<int>();

            // Change to Com Playerturn (0) // scoring is inverted to help order(human = 0 com =  1)
            Playerturn = Nextturn(Playerturn);

            // check to see if the gameboard is full or if there is a win
            if (Scoringfunction(NewGameboard, Playerturn) != 0)
                return Scoringfunction(NewGameboard, Playerturn);

            // if the gameboard is full or there is a win then return the specified win value depending on player turn

            else if (board.FreeSpaces(NewGameboard).Sum() == 0)
                return 0;
            // else plug in an x to every spot on the board and recall function then add the move(i) to a list
            else
            {
                for (int i = 0; i < 9; i++)
                {
                    if (NewGameboard[i] == 0)
                    {
                        PlayPiece(NewGameboard, Playerturn, i);
                        board.DisplayBoard(NewGameboard);
                        Console.ReadLine();

                        scores.Add(AI(NewGameboard, GameBoard, Playerturn));
                        moves.Add(i);
                    }

                }

            }
            // next return the max value of the list of optional move back up the tree if turn is 0

            if (Playerturn == 0) // human player take min
            {
                int MinScoreIndex = scores.IndexOf(scores.Min());
                choice = moves[MinScoreIndex];
                return scores.Min();
            }
            // or return the min of the array if the trun is 1
            else // Com turn take max
            {
                int MaxScoreIndex = scores.IndexOf(scores.Max());
                choice = moves[MaxScoreIndex];
                return scores.Max();
            }

        }

        public int returnchoice()
        {
            return choice;
        }

        public int Nextturn(int Playerturn)
        {
            Console.WriteLine("Changing Turn");
            //Console.ReadLine();
            if (Playerturn == 1)
            {
                return 0; // computer turn
            }

            else // computer turn is 0
            {
                return 1;
            }
        }

        public int Scoringfunction(int[] NewGameboard, int Playerturn)
        {
            //Console.WriteLine("Checking for winner");
            //Console.ReadLine();
            int winner = board.checkwin(NewGameboard); // check for winner

            if (Playerturn == 1)
            {
                if (winner == 1)
                {
                    Console.WriteLine("-10p0");
                    //Console.ReadLine();
                    board.DisplayBoard(NewGameboard);
                    return -10;
                }
                else if (winner == 2)
                {
                    Console.WriteLine("10p0");
                    //Console.ReadLine();
                    board.DisplayBoard(NewGameboard);
                    return 10;
                }
                else
                {
                    return 0;
                }

            }

            else if (Playerturn == 0)

            {
                if (winner == 1)
                {
                    Console.WriteLine("-10p1");
                    //Console.ReadLine();
                    board.DisplayBoard(NewGameboard);
                    return 10;

                }
                else if (winner == 2)
                {
                    Console.WriteLine("10p1");
                    //Console.ReadLine();
                    board.DisplayBoard(NewGameboard);
                    return -10;
                }
                else
                {
                    return 0;
                }


            }
            else
            {
                return 0;
            }
        }

        public int[] PlayPiece(int[] NewGameboard, int Playerturn, int i)
        {

            if (Playerturn == 0)
            {
                Console.WriteLine("Filling Com space");
                //Console.ReadLine();
                NewGameboard[i] = 4;

            }
            else
            {
                Console.WriteLine("Filling playerspace");
                //Console.ReadLine();
                NewGameboard[i] = 1;
            }
            return NewGameboard;
        }
    }
}
