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
    public partial class Form1 : Form
    {
        Ball ball;
        private bool isUpPressed, isDownPressed;
        private bool isWPressed, isSPressed;
        private int TopWorld = 0;
        private int BotWorld = 307;

        public Form1()
        {
            InitializeComponent();
            ball = new Ball(aBall);
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            ball.Move();
            if (this.isUpPressed == true)
            {
                Paddle2.Location = new Point(Paddle2.Location.X, Math.Max(this.TopWorld, Paddle2.Location.Y - 2));
            }
            if (this.isDownPressed == true)
            {
                Paddle2.Location = new Point(Paddle2.Location.X, Math.Min(this.BotWorld, Paddle2.Location.Y + 2));
            }
            if (this.isWPressed == true)
            {
                Paddle1.Location = new Point(Paddle1.Location.X, Math.Max(this.TopWorld, Paddle1.Location.Y - 2));
            }
            if (this.isSPressed == true)
            {
                Paddle1.Location = new Point(Paddle1.Location.X, Math.Min(this.BotWorld, Paddle1.Location.Y + 2));
            }

        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
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

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
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
