using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraTP
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            decimal Num1;
            decimal Num2;
            decimal Resultado;
            try
            {
                Num1 = decimal.Parse(txtNum1.Text);
                Num2 = decimal.Parse(txtNum2.Text);
                Resultado = Num1 + Num2;
                MessageBox.Show("O resultado é: " + Resultado);
            }
            catch(FormatException)
            {
                MessageBox.Show("Não se soma letras, seu animal de tetas!");
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            decimal Num1;
            decimal Num2;
            decimal Resultado;
            try
            {
                Num1 = decimal.Parse(txtNum1.Text);
                Num2 = decimal.Parse(txtNum2.Text);
                Resultado = Num1 - Num2;
                MessageBox.Show("O resultado é: " + Resultado);
            }
            catch(FormatException)
            {
                MessageBox.Show("Não se subtrai letras, seu animal de tetas!");
            }
        }

        private void btnVezes_Click(object sender, EventArgs e)
        {
            decimal Num1;
            decimal Num2;
            decimal Resultado;
            try
            {
                Num1 = decimal.Parse(txtNum1.Text);
                Num2 = decimal.Parse(txtNum2.Text);
                Resultado = Num1 * Num2;
                MessageBox.Show("O resultado é: " + Resultado);
            }
            catch (FormatException)
            {
                MessageBox.Show("Não se multiplica letras, seu animal de tetas!");
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            decimal Num1;
            decimal Num2;
            decimal Resultado;
            try
            {
                Num1 = decimal.Parse(txtNum1.Text);
                Num2 = decimal.Parse(txtNum2.Text);
                Resultado = Num1 / Num2;
                MessageBox.Show("O resultado é: " + Resultado);
            }
            catch (FormatException)
            {
                MessageBox.Show("Não se divide letras, seu animal de tetas!");
            }
        }

        private void btnRaix_Click(object sender, EventArgs e)
        {
            double Num1;
            double Resultado;
            try
            {
                Num1 = Convert.ToDouble(txtNum1.Text);
                Resultado = Math.Sqrt(Num1);
            }
            catch (FormatException)
            {
                MessageBox.Show("Não tem como chegar à RAÍZ de uma LETRA, seu animal de tetas!");
            }
        }

        private void btnEleva_Click(object sender, EventArgs e)
        {
            double Num1;
            double Num2;
            double Resultado;
            try
            {
                Num1 = Convert.ToDouble(txtNum1.Text);
                Num2 = Convert.ToDouble(txtNum2.Text);
                Resultado = Math.Pow(Num1, Num2);
                MessageBox.Show("O resultado é: " + Resultado);
            }
            catch (FormatException)
            {
                MessageBox.Show("Não se eleva letras, seu animal de tetas!");
            }
        }

        private void btnJunta_Click(object sender, EventArgs e)
        {
            MessageBox.Show("O resultado é: " + txtNum1.Text + txtNum2.Text);
        }

        private void btnFaxineira_Click(object sender, EventArgs e)
        {
            txtNum1.Text = null;
            txtNum2.Text = null;
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
