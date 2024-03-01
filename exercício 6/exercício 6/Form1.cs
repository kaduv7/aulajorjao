namespace exercício_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            aluno a = new aluno();
            a.nome = textBox1.Text;
            double media;

            media = a.Media(Convert.ToDouble (textBox2.Text), Convert.ToDouble (textBox3.Text), Convert.ToDouble(textBox4.Text), Convert.ToDouble(textBox5.Text));

            MessageBox.Show("O aluno " +a.nome+ " ficou com a média de: "+ media.ToString());

        }
    }
}
