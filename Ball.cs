using System;
using System.Windows.Forms;
using System.Drawing;
using System.Media;

namespace Pong
{
    internal class Ball
    {
        private Label P1, P2;
        private PictureBox ball, Paddle1, Paddle2;
        Random rnd = new Random();
        private int xSpeed = 1;
        private int ySpeed = 1;
        private int topWorld = 0;
        private int botWorld = 485;
        private int leftWorld = 0;
        private int rightWorld = 971;
        private int[] xstartSpeed = {-5, 5};
        private int[] ystartSpeed = {-1, 1};
        private int[] speedOptions = {3, 5, 7};

        public Ball(PictureBox ball, PictureBox Paddle1, PictureBox Paddle2, Label P1, Label P2)
        {

            this.ball = ball;
            this.Paddle1 = Paddle1;
            this.Paddle2 = Paddle2;
            this.P1 = P1;
            this.P2 = P2;
            Reset_Ball();
            this.xSpeed = this.xstartSpeed[this.rnd.Next(xstartSpeed.Length)];            
        }


        public void Move()
        {
            int bottom = this.botWorld - ball.Height;
            ball.Location = new Point(ball.Location.X + this.xSpeed, Math.Max(this.topWorld, Math.Min(this.botWorld, ball.Location.Y + this.ySpeed)));
            if (ball.Location.Y >= bottom || ball.Location.Y <= this.topWorld)
            {
                this.ySpeed = this.ySpeed * -1;
                SoundPlayer sound = new SoundPlayer(@"C:\Users\Ben\Downloads\Bar_Sound.wav");
                sound.Load();
                sound.Play();
            }
            if (ball.Location.X <= this.leftWorld)
            {
                Score(this.P2);
            }
            else if (ball.Location.X >= this.rightWorld - ball.Width)
            {
                Score(this.P1);
            }
            if (this.Paddle1.Bounds.IntersectsWith(this.ball.Bounds) || this.Paddle2.Bounds.IntersectsWith(this.ball.Bounds))
            {
                this.xSpeed = this.xSpeed * -1;
                SoundPlayer sound = new SoundPlayer(@"C:\Users\Ben\Downloads\Pong_Sound.wav");
                sound.Load();
                sound.Play();
            }
        }


        public void Add_Speed()
        {
            if (this.xSpeed == this.speedOptions[0])
            {
                if (this.xSpeed > 0)
                    this.xSpeed = this.speedOptions[1];
                else
                    this.xSpeed = this.speedOptions[1] * -1;
            }
            else if (this.xSpeed == this.speedOptions[1])
            {
                if (this.xSpeed > 0)
                    this.xSpeed = this.speedOptions[2];
                else
                    this.xSpeed = this.speedOptions[2] * -1;
            }
        }



        public void Sub_Speed()
        {
            if (this.xSpeed == this.speedOptions[2])
            {
                if (this.xSpeed > 0)
                    this.xSpeed = this.speedOptions[1];
                else
                    this.xSpeed = this.speedOptions[1] * -1;
            }
            else if (this.xSpeed == this.speedOptions[1])
            {
                if (this.xSpeed > 0)
                    this.xSpeed = this.speedOptions[0];
                else
                    this.xSpeed = this.speedOptions[0] * -1;
            }
        }


        private void Score(Label Player_Score)
        {
            Player_Score.Text = (Convert.ToInt32(Player_Score.Text)+1).ToString();
            Reset_Ball();
            this.xSpeed = this.xSpeed * -1;
            this.ySpeed = this.ystartSpeed[this.rnd.Next(ystartSpeed.Length)];
        }


        private void Reset_Ball()
        {
            ball.Location = new Point((this.rightWorld + this.leftWorld) / 2, (this.topWorld + this.botWorld) / 2);
        }
    }
}