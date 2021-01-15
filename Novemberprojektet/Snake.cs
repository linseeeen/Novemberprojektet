using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System;
using Raylib_cs;

namespace Novemberprojektet
{
    public class Snake: GameObject
    {
        public KeyboardKey upKey;
        public KeyboardKey downKey;
        public KeyboardKey rightKey;
        public KeyboardKey leftKey;

        /*Snakes konstruktor, den tar både in information samt skickar iväg. Den tar in värden för x och y samt
        vilka knappar som ska användas. Den definerar också storleken på "snake" och lägger till den i lsitan för gameobjects
        */
        public Snake(float x, float y, KeyboardKey upKey, KeyboardKey downKey, KeyboardKey rightKey, KeyboardKey leftKey)
        {
            gameObjects.Add(this);
            this.rect.height = 50;
            this.rect.width = 50;
            this.rect.x = x;
            this.rect.y = y;

            this.upKey = upKey;
            this.downKey = downKey;
            this.leftKey = leftKey;
            this.rightKey = rightKey; 
        }
        /*Update kollar om någon knapp är nedtryckt och beroende på vilken så ändrar den riktning, detta genom att ändra om
        speed är ett positivt eller negativt värde. Upp ändrar speed till ett negativt värde så att den förflyttar sig uppåt
        på skärmen, vilket blir en lägre siffra på kordinatsystemet.
        */
        public override void Update()
        {
            if (Raylib.IsKeyDown(upKey))
            {
                this.rect.y -= speed;
            }
            else if (Raylib.IsKeyDown(downKey))
            {
                this.rect.y += speed;
            }
            else if (Raylib.IsKeyDown(leftKey))
            {
                this.rect.x -= speed;
            }
            else if (Raylib.IsKeyDown(rightKey))
            {
                this.rect.x += speed;
            }
            
        }
    }
}