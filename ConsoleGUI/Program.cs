using System;
using System.Text;
using Pastel;
using Figgle;

namespace ConsoleGUI
{
    internal class Program
    {
        private static void Main()
        {
            //Grid grid = new(10,10);
            ////game.Start();
            //grid.Initialize();
            //grid.Draw();
            //grid.DrawChessPattern();
            //Console.CursorVisible = false;
            // Console.CursorSize = 6;

            //Console.BackgroundColor = ConsoleColor.Gray;
            //Console.ForegroundColor = ConsoleColor.Blue;
            // Console.SetWindowSize(Console.LargestWindowWidth - 5, Console.LargestWindowHeight - 5);
            Console.SetBufferSize(Console.WindowWidth, Console.WindowHeight+1);

            bool isCorner(int row, int col)
            {
                return row == 0 && col == 0
                    || row == 0 && col == Console.WindowWidth - 1
                    || row == Console.WindowHeight - 5 && col == 0
                    || row == Console.WindowHeight - 5 && col == Console.WindowWidth - 1;
            }

            bool isEdge_LeftRight(int row, int col)
            {
                return col == 0
                    || col == Console.WindowWidth - 1;
            }

            bool isEdge_TopBottom(int row, int col)
            {
                return row == 0
                    || row == Console.WindowHeight - 5;
            }

            for (int rows = 0; rows < Console.WindowHeight - 4; rows++)
            {
                for (int cols = 0; cols < Console.WindowWidth; cols++)
                {
                    if (isCorner(rows, cols))
                    {
                        //Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.Write("╬".Pastel("#ff6b6b").PastelBg("#c6a0e8"));
                    }
                    else if (isEdge_LeftRight(rows, cols))
                    {
                        //Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.Write("║".Pastel("#ff6b6b").PastelBg("#c6a0e8"));
                    }
                    else if (isEdge_TopBottom(rows, cols))
                    {
                        //Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.Write("═".Pastel("#ff6b6b").PastelBg("#c6a0e8"));
                    }
                    else
                    {
                        //Console.BackgroundColor = ConsoleColor.Blue;
                        Console.Write(" ".Pastel("#ff6b6b").PastelBg("#c6a0e8"));

                    }
                }
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.Write("\n");
                //Console.WriteLine();
            }

            //grid.InitializeWithBuffer();
            //grid.DrawChessPatternWithBuffer();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Green;
            string figgle = FiggleFonts.Contessa.Render("press any Key to exit");
            StringBuilder strBuilder = new StringBuilder();
            foreach (char item in figgle)
            {
                strBuilder.Append(item);
            }
            int last = figgle.Length-1;
            strBuilder.Remove(last, 1);
            Console.Write(strBuilder.ToString());
            Console.SetCursorPosition(1, 1);
            Console.ReadKey(true);
        }

        //private void Start()
        //{
        //    WriteLine("Game is starting..");

        //    initialize(ref rows, ref cols, ref grid);
        //    Draw(grid);
        //    DrawChessPattern(grid);

        //    initialize(ref rows, ref cols, ref grid, true);

        //    DrawChessPatternWithBuffer(grid);


        //}
    }
}