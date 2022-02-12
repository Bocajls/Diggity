using System;

namespace Diggity
{
    public static class Program
    {
        private static readonly string _version = "V0.01";

        [STAThread]
        static void Main()
        {
            using (var game = new Game())
            {
                game.Run();
            }
        }
    }
}