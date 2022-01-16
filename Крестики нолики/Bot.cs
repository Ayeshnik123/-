using System;
using System.Windows.Forms;

namespace Крестики_нолики
{
    class Bot
    {
    public static void Hod(Button button1, Button button2, Button button3, Button button4, Button button5, Button button6, Button button7, Button button8, Button button9, TextBox textBox1, int rastanovka)
        {
            if (button1.Text == "" || button2.Text == "" || button3.Text == "" || button4.Text == "" || button5.Text == "" || button6.Text == "" || button7.Text == "" || button8.Text == "" || button9.Text == "")
            {

                if (textBox1.Text == "Первым ходит бот")
                {
                    Random rand = new Random();
                    rastanovka = rand.Next(1, 10);
                    for (int i = 0; i < 1; i++)
                    {
                        switch (rastanovka)
                        {
                            case (1):
                                if (button1.Text == "") button1.Text = "X";
                                else goto case (2);
                                break;
                            case (2):
                                if (button2.Text == "") button2.Text = "X";
                                else goto case (3);
                                break;
                            case (3):
                                if (button3.Text == "") button3.Text = "X";
                                else goto case (4);
                                break;
                            case (4):
                                if (button4.Text == "") button4.Text = "X";
                                else goto case (5);
                                break;
                            case (5):
                                if (button5.Text == "") button5.Text = "X";
                                else goto case (6);
                                break;
                            case (6):
                                if (button6.Text == "") button6.Text = "X";
                                else goto case (7);
                                break;
                            case (7):
                                if (button7.Text == "") button7.Text = "X";
                                else goto case (8);
                                break;
                            case (8):
                                if (button8.Text == "") button8.Text = "X";
                                else goto case (9);
                                break;
                            case (9):
                                if (button9.Text == "") button9.Text = "X";
                                else goto case (1);
                                break;
                        }
                    }
                }
                if (textBox1.Text == "Первым ходит игрок")
                {
                    Random rand = new Random();
                    rastanovka = rand.Next(1, 10);
                    for (int i = 0; i < 1; i++)
                    {
                        switch (rastanovka)
                        {
                            case (1):
                                if (button1.Text == "") button1.Text = "O";
                                else goto case (2);
                                break;
                            case (2):
                                if (button2.Text == "") button2.Text = "O";
                                else goto case (3);
                                break;
                            case (3):
                                if (button3.Text == "") button3.Text = "O";
                                else goto case (4);
                                break;
                            case (4):
                                if (button4.Text == "") button4.Text = "O";
                                else goto case (5);
                                break;
                            case (5):
                                if (button5.Text == "") button5.Text = "O";
                                else goto case (6);
                                break;
                            case (6):
                                if (button6.Text == "") button6.Text = "O";
                                else goto case (7);
                                break;
                            case (7):
                                if (button7.Text == "") button7.Text = "O";
                                else goto case (8);
                                break;
                            case (8):
                                if (button8.Text == "") button8.Text = "O";
                                else goto case (9);
                                break;
                            case (9):
                                if (button9.Text == "") button9.Text = "O";
                                else goto case (1);
                                break;
                        }
                    }
                }
            }
        }
        public static void Result(Button button1, Button button2, Button button3, Button button4, Button button5, Button button6, Button button7, Button button8, Button button9, Button button10, Button button15, Timer timer1, Label label1, TextBox textBox1, int s)
        {
            if (textBox1.Text == "Первым ходит игрок")
            {
                if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X")
                {
                    timer1.Stop();
                    label1.Text = "Игра закончилась";
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
                    MessageBox.Show("Победил игрок!");
                }
                if (button6.Text == "X" && button5.Text == "X" && button4.Text == "X")
                {
                    timer1.Stop();
                    label1.Text = "Игра закончилась";
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
                    MessageBox.Show("Победил игрок!");
                }
                if (button9.Text == "X" && button8.Text == "X" && button7.Text == "X")
                {
                    timer1.Stop();
                    label1.Text = "Игра закончилась";
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
                    MessageBox.Show("Победил игрок!");
                }
                if (button1.Text == "X" && button6.Text == "X" && button9.Text == "X")
                {
                    timer1.Stop();
                    label1.Text = "Игра закончилась";
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
                    MessageBox.Show("Победил игрок!");
                }
                if (button2.Text == "X" && button5.Text == "X" && button8.Text == "X")
                {
                    timer1.Stop();
                    label1.Text = "Игра закончилась";
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
                    MessageBox.Show("Победил игрок!");
                }
                if (button3.Text == "X" && button4.Text == "X" && button7.Text == "X")
                {
                    timer1.Stop();
                    label1.Text = "Игра закончилась";
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
                    MessageBox.Show("Победил игрок!");
                }
                if (button1.Text == "X" && button5.Text == "X" && button7.Text == "X")
                {
                    timer1.Stop();
                    label1.Text = "Игра закончилась";
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
                    MessageBox.Show("Победил игрок!");
                }
                if (button3.Text == "X" && button5.Text == "X" && button9.Text == "X")
                {
                    timer1.Stop();
                    label1.Text = "Игра закончилась";
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
                    MessageBox.Show("Победил игрок!");
                }
            }
            else if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")
            {
                timer1.Stop();
                label1.Text = "Игра закончилась";
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
                MessageBox.Show("Ничья!");
            }
            if (textBox1.Text == "Первым ходит бот")
            {
                if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O")
                {
                    timer1.Stop();
                    label1.Text = "Игра закончилась";
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
                    MessageBox.Show("Победил игрок!");
                }
                if (button6.Text == "O" && button5.Text == "O" && button4.Text == "O")
                {
                    timer1.Stop();
                    label1.Text = "Игра закончилась";
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
                    MessageBox.Show("Победил игрок!");
                }
                if (button9.Text == "O" && button8.Text == "O" && button7.Text == "O")
                {
                    timer1.Stop();
                    label1.Text = "Игра закончилась";
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
                    MessageBox.Show("Победил игрок!");
                }
                if (button1.Text == "O" && button6.Text == "O" && button9.Text == "O")
                {
                    timer1.Stop();
                    label1.Text = "Игра закончилась";
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
                    MessageBox.Show("Победил игрок!");
                }
                if (button2.Text == "O" && button5.Text == "O" && button8.Text == "O")
                {
                    timer1.Stop();
                    label1.Text = "Игра закончилась";
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
                    MessageBox.Show("Победил игрок!");
                }
                if (button3.Text == "O" && button4.Text == "O" && button7.Text == "O")
                {
                    timer1.Stop();
                    label1.Text = "Игра закончилась";
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
                    MessageBox.Show("Победил игрок!");
                }
                if (button1.Text == "O" && button5.Text == "O" && button7.Text == "O")
                {
                    timer1.Stop();
                    label1.Text = "Игра закончилась";
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
                    MessageBox.Show("Победил игрок!");
                }
                if (button3.Text == "O" && button5.Text == "O" && button9.Text == "O")
                {
                    timer1.Stop();
                    label1.Text = "Игра закончилась";
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
                    MessageBox.Show("Победил игрок!");
                }
            }
            else if (button1.Text != "" && button2.Text != "" && button3.Text != "" && button4.Text != "" && button5.Text != "" && button6.Text != "" && button7.Text != "" && button8.Text != "" && button9.Text != "")            
            {
                timer1.Stop();
                label1.Text = "Игра закончилась";
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
                MessageBox.Show("Ничья!");
            }    
        }
    }
}