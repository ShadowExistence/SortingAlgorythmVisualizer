using System;

namespace Algorithm_visualizer
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new Game1())
                game.Run();

        }
    }
}
