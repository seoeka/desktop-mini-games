namespace MiniGame
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
            this.bt_sudoku = new System.Windows.Forms.Button();
            this.bt_matching = new System.Windows.Forms.Button();
            this.bt_flappy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_quit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_sudoku
            // 
            this.bt_sudoku.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_sudoku.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_sudoku.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_sudoku.FlatAppearance.BorderSize = 2;
            this.bt_sudoku.Font = new System.Drawing.Font("Batang", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sudoku.Location = new System.Drawing.Point(169, 161);
            this.bt_sudoku.Name = "bt_sudoku";
            this.bt_sudoku.Padding = new System.Windows.Forms.Padding(5);
            this.bt_sudoku.Size = new System.Drawing.Size(195, 45);
            this.bt_sudoku.TabIndex = 0;
            this.bt_sudoku.Text = "Sudoku";
            this.bt_sudoku.UseVisualStyleBackColor = false;
            this.bt_sudoku.Click += new System.EventHandler(this.bt_sudoku_Click);
            // 
            // bt_matching
            // 
            this.bt_matching.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_matching.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_matching.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_matching.FlatAppearance.BorderSize = 2;
            this.bt_matching.Font = new System.Drawing.Font("Batang", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_matching.Location = new System.Drawing.Point(169, 222);
            this.bt_matching.Name = "bt_matching";
            this.bt_matching.Padding = new System.Windows.Forms.Padding(5);
            this.bt_matching.Size = new System.Drawing.Size(195, 45);
            this.bt_matching.TabIndex = 1;
            this.bt_matching.Text = "Matching Game";
            this.bt_matching.UseVisualStyleBackColor = false;
            this.bt_matching.Click += new System.EventHandler(this.bt_matching_Click);
            // 
            // bt_flappy
            // 
            this.bt_flappy.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_flappy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_flappy.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_flappy.FlatAppearance.BorderSize = 2;
            this.bt_flappy.Font = new System.Drawing.Font("Batang", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_flappy.Location = new System.Drawing.Point(169, 286);
            this.bt_flappy.Name = "bt_flappy";
            this.bt_flappy.Padding = new System.Windows.Forms.Padding(5);
            this.bt_flappy.Size = new System.Drawing.Size(195, 45);
            this.bt_flappy.TabIndex = 2;
            this.bt_flappy.Text = "Flappy Bird";
            this.bt_flappy.UseVisualStyleBackColor = false;
            this.bt_flappy.Click += new System.EventHandler(this.bt_flappy_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Orbitron", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 105);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mini Games";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_quit
            // 
            this.bt_quit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bt_quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_quit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_quit.FlatAppearance.BorderSize = 2;
            this.bt_quit.Font = new System.Drawing.Font("Batang", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_quit.Location = new System.Drawing.Point(169, 347);
            this.bt_quit.Name = "bt_quit";
            this.bt_quit.Padding = new System.Windows.Forms.Padding(5);
            this.bt_quit.Size = new System.Drawing.Size(195, 45);
            this.bt_quit.TabIndex = 4;
            this.bt_quit.Text = "Quit";
            this.bt_quit.UseVisualStyleBackColor = false;
            this.bt_quit.Click += new System.EventHandler(this.bt_quit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(534, 441);
            this.Controls.Add(this.bt_quit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_flappy);
            this.Controls.Add(this.bt_matching);
            this.Controls.Add(this.bt_sudoku);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mini Games";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_sudoku;
        private System.Windows.Forms.Button bt_matching;
        private System.Windows.Forms.Button bt_flappy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_quit;
    }
}

