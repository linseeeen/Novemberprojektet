using System.ComponentModel;
using System;
using Raylib_cs;

namespace Novemberprojektet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapar mitt fönster där själva spelet visas, sätter även fps
            Raylib.InitWindow(800, 800, "Snake");
            Raylib.SetTargetFPS(60);
            
            /*Skapar mina objekt, detta gör att de faktiskt exsiterar så att spelaren kan se de i mitt spel och
            inte bara existerar i koden. Informationen om vad snake och äpple faktiskt ska göra hämtas sen från respektive klass.
            */
            Snake s1 = new Snake(100, 200, KeyboardKey.KEY_W, KeyboardKey.KEY_S, KeyboardKey.KEY_D, KeyboardKey.KEY_A);
            Apple a1 = new Apple();
            Text t1 = new Text();
            //programmet körs så länge man inte tryckt på x-et som stänger rutan
            while(!Raylib.WindowShouldClose())
            {
                /*Jag har en huvud klass med arv som kallas för GameObject, här samlas alla gameobjects som finns i spelet,
                I denna del av koden så uppdateras spellogiken, med andra ord kollar den t.ex om spelaren trycker på någon knapp
                */
                GameObject.UpdateAll();
                t1.Update();
                //Här ritas grafiken ut. Den kollar på vad som ska ritas ut i denna frame och ritar ut det på skrämen
                Raylib.BeginDrawing();
                GameObject.DrawAll();
                Text.Draw();
                //Gör så att inte alla frames stannar kvar på skärmen, den rensar alltså så att nästa draw ska rita å ett "tomt canvas"
                Raylib.ClearBackground(Color.YELLOW);

                Raylib.EndDrawing();
            }
        }
    }
}
