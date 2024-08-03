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
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int n1, n2;
            if (Sistema.TryParse<string, int>(txtn1.Text, out n1) && Sistema.TryParse<string, int>(txtn2.Text, out n2))
            {

                float r = 0;

                if (rdbSoma.Checked)
                {
                    r = n1 + n2;
                }

                if (rdbSub.Checked)
                {
                    r = n1 - n2;
                }

                if (rdbMult.Checked)
                {
                    r = n1 * n2;
                }

                if (rdbDiv.Checked)
                {
                    r = n1 / n2;
                }
                if (rdbMod.Checked)
                {
                    r = n1 % n2;
                }
                if (rdbPot.Checked)
                {
                    r = 1;
                    for (int i = 1; i <= n2; i++) {

                        r *= n1;
                        
                    }
                }
                lblResult.Text = r.ToString();
            }
            else
            {
                MessageBox.Show("coloque numeros validos");
                txtn1.Text = "0";
                txtn2.Text = "0";
            }
        }

        private void lblR_Click(object sender, EventArgs e)
        {

        }

        private void rdbMod_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
