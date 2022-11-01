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
    public partial class Form3 : Form
    {
        int x1, y1, x2, y2;
        bool MouseD = false;
        bool MouseU = false;
        List<Label> labels = new List<Label>();
        public Form3()
        {
            InitializeComponent();
        }


        private void Form3_Load(object sender, EventArgs e)
        {
            this.MouseDown += Form3_MouseDown;
            this.MouseMove += Form3_MouseMove;
            this.MouseUp += Form3_MouseUp;
        }

        private void Form3_MouseUp(object? sender, MouseEventArgs e)
        {
            MouseU = true;
            MouseD = false;
        }

        private void Form3_MouseMove(object? sender, MouseEventArgs e)
        {
            if(MouseD)
            {
                x2 = e.X;
                y2 = e.Y;

                labels.Add(CreateLable());
                foreach ( object item in labels)
                {
                    
                }

            }
        }

        private Label CreateLable()
        {
            Label label = new Label();
            label.Width = x1;
            label.Height = y1;
            label.Text = "1";
            return new Label();
        }

        private void Form3_MouseDown(object? sender, MouseEventArgs e)
        {
            MouseU = false;
            MouseD = true;
            x1 = e.X;
            y1 = e.Y;
        }
    }
}
