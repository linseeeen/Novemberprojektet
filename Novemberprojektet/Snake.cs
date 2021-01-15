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