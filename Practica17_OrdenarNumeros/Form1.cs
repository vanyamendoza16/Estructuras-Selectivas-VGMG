namespace Practica17_OrdenarNumeros
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

        private void button1_Click(object sender, EventArgs e)
        {
            int A, B, C;
            A = int.Parse(textBox1.Text);
            B = int.Parse(textBox2.Text);
            C = int.Parse(textBox3.Text);

            if (A > B)
            {
                if (A > C)
                {
                    if (B > C)
                    {
                        textBox4.Text = A.ToString();
                        textBox5.Text = B.ToString();
                        textBox6.Text = C.ToString();
                    }
                    else
                    {
                        textBox4.Text = A.ToString();
                        textBox5.Text = C.ToString();
                        textBox6.Text = B.ToString();
                    }
                }
                else
                {
                    textBox4.Text = C.ToString();
                    textBox5.Text = A.ToString();
                    textBox6.Text = B.ToString();
                }
            }
            else
            {
                if (B > C)
                {
                    if (A > C)
                    {
                        textBox4.Text = B.ToString();
                        textBox5.Text = A.ToString();
                        textBox6.Text = C.ToString();
                    }
                    else
                    {
                        textBox4.Text = B.ToString();
                        textBox5.Text = C.ToString();
                        textBox6.Text = A.ToString();
                    }
                }
                else
                {
                    textBox4.Text = C.ToString();
                    textBox5.Text = B.ToString();
                    textBox6.Text = A.ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
