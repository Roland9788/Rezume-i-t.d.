using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Резюме
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.MouseClick += Form2_MouseClick;
        }

        private void Form2_MouseMove(object? sender, MouseEventArgs e)
        {
            if (e.X <= this.Width-100 && e.Y <= this.Height-100)
                MessageBox.Show($"Внутри прямоугольника");
            else MessageBox.Show($"Вне прямоугольника");
            this.MouseMove -= Form2_MouseMove;
            timer1.Start();
        }

        private void Form2_MouseClick(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                timer1.Stop();
                this.MouseMove += Form2_MouseMove;
            }
            if (e.Button == MouseButtons.Right)
            {
                timer1.Stop();
                MessageBox.Show($"x :{this.Width - 100}; y :{this.Height - 100}");
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = $"x :{Control.MousePosition.X}; y :{Control.MousePosition.Y}";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
