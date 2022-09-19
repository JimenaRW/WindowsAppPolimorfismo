using WindowsAppPolimorfismo.Ajedrez;

namespace WindowsAppPolimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTorre_Click(object sender, EventArgs e)
        {
            Torre torre = new Torre();

            MessageBox.Show(torre.Mover("infinitos"));
        }

        private void btnPeon_Click(object sender, EventArgs e)
        {
            Peon peon = new Peon();

            MessageBox.Show(peon.Mover("1"));
        }

        private void btnCaballo_Click(object sender, EventArgs e)
        {
            Caballo caballo = new Caballo();

            MessageBox.Show(caballo.Mover("3"));
        }
    }
}