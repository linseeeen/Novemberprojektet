using System.ComponentModel;
using System;
using Raylib_cs;

namespace Novemberprojektet
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Raylib.InitWindow(800, 800, "Snake");
            Raylib.SetTargetFPS(60);
            

            Snake s1 = new Snake(100, 100, KeyboardKey.KEY_W, KeyboardKey.KEY_S, KeyboardKey.KEY_D, KeyboardKey.KEY_A);
            Apple a1 = new Apple();
            while(!Raylib.WindowShouldClose())
            {
                GameObject.UpdateAll();
                Raylib.BeginDrawing();
                s1.Draw();
                a1.Draw();
                
                Raylib.ClearBackground(Color.YELLOW);

                Raylib.EndDrawing();
            }
        }
    }
}
