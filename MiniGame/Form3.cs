using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniGame
{
    public partial class Form3 : Form
    {
        Random random = new Random();

        List<string> icons = new List<string>()
        {
            "!", "!", "L", "L", "N", "N", ",", ",", 
            "k", "k", "b", "b", "g", "g", "v", "v",
            "?", "?", "r", "r", "M", "M", ".", ".",
            "w", "w", "z", "z", "Y", "Y", "a", "a",
            "C", "C", "x", "x"
        };
        public Form3()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }

        private void AssignIconsToSquares()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    // iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        private void bt_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
