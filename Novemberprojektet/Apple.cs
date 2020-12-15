using System;
using Raylib_cs;

namespace Novemberprojektet
{
    public class Apple: GameObject
    {
        public Apple(){
            this.rect.height = 30;
            this.rect.width = 30;
            this.rect.x = 50;
            this.rect.y = 50;
            gameObjects.Add(this);
        }
        public override void Update()
        {
            if(appleExist == false)
            {
                this.rect.x = generator.Next(30, 770);
                this.rect.y = generator.Next(30, 770);
            }
        }
        public override void Draw()
        {
            if (appleExist == true)
            {
                   
            }
            Raylib.DrawRectangleRec(rect, Color.GREEN);
        }

        
    }
}
