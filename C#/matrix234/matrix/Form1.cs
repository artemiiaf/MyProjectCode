using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matrix
{
    public partial class Form1 : Form
    {
        List<List<int>> deleteRowAndCol(List<List<int>> matrix, int row, int col)
        {
            List<List<int>> output = new List<List<int>>();
            for (int i = 0; i < matrix.Count(); i++)
            {
                if (i != row)
                {
                    List<int> empty_vect = new List<int>();
                    output.Add(empty_vect);
                    for (int j = 0; j < matrix[i].Count(); j++)
                    {
                        if (j != col)
                        {
                            output[i > row ? i - 1 : i].Add(matrix[i][j]);
                        }
                    }
                }
            }
            return output;
        }
        double determinateRecur(List<List<int>> matrix)
        {
            double output = 0;
            if (matrix.Count() == 2)
            {
                return matrix[0][0] * matrix[1][1] - matrix[1][0] * matrix[0][1]; // базовый случай - двумерная матрица второго порядка
            }
            // матрицы высших порядков обрабатываются тут:
            else
            {
                for (int j = 0; j < matrix[0].Count(); j++)
                {
                    output += (Math.Pow(-1, 2 + j)) * matrix[0][j] * determinateRecur(deleteRowAndCol(matrix, 0, j)); // реккурентная формула вида ((-1)^(n+m)) * M(n, m) * det(minorM(n, m)) + ...

                }
            }
            return output;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void a2btn_Click(object sender, EventArgs e)
        {
            List<List<int>> matrix = new List<List<int>>();

            matrix.Add( new List<int> () {Convert.ToInt32(a211.Text), Convert.ToInt32(a212.Text) } );
            matrix.Add(new List<int>() { Convert.ToInt32(a221.Text), Convert.ToInt32(a222.Text) });

            List<List<int>> xmatrix = new List<List<int>>();

            xmatrix.Add(new List<int>() { Convert.ToInt32(a21r.Text), Convert.ToInt32(a212.Text) });
            xmatrix.Add(new List<int>() { Convert.ToInt32(a22r.Text), Convert.ToInt32(a222.Text) });

            List<List<int>> ymatrix = new List<List<int>>();

            ymatrix.Add(new List<int>() { Convert.ToInt32(a211.Text), Convert.ToInt32(a21r.Text) });
            ymatrix.Add(new List<int>() { Convert.ToInt32(a221.Text), Convert.ToInt32(a22r.Text) });


            a2out.Text = Convert.ToString(determinateRecur(xmatrix) / determinateRecur(matrix));
            label1.Text = Convert.ToString(determinateRecur(ymatrix) / determinateRecur(matrix));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<List<int>> matrix = new List<List<int>>();

            matrix.Add(new List<int>() { Convert.ToInt32(a311.Text), Convert.ToInt32(a312.Text), Convert.ToInt32(a313.Text) });
            matrix.Add(new List<int>() { Convert.ToInt32(a321.Text), Convert.ToInt32(a322.Text), Convert.ToInt32(a323.Text) });
            matrix.Add(new List<int>() { Convert.ToInt32(a331.Text), Convert.ToInt32(a332.Text), Convert.ToInt32(a333.Text) });

            List<List<int>> xmatrix = new List<List<int>>();

            xmatrix.Add(new List<int>() { Convert.ToInt32(a31r.Text), Convert.ToInt32(a312.Text), Convert.ToInt32(a313.Text) });
            xmatrix.Add(new List<int>() { Convert.ToInt32(a32r.Text), Convert.ToInt32(a322.Text), Convert.ToInt32(a323.Text) });
            xmatrix.Add(new List<int>() { Convert.ToInt32(a33r.Text), Convert.ToInt32(a332.Text), Convert.ToInt32(a333.Text) });

            List<List<int>> ymatrix = new List<List<int>>();

            ymatrix.Add(new List<int>() { Convert.ToInt32(a311.Text), Convert.ToInt32(a31r.Text), Convert.ToInt32(a313.Text) });
            ymatrix.Add(new List<int>() { Convert.ToInt32(a321.Text), Convert.ToInt32(a32r.Text), Convert.ToInt32(a323.Text) });
            ymatrix.Add(new List<int>() { Convert.ToInt32(a331.Text), Convert.ToInt32(a33r.Text), Convert.ToInt32(a333.Text) });

            List<List<int>> zmatrix = new List<List<int>>();

            zmatrix.Add(new List<int>() { Convert.ToInt32(a311.Text), Convert.ToInt32(a312.Text), Convert.ToInt32(a31r.Text) });
            zmatrix.Add(new List<int>() { Convert.ToInt32(a321.Text), Convert.ToInt32(a322.Text), Convert.ToInt32(a32r.Text) });
            zmatrix.Add(new List<int>() { Convert.ToInt32(a331.Text), Convert.ToInt32(a332.Text), Convert.ToInt32(a33r.Text) });


            x3out.Text = Convert.ToString(determinateRecur(xmatrix) / determinateRecur(matrix));
            y3out.Text = Convert.ToString(determinateRecur(ymatrix) / determinateRecur(matrix));
            z3out.Text = Convert.ToString(determinateRecur(zmatrix) / determinateRecur(matrix));
        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {

        }

        private void m4btn_Click(object sender, EventArgs e)
        {
            List<List<int>> matrix = new List<List<int>>();

            matrix.Add(new List<int>() { Convert.ToInt32(a411.Text), Convert.ToInt32(a412.Text), Convert.ToInt32(a413.Text), Convert.ToInt32(a414.Text) });
            matrix.Add(new List<int>() { Convert.ToInt32(a421.Text), Convert.ToInt32(a422.Text), Convert.ToInt32(a423.Text), Convert.ToInt32(a424.Text) });
            matrix.Add(new List<int>() { Convert.ToInt32(a431.Text), Convert.ToInt32(a432.Text), Convert.ToInt32(a433.Text), Convert.ToInt32(a434.Text) });
            matrix.Add(new List<int>() { Convert.ToInt32(a441.Text), Convert.ToInt32(a442.Text), Convert.ToInt32(a443.Text), Convert.ToInt32(a444.Text) });

            List<List<int>> xmatrix = new List<List<int>>();

            xmatrix.Add(new List<int>() { Convert.ToInt32(a41r.Text), Convert.ToInt32(a442.Text), Convert.ToInt32(a413.Text), Convert.ToInt32(a414.Text) });
            xmatrix.Add(new List<int>() { Convert.ToInt32(a42r.Text), Convert.ToInt32(a422.Text), Convert.ToInt32(a423.Text), Convert.ToInt32(a424.Text) });
            xmatrix.Add(new List<int>() { Convert.ToInt32(a43r.Text), Convert.ToInt32(a432.Text), Convert.ToInt32(a433.Text), Convert.ToInt32(a434.Text) });
            xmatrix.Add(new List<int>() { Convert.ToInt32(a441.Text), Convert.ToInt32(a442.Text), Convert.ToInt32(a443.Text), Convert.ToInt32(a444.Text) });

            List<List<int>> ymatrix = new List<List<int>>();

            ymatrix.Add(new List<int>() { Convert.ToInt32(a411.Text), Convert.ToInt32(a41r.Text), Convert.ToInt32(a413.Text), Convert.ToInt32(a414.Text) });
            ymatrix.Add(new List<int>() { Convert.ToInt32(a421.Text), Convert.ToInt32(a42r.Text), Convert.ToInt32(a423.Text), Convert.ToInt32(a424.Text) });
            ymatrix.Add(new List<int>() { Convert.ToInt32(a431.Text), Convert.ToInt32(a43r.Text), Convert.ToInt32(a433.Text), Convert.ToInt32(a434.Text) });
            ymatrix.Add(new List<int>() { Convert.ToInt32(a441.Text), Convert.ToInt32(a44r.Text), Convert.ToInt32(a443.Text), Convert.ToInt32(a444.Text) });

            List<List<int>> zmatrix = new List<List<int>>();

            zmatrix.Add(new List<int>() { Convert.ToInt32(a411.Text), Convert.ToInt32(a412.Text), Convert.ToInt32(a41r.Text), Convert.ToInt32(a414.Text) });
            zmatrix.Add(new List<int>() { Convert.ToInt32(a421.Text), Convert.ToInt32(a422.Text), Convert.ToInt32(a42r.Text), Convert.ToInt32(a424.Text) });
            zmatrix.Add(new List<int>() { Convert.ToInt32(a431.Text), Convert.ToInt32(a432.Text), Convert.ToInt32(a43r.Text), Convert.ToInt32(a434.Text) });
            zmatrix.Add(new List<int>() { Convert.ToInt32(a441.Text), Convert.ToInt32(a442.Text), Convert.ToInt32(a44r.Text), Convert.ToInt32(a444.Text) });


            List<List<int>> amatrix = new List<List<int>>();

            amatrix.Add(new List<int>() { Convert.ToInt32(a411.Text), Convert.ToInt32(a412.Text), Convert.ToInt32(a413.Text), Convert.ToInt32(a41r.Text) });
            amatrix.Add(new List<int>() { Convert.ToInt32(a421.Text), Convert.ToInt32(a422.Text), Convert.ToInt32(a423.Text), Convert.ToInt32(a42r.Text) });
            amatrix.Add(new List<int>() { Convert.ToInt32(a431.Text), Convert.ToInt32(a432.Text), Convert.ToInt32(a433.Text), Convert.ToInt32(a43r.Text) });
            amatrix.Add(new List<int>() { Convert.ToInt32(a441.Text), Convert.ToInt32(a442.Text), Convert.ToInt32(a443.Text), Convert.ToInt32(a44r.Text) });



            x4out.Text = Convert.ToString(determinateRecur(xmatrix) / determinateRecur(matrix));
            y4out.Text = Convert.ToString(determinateRecur(ymatrix) / determinateRecur(matrix));
            z4out.Text = Convert.ToString(determinateRecur(zmatrix) / determinateRecur(matrix));
            a4out.Text = Convert.ToString(determinateRecur(amatrix) / determinateRecur(matrix));

        }
    }
}
