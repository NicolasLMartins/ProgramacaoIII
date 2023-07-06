namespace TelaComponentesPropriedadesEEventos
{
    public partial class frCalculo : Form
    {
        public frCalculo()
        {
            InitializeComponent();
        }

        private void btCalculo_Click(object sender, EventArgs e)
        {
            int valor1, valor2, soma, subtracao, multiplicacao, divisao;

            try
            {
                valor1 = int.Parse(tbValor1.Text);
                valor2 = int.Parse(tbValor2.Text);

                soma = valor1 + valor2;
                subtracao = valor1 - valor2;
                multiplicacao = valor1 * valor2;
                divisao = valor1 / valor2;

                tbSoma.Text = soma.ToString();
                tbSubtracao.Text = subtracao.ToString();
                tbMultiplicacao.Text = multiplicacao.ToString();
                tbDivisao.Text = divisao.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Entrada de valores invlida! Digite um valor númerico.");
            }
        }
    }
}