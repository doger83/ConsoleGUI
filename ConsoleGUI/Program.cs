using System;
using static System.Console;

namespace ConsoleGUI
{
    internal class Program
    {
        private static void Main()
        {
            Grid grid = new(10,10);
            //game.Start();
            grid.Initialize();
            grid.Draw();
            grid.DrawChessPattern();

            grid.InitializeWithBuffer();
            grid.DrawChessPatternWithBuffer();

            WriteLine("\n\nPress any key to exit ..");
            ReadKey(true);
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