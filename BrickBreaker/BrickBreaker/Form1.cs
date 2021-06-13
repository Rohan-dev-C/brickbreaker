using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BrickBreaker
{
    public partial class Form1 : Form
    {
        List<Brick> bricks = new List<Brick>();
        Graphics gfx;
        Bitmap canvas;
        Paddle paddle = new Paddle(10, 700, 120, 10, Color.Black, 0);
        Ball ball = new Ball(10, 690, 10, 10, Color.LavenderBlush, 4, 4);
        bool wasRightPressed = false;
        bool wasLeftPressed = false;


        int score = 0;





        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            int y = 100;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j + 40 < ClientSize.Width; j += 70)
                {
                    bricks.Add(new Brick(j, y, 55, 35, Color.FromArgb(50, Color.DarkOrchid), 1));

                }

                y += 50;
            }
            scoreLabel.ForeColor = Color.FromArgb(50, Color.DarkOrchid);

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            gfx = Graphics.FromImage(canvas);

            gfx.Clear(Color.DarkSlateGray);
            paddle.move(wasRightPressed, wasLeftPressed, ClientSize);

            if (ball.HitBox.IntersectsWith(paddle.HitBox))
            {
                ball.ySpeed = -Math.Abs(ball.ySpeed);
            }

            if (ball.y + ball.height > ClientSize.Height)
            { 
                score = score / 2;
                ball.x = (paddle.x + (paddle.x + paddle.width)) / 2;
                ball.y = paddle.y;
                ball.ySpeed = -Math.Abs(ball.ySpeed);
            }

            for (int i = 0; i < bricks.Count; i++)
            {
                bricks[i].Draw(gfx, ClientSize);
            }

            for (int i = 0; i < bricks.Count; i++)
            {

                Point point = new Point(bricks[i].x, bricks[i].y);
                if (ball.HitBox.IntersectsWith(bricks[i].HitBox))
                {
                    if (ball.x >= bricks[i].x)
                    {
                        ball.xSpeed = Math.Abs(ball.xSpeed);
                    }
                    else if (ball.x + ball.width <= bricks[i].width + bricks[i].x)
                    {
                        ball.xSpeed = -Math.Abs(ball.xSpeed);
                    }
                    if (ball.y >= bricks[i].y)
                    {
                        ball.ySpeed = Math.Abs(ball.ySpeed);
                    }
                    else if (ball.y + ball.height <= bricks[i].y + bricks[i].height)
                    {
                        ball.ySpeed = -Math.Abs(ball.ySpeed);
                    }

                    score += 4;


                    gfx.FillRectangle(Brushes.DarkSlateGray, bricks[i].HitBox);
                    bricks.RemoveAt(i);

                }
            }
            
            scoreLabel.Text = $"Score: {score}";
            Point point1 = new Point(0, 0);
            paddle.Draw(gfx, ClientSize);
            ball.Draw(gfx, ClientSize);
            ball.Bounce(ClientSize, point1);

            pictureBox1.Image = canvas;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                wasRightPressed = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                wasLeftPressed = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                wasRightPressed = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                wasLeftPressed = false;
            }

        }



        //game object class
        // size, location, color, draw,  hitbox

        // brick class inherit from game object
        // hp, 

        // paddle calss invherit from gamer object
        // key control, speed, 


        // ball class inherit from game object
        // bounce, speed, 
    }



}
