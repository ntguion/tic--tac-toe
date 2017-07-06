using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeForeal
{
    public class Board
    {

        
        public List<int> score = new List<int>();

        public int[] RowSum = new int[3];
        public int[] ColSum = new int[3];
        


        public int[] SetGameBoard(int[] GameBoard)
            {
                for (int i = 0; i < 9; i++)
                {
                    GameBoard[i] = 0;
                }

                return GameBoard;
            }


       public void DisplayBoard(int[] GameBoard)
       {
           for (int i = 0; i < 9; i = i + 3)
                {
                    Console.WriteLine("[{0}] [{1}] [{2}]", GameBoard[i], GameBoard[i + 1], GameBoard[i + 2]);
                }
       }

        public int[] ResetBoard(int[] GameBoard)
        {
            for (int i = 0; i < 9; i = i + 4)
            {
                GameBoard[i] = 0;

            }
            return GameBoard;
        }

        public int[] SumRows(int[] GameBoard)
        {
            for (int i = 0; i < 9; i = i + 3)
            {
                
                RowSum[i / 3] = GameBoard[i] + GameBoard[i + 1] + GameBoard[i + 2];
            }
            //Console.WriteLine(RowSum[0]);
            //Console.WriteLine(RowSum[1]);
            //Console.WriteLine(RowSum[2]);
            return RowSum;
        }
        
        public int[] SumCols(int[] GameBoard)
        {
            for (int i = 0; i < 3; i++)
            {
                ColSum[i] = GameBoard[i] + GameBoard[i + 3] + GameBoard[i + 6];
            }
            //Console.WriteLine(ColSum[0]);
            //Console.WriteLine(ColSum[1]);
            //Console.WriteLine(ColSum[2]);
            return ColSum;
        }
        
        public int SumRD(int[] GameBoard)
        {
            int RDSum = GameBoard[2] + GameBoard[4] + GameBoard[6];
            //Console.WriteLine(RDSum[0]);
            return RDSum;
        }
        
        public int SumLD(int[] GameBoard)
        {
            int LDSum = GameBoard[0] + GameBoard[4] + GameBoard[8];
            //Console.WriteLine(LDSum[0]);
            return LDSum;
        }

        public int CheckIfEmpty(int playspace, int[] GameBoard)
        {
            Console.WriteLine("Checking if Empty");
            Console.WriteLine(playspace.ToString());
            //Console.ReadLine();
            if (GameBoard[playspace] == 0)
            {
               return 1;
            }
            else
            {
               return 0;
            }

        }
        public int[] FillPlayerSpace(int playspace, int[] GameBoard)
        {
            GameBoard[playspace] = 1;
            return GameBoard;
        }
        public int[] FillComputerSpace(int playspace, int[] GameBoard)
        {
            GameBoard[playspace] = 4;
            return GameBoard;
        }





        public int win;

        public int checkwin(int[] GameBoard)
        {
            int[] RowSums = SumRows(GameBoard);
            int[] ColSums = SumCols(GameBoard);
            int RDiagSum = SumRD(GameBoard);
            int LDiagSum = SumLD(GameBoard);


            if (RowSums[0] == 3 || RowSum[1] == 3 || RowSum[2] == 3)
            {
                return win = 1;
            }
            if (ColSums[0] == 3 || ColSum[1] == 3 || ColSum[2] == 3)
            {
                return win = 1;
            }
            if (LDiagSum == 3)
            {
                return win = 1;
            }
            if (RDiagSum == 3)
            {
                return win = 1;
            }
            if (RowSum[0] == 12 || RowSum[1] == 12 || RowSum[2] == 12)
            {
                return win = 2;
            }
            if (ColSum[0] == 12 || ColSum[1] == 12 || ColSum[2] == 12)
            {
                return win = 2;
            }
            if (LDiagSum == 12)
            {
                return win = 2;
            }
            if (RDiagSum == 12)
            {
                return win = 2;
            }
            else
            {
               // DisplayBoard();

                return win = 0;

            }
        }

        
        public List<int> FreeSpaces(int[] GameBoard)
        {
             List<int> emptyspaces = new List<int>();

            for (int i = 0; i < 9; i++)
            {
                if (GameBoard[i] == 0)
                {
                    emptyspaces.Add(i);
                }
            }
           
            return emptyspaces;
        }










    }
    
}
