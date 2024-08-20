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
    public partial class Gerador_de_CPF_Valido : Form
    {
        public Gerador_de_CPF_Valido()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            lblResult.Text = CPF.GerarCPF();
            btnCopiar.Enabled = true;
        }

        [STAThread]
        private void btnCopiar_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblResult.Text);
            Console.WriteLine("Texto copiado para a área de transferência.");
        }
    }


}
