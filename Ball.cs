using System;
using System.Windows.Forms;
using System.Drawing;

namespace Pong
{
    internal class Ball
    {
        private PictureBox ball;
        private int xSpeed = 1;
        private int ySpeed = 1;
        private int TopWorld = 0;
        private int BotWorld = 485;

        public Ball(PictureBox ball)
        {
            this.ball = ball;
        }
        
        
        public void Move()
        {
            int bottom = this.BotWorld - ball.Height;
            ball.Location = new Point(ball.Location.X + this.xSpeed, Math.Max(this.TopWorld, Math.Min(this.BotWorld, ball.Location.Y + ySpeed)));
            if (ball.Location.Y == bottom || ball.Location.Y == this.TopWorld)
            {
                ySpeed = ySpeed * -1;
            }
        }
    }
}