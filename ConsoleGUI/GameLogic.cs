using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ConsoleGUI
{
    class GameLogic
    {
        static readonly int rows = 12;
        static readonly int cols = 12;
        private string[,] grid = new string[rows, cols];

        //private string[,] grid = {
        //    { "1", "2", "3" },
        //    { "4", "5", "6"},
        //    { "7", "8", "9"}
        //};

        public void Start()
        {
            WriteLine("Game is starting..");

            InitGrid(rows, cols, grid);

            DrawGridChessPattern(grid);
            DrawGrid(grid);

            WriteLine("\n\nPress any key to exit ..");
            ReadKey(true);
        }

        private void DrawGrid(string[,] grid)
        {
            for (int row = 0; row < grid.GetLength(0); row++)
            {
                for (int col = 0; col < grid.GetLength(1); col++)
                {
                    Write(grid[row, col]);
                }
                WriteLine();
            }
        }

        private static void DrawGridChessPattern(string[,] grid)
        {
            for (int row = 0; row < grid.GetLength(0); row++)
            {
                for (int col = 0; col < grid.GetLength(1); col++)
                {
                    if (col % 2 == 0 && row % 2 != 0)
                    {
                        if (row == 0 || row == grid.GetLength(1) - 1 || col == 0 || col == grid.GetLength(0) - 1)
                        {
                            BackgroundColor = ConsoleColor.Red;
                            Write(grid[row, col]);
                        }
                        else
                        {
                            BackgroundColor = ConsoleColor.Green;
                            Write(grid[row, col]);
                        }

                    }
                    else if (col % 2 == 0 && row % 2 == 0)
                    {
                        if (row == 0 || row == grid.GetLength(1) - 1 || col == 0 || col == grid.GetLength(0) - 1)
                        {
                            BackgroundColor = ConsoleColor.Red;
                            Write(grid[row, col]);
                        }
                        else
                        {
                            BackgroundColor = ConsoleColor.White;
                            Write(grid[row, col]);
                        }
                    }
                    else if (col % 2 != 0 && row % 2 == 0)
                    {
                        if (row == 0 || row == grid.GetLength(1) - 1 || col == 0 || col == grid.GetLength(0) - 1)
                        {
                            BackgroundColor = ConsoleColor.Red;
                            Write(grid[row, col]);
                        }
                        else
                        {
                            BackgroundColor = ConsoleColor.Green;
                            Write(grid[row, col]);
                        }
                    }
                    else
                    {
                        if (row == 0 || row == grid.GetLength(1) - 1 || col == 0 || col == grid.GetLength(0) - 1)
                        {
                            BackgroundColor = ConsoleColor.Red;
                            Write(grid[row, col]);
                        }
                        else
                        {
                            BackgroundColor = ConsoleColor.White;
                            Write(grid[row, col]);
                        }
                    }
                }
                WriteLine();
            }
            ResetColor();
        }

        private static void InitGrid(int rows, int cols, string[,] grid)
        {
            int counter = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (row == 0 || row == grid.GetLength(1) - 1 || col == 0 || col == grid.GetLength(0) - 1)
                    {
                        grid[row, col] = "0 ";
                        continue;
                    }

                    if (counter > 9)
                    {
                        grid[row, col] = counter++.ToString();
                    }
                    else
                    {
                        grid[row, col] = counter++ + " ";
                    }

                }
            }
        }
    }
}
