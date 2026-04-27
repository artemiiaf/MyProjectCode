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

namespace быстр_печать
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> myArr = new List<string>
            {
            "дима",
            "Саша",
            "Костя",
            "богдан",
            "Никита",
            "артем",
            "Даша",
            "гоша",
            "артур",
            "семен",
            };
            Random rand = new Random();
            for (int i = myArr.Count; i > 0; i--)
            {
                int flag = rand.Next(myArr.Count);
                label1.Text = (myArr[flag]);
                myArr.RemoveAt(flag);
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = String.Empty;
            
        }
    }
}



//if( саша = саша)
//{
//    plus = plus + 1;
//}
//else
//{
//    minys = minys + 1;
//}