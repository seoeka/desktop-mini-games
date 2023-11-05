namespace MiniGame
{
    partial class Form4
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
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.trunkTop = new System.Windows.Forms.PictureBox();
            this.trunkBottom = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.timerFlappy = new System.Windows.Forms.Timer(this.components);
            this.scoreLabel = new System.Windows.Forms.Label();
            this.bt_home = new System.Windows.Forms.Button();
            this.bt_start = new System.Windows.Forms.Button();
            this.bt_restart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trunkTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trunkBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // flappyBird
            // 
            this.flappyBird.Image = global::MiniGame.Properties.Resources.pink_bird;
            this.flappyBird.Location = new System.Drawing.Point(111, 140);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(56, 40);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 23;
            this.flappyBird.TabStop = false;
            // 
            // trunkTop
            // 
            this.trunkTop.Image = global::MiniGame.Properties.Resources.trunkdown;
            this.trunkTop.Location = new System.Drawing.Point(380, -188);
            this.trunkTop.Name = "trunkTop";
            this.trunkTop.Size = new System.Drawing.Size(84, 334);
            this.trunkTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trunkTop.TabIndex = 24;
            this.trunkTop.TabStop = false;
            // 
            // trunkBottom
            // 
            this.trunkBottom.Image = global::MiniGame.Properties.Resources.trunk;
            this.trunkBottom.Location = new System.Drawing.Point(309, 257);
            this.trunkBottom.Name = "trunkBottom";
            this.trunkBottom.Size = new System.Drawing.Size(84, 307);
            this.trunkBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.trunkBottom.TabIndex = 25;
            this.trunkBottom.TabStop = false;
            // 
            // ground
            // 
            this.ground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(216)))), ((int)(((byte)(149)))));
            this.ground.Image = global::MiniGame.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-12, 386);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(562, 90);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 26;
            this.ground.TabStop = false;
            // 
            // timerFlappy
            // 
            this.timerFlappy.Interval = 30;
            this.timerFlappy.Tick += new System.EventHandler(this.timerFlappyEvent);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(216)))), ((int)(((byte)(149)))));
            this.scoreLabel.Font = new System.Drawing.Font("Leelawadee", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(27, 410);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(90, 25);
            this.scoreLabel.TabIndex = 27;
            this.scoreLabel.Text = "Score: 0";
            // 
            // bt_home
            // 
            this.bt_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_home.Location = new System.Drawing.Point(27, 323);
            this.bt_home.Name = "bt_home";
            this.bt_home.Size = new System.Drawing.Size(116, 34);
            this.bt_home.TabIndex = 29;
            this.bt_home.TabStop = false;
            this.bt_home.Text = "Homepage";
            this.bt_home.UseVisualStyleBackColor = true;
            this.bt_home.Click += new System.EventHandler(this.bt_home_Click);
            // 
            // bt_start
            // 
            this.bt_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_start.Location = new System.Drawing.Point(27, 283);
            this.bt_start.Name = "bt_start";
            this.bt_start.Size = new System.Drawing.Size(116, 34);
            this.bt_start.TabIndex = 30;
            this.bt_start.TabStop = false;
            this.bt_start.Text = "Start";
            this.bt_start.UseVisualStyleBackColor = true;
            this.bt_start.Click += new System.EventHandler(this.bt_start_Click);
            // 
            // bt_restart
            // 
            this.bt_restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_restart.Location = new System.Drawing.Point(27, 283);
            this.bt_restart.Name = "bt_restart";
            this.bt_restart.Size = new System.Drawing.Size(116, 34);
            this.bt_restart.TabIndex = 31;
            this.bt_restart.TabStop = false;
            this.bt_restart.Text = "Restart";
            this.bt_restart.UseVisualStyleBackColor = true;
            this.bt_restart.Click += new System.EventHandler(this.bt_restart_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(534, 441);
            this.Controls.Add(this.bt_restart);
            this.Controls.Add(this.bt_start);
            this.Controls.Add(this.bt_home);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.trunkBottom);
            this.Controls.Add(this.trunkTop);
            this.Controls.Add(this.flappyBird);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.flappyKeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.flappyKeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trunkTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trunkBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox trunkTop;
        private System.Windows.Forms.PictureBox trunkBottom;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Timer timerFlappy;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button bt_home;
        private System.Windows.Forms.Button bt_start;
        private System.Windows.Forms.Button bt_restart;
    }
}