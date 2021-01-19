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
                Raylib.DrawText("Spelet går ut på att samla så många poäng som möjligt (om det va klart)", 50, 50, 20, Color.BLACK);
                Raylib.DrawText("Kontroller: Upp = W, Ner = S, Höger = D, Vänster = A", 50, 80, 20, Color.BLACK);
                Raylib.DrawText("Tryck enter för att stänga instruktioenr", 50, 110, 20, Color.BLACK);
            }
        }
    }
}