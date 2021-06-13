using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickBreaker
{
    class Ball : GameObject
    {

        public int xSpeed;
        public int ySpeed;
        public Ball(int x, int y, int width, int height, Color coloir, int xSpeed, int ySpeed) : base(x, y, width, height, coloir)
        {
            this.xSpeed = xSpeed;
            this.ySpeed = ySpeed;
        }

        public override void Draw(Graphics gfx, Size ClientSize)
        {
            gfx.FillEllipse(new SolidBrush(colour), HitBox);
            this.x += this.xSpeed;
            this.y += this.ySpeed;
        }
        public void Bounce(Size ClientSize, Point startPoint)
        {

            if (y < 0)
            {
                ySpeed = Math.Abs(ySpeed);
            }
            //if (y < startPoint.Y + ClientSize.Height)
            //{
            //    ySpeed = -Math.Abs(ySpeed);
            //}
            if (x + width > ClientSize.Width)
            {
                xSpeed = -Math.Abs(xSpeed);
            }
            if (x < 0)
            {
                xSpeed = Math.Abs(xSpeed);
            }
            if(y + height > ClientSize.Height)
            {
                ySpeed = -Math.Abs(ySpeed);
            }

        }

    }
}
