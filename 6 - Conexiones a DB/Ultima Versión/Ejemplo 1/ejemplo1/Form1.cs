using System;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int resultado = calcular();
                lblResultado.Text = $"= {resultado}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, ingresar solo números...");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("No se puede dividir por cero...");
            }
            catch (Exception)
            {
                MessageBox.Show("Error no reconocido... contactar a tu desarrollador...");
            }
            finally
            {
                MessageBox.Show("Finalizó el intento de cálculo.");
            }
        }

        private int calcular()
        {
            try
            {
                int a = int.Parse(textBox1.Text);
                int b = int.Parse(textBox2.Text);

                return a / b;
            }
            catch (Exception)
            {
                // Relanzamos la excepción para que la
                // gestione el método button1_Click().
                throw;
            }
        }
    }
}