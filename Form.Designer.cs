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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.aBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paddle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paddle1)).BeginInit();
            this.menuStrip.SuspendLayout();
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
            this.Score_Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
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
            this.P1_Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
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
            this.P2_Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.P2_Label.Location = new System.Drawing.Point(622, 454);
            this.P2_Label.Name = "P2_Label";
            this.P2_Label.Size = new System.Drawing.Size(33, 38);
            this.P2_Label.TabIndex = 5;
            this.P2_Label.Text = "0";
            // 
            // aBall
            // 
            this.aBall.Image = global::Pong.Properties.Resources.Ball_New;
            this.aBall.Location = new System.Drawing.Point(439, 165);
            this.aBall.Name = "aBall";
            this.aBall.Size = new System.Drawing.Size(20, 20);
            this.aBall.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.aBall.TabIndex = 2;
            this.aBall.TabStop = false;
            // 
            // Paddle2
            // 
            this.Paddle2.Image = global::Pong.Properties.Resources.Paddle;
            this.Paddle2.Location = new System.Drawing.Point(923, 165);
            this.Paddle2.Name = "Paddle2";
            this.Paddle2.Size = new System.Drawing.Size(20, 200);
            this.Paddle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Paddle2.TabIndex = 1;
            this.Paddle2.TabStop = false;
            // 
            // Paddle1
            // 
            this.Paddle1.Image = global::Pong.Properties.Resources.Paddle;
            this.Paddle1.Location = new System.Drawing.Point(12, 165);
            this.Paddle1.Name = "Paddle1";
            this.Paddle1.Size = new System.Drawing.Size(20, 200);
            this.Paddle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Paddle1.TabIndex = 0;
            this.Paddle1.TabStop = false;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Aqua;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem2,
            this.helpToolStripMenuItem2});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip.Size = new System.Drawing.Size(955, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem2
            // 
            this.fileToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem2.Name = "fileToolStripMenuItem2";
            this.fileToolStripMenuItem2.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem2.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem2
            // 
            this.helpToolStripMenuItem2.Name = "helpToolStripMenuItem2";
            this.helpToolStripMenuItem2.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem2.Text = "Help";
            this.helpToolStripMenuItem2.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Checked = true;
            this.helpToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(955, 505);
            this.Controls.Add(this.Paddle1);
            this.Controls.Add(this.Paddle2);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.aBall);
            this.Controls.Add(this.P1_Label);
            this.Controls.Add(this.Score_Label);
            this.Controls.Add(this.P2_Label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pong Game";
            this.Activated += new System.EventHandler(this.Form_Activated);
            this.Deactivate += new System.EventHandler(this.Form_Deactivate);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.aBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paddle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paddle1)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        public System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
    }
}

