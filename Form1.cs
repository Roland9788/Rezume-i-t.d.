namespace Резюме
{
    public partial class Form1 : Form
    {
        int count_guess_number = 0;
        int Rbt = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "Рыбин\nСергей\nАлександрович\nТелефон: +79509221826\n Возраст 17 лет";
            MessageBox.Show(s, s.Length.ToString());
            s = "Место проживания: Россия г.Тула \nОбразование: Среднее общее\n Дополнительно образование: Компьютерная академия 'TOP'";
            MessageBox.Show(s, s.Length.ToString());
            s = " Желаемая должность: Програмист С++, С#\n Опыт работы: Отсутствует ";
            MessageBox.Show(s, s.Length.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            guess_number();
        }

        void guess_number()
        {
            Random random = new Random();
            int number = random.Next(1, 2000);

            DialogResult result = MessageBox.Show($"{number}", "Угадавание числа", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show($"Было использованно = {count_guess_number} попыток");
            }
            else
            {
                count_guess_number++;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e){}

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            Random r = new Random();
            button5.Left = r.Next(0, this.ClientSize.Width - button1.Width);
            button5.Top = r.Next(0, this.ClientSize.Height - button1.Height);
        }

        private void Form1_Load(object sender, EventArgs e){}

        private void label1_Click(object sender, EventArgs e){}

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Сегодня {Convert.ToDateTime(textBox1.Text.ToString()).DayOfWeek}");
        }

        private void label2_Click(object sender, EventArgs e){}

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(textBox2.Text!="")
            {
                if (this.radioButton1.Checked)
                {
                    timer1.Start();
                    Rbt = 1;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Rbt == 1) 
            {
                label2.Text = $"{Convert.ToDateTime(textBox2.Text.ToString()).Year - DateTime.Now.Year}";
            }
            if (Rbt == 2)
            {
                label2.Text = $"{Convert.ToDateTime(textBox2.Text.ToString()).Month - DateTime.Now.Month}";
            }
            if (Rbt == 3)
            {
                label2.Text = $"{Convert.ToDateTime(textBox2.Text.ToString()).Day - DateTime.Now.Day}";
            }
            if (Rbt == 4)
            {
                label2.Text = $"{Convert.ToDateTime(textBox2.Text.ToString()).Minute - DateTime.Now.Minute}";
            }
            if (Rbt == 5)
            {
                label2.Text = $"{Convert.ToDateTime(textBox2.Text.ToString()).Second - DateTime.Now.Second}";
            }
            if (Rbt == 6)
            {
                label2.Text = $"{Convert.ToDateTime(textBox2.Text.ToString()).Hour - DateTime.Now.Hour}";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                if (this.radioButton2.Checked)
                {
                    timer1.Start();
                    Rbt = 2;
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                if (this.radioButton3.Checked)
                {
                    timer1.Start();
                    Rbt = 3;
                }
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                if (this.radioButton4.Checked)
                {
                    timer1.Start();
                    Rbt = 4;
                }
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                if (this.radioButton5.Checked)
                {
                    timer1.Start();
                    Rbt = 5;
                }
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                if (this.radioButton6.Checked)
                {
                    timer1.Start();
                    Rbt = 6;
                }
            }
        }
    }
}