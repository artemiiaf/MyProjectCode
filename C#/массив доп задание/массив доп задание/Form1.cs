using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace массив_доп_задание
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {            
             int n = textBox1.Lines.Count();
            double[] x = new double[n];
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = double.Parse(textBox1.Lines[i]);
                
            }

            double minEl = x[0];
            double maxEl = x[0];

            for (int i = 1; i < x.Length; i++)
            {
                if (minEl > x[i])
                {
                    minEl = x[i];
                }
            }
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] < 0)
                {
                    x[i] = minEl;

                }
            }
            for (int i = 1; i < x.Length; i++)
            {
                if (maxEl < x[i])
                {
                    maxEl = x[i];
                }
            }
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] > 0)
                {
                    x[i] = maxEl;

                }
            }
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] > 0)
                {
                    x[i] = maxEl;

                }
                listBox1.Items.Add(x[i]);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
