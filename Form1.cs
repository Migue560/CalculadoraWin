using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraWin
{
    public partial class Form1 : Form
    {
        double dato1;
        double dato2;
        String operador;
        public Form1()
        {
            InitializeComponent();
        }

        Operaciones.suma obj = new Operaciones.suma();
        Operaciones.resta obj2 = new Operaciones.resta();
        Operaciones.divi obj3 = new Operaciones.divi();
        Operaciones.multiplica obj4 = new Operaciones.multiplica();
        private void btn0_Click(object sender, EventArgs e)
        {
            textTV.Text = textTV.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textTV.Text = textTV.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textTV.Text = textTV.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textTV.Text = textTV.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textTV.Text = textTV.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textTV.Text = textTV.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textTV.Text = textTV.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textTV.Text = textTV.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textTV.Text = textTV.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textTV.Text = textTV.Text + "9";
        }

        private void btnpu_Click(object sender, EventArgs e)
        {
            textTV.Text = textTV.Text + ".";
        }

        private void btnsu_Click(object sender, EventArgs e)
        {
            operador = "+";
            dato1 = double.Parse(textTV.Text);
            textTV.Clear();
        }

        private void btnre_Click(object sender, EventArgs e)
        {
            operador = "-";
            dato1 = double.Parse(textTV.Text);
            textTV.Clear();
        }

        private void btnmu_Click(object sender, EventArgs e)
        {
            operador = "*";
            dato1 = double.Parse(textTV.Text);
            textTV.Clear();
        }

        private void btndi_Click(object sender, EventArgs e)
        {
            operador = "/";
            dato1 = double.Parse(textTV.Text);
            textTV.Clear();
        }

        private void btnrta_Click(object sender, EventArgs e)
        {
        dato2= double.Parse(textTV.Text);
            double sum;
            double res;
            double mul;
            double div;

            switch (operador)
            {
                case "+":
                    sum = obj.sumar(dato1,dato2);
                    textTV.Text = sum.ToString();
                    break;
                case "-":
                    res = obj2.Restar(dato1, dato2);
                    textTV.Text = res.ToString();
                    break;
                case "/":
                    div = obj3.Dividir(dato1, dato2);
                    textTV.Text = div.ToString();
                    break;
                case "*":
                    mul = obj4.Multiplica(dato1, dato2);
                    textTV.Text = mul.ToString();
                    break;
            }

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            textTV.Clear();
            dato1=0;
            dato2=0;
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            if (textTV.Text.Length == 1)
                textTV.Text = "";
            else
                textTV.Text = textTV.Text.Substring(0, textTV.Text.Length - 1);
        }
    }
}
