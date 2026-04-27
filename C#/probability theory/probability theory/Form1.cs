using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace probability_theory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);


            double result = a / b;

            listBox1.Items.Add(result);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] stringArray = textBox4.Text.Split(new char[] { ' ' });

            int[] numbers = new int[stringArray.Length];

            for (int i = 0; i < stringArray.Length; i++)
            {
                numbers[i] = Convert.ToInt32(stringArray[i]);
            }

            
            foreach (int x in numbers)
            {
                foreach (int y in numbers)
                {
                    if (x != y) 
                    {   
                        listBox2.Items.Add($"{x} {y}");
                    }
                }
            }
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox5.Text);
            int m = Convert.ToInt32(textBox6.Text);


            int faktorialN = 1;
            for (int i = 1; i <= n; i++)
            {
                faktorialN = faktorialN * i;
            }


            int faktorialNM = 1;
            for (int i = 1; i <= n - m; i++)
            {
                faktorialNM = faktorialNM * i;
            }

            int result = faktorialN / faktorialNM;

            listBox3.Items.Add(result);

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox3.Text);
            int k = Convert.ToInt32(textBox7.Text);
            double p = Convert.ToInt32(textBox8.Text);
            double q = Convert.ToInt32(textBox9.Text) - p;

           
            double combinations = n*k; 

           
            double result = combinations * Math.Pow(p, k) * Math.Pow(q, n - k);

            listBox4.Items.Add(result);

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
            
