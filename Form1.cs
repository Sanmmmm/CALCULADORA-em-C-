using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULADORA
{
    public partial class FormCalculadora : Form
    {
        decimal calculo;
        bool adicao = false;
        bool multiplicacao = false;
        bool subtracao = false;
        bool divisao = false;
        bool resultado = false;

        private object txtResultado;
        private string expression;
        private object result;

        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e) 
        {
            textBox1.Text += "1"; 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {



                calculo = Convert.ToDecimal(textBox1.Text);

                textBox1.Text = "";

                adicao = true;
                subtracao = false;
                multiplicacao = false;
                divisao = false;
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            resultado = true;

            if (adicao == true)
            {
                textBox1.Text = (Convert.ToDecimal(textBox1.Text) + calculo) % 1 == 0 
                ? ((int)(Convert.ToDecimal(textBox1.Text) + calculo)).ToString()
                : (Convert.ToDecimal(textBox1.Text) + calculo).ToString().Replace(".", ",");
            }
            if (subtracao == true)
            {
                textBox1.Text = Convert.ToString(calculo - Convert.ToDecimal(textBox1.Text));
            }
            if (multiplicacao == true)
            {
                textBox1.Text = Convert.ToString(Convert.ToDecimal(textBox1.Text) * calculo);
            }
            if (divisao == true)
            {
                textBox1.Text = Convert.ToString(calculo / Convert.ToDecimal(textBox1.Text));
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                calculo = Convert.ToDecimal(textBox1.Text);

                textBox1.Text = "";

                adicao = false;
                subtracao = true;
                multiplicacao = false;
                divisao = false;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {

                calculo = Convert.ToDecimal(textBox1.Text);

                textBox1.Text = "";

                adicao = false;
                subtracao = false;
                multiplicacao = true;
                divisao = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                calculo = Convert.ToDecimal(textBox1.Text);

                textBox1.Text = "";

                adicao = false;
                subtracao = false;
                multiplicacao = false;
                divisao = true;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += ",";

           
            try
            {
               
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro na expressão: {ex.Message}");
                textBox1.Text = "";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            try
            {
                string apagar = textBox1.Text;
                apagar = apagar.Remove(apagar.Length - 1);
                textBox1.Text = apagar; 

            }
            catch (Exception)
            {

            }
        }
    }
}
