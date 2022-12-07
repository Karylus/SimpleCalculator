using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Ventana : Form
    {
        public Ventana()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText += "/";
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText += "8";
        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText += "9";
        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText += "7";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            string operacion = textBox1.Text;
            double resultado = 0.0;

            try
            {
                resultado = Convert.ToDouble(new DataTable().Compute(operacion, null)); //Usa una DataTable para hacer los calculos

                textBox1.Clear();

                textBox1.AppendText(resultado.ToString());
            }

            catch (Exception ex)
            {
                textBox1.Clear();

                textBox1.AppendText("Error en la fórmula");
            }

            string completo = operacion + " = " + resultado;

            string[] columna = { completo }; //Creo un array que es igual a una fila de la listView

            var listViewItem = new ListViewItem(columna);

            listView1.Items.Add(listViewItem);
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText += "*";
        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText += "6";
        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText += "5";
        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText += "4";
        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText += "1";
        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText += "2";
        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText += "3";
        }

        private void buttonSubtraction_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText += "-";
        }

        private void buttonAddition_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText += "+";
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText += ".";
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            textBox1.SelectedText += "0";
        }

        private void buttonChangeSign_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text[0].Equals('-')) //Si el primer char es '-' lo cambia por '+'
                {
                    string text = textBox1.Text.Replace('-', '+');

                    textBox1.Clear();

                    textBox1.AppendText(text);
                }

                else
                {
                    Decimal text = Decimal.Negate(Convert.ToDecimal(textBox1.Text)); //Niega el '+' o el ' ' en el primer char por '-'

                    textBox1.Clear();

                    textBox1.AppendText(Convert.ToString(text));
                }
            }

            catch (Exception ex)
            {
                textBox1.Clear();

                textBox1.AppendText("Error al cambiar signo");
            }
        }
    }
}