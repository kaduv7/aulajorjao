namespace Exercício_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contabancaria cb = new contabancaria();
            cb.valor1 = Convert.ToInt32(textBox1.Text);
            cb.valor2 = Convert.ToInt32(textBox2.Text);
            if (cb.valor1 > cb.valor2)
                MessageBox.Show("Seu saldo é maior que o seu limite.");
            if (cb.valor1 < cb.valor2)
                MessageBox.Show("Seu limite é maior que seu saldo.");
            if (cb.valor1 == cb.valor2)
                MessageBox.Show("Seu limite é igual ao seu saldo.");
        }
    }
}
