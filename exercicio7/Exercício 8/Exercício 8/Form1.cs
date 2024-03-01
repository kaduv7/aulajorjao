namespace Exercício_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            triangulo t = new triangulo();
            double p;

            p = t.Perimetro(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));

            MessageBox.Show("O perímetro é: " +p);


        }
    }
}
