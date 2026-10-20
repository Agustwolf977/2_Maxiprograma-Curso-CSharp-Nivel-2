using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            int a, b, r;
            try
            {
                a = int.Parse(textBox1.Text);
                b = int.Parse(textBox2.Text);
                r = a / b;
                lblResultado.Text = $"= {r}";
            }
            //catch (FormatException ex)
            //{
            //    MessageBox.Show("Por favor, cargar solo números...");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    MessageBox.Show("No se puede dividir por cero...");
            //}
            catch (FormatException ex)
            {
                MessageBox.Show("Error no reconocido... contactar a tu dev...");
            }
            finally
            {

            }
        }

        private int calcular()
        {
            try
            {
                return 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}