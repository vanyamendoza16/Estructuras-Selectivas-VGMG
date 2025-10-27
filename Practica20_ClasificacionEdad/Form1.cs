namespace Practica20_ClasificacionEdad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int edad;
            edad = int.Parse(textBox1.Text);

            if (edad < 12)
                MessageBox.Show("Es un Niño");
            else if (edad < 18)
                MessageBox.Show("Es un Adolescente");
            else if (edad < 60)
                MessageBox.Show("Es un Adulto");
            else
                MessageBox.Show("Es un Adulto mayor");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
