using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace matrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double determinant;
        double xDeterminant;
        double yDeterminant;

        matrix2 mat = new matrix2();


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            double x1 = Convert.ToDouble(textBox1.Text);
            double b1 = Convert.ToDouble(textBox2.Text);
            double x2 = Convert.ToDouble(textBox3.Text);
            double b2 = Convert.ToDouble(textBox4.Text);
            double c1 = Convert.ToDouble(textBox5.Text);
            double c2 = Convert.ToDouble(textBox6.Text);
            
             
            determinant = mat.matrix(x1, x2, b1, b2);
            xDeterminant = mat.matrix(c1, c2, b1, b2);
            yDeterminant = mat.matrix(x1, x2, c1, c2);

            listBox1.Items.Add(xDeterminant / determinant);

            listBox2.Items.Add(yDeterminant / determinant);
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
