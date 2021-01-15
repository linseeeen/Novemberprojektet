using System;
using Raylib_cs;

namespace Novemberprojektet
{
    public class Text
    {
        public static bool readInstructions = false;
        //Kollar om spelaren har tryckt enter för att stänga instruktionerna
        public void Update() {
            if (Raylib.IsKeyDown(KeyboardKey.KEY_ENTER))
            {
                readInstructions = true;
            }
        }
        //Ritar ut texten tills spelaren valt att stänga instruktionerna
        public static void Draw(){
            if (!readInstructions)
            {
                Raylib.DrawText("Spelet går ut på att samla så många poäng som möjligt", 100, 50, 20, Color.BLACK);
                Raylib.DrawText("Kontroller: Upp = W, Ner = S, Höger = D, Vänster = A", 100, 80, 20, Color.BLACK);
                Raylib.DrawText("Tryck enter för att stänga instruktioenr", 100, 110, 20, Color.BLACK);
            }
        }
    }
}