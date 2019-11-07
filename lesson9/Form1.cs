using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lesson9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            Random R = new Random();
            int[,] mass= new int[5,3];
            int max = 0,
                flag = 0,
                flag2 = 0,
                sum = 0;
            for(int i = 0; i < 5; i++)
            {
                sum = 0;
                for(int j = 0; j < 3; j++)
                {
                    mass[i, j] = R.Next(10,100);
                    richTextBox1.Text += mass[i,j] + "    ";
                    sum += mass[i,j];
                    
                }
                if(sum > max)
                {
                    max = sum;
                    flag = i;
                }
                
                richTextBox1.Text += "\n";
            }
            for (int j = 0; j < 3; j++)
            {
                sum = 0;
                for (int i = 0; i < 5; i++)
                {
                   
                    sum += mass[i, j];

                }
                if (sum > max)
                {
                    max = sum;
                    flag2 = j;
                }
            }

            richTextBox1.Text += "максимальная сумма в " + (flag+1) + " строке \n";
            for (int j = 0; j < 3; j++)
            {
                richTextBox1.Text += mass[flag,j] + " ";
            }
            richTextBox1.Text += "\nмаксимальная сумма в " + (flag2 + 1) + " сталбце \n";
            for (int i = 0; i < 5; i++)
            {
                richTextBox1.Text += mass[i, flag2] + "\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            Random R = new Random();
            int[,] mass = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    mass[i, j] = R.Next(10, 100);
                    richTextBox1.Text += mass[i, j] + "    ";
                }

                richTextBox1.Text += "\n\n";
            }
            for(int igor = 0; igor < 5;igor++)
            {
                int Box = mass[0, igor];
                mass[0, igor] = mass[4, igor];
                mass[4, igor] = Box;
            }
            for(int lal = 0; lal < 5;lal++)
            {
                for(int lalka = 0; lalka < 5; lalka++)
                {
                    richTextBox2.Text += mass[lal, lalka] + "   ";
                }
                richTextBox2.Text += "\n\n";
            }
            richTextBox1.Text += "сумма в 1-ой диогонале = " + (mass[0,0] + mass[1, 1] + mass[2, 2] + mass[3, 3] + mass[4, 4]) +"\n";
            richTextBox1.Text += "сумма во 2-ой диогонале = " + (mass[0, 4] + mass[1, 3] + mass[2, 2] + mass[3, 1] + mass[4, 0]);
        }
    }
}
