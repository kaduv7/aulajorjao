namespace exercicio_1_23._02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pessoa P = new Pessoa();
            P. idade = Convert .ToInt32(textBox1.Text);
            P. nome textBox2.Text;
            MessageBox.Show("Oi, " + P.nome + " , idade " + P.idade);
        }
    }
}
