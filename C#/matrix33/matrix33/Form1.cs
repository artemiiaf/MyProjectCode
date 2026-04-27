using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrix33
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
        double zDeterminant;

        matrix3 mat = new matrix3();

        private void button1_Click(object sender, EventArgs e)
        {
            double x1 = Convert.ToDouble(textBox1.Text);
            double b1 = Convert.ToDouble(textBox2.Text);
            double z1 = Convert.ToDouble(textBox3.Text);
            double x2 = Convert.ToDouble(textBox4.Text);
            double b2 = Convert.ToDouble(textBox5.Text);
            double z2 = Convert.ToDouble(textBox6.Text);
            double x3 = Convert.ToDouble(textBox7.Text);
            double b3 = Convert.ToDouble(textBox8.Text);
            double z3 = Convert.ToDouble(textBox9.Text);
            double c1 = Convert.ToDouble(textBox10.Text);
            double c2 = Convert.ToDouble(textBox11.Text);
            double c3 = Convert.ToDouble(textBox12.Text);


            determinant = mat.matrix(x1, x2, x3, b1, b2, b3, z1, z2, z3);
            xDeterminant = mat.matrix(c1, c2, c3, b1, b2, b3, z1, z2, z3);
            yDeterminant = mat.matrix(x1, x2, x3, c1, c2, c3, z1, z2, z3);
            zDeterminant = mat.matrix(x1, x2, x3, b1, b2, b3, c1, c2, c3);

            listBox1.Items.Add(xDeterminant / determinant);

            listBox2.Items.Add(yDeterminant / determinant);

            listBox3.Items.Add(zDeterminant / determinant);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
