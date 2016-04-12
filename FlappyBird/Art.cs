using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace FlappyBird
{
    static class Art
    {
        public static Texture2D Plane { get; private set; }

        public static void Load(ContentManager content)
        {
            Plane = content.Load<Texture2D>("plane");

            if (Plane != null)
            {
            Console.WriteLine("Plane loaded Sucessfully");    
            }
        }
    }
}
