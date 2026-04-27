using matrix4;
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

namespace matrix4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        double determinant, xDet, yDet, zDet, wDet;
        matrix4 mat = new matrix4();

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

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
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

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

           


            
            double a1 = Convert.ToDouble(textBox1.Text);
            double b1 = Convert.ToDouble(textBox2.Text);
            double c1 = Convert.ToDouble(textBox3.Text);
            double d1 = Convert.ToDouble(textBox4.Text);
            double res1 = Convert.ToDouble(textBox5.Text);

          
            double a2 = Convert.ToDouble(textBox6.Text);
            double b2 = Convert.ToDouble(textBox7.Text);
            double c2 = Convert.ToDouble(textBox8.Text);
            double d2 = Convert.ToDouble(textBox9.Text);
            double res2 = Convert.ToDouble(textBox10.Text);

        
            double a3 = Convert.ToDouble(textBox11.Text);
            double b3 = Convert.ToDouble(textBox12.Text);
            double c3 = Convert.ToDouble(textBox13.Text);
            double d3 = Convert.ToDouble(textBox14.Text);
            double res3 = Convert.ToDouble(textBox15.Text);

            double a4 = Convert.ToDouble(textBox16.Text);
            double b4 = Convert.ToDouble(textBox17.Text);
            double c4 = Convert.ToDouble(textBox18.Text);
            double d4 = Convert.ToDouble(textBox19.Text);
            double res4 = Convert.ToDouble(textBox20.Text);

            
            determinant = mat.matrix4x4(a1, b1, c1, d1, a2, b2, c2, d2, a3, b3, c3, d3, a4, b4, c4, d4);

         
            xDet = mat.matrix4x4(res1, b1, c1, d1, res2, b2, c2, d2, res3, b3, c3, d3, res4, b4, c4, d4);
            yDet = mat.matrix4x4(a1, res1, c1, d1, a2, res2, c2, d2, a3, res3, c3, d3, a4, res4, c4, d4);
            zDet = mat.matrix4x4(a1, b1, res1, d1, a2, b2, res2, d2, a3, b3, res3, d3, a4, b4, res4, d4);
            wDet = mat.matrix4x4(a1, b1, c1, res1, a2, b2, c2, res2, a3, b3, c3, res3, a4, b4, c4, res4);

           
                listBox1.Items.Add(xDet / determinant);
                listBox2.Items.Add(yDet / determinant);
                listBox3.Items.Add(zDet / determinant);
                listBox4.Items.Add(wDet / determinant);
           
        }
    
    }
}
