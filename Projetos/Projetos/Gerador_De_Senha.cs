using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Projetos
{
    public partial class Gerador_De_Senha : Form
    {
        public Gerador_De_Senha()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            string possiveisChar = "";
            if (chcMi.Checked)
            {
                possiveisChar += "abcdefghijklmnopqrstuvwxyzç";
            }
            if (chcMa.Checked)
            {
                possiveisChar += "ABCDEFGHIJKLMNOPQRSTUVWXYZÇ";
            }
            if (chcNum.Checked)
            {
                possiveisChar += "1234567890";
            }
            if (chcCE.Checked)
            {
                possiveisChar += "!@#$%¨&*?^ ~";
            }
            if (possiveisChar != "")
            {
                string senha = "";

                possiveisChar = Sistema.Embaralhar_String(possiveisChar);
                for (int i = 0; i < nmrNuns.Value; i++)
                {
                    Random random = new Random();

                    senha += possiveisChar[random.Next(possiveisChar.Length)];

                }
                lblSenha.Text = senha;
                btnCopiar.Enabled = true;
            }
            else
            {
                MessageBox.Show("selecione Alguma opção");
            }


        }
        [STAThread]
        private void btnCopiar_Click(object sender, EventArgs e)
        {

            Clipboard.SetText(lblSenha.Text);
            Console.WriteLine("Texto copiado para a área de transferência.");
        }
    }
}
