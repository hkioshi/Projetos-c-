using System.Diagnostics;
using System.Windows.Forms;

namespace Projetos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculadora_Click(object sender, EventArgs e)
        {
            Calculadora d = new Calculadora();
            d.ShowDialog();
        }

        private void btnGeradorSenha_Click(object sender, EventArgs e)
        {
            Gerador_De_Senha d = new Gerador_De_Senha();
            d.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ParOuImpar d = new ParOuImpar();
            d.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Validador_de_CPF a = new Validador_de_CPF();
            a.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gerador_de_CPF_Valido a = new Gerador_de_CPF_Valido();
            a.ShowDialog();
        }

        private void btnColorir_Click(object sender, EventArgs e)
        {
            Bolinha bolinha = new Bolinha();
            bolinha.ShowDialog();
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            BancoDeDados bancoDeDados = new BancoDeDados();
            bancoDeDados.ShowDialog();
        }
    }
}
