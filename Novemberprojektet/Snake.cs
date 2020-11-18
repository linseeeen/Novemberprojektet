using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System;
using Raylib_cs;

namespace Novemberprojektet
{
    public class Snake
    {
        public static List<Snake> snakes = new List<Snake>();

        public Rectangle body = new Rectangle();
        public KeyboardKey upKey;
        public KeyboardKey downKey;
        public KeyboardKey rightKey;
        public KeyboardKey leftKey;

        public Snake(float x, float y, KeyboardKey upKey, KeyboardKey downKey, KeyboardKey rightKey, KeyboardKey leftKey){

            this.body.height = 50;
            this.body.width = 50;
            this.body.x = x;
            this.body.y = y;

            this.upKey = upKey;
            this.downKey = downKey;
            this.leftKey = leftKey;
            this.rightKey = rightKey;

            snakes.Add(this);
        }
        public void MoveSnake()
        {
            if (Raylib.IsKeyDown(upKey))
            {
                this.body.y -= 3;
            }
            else if (Raylib.IsKeyDown(downKey))
            {
                this.body.y += 3;
            }
            else if (Raylib.IsKeyDown(leftKey))
            {
                this.body.x -= 3;
            }
            else if (Raylib.IsKeyDown(rightKey))
            {
                this.body.x += 3;
            }
        }
        public void Draw(){
            Raylib.DrawRectangleRec(body, Color.RED);
        }
        public static void UpdateAll(){
            foreach (Snake s in snakes)
            {
                s.MoveSnake();
            }
        }
    }
}
