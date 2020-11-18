using System.ComponentModel;
using System;
using Raylib_cs;

namespace Novemberprojektet
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Raylib.InitWindow(800, 800, "My awesome game");
            Raylib.SetTargetFPS(60);
            

            Snake s1 = new Snake(100, 100, KeyboardKey.KEY_W, KeyboardKey.KEY_S, KeyboardKey.KEY_D, KeyboardKey.KEY_A);
            while(!Raylib.WindowShouldClose())
            {
                Snake.UpdateAll();
                Raylib.BeginDrawing();
                s1.Draw();
                
                Raylib.ClearBackground(Color.YELLOW);

                Raylib.EndDrawing();
            }
        }
    }
}
