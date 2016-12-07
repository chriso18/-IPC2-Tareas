using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hoja_de_Trabajo_1
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


        public void Metodo1() 
        {
            double x1, x2;

            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);

            if (String.IsNullOrWhiteSpace(textBox1.Text) || String.IsNullOrWhiteSpace(textBox2.Text) || String.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Dejo algunos campos en Blanco");
            }

            else
            {
                double resultado = Math.Pow(b, 2) * (4 * a * c);

                a = a * 2;
                if (Math.Sign(resultado) == -1)
                {
                    resultado = (Math.Sqrt(-resultado)) / a;
                    x1 = -b / a;
                    textBox4.Text = x1 + "-" + resultado.ToString();
                    textBox5.Text = x1 + "+" + resultado.ToString();

                }
                else
                {
                    resultado = Math.Sqrt(resultado);
                    x1 = (-b - resultado) / a;
                    x2 = (-b + resultado) / a;

                    textBox4.Text = x1 + "-" + resultado.ToString();
                    textBox5.Text = x2 + "+" + resultado.ToString();
                }
            }
        }

        public void Metodo2()
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);

            if (String.IsNullOrWhiteSpace(textBox1.Text) || String.IsNullOrWhiteSpace(textBox2.Text) || String.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Dejo algunos campos en Blanco");
            }

            else
            {

                double resultado = Math.Sqrt(a) + b - c;

                textBox4.Text = resultado.ToString();
            }
        }

        public void Metodo3()
        {
            //pitagoras
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);

            if (String.IsNullOrWhiteSpace(textBox1.Text) || String.IsNullOrWhiteSpace(textBox2.Text) || String.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Dejo algunos campos en Blanco");
            }

            else
            {

                double resultado = Math.Sqrt((a * a) + (b * b));

                textBox4.Text = resultado.ToString();
                textBox5.Text = "201213326";
            }
        }

        public void Metodo4()
        {

            //pitagoras
            int c = Convert.ToInt32(textBox1.Text);
            int a = Convert.ToInt32(textBox2.Text);

            if (String.IsNullOrWhiteSpace(textBox1.Text) || String.IsNullOrWhiteSpace(textBox2.Text) || String.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Dejo algunos campos en Blanco");
            }

            else
            {

                double resultado = Math.Sqrt((c * c) - (a * a));

                textBox4.Text = resultado.ToString();

            }
        }
        

        private void Operacion1_Click(object sender, EventArgs e)
        {
            Metodo1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
        }

        private void Operacion2_Click(object sender, EventArgs e)
        {
            Metodo2();
        }

        private void Operacion3_Click(object sender, EventArgs e)
        {
            Metodo3();
        }

        private void Operacion4_Click(object sender, EventArgs e)
        {
            Metodo4();
        }


    }
}
