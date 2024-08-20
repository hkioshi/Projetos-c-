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
    public partial class Validador_de_CPF : Form
    {
        public Validador_de_CPF()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar) || txtCPF.Text.Length == 11 && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCPF_Click(object sender, EventArgs e)
        {
            CPF cpf = new CPF(txtCPF.Text);
            if(cpf.Validar())
            {
                lblValidar.Text = "CPF Valido";
            }
            else
            {
                lblValidar.Text = "CPF não Valido";
            }
        }
    }
}
