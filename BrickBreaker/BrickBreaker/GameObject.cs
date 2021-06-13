using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BrickBreaker
{
    abstract class GameObject
    {
        public int x;
        public int y;
        public int width;
        public int height;
        protected Color colour;

        public Rectangle HitBox { get { return new Rectangle(x, y, width, height); } }


        public GameObject(int x, int y, int width, int height, Color coloir)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
            this.colour = coloir;
        }

        public abstract void Draw(Graphics gfx, Size ClientSize);
    }
   
}
