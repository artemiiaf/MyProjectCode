using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace вордли
{
    public partial class Form1 : Form
    {
       double a;
       double b;
        double v;


        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            double c = a + b;
            
            
           ответ.Items.Add(c);

           

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)

        {
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            double с = a - b;
            ответ.Items.Add(с);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            double с = a * b;
            ответ.Items.Add(с);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            double с = a / b;
            ответ.Items.Add(с);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                string str = textBox1.Text;
                str = str + 9;
                textBox1.Text = str.ToString();


            }
            else
            {
                string str = textBox2.Text;
                str = str + 9;
                textBox2.Text = str.ToString();
            }
            }

        private void button6_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                string str = textBox1.Text;
                str = str + 8;
                textBox1.Text = str.ToString();


            }
            else
            {
                string str = textBox2.Text;
                str = str + 8;
                textBox2.Text = str.ToString();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                string str = textBox1.Text;
                str = str + 7;
                textBox1.Text = str.ToString();


            }
            else
            {
                string str = textBox2.Text;
                str = str + 7;
                textBox2.Text = str.ToString();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                string str = textBox1.Text;
                str = str + 6;
                textBox1.Text = str.ToString();


            }
            else
            {
                string str = textBox2.Text;
                str = str + 6;
                textBox2.Text = str.ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                string str = textBox1.Text;
                str = str + 5;
                textBox1.Text = str.ToString();


            }
            else
            {
                string str = textBox2.Text;
                str = str + 5;
                textBox2.Text = str.ToString();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                string str = textBox1.Text;
                str = str + 4;
                textBox1.Text = str.ToString();


            }
            else
            {
                string str = textBox2.Text;
                str = str + 4;
                textBox2.Text = str.ToString();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                string str = textBox1.Text;
                str = str + 3;
                textBox1.Text = str.ToString();


            }
            else
            {
                string str = textBox2.Text;
                str = str + 3;
                textBox2.Text = str.ToString();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                string str = textBox1.Text;
                str = str + 2;
                textBox1.Text = str.ToString();


            }
            else
            {
                string str = textBox2.Text;
                str = str + 2;
                textBox2.Text = str.ToString();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                string str = textBox1.Text;
                str = str + 1;
                textBox1.Text = str.ToString();


            }
            else
            {
                string str = textBox2.Text;
                str = str + 1;
                textBox2.Text = str.ToString();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                string str = textBox1.Text;
                str = str + 0;
                textBox1.Text = str.ToString();


            }
            else
            {
                string str = textBox2.Text;
                str = str + 0;
                textBox2.Text = str.ToString();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {

            a = Convert.ToDouble(textBox1.Text);
            int factorial = 1;
            
            for (int i = 1; i <= a; i++)
            {
                factorial = factorial * i;
            }
            ответ.Items.Add(factorial);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);

            double c = Math.Sqrt(a);

            ответ.Items.Add(c);
        }

        private void ответ_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            ответ.Items.Clear();
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
