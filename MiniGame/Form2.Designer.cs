namespace MiniGame
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_newgame = new System.Windows.Forms.Button();
            this.rb_beginner = new System.Windows.Forms.RadioButton();
            this.rb_intermediate = new System.Windows.Forms.RadioButton();
            this.rb_advanced = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_check = new System.Windows.Forms.Button();
            this.bt_restart = new System.Windows.Forms.Button();
            this.bt_home = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(23, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 360);
            this.panel1.TabIndex = 0;
            // 
            // bt_newgame
            // 
            this.bt_newgame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_newgame.Location = new System.Drawing.Point(398, 135);
            this.bt_newgame.Name = "bt_newgame";
            this.bt_newgame.Size = new System.Drawing.Size(110, 34);
            this.bt_newgame.TabIndex = 1;
            this.bt_newgame.Text = "New Game";
            this.bt_newgame.UseVisualStyleBackColor = true;
            this.bt_newgame.Click += new System.EventHandler(this.bt_newgame_Click);
            // 
            // rb_beginner
            // 
            this.rb_beginner.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_beginner.Location = new System.Drawing.Point(404, 51);
            this.rb_beginner.Name = "rb_beginner";
            this.rb_beginner.Size = new System.Drawing.Size(104, 24);
            this.rb_beginner.TabIndex = 2;
            this.rb_beginner.TabStop = true;
            this.rb_beginner.Text = "Beginner";
            this.rb_beginner.UseVisualStyleBackColor = true;
            // 
            // rb_intermediate
            // 
            this.rb_intermediate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_intermediate.Location = new System.Drawing.Point(404, 78);
            this.rb_intermediate.Name = "rb_intermediate";
            this.rb_intermediate.Size = new System.Drawing.Size(104, 24);
            this.rb_intermediate.TabIndex = 3;
            this.rb_intermediate.TabStop = true;
            this.rb_intermediate.Text = "Intermediate";
            this.rb_intermediate.UseVisualStyleBackColor = true;
            // 
            // rb_advanced
            // 
            this.rb_advanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_advanced.Location = new System.Drawing.Point(404, 104);
            this.rb_advanced.Name = "rb_advanced";
            this.rb_advanced.Size = new System.Drawing.Size(104, 24);
            this.rb_advanced.TabIndex = 4;
            this.rb_advanced.TabStop = true;
            this.rb_advanced.Text = "Advanced";
            this.rb_advanced.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(395, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose Your Level :";
            // 
            // bt_check
            // 
            this.bt_check.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_check.Location = new System.Drawing.Point(398, 346);
            this.bt_check.Name = "bt_check";
            this.bt_check.Size = new System.Drawing.Size(110, 34);
            this.bt_check.TabIndex = 6;
            this.bt_check.Text = "Check Answer";
            this.bt_check.UseVisualStyleBackColor = true;
            this.bt_check.Click += new System.EventHandler(this.bt_check_Click);
            // 
            // bt_restart
            // 
            this.bt_restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_restart.Location = new System.Drawing.Point(398, 306);
            this.bt_restart.Name = "bt_restart";
            this.bt_restart.Size = new System.Drawing.Size(110, 34);
            this.bt_restart.TabIndex = 7;
            this.bt_restart.Text = "Restart";
            this.bt_restart.UseVisualStyleBackColor = true;
            this.bt_restart.Click += new System.EventHandler(this.bt_restart_Click);
            // 
            // bt_home
            // 
            this.bt_home.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_home.Location = new System.Drawing.Point(23, 394);
            this.bt_home.Name = "bt_home";
            this.bt_home.Size = new System.Drawing.Size(485, 34);
            this.bt_home.TabIndex = 8;
            this.bt_home.Text = "Homepage";
            this.bt_home.UseVisualStyleBackColor = true;
            this.bt_home.Click += new System.EventHandler(this.bt_home_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(534, 441);
            this.Controls.Add(this.bt_home);
            this.Controls.Add(this.bt_restart);
            this.Controls.Add(this.bt_check);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rb_advanced);
            this.Controls.Add(this.rb_intermediate);
            this.Controls.Add(this.rb_beginner);
            this.Controls.Add(this.bt_newgame);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_newgame;
        private System.Windows.Forms.RadioButton rb_beginner;
        private System.Windows.Forms.RadioButton rb_intermediate;
        private System.Windows.Forms.RadioButton rb_advanced;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_check;
        private System.Windows.Forms.Button bt_restart;
        private System.Windows.Forms.Button bt_home;
    }
}