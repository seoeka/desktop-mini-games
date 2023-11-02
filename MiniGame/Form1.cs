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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_sudoku_Click(object sender, EventArgs e)
        {
            // Sembunyikan form utama
            this.Hide();

            // Membuat instance form baru
            Form2 form2 = new Form2();

            // Menampilkan form baru
            form2.Show();
        }

        private void bt_matching_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void bt_flappy_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
