using System;
using System.Windows.Forms;
using System.Drawing;

namespace Pong
{
    internal class Ball
    {
        private Label P1, P2;
        private PictureBox ball, Paddle1, Paddle2;
        Random rnd = new Random();
        private int xSpeed = 1;
        private int ySpeed = 1;
        private int TopWorld = 0;
        private int BotWorld = 485;
        private int LeftWorld = 0;
        private int RightWorld = 971;

        public Ball(PictureBox ball, PictureBox Paddle1, PictureBox Paddle2, Label P1, Label P2)
        {
            this.ball = ball;
            this.Paddle1 = Paddle1;
            this.Paddle2 = Paddle2;
            this.P1 = P1;
            this.P2 = P2;
            ResetBall();
        }
        
        
        public void Move()
        {
            int bottom = this.BotWorld - ball.Height;
            ball.Location = new Point(ball.Location.X + this.xSpeed, Math.Max(this.TopWorld, Math.Min(this.BotWorld, ball.Location.Y + this.ySpeed)));
            if (ball.Location.Y >= bottom || ball.Location.Y <= this.TopWorld)
            {
                this.ySpeed = this.ySpeed * -1;
            }
            if (ball.Location.X <= this.LeftWorld)
            {
                Score(this.P2);
            }
            else if (ball.Location.X >= this.RightWorld - ball.Width)
            {
                Score(this.P1);
            }
            if (this.Paddle1.Bounds.IntersectsWith(this.ball.Bounds) || this.Paddle2.Bounds.IntersectsWith(this.ball.Bounds))
            {
                this.xSpeed = this.xSpeed * -1;
            }
        }


        public void AddSpeed()
        {
            this.xSpeed = this.xSpeed + 1;
            this.ySpeed = this.ySpeed + 1;
        }


        public void SubSpeed()
        {
            if (this.xSpeed > 1)
            {
                this.xSpeed = this.xSpeed - 1;
                this.ySpeed = this.ySpeed - 1;
            }
        }
        private void Score(Label Player_Score)
        {
            Player_Score.Text = (Convert.ToInt32(Player_Score.Text)+1).ToString();
            ResetBall();
            this.ySpeed = 1;
            this.xSpeed = this.xSpeed * -1;
            this.ySpeed = this.rnd.Next(this.ySpeed * -1, this.ySpeed);
        }

        private void ResetBall()
        {
            ball.Location = new Point((this.RightWorld + this.LeftWorld) / 2, (this.TopWorld + this.BotWorld) / 2);
        }
    }
}