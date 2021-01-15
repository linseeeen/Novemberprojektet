using System;
using Raylib_cs;

namespace Novemberprojektet
{
    public class Text
    {
        public static bool readInstructions = false;

        public void Update() {
            if (Raylib.IsKeyDown(KeyboardKey.KEY_ENTER))
            {
                readInstructions = true;
            }
        }
        public static void Draw(){
            if (!readInstructions)
            {
                Raylib.DrawText("Spelet går ut på att samla så många poäng som möjligt", 100, 50, 20, Color.WHITE);
            }
        }
    }
}