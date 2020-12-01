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
        private int speed = 3;

        public Snake(float x, float y, KeyboardKey upKey, KeyboardKey downKey, KeyboardKey rightKey, KeyboardKey leftKey)
        {
            gameObjects.Add(this);
            this.body.height = 50;
            this.body.width = 50;
            this.body.x = x;
            this.body.y = y;

            this.upKey = upKey;
            this.downKey = downKey;
            this.leftKey = leftKey;
            this.rightKey = rightKey; 
        }
        public override void Update()
        {
            if (Raylib.IsKeyDown(upKey))
            {
                this.body.y -= speed;
            }
            else if (Raylib.IsKeyDown(downKey))
            {
                this.body.y += speed;
            }
            else if (Raylib.IsKeyDown(leftKey))
            {
                this.body.x -= speed;
            }
            else if (Raylib.IsKeyDown(rightKey))
            {
                this.body.x += speed;
            }
        }
    }
}