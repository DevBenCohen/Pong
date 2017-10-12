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
        Ball ball;
        private bool isUpPressed, isDownPressed;
        private bool isWPressed, isSPressed;
        private int topWorld = 27;
        private int botWorld = 307;

        public Form()
        {
            InitializeComponent();
            ball = new Ball(aBall, Paddle1, Paddle2, P1_Label, P2_Label);
            this.aBall.BringToFront();
            this.MouseWheel += new MouseEventHandler(Form_MouseWheel);
        }

        private void Form_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                this.ball.Add_Speed();
            }
            else if (e.Delta < 0)
            {
                this.ball.Sub_Speed();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            ball.Move();
            if (this.isUpPressed == true)
            {
                Paddle2.Location = new Point(Paddle2.Location.X, Math.Max(this.topWorld, Paddle2.Location.Y - 3));
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
            string Message = " - Don't Let The Ball Get Past Your Paddle \n - To Control The Right Paddle Use W & S \n -To Use The Left Paddle Use The Arrows \n Have Fun!";
            MessageBox.Show(Message, "Rules");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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
