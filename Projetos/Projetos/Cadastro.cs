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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            if (Sistema.ValidarEmail(txtEmail.Text) && Sistema.ValidarTelefone(txtTel.Text))
            {
                if (txtCEmail.Text.Equals(txtCEmail.Text) && txtSenha.Text.Equals(txtSenha.Text))
                {
                    MessageBox.Show(Sistema_Login.Cadastrar(txtEmail.Text, txtSenha.Text, txtNome.Text, txtTel.Text)? "adicionado":"erro");
                }
            }
        }
    }
}
