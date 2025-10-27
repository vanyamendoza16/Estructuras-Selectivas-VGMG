using System;
using System.Windows.Forms;

namespace Practica12_Calificacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double calificacion;
            calificacion = double.Parse(textBox1.Text);

            if (calificacion < 3.0)
            {
                MessageBox.Show("REPROBADO");
            }
        }
    }
}
