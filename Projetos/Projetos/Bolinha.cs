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
    public partial class Bolinha : Form
    {
        Graphics g;
        Brush brush;
        public Bolinha()
        {
            InitializeComponent();
            brush = new SolidBrush(Color.Red);
            g = this.CreateGraphics();
        }

        private void btnCriarBola_Click(object sender, EventArgs e)
        {
            

            // Desenhar o ponto como uma elipse


            g.FillEllipse(brush, this.Width / 3, this.Height / 2, 80, 80);
            Thread.Sleep(1000);
            this.Refresh();
        }

        private void btnCair_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                Refresh();

                g.FillEllipse(brush, this.Width / 2 - i, this.Height / 2 - i, 80, 80);
                Thread.Sleep(10);
            }
        }
    }
}
