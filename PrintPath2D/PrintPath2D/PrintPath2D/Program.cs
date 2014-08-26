using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintPath2D
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] board = new int[,]
            {
                {0, 0, 0, 1},
                {1, 1, 0, 1},
                {1, 1, 0, 1},
                {1, 1, 0, 1},
                {0, 0, 0, 1},
                {0, 1, 1, 1},
                {0, 0, 0, 0},
                {1, 1, 1, 0},
            };
            int row = 8;
            int col = 4;
            PrintPath(board, row, col, 0, 2);
            Console.ReadLine();

        }
        static void PrintPath(int[,] array, int row, int col, int currRow, int currCol)
        {
            if (array != null && array[currRow, currCol] == 0)
            {
                Console.WriteLine("[{0},{1}]", currRow, currCol);
                array[currRow, currCol] = 2;
                if (currCol + 1 < col)
                    PrintPath(array, row, col, currRow, currCol + 1);
                if (currRow - 1 >= 0)
                    PrintPath(array, row, col, currRow - 1, currCol);
                if (currCol - 1 >= 0)
                    PrintPath(array, row, col, currRow, currCol - 1);
                if (currRow + 1 < row)
                    PrintPath(array, row, col, currRow + 1, currCol);

            }
        }
    }
}
