using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form : System.Windows.Forms.Form
    {
        /// <summary>
        /// This Class Manages The Game
        /// </summary>
        Ball ball;
        private bool isUpPressed, isDownPressed;
        private bool isWPressed, isSPressed;
        private int topWorld = 27;  
        private int botWorld = 307;

        public Form()
        {
            ///Form Builder
            InitializeComponent();
            ball = new Ball(aBall, Paddle1, Paddle2, P1_Label, P2_Label);
            this.aBall.BringToFront();  //Makes The Ball Infront Of The Score Label
            this.MouseWheel += new MouseEventHandler(Form_MouseWheel);  //Creating A New Event In Case User Using Mouse Wheel
        }


        private void Form_MouseWheel(object sender, MouseEventArgs e)
        {
            ///A Function That Reacts To The User's Mouse Wheel
            if (e.Delta > 0)    //Incase User Uses Mouse Wheel Up
            {
                this.ball.Add_Speed();
            }
            else if (e.Delta < 0)   //Incase User Uses Mouse Wheel Down
            {
                this.ball.Sub_Speed();
            }
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            ///Main Function That Runs The Game, Moving Paddle And Ball
            this.ball.Move();
            if (this.isUpPressed == true)
            {
                Paddle2.Location = new Point(Paddle2.Location.X, Math.Max(this.topWorld, Paddle2.Location.Y - 3));  ///Moving The Paddle (Blocking If Out Off Screen)-
            }
            if (this.isDownPressed == true)
            {
                Paddle2.Location = new Point(Paddle2.Location.X, Math.Min(this.botWorld, Paddle2.Location.Y + 3));
            }
            if (this.isWPressed == true)
            {
                Paddle1.Location = new Point(Paddle1.Location.X, Math.Max(this.topWorld, Paddle1.Location.Y - 3));
            }
            if (this.isSPressed == true)
            {
                Paddle1.Location = new Point(Paddle1.Location.X, Math.Min(this.botWorld, Paddle1.Location.Y + 3));
            }

        }


        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ///Help Toop Strip
            string Message = " - Don't Let The Ball Get Past Your Paddle \n - To Control The Right Paddle Use W & S \n -To Use The Left Paddle Use The Arrows \n   Have Fun!";
            MessageBox.Show(Message, "Rules");
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ///Exit Tool Strip
            this.Close();
        }


        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ///New Game Tool Strip
            this.ball.New_Game();
        }


        private void Form_Deactivate(object sender, EventArgs e)
        {
            ///When Form Isn't In Focus Pausing The Game
            Timer.Stop();
        }


        private void Form_Activated(object sender, EventArgs e)
        {
            ///When Form Is In Focus The Game Continues
            Timer.Start();
        }


        private void Form_KeyDown(object sender, KeyEventArgs e)
        {
            ///Checks Which Key The User Has Presses
            if (e.KeyCode == Keys.Up)
            {
                this.isUpPressed = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                this.isDownPressed = true;
            }
            if (e.KeyCode == Keys.W)
            {
                this.isWPressed = true;
            }
            if (e.KeyCode == Keys.S)
            {
                this.isSPressed = true;
            }
        }


        private void Form_KeyUp(object sender, KeyEventArgs e)
        {
            ///Telling The Program The User Stopped Clicking The Key
            if (e.KeyCode == Keys.Up)
            {
                this.isUpPressed = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                this.isDownPressed = false;
            }
            if (e.KeyCode == Keys.W)
            {
                this.isWPressed = false;
            }
            if (e.KeyCode == Keys.S)
            {
                this.isSPressed = false;
            }
        }
    }


     
}
