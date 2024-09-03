using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projetos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string nome, telefone;
            if (!txtLogin.Text.Equals("") && !txtSenha.Text.Equals(""))
            {
                if (Sistema_Login.Logar(out nome, out telefone, txtLogin.Text, txtSenha.Text))
                {
                    lblConctado.Text = "Conectado";
                    lblNome.Text = nome;
                    lblTel.Text = telefone;
                }
                else
                    lblConctado.Text = "Não conectado";
            }
            else
            {
                MessageBox.Show("coloque um valor valido");
            }
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.ShowDialog();
        }
    }
}
