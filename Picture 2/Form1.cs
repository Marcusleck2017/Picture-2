using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Picture_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 10000, pictureBox1.Location.Y + 10000);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 10, pictureBox1.Location.Y + 10);
        }

        private async void button1_Click_2(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 275, pictureBox1.Location.Y);
            await Task.Delay(500);
            pictureBox1.Location = new Point(pictureBox1.Location.X - 275, pictureBox1.Location.Y);
            await Task.Delay(500);
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X - 260, pictureBox1.Location.Y);
            await Task.Delay(500);
            pictureBox1.Location = new Point(pictureBox1.Location.X + 260, pictureBox1.Location.Y);
            await Task.Delay(500);
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X - 10000, pictureBox1.Location.Y);
            await Task.Delay(5000);
            pictureBox1.Location = new Point(pictureBox1.Location.X + 10000, pictureBox1.Location.Y);
            await Task.Delay(5000);
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(pictureBox1.Location.X + 50, pictureBox1.Location.Y);
            await Task.Delay(500);
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 50);
            await Task.Delay(500);
            pictureBox1.Location = new Point(pictureBox1.Location.X - 50, pictureBox1.Location.Y);
            await Task.Delay(500);
            pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 50);
            await Task.Delay(500);
        }
    }
}
