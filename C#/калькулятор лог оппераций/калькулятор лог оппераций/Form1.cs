using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace калькулятор_лог_оппераций
{
    public partial class Form1 : Form
    {


        int[] a = { 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1 };
        int[] b = { 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 1, 1, 1, 1 };
        int[] c = { 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1 };
        int[] d = { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 };



        int[] _a = new int[16];
        int[] _b = new int[16];
        int[] _c = new int[16];
        int[] _d = new int[16];



        int[] aub = new int[16];
        int[] anb = new int[16];
        int[] aBb = new int[16];
        int[] aUBb = new int[16];

        int[] auc = new int[16];
        int[] anc = new int[16];
        int[] aBc = new int[16];
        int[] aUBc = new int[16];

        int[] aud = new int[16];
        int[] and = new int[16];
        int[] aBd = new int[16];
        int[] aUBd = new int[16];

        int[] buc = new int[16];
        int[] bnc = new int[16];
        int[] bBc = new int[16];
        int[] bUBc = new int[16];

        int[] bud = new int[16];
        int[] bnd = new int[16];
        int[] bBd = new int[16];
        int[] bUBd = new int[16];

        int[] cud = new int[16];
        int[] cnd = new int[16];
        int[] cBd = new int[16];
        int[] cUBd = new int[16];


        string aas = "...";
        string bbs = "...";
        string ccs = "...";
        string dds = "...";



        public Form1()
        {
            InitializeComponent();
        }

        private void listBox25_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label131_Click(object sender, EventArgs e)
        {

        }

        private void label128_Click(object sender, EventArgs e)
        {

        }

        private void label130_Click(object sender, EventArgs e)
        {

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void label129_Click(object sender, EventArgs e)
        {

        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {

        }

        static int checkElement(int i)
        {
            if (i > 1)
            {
                i = 1;
            }
            return i;
        }

        static int revers(int i)
        {
            if (i < 1)
            {
                i = 1;
            }
            else
            {
                i = 0;
            }
            return i;
        }


        public int both(int a, int b, int ab)
        {
            if (a == b)
            {
                ab = 1;
            }
            else
            {
                ab = 0;
            }

            return ab;
        }

        public int unboth(int a, int b, int ab)
        {
            if (a == b)
            {
                ab = 0;
            }
            else
            {
                ab = 1;
            }

            return ab;
        }

        public int equally(int a, int b, int ab)
        {

            if (a == 1 && b == 1)
            {
                ab = 1;
            }
            else
            {
                ab = 0;
            }
            return ab;
        }








        private void button2_Click(object sender, EventArgs e)
        {


            button2.BackColor = Color.Pink;



            int aa = Convert.ToInt32(textBox26.Text);
            int bb = Convert.ToInt32(textBox24.Text);
            int cc = Convert.ToInt32(textBox31.Text);
            int dd = Convert.ToInt32(textBox30.Text);




            string aasw = Err(aa, aas);
            string bbsw = Err(bb, aas);
            string ccsw = Err(cc, aas);
            string ddsw = Err(dd, aas);



            int _aa = revers(aa);
            int _bb = revers(bb);
            int _cc = revers(cc);
            int _dd = revers(dd);

            textBox29.Text = _aa.ToString();
            textBox30.Text = _bb.ToString();
            textBox31.Text = _cc.ToString();
            textBox1.Text = _dd.ToString();


            int aaubb = checkElement(aa + bb);
            int aaucc = checkElement(aa + cc);
            int aaudd = checkElement(aa + dd);
            int bbucc = checkElement(bb + cc);
            int bbudd = checkElement(bb + dd);
            int ccudd = checkElement(cc + dd);

            textBox5.Text = aaubb.ToString();
            textBox9.Text = aaucc.ToString();
            textBox13.Text = aaudd.ToString();
            textBox17.Text = bbucc.ToString();
            textBox21.Text = bbucc.ToString();
            textBox25.Text = ccudd.ToString();


            int aanbb = 0;
            int aancc = 0;
            int aandd = 0;
            int bbncc = 0;
            int bbndd = 0;
            int ccndd = 0;

            aanbb = equally(aa, bb, aanbb);
            aancc = equally(aa, bb, aancc);
            aandd = equally(aa, bb, aandd);
            bbncc = equally(aa, bb, bbncc);
            bbndd = equally(aa, bb, bbndd);
            ccndd = equally(aa, bb, ccndd);

            textBox6.Text = aanbb.ToString();
            textBox6.Text = aaubb.ToString();
            textBox10.Text = aancc.ToString();
            textBox2.Text = aandd.ToString();
            textBox18.Text = bbncc.ToString();
            textBox22.Text = bbncc.ToString();
            textBox26.Text = ccndd.ToString();


            int aaBbb = 0;
            int aaBcc = 0;
            int aaBdd = 0;
            int bbBcc = 0;
            int bbBdd = 0;
            int ccBdd = 0;

            aaBbb = both(aa, bb, aaBbb);
            aaBcc = both(aa, bb, aaBcc);
            aaBdd = both(aa, bb, aaBdd);
            bbBcc = both(aa, bb, bbBcc);
            bbBdd = both(aa, bb, bbBdd);
            ccBdd = both(aa, bb, ccBdd);

            textBox7.Text = aaBbb.ToString();
            textBox11.Text = aaBcc.ToString();
            textBox3.Text = aaBdd.ToString();
            textBox19.Text = bbBcc.ToString();
            textBox23.Text = bbBdd.ToString();
            textBox27.Text = ccBdd.ToString();


            int aaUBbb = 0;
            int aaUBcc = 0;
            int aaUBdd = 0;
            int bbUBcc = 0;
            int bbUBdd = 0;
            int ccUBdd = 0;

            aaUBbb = unboth(aa, bb, aaUBbb);
            aaUBcc = unboth(aa, bb, aaUBcc);
            aaUBdd = unboth(aa, bb, aaUBdd);
            bbUBcc = unboth(aa, bb, bbUBcc);
            bbUBdd = unboth(aa, bb, bbUBdd);
            ccUBdd = unboth(aa, bb, ccUBdd);

            textBox8.Text = aaUBbb.ToString();
            textBox12.Text = aaUBcc.ToString();
            textBox4.Text = aaUBdd.ToString();
            textBox20.Text = bbUBcc.ToString();
            textBox24.Text = bbUBdd.ToString();
            textBox28.Text = ccUBdd.ToString();

        }


        static string Err(int i, string Er)
        {
            if (i >= 2)
            {
                Er = "wrong";
            }
            else
            {
                Er = "...";
            }
            return Er;
        }






        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



    }
}

    

