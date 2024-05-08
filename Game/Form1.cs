using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int number = 0;
        int guesses = 0;
        public Form1()
        {
            InitializeComponent();
            loadQuestion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(textBox1.Text);
                guesses += 1;
                if (i == number)
                {
                    label4.Text = Convert.ToString(number);
                    label3.Text = "Congratulations You Have Guessed In " + guesses + " Times";
                    MessageBox.Show("Congratulations You Guessed");
                    loadQuestion();
                    textBox1.Text = "";
                    guesses = 0;
                textBox1.Select();
                }
                else if (i > number)
                {
                textBox1.Text = "";
                    MessageBox.Show("Hint For Go Through Lower Number");
                textBox1.Select();
            }
                else
                {
                textBox1.Text = "";
                MessageBox.Show("Hint For Go Through Higher Number");
                textBox1.Select();
            }

        }

        private void loadQuestion()
        {
            number = random.Next(1, 20);
            label1.Text = "Guess The Number Between 1 to 20";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            label4.Text = "**";
            loadQuestion();
            textBox1.Select();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
