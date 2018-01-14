using System;
using System.Windows.Forms;
using System.Drawing;
using System.Media;

namespace Pong
{
    internal class Ball
    {
        /// <summary>
        /// This Class Manages The Ball Movement
        /// </summary>
        private Label P1, P2;
        private PictureBox ball, Paddle1, Paddle2;
        Random rnd = new Random();
        private int xSpeed;
        private int ySpeed = 1;
        private int topWorld = 27;
        private int botWorld = 485;
        private int leftWorld = 0;
        private int rightWorld = 971;
        private int[] xstartSpeed = {-5, 5};
        private int[] ystartSpeed = {-1, 1};
        private int[] speedOptions = {3, 5, 7};

        public Ball(PictureBox ball, PictureBox Paddle1, PictureBox Paddle2, Label P1, Label P2)
        {
            ///Builder For The Ball
            this.ball = ball;
            this.Paddle1 = Paddle1;
            this.Paddle2 = Paddle2;
            this.P1 = P1;
            this.P2 = P2;
            Reset_Ball();
            this.xSpeed = this.xstartSpeed[this.rnd.Next(xstartSpeed.Length)];  //Finding A Random Move To The Ball (X Line)
            this.ySpeed = this.ystartSpeed[this.rnd.Next(ystartSpeed.Length)];  //Finding A Random Move To The Ball (Y Line)
        }


        public void Move()
        {
            ///A Functions That Moves The Ball, Reacts In Angels, Paddles, And Finds When Player Misses
            int bottom = this.botWorld - ball.Height;   //Find The Buttom Of The Screen
            ball.Location = new Point(ball.Location.X + this.xSpeed, Math.Max(this.topWorld, Math.Min(bottom, ball.Location.Y + this.ySpeed))); //Moving The Ball Acording To xSpeed and ySpeed
            if (ball.Location.Y >= bottom || ball.Location.Y <= this.topWorld)  //Checks If Ball Hits Top/Bot Of The Screen
            {
                this.ySpeed = this.ySpeed * -1;    //Changing The Y Line Direction When Hitting Top/Bot Of The Screen
                SoundPlayer sound = new SoundPlayer(Properties.Resources.Bar_Sound);    //Playing Sound When Ball Hits Top/Bot Of The Screen
                sound.Load();
                sound.Play();
            }
            if (ball.Location.X <= this.leftWorld)   //Checks If Ball Got To The Left Bar
            {
                Score(this.P2);
            }
            else if (ball.Location.X >= this.rightWorld - ball.Width)   //Checks If Ball Got To The Right Bar
            {
                Score(this.P1);
            }
            if (this.Paddle1.Bounds.IntersectsWith(this.ball.Bounds) || this.Paddle2.Bounds.IntersectsWith(this.ball.Bounds))   //Checks If Ball Is In Paddle Range
            {
                this.xSpeed = this.xSpeed * -1;
                SoundPlayer sound = new SoundPlayer(Properties.Resources.Pong_Sound);   //Playing A Sound When Ball Hits Paddle
                sound.Load();
                sound.Play();
            }
        }


        public void Add_Speed()
        {
            ///A Function That Adds Speed To The Ball
            if (this.xSpeed == this.speedOptions[0])    //Finds The New Speed
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
            ///A Functions That Substracts Speed From The Ball
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
            ///A Function That Adds Score And Reset Ball Position
            Player_Score.Text = (Convert.ToInt32(Player_Score.Text)+1).ToString();  //Adds A Point To The Player
            Reset_Ball();
            this.xSpeed = this.xSpeed * -1; //Changing The Direction Of The Ball
            this.ySpeed = this.ystartSpeed[this.rnd.Next(ystartSpeed.Length)]; 
        }


        private void Reset_Ball()
        {
            ///A Function That Find The Middle Of The Screen And Putting The Ball In It
            ball.Location = new Point((this.rightWorld + this.leftWorld) / 2, (this.topWorld + this.botWorld) / 2);
        }


        public void New_Game()
        {
            ///A Function That Resets The Game
            this.P1.Text = "0";
            this.P2.Text = "0";
            Reset_Ball();
        }
    }
}