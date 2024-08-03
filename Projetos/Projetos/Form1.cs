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
            Calculadora d = new Calculadora ();
            d.ShowDialog();
        }
    }
}
