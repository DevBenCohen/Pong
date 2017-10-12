namespace Pong
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Score_Label = new System.Windows.Forms.Label();
            this.P1_Label = new System.Windows.Forms.Label();
            this.P2_Label = new System.Windows.Forms.Label();
            this.aBall = new System.Windows.Forms.PictureBox();
            this.Paddle2 = new System.Windows.Forms.PictureBox();
            this.Paddle1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.aBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paddle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paddle1)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 1;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Score_Label
            // 
            this.Score_Label.AutoSize = true;
            this.Score_Label.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Score_Label.Location = new System.Drawing.Point(409, 452);
            this.Score_Label.Name = "Score_Label";
            this.Score_Label.Size = new System.Drawing.Size(97, 40);
            this.Score_Label.TabIndex = 3;
            this.Score_Label.Text = "Score";
            this.Score_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // P1_Label
            // 
            this.P1_Label.AutoSize = true;
            this.P1_Label.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1_Label.Location = new System.Drawing.Point(274, 454);
            this.P1_Label.Name = "P1_Label";
            this.P1_Label.Size = new System.Drawing.Size(33, 38);
            this.P1_Label.TabIndex = 4;
            this.P1_Label.Text = "0";
            // 
            // P2_Label
            // 
            this.P2_Label.AutoSize = true;
            this.P2_Label.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2_Label.Location = new System.Drawing.Point(622, 454);
            this.P2_Label.Name = "P2_Label";
            this.P2_Label.Size = new System.Drawing.Size(33, 38);
            this.P2_Label.TabIndex = 5;
            this.P2_Label.Text = "0";
            // 
            // aBall
            // 
            this.aBall.Image = global::Pong.Properties.Resources.Ball_New;
            this.aBall.Location = new System.Drawing.Point(485, 242);
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
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(955, 505);
            this.Controls.Add(this.P2_Label);
            this.Controls.Add(this.P1_Label);
            this.Controls.Add(this.Score_Label);
            this.Controls.Add(this.aBall);
            this.Controls.Add(this.Paddle2);
            this.Controls.Add(this.Paddle1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label Score_Label;
        private System.Windows.Forms.Label P1_Label;
        private System.Windows.Forms.Label P2_Label;
    }
}

