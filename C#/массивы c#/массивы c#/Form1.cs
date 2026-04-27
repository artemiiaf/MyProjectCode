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

namespace массивы_c_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double[] x = { -1.5, 0.1, 12, 0, -2.2, 0.5, -1, 0.3 };

            double minEl = x[0];
            double maxEl = x[0];

            for (int i = 1; i < 7; i++)
            {
                if (minEl > x[i])
                {
                    minEl = x[i];
                }
            }
            for (int i = 0; i < 7; i++)
            {
                if (x[i] < 0)
                {
                    x[i] = minEl;

                }
            }
            for (int i = 1; i < 7; i++)
            {
                if (maxEl < x[i])
                {
                    maxEl = x[i];
                }
            }
            for (int i = 0; i < 7; i++)
            {
                if (x[i] > 0)
                {
                    x[i] = maxEl;

                }
            }
            for (int i = 0; i < 7; i++)
            {
                if (x[i] > 0)
                {
                    x[i] = maxEl;

                }
                
            }

        }
       

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
