﻿using System;

namespace Diggidy
{
    public static class Program
    {
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
