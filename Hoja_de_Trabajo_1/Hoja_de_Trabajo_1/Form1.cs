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

            double resultado = Math.Pow(b, 2) * (4 * a * c);

            a = a * 2;
            if(Math.Sign(resultado)== -1)
            {
                resultado = (Math.Sqrt(-resultado))/a;
                x1 = -b / a;
                textBox4.Text = x1 + "-" + resultado.ToString();
                textBox5.Text = x1 + "+" + resultado.ToString();

            }
            else
            {
                resultado = Math.Sqrt(resultado);
                x1= (-b - resultado)/a;
                x2= (-b + resultado)/a;
            }
           
        }

        public void Metodo2()
        {
            
        }

        public void Metodo3()
        {




        }

        public void Metodo4()
        {




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
