namespace Pong
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.aBall = new System.Windows.Forms.PictureBox();
            this.Paddle2 = new System.Windows.Forms.PictureBox();
            this.Paddle1 = new System.Windows.Forms.PictureBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.aBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paddle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paddle1)).BeginInit();
            this.SuspendLayout();
            // 
            // aBall
            // 
            this.aBall.Image = global::Pong.Properties.Resources.Ball_New;
            this.aBall.Location = new System.Drawing.Point(408, 240);
            this.aBall.Name = "aBall";
            this.aBall.Size = new System.Drawing.Size(20, 20);
            this.aBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.aBall.TabIndex = 2;
            this.aBall.TabStop = false;
            // 
            // Paddle2
            // 
            this.Paddle2.Image = global::Pong.Properties.Resources.Paddle;
            this.Paddle2.Location = new System.Drawing.Point(911, 165);
            this.Paddle2.Name = "Paddle2";
            this.Paddle2.Size = new System.Drawing.Size(20, 200);
            this.Paddle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Paddle2.TabIndex = 1;
            this.Paddle2.TabStop = false;
            // 
            // Paddle1
            // 
            this.Paddle1.Image = global::Pong.Properties.Resources.Paddle;
            this.Paddle1.Location = new System.Drawing.Point(26, 165);
            this.Paddle1.Name = "Paddle1";
            this.Paddle1.Size = new System.Drawing.Size(20, 200);
            this.Paddle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Paddle1.TabIndex = 0;
            this.Paddle1.TabStop = false;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(955, 505);
            this.Controls.Add(this.aBall);
            this.Controls.Add(this.Paddle2);
            this.Controls.Add(this.Paddle1);
            this.Name = "Form1";
            this.Text = "Pong Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.aBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paddle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paddle1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Paddle1;
        private System.Windows.Forms.PictureBox Paddle2;
        private System.Windows.Forms.PictureBox aBall;
        private System.Windows.Forms.Timer Timer;
    }
}

