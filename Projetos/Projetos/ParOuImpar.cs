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
    public partial class ParOuImpar : Form
    {
        public ParOuImpar()
        {
            InitializeComponent();
        }

        private void btnPOI_Click(object sender, EventArgs e)
        {
            try
            {
                lblPOI.Text = Convert.ToInt32(txtPOI.Text) % 2 == 0 ? "Par" : "Impar";
            }
            catch 
            {
                MessageBox.Show("Coloque um valor valido");
            }
        }
    }
}
