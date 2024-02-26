namespace Exercício_4
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
            livro l = new livro();
            l.titulo = textBox1.Text;
            l.autor = textBox2.Text;
            l.anopublicacao = Convert .ToInt32(textBox3.Text);
            MessageBox.Show("O livro " + l.titulo + " escrito por " + l.autor + " foi publicado em " + l.anopublicacao);
        }
    }
}
