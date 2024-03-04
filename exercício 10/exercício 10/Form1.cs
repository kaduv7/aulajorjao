namespace exercício_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            funcionario f = new funcionario();
            f.nome = textBox1.Text;
            f.salario = Convert.ToDouble(textBox2.Text);

            MessageBox.Show(f.nome + " seu salário anual é de: " + f.SalarioAnual(f.salario).ToString());
        }
    }
}
