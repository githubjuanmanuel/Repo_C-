namespace Proyecto_Herramientas_II
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void Inicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Convert.ToInt32(e.KeyChar) == 13)
            {
                Espacio espacio = new Espacio();
                espacio.ShowDialog();
                
            }
        }
    }
}