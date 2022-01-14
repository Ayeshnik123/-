using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Крестики_нолики
{
    class Bot
    {
        public static void Hod(Button button1, Button button2, Button button3, Button button4, Button button5, Button button6, Button button7, Button button8, Button button9, TextBox textBox1, int rastanovka)
        {
            if (textBox1.Text == "Первым ходит бот")
            {
                Random rand = new Random();
                for (int i = 0; i < 1; i++)
                {
                    rastanovka = rand.Next(1, 10);
                    /*switch (rastanovka)
                    {
                        case (1):
                            if (button1.Text == "") button1.Text = "X";
                            break;
                        case (2):
                            if (button2.Text == "") button2.Text = "X";
                            break;
                        case (3):
                            if (button3.Text == "") button3.Text = "X";
                            break;
                        case (4):
                            if (button4.Text == "") button4.Text = "X";
                            break;
                        case (5):
                            if (button5.Text == "") button5.Text = "X";
                            break;
                        case (6):
                            if (button6.Text == "") button6.Text = "X";
                            break;
                        case (7):
                            if (button7.Text == "") button7.Text = "X";
                            break;
                        case (8):
                            if (button8.Text == "") button8.Text = "X";
                            break;
                        case (9):
                            if (button9.Text == "") button9.Text = "X";
                            break;
                    }*/
                }
            }
        }
    }
}