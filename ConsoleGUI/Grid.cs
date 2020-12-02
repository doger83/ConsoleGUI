using System;
using static System.Console;

namespace ConsoleGUI
{
    internal class Grid
    {
        private int rows;
        private int cols;
        private string[,] grid ;

        public Grid(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            this.grid = new string[rows, cols];
        }

        public void Draw()
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

        public void DrawChessPattern()
        {
            for (int row = 0; row < grid.GetLength(0); row++)
            {
                for (int col = 0; col < grid.GetLength(1); col++)
                {
                    if (col % 2 == 0 && row % 2 != 0 ||
                        col % 2 != 0 && row % 2 == 0)
                    {
                        BackgroundColor = ConsoleColor.Green;
                        Write(grid[row, col]);
                    }
                    else
                    {
                        BackgroundColor = ConsoleColor.White;
                        Write(grid[row, col]);
                    }
                }
                WriteLine();
            }
            ResetColor();
        }

        public void DrawChessPatternWithBuffer()
        {
            for (int row = 0; row < grid.GetLength(0); row++)
            {
                for (int col = 0; col < grid.GetLength(1); col++)
                {
                    if (row == 0 ||
                        row == grid.GetLength(1) - 1 ||
                        col == 0 ||
                        col == grid.GetLength(0) - 1)
                    {
                        BackgroundColor = ConsoleColor.Red;
                        Write(grid[row, col]);
                    }
                    else if (col % 2 == 0 && row % 2 != 0 ||
                             col % 2 != 0 && row % 2 == 0)
                    {
                        BackgroundColor = ConsoleColor.Green;
                        Write(grid[row, col]);
                    }
                    else
                    {
                        BackgroundColor = ConsoleColor.White;
                        Write(grid[row, col]);
                    }
                }
                WriteLine();
            }
            ResetColor();
        }

        /// <summary>
        /// Inizializes the <paramref name="grid"/> with the given <paramref name="rows"/> and <paramref name="cols"/>
        /// </summary>
        public void Initialize()
        {
            int counter = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
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

        /// <summary>
        /// Inizializes the <paramref name="grid"/> with the given <paramref name="rows"/> and <paramref name="cols"/> with one field around as a buffer
        /// </summary>
        public void InitializeWithBuffer()
        {

            this.rows += 2;
            this.cols += 2;

            grid = new string[rows, cols];
            int counter = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (row == 0 ||
                        row == grid.GetLength(1) - 1 ||
                        col == 0 ||
                        col == grid.GetLength(0) - 1)
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