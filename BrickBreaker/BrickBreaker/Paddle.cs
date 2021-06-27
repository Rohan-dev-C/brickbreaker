using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickBreaker
{
    class Paddle : GameObject
    {
        public int xSpeed; 
        public Paddle(int x, int y, int width, int height, Color coloir, int xSpeed) : base(x, y, width, height, coloir)
        {
            this.xSpeed = xSpeed;
        }

        public override void Draw(Graphics gfx, Size ClientSize)
        {
            gfx.FillRectangle(new SolidBrush(colour), HitBox);
        }

       public void move(bool bool1, bool bool2, Size ClientSize)
       {
            if (bool1 && this.x + this.width < ClientSize.Width)
            {
                this.x += 7;
            }
            if (bool2 && this.x > 0)
            {
                this.x -= 7;
            }

        }
    }
}
