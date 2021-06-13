using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickBreaker
{
    class Brick : GameObject
    {
        int health;    
        public Brick(int x, int y, int width, int height, Color coloir, int health) : base(x, y, width, height, coloir) 
        {
            this.health = health; 
        }

        public override void Draw(Graphics gfx, Size ClientSize)
        {
            gfx.FillRectangle(new SolidBrush(colour), HitBox);
            gfx.DrawRectangle(new Pen(Color.Black, 5), HitBox);
        }



    }
}
