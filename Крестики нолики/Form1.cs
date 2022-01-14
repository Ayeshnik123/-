using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Крестики_нолики
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int a1 = 2, a2 = 2, a3 = 2, b1 = 2, b2 = 2, b3 = 2, c1 = 2, c2 = 2, c3 = 2;
        int hod = 0;
        int rastanovka = 0;
        int s = 11;

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            menuStrip1.Visible = true;
            button14.Visible = false;
            button13.Visible = false;
            button11.Visible = false;
            button10.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button12.Visible = true;
            textBox1.Visible = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {            
            //Вывод информации о правилах игры и об окне с игрой при нажатии на кнопку "Правила"              
            MessageBox.Show("Правила:\nИгроки по очереди ставят на свободные клетки поля 3х3 знаки (один всегда крестики, другой всегда нолики). Первый, выстроивший в ряд 3 своих фигуры по вертикали, горизонтали или диагонали, выигрывает. Первый ход делает игрок, ставящий крестики.\n\nОб игре:\nПосле нажатия в мену кнопки 'Играть' перед вами откроется окно с игрой, в нём вы увидите игровое поле 3 на 3 клетки. Игрок 1 всегда ставит на нём Крестики, Игрок 2 - Нолики. Под игровым полем табло счёта (очки первого игрока слева, очки второго игрока справа). Над полем будет выводиться информация о том, кто сейчас ходит. Ещё выше меню быстрого доступа.\n\nПриятной Вам Игры!!\n", "Правила");            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" Игра 'Крестики нолики'\n Разработчик: Кучаев Сергей ИСП-41");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Первым ходит бот")
            {
                button1.Text = "O";
            }
            else button1.Text = "X";
            Bot.Hod(button1, button2, button3, button4, button5, button6, button7, button8, button9, textBox1, rastanovka);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            int rastanovka;
            Random rand = new Random();
            for (int i = 0; i < 1; i++)
            {
                rastanovka = rand.Next(1, 3);
                switch (rastanovka)
                {
                    case (1):
                        textBox1.Text = "Первым ходит игрок";
                        button12.Enabled = false;
                        button1.Enabled = true;
                        button2.Enabled = true;
                        button3.Enabled = true;
                        button4.Enabled = true;
                        button5.Enabled = true;
                        button6.Enabled = true;
                        button7.Enabled = true;
                        button8.Enabled = true;
                        button9.Enabled = true;
                        textBox1.Enabled = true;
                        timer1.Start();
                        break;
                    case (2):
                        textBox1.Text = "Первым ходит бот";
                        button12.Enabled = false;
                        button1.Enabled = true;
                        button2.Enabled = true;
                        button3.Enabled = true;
                        button4.Enabled = true;
                        button5.Enabled = true;
                        button6.Enabled = true;
                        button7.Enabled = true;
                        button8.Enabled = true;
                        button9.Enabled = true;
                        textBox1.Enabled = true;
                        timer1.Start();
                        break;
                }
                Bot.Hod(button1, button2, button3, button4, button5, button6, button7, button8, button9, textBox1, rastanovka);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s = s - 1;
            label1.Text = s.ToString();
            if (s == 0)
            {
                timer1.Stop();
                label1.Text = "Время вышло";
                MessageBox.Show("Время закончилось\nПобедил БОТ");
                button15.Visible = true;
                button10.Visible = true;
                s = 11;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.Visible = false;
            button10.Visible = false;
            button12.Enabled = true;
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            hod = 0;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Первым ходит бот")
            {
                button2.Text = "O";
            }
            else button2.Text = "X";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Первым ходит бот")
            {
                button3.Text = "O";
            }
            else button3.Text = "X";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Первым ходит бот")
            {
                button4.Text = "O";
            }
            else button4.Text = "X";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Первым ходит бот")
            {
                button5.Text = "O";
            }
            else button5.Text = "X";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Первым ходит бот")
            {
                button6.Text = "O";
            }
            else button6.Text = "X";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Первым ходит бот")
            {
                button7.Text = "O";
            }
            else button7.Text = "X";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Первым ходит бот")
            {
                button8.Text = "O";
            }
            else button8.Text = "X";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Первым ходит бот")
            {
                button9.Text = "O";
            }
            else button9.Text = "X";
        }
    }
}
