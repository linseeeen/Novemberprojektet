using System.Collections.Generic;
using System;
using Raylib_cs;

namespace Novemberprojektet
{
    public class GameObject
    {
        public Rectangle rect = new Rectangle();
        public static List<GameObject> gameObjects = new List<GameObject>();
        public Random generator = new Random();
        public int speed = 3;
        public bool appleExist = false;
        public GameObject()
        {
            gameObjects.Add(this);
        }
        public virtual void Update()
        {
            
        }
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
        public virtual void Draw(){
            Raylib.DrawRectangleRec(rect, Color.RED);
        }
        public static void DrawAll(){
            foreach (GameObject g in gameObjects)
            {
                g.Draw();
            }
        }
        public static void UpdateAll(){
            foreach (GameObject g in gameObjects)
            {
                g.Update();
                g.Wall();
            }
        }
        
    }
}
