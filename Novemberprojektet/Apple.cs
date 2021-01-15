using System;
using Raylib_cs;

namespace Novemberprojektet
{
    public class Apple: GameObject
    {
        /* Appleklassens konstruktor, gemensamt för alla "apple" objekt. Här deffineras äpplets storlek, xoch y position slumpas fram
        basert på hur stor de är, planen var att den skulle slumpas fram synkat med hur ormen rör sig men blev ej som tänkt.
        Konstruktorn lägger också till äpplet i listan för alla gameobjects.
        */
        public Apple(){
            gameObjects.Add(this);
            this.rect.height = 30;
            this.rect.width = 30;
            this.rect.x = generator.Next(30 * speed, 770 * speed) / speed;
            this.rect.y = generator.Next(30 * speed, 770 * speed) / speed;
            
        }
        /*Kollar om det finns något äpple just nu, om det inte gör det kommer ett nytt att slumpas fram på en ny plats.
        */
        public override void Update()
        {
            if(appleExist == false)
            {
                this.rect.x = generator.Next(30 * speed, 770 * speed) / speed;
                this.rect.y = generator.Next(30 * speed, 770 * speed) / speed;
            }
        }
        /*Här ritas äpplet ut om det existerar, det ritas ut som en grön rektangel baserat på storleken vi angav i konstruktorn.
        */
        public override void Draw()
        {
            if (appleExist == true)
            {
                Raylib.DrawRectangleRec(rect, Color.GREEN);
            }
            
        }

        
    }
}
