using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumaAlgebraica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnSuma_Click(object sender, EventArgs e)
        {
            /*Para hacer la transformación de una variable tipo String a int,
             * se utiliza la fórmula .Parse
             */
            int dt1, dt2, suma;
            dt1 = int.Parse(txtDato1.Text);
            dt2 = int.Parse(txtDato2.Text);
            suma = dt1 + dt2;
            /*Para cambiar los datos tipo int a String, se utiliza la fórmula
             * .ToString
             */
            txtResultado.Text = suma.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDato1.Text = "";
            txtDato2.Text = "";
            txtResultado.Text = "";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int dt1, dt2, resta;
            dt1 = int.Parse(txtDato1.Text);
            dt2 = int.Parse(txtDato2.Text);
            resta = dt1 - dt2;
            txtResultado.Text = resta.ToString();
        }

        private void btnMultiplica_Click(object sender, EventArgs e)
        {
            int dt1, dt2, multiplica;
            dt1 = int.Parse(txtDato1.Text);
            dt2 = int.Parse(txtDato2.Text);
            multiplica = dt1 * dt2;
            txtResultado.Text = multiplica.ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            int dt1, dt2, resta;
            dt1 = int.Parse(txtDato1.Text);
            dt2 = int.Parse(txtDato2.Text);
            resta = dt1 - dt2;
            txtResultado.Text = resta.ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            int dt1, dt2, divide;
            dt1 = int.Parse(txtDato1.Text);
            dt2 = int.Parse(txtDato2.Text);
            divide = dt1 / dt2;
            txtResultado.Text = divide.ToString();
        }
    }
}
