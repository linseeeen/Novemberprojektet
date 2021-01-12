using System;
using Raylib_cs;

namespace Novemberprojektet
{
    public class Apple: GameObject
    {
        public Apple(){
            gameObjects.Add(this);
            this.rect.height = 30;
            this.rect.width = 30;
            this.rect.x = generator.Next(30 * speed, 770 * speed) / speed;
            this.rect.y = generator.Next(30 * speed, 770 * speed) / speed;
            
        }
        public override void Update()
        {
            if(appleExist == false)
            {
                this.rect.x = generator.Next(30 * speed, 770 * speed) / speed;
                this.rect.y = generator.Next(30 * speed, 770 * speed) / speed;
            }
        }
        public override void Draw()
        {
            if (appleExist == true)
            {
                Raylib.DrawRectangleRec(rect, Color.GREEN);
            }
            
        }

        
    }
}
