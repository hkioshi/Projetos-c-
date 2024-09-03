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
    public partial class BancoDeDados : Form
    {
        public BancoDeDados()
        {
            InitializeComponent();
        }

        private void BancoDeDados_Load(object sender, EventArgs e)
        {
            Conector conector = new Conector("world");
            conector.SQL_ALL(LstBanco , "country");

        }
    }
}
