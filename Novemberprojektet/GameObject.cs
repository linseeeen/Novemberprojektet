using System.Collections.Generic;
using System;
using Raylib_cs;

namespace Novemberprojektet
{
    public class GameObject
    {
        public Rectangle body = new Rectangle();
        public static List<GameObject> gameObjects = new List<GameObject>();
        public GameObject()
        {
            gameObjects.Add(this);
        }
        public virtual void Update()
        {

        }
        public void Draw(){
            Raylib.DrawRectangleRec(body, Color.RED);
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
            }
        }
    }
}
