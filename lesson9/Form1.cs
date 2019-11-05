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
            Random R = new Random();
            int[,] mass= new int[5,3];
            int max = 0,
                flag = 0,
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
            
            richTextBox1.Text += "максимальная сумма в " + (flag+1) + " строке \n";
            for (int j = 0; j < 3; j++)
            {
                richTextBox1.Text += mass[flag,j] + " ";
            }
        }
    }
}
