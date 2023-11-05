using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace MiniGame
{
    public partial class Form4 : Form
    {
        int trunkSpeed = 6; // default trunk speed defined with an integer
        int gravity = 5; // default gravity speed defined with an integer
        int score = 0; // default score integer set to 0
        public Form4()
        {
            InitializeComponent();
            bt_restart.Visible = false;
            bt_restart.Enabled = false;
        }

        private void flappyKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 8;
            }
        }

        private void flappyKeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void timerFlappyEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            trunkTop.Left -= trunkSpeed; // the same is happening with the top pipe, reduce the value of pipe speed integer from the left position of the pipe using the -= sign
            trunkBottom.Left -= trunkSpeed; // link the bottom pipes left position to the pipe speed integer, it will reduce the pipe speed value from the left position of the pipe picture box so it will move left with each tick
            scoreLabel.Text = "Score: " + score; // show the current score on the score text label

            if (trunkBottom.Left < -150)
            {
                trunkBottom.Left = 800;
                score++;
            }
            if (trunkTop.Left < -180)
            {
                // if the top pipe location is -180 then we will reset the pipe back to the 950 and add 1 to the score
                trunkTop.Left = 950;
                score++;
            }

            if (score > 5 && score <= 10)
            {
                trunkSpeed = 8;
            }

            if (score > 10 && score <= 15)
            {
                trunkSpeed = 10;
            }

            if (flappyBird.Bounds.IntersectsWith(trunkBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(trunkTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) || flappyBird.Top < -25
                )
            {
                // if any of the conditions are met from above then we will run the end game function
                endGame();
            }

            
        }

        private void endGame()
        {
            timerFlappy.Stop(); // stop the main timer
            scoreLabel.Text = "Game over!!!";
            bt_home.Visible = true;
            bt_home.Enabled = true;
            bt_restart.Visible = true;
            bt_restart.Enabled = true;
        }

        private void bt_start_Click(object sender, EventArgs e)
        {
            bt_start.Visible = false;
            bt_start.Enabled = false;
            bt_home.Visible = false;
            bt_home.Enabled = false;
            timerFlappy.Start(); // stop the main timer

        }

        private void bt_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void bt_restart_Click(object sender, EventArgs e)
        {
            trunkSpeed = 6;
            gravity = 5;
            score = 0;
            scoreLabel.Text = "Score: " + score;
            flappyBird.Location = new Point(53, 175);
            trunkTop.Location = new Point(380, -188);
            trunkBottom.Location = new Point(309, 257);
            bt_restart.Visible = false;
            bt_restart.Enabled = false;
            bt_home.Visible = false;
            bt_home.Enabled = false;
            timerFlappy.Start();
        }
    }
}
