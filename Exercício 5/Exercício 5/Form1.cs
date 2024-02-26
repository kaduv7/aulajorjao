namespace Exercício_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            circulo c = new circulo();
            c.raio = Convert.ToDouble(textBox1.Text);
            if (c.raio > 0)
            MessageBox.Show("Seu diâmetro é: " + c.raio * 2);
                   
        }
    }
}
