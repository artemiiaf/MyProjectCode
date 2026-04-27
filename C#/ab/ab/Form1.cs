using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace ab
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int[] a;
            int[] b = { 1,2,3,5,6 };
            int r = 0;

            int n = textBox1.Lines.Count();
            a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(textBox1.Lines[i]);
            }


            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {

                    if (a[i] == b[i])
                    {
                        break;
                    }
                    if (j == b.Length - 1)
                    {
                        break;  
                    }

                }

            }
            int[] c = new int[r];


            string str = "";

            for(int i = 0; i < a.Length; i++)
            {
                str +=  c[i] + " ";
            }

            textBox1.Text = str;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
