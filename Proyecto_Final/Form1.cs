using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proyecto_Final
{   
    public partial class Inicio : Form
    {
        string user;
        string password;

        Registro FormRegistro;
        List<Usuario> list_Usuarios = new List<Usuario>();
        public Inicio()
        {
            InitializeComponent();
            FormRegistro = new Registro();
            CargarArchivo();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            FormRegistro.ShowDialog();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            user = textBox1.Text;
            password = textBox2.Text;
            Validar();
        }
        public void CargarArchivo()
        {
            StreamReader streamReader = new StreamReader("D:\\Juan Manuel\\Ejercicios c·\\Usuarios.txt");
            string linea;
            linea = streamReader.ReadLine();
            while (linea != null)
            {
                string[] arreglo = linea.Split(';');
                list_Usuarios.Add(new Usuario(arreglo[0], arreglo[1]));
            }
            streamReader.Close();
        }
        public void Validar()
        {
            foreach(Usuario usuario in list_Usuarios)
            {
                if (user == usuario.Nombre && password == usuario.Contrasena)
                {
                    MessageBox.Show("Bienvenido");
                    break;
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña errada");
                }
            }
        }
    }
}
