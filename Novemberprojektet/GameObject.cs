using System.Collections.Generic;
using System;
using Raylib_cs;

namespace Novemberprojektet
{
    public class GameObject
    {
        /* Här skapas ett rektangelobejekt, detta används sen både för att skapa snake samt äpple
        */
        public Rectangle rect = new Rectangle();
        //En lista där alla mina gameobjects samlas
        public static List<GameObject> gameObjects = new List<GameObject>();
        //Sumpgenerator, en gemensam eftersom att det annars kan bli problem med slump om alla siffror slumpas samtidigt.
        public Random generator = new Random();
        /*Gemensam variabel för speed, kan anvndas t.ex om jag vill ändra hastigheten på ormen under spelets gång
        */
        public int speed = 3;
        //Gemensam variabel för om äpplet existerar
        public bool appleExist = true;
        //Gameobjects konstruktor
        public GameObject()
        {
            gameObjects.Add(this);
        }
        /*Gemensam update för alla gameobjects, denna är "virtual" för att de olika objekten ska kunna ändra på den utifrån
        objektets behov, t.ex kollar snakes update om någon tangent är nedtryckt, medan äpplet kollar omd et existerar
        */
        public virtual void Update()
        {
            
        }
        //Kollar så att inga objekt hmanar utanför fönstret, om den gör det skickar den det tillbaka in i fönstret.
        public void Wall()
        {
            if (this.rect.x > 750)
            {
               this.rect.x = 750; 
            }
            else if (this.rect.x < 0)
            {
                this.rect.x = 0;
            }
            else if (this.rect.y > 750)
            {
                this.rect.y = 750;
            }
            else if (this.rect.y < 0)
            {
                this.rect.y = 0;
            }
        }
        /*Ritar ut en röd triangel om inget annat skulle uppges, denna är också virtual för att kunna ändra efter behov,
        äpplet ritas ut grönt istället för rött.
        */
        public virtual void Draw(){
            Raylib.DrawRectangleRec(rect, Color.RED);
        }
        //kör draw metoden på alla gameobjects i listan
        public static void DrawAll(){
            foreach (GameObject g in gameObjects)
            {
                g.Draw();
            }
        }
        //Kör update på alla gameobjects i listan, samt kör "wall" på alla (kollar om något är utanför)
        public static void UpdateAll(){
            foreach (GameObject g in gameObjects)
            {
                g.Update();
                g.Wall();
            }
        }
        
    }
}
