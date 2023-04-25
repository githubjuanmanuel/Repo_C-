using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto_Final
{
    public partial class Registro : Form
    {
        string user;
        string password;

        List<Usuario> list_Usuarios = new List<Usuario>();

        
        public Registro()
        {
            InitializeComponent();
            CargarArchivo();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            user = textBox1.Text;
            password = textBox2.Text;
            Usuario usuario = new Usuario(user, password);
            list_Usuarios.Add(usuario);
            AlmacenarArchivo();
            MessageBox.Show("Usuario registrado");
            Close();
        }

        public void AlmacenarArchivo()
        {
            StreamWriter streamWriter = new StreamWriter("D:\\Juan Manuel\\Ejercicios c·\\Usuarios.txt");
            foreach (Usuario usuario in list_Usuarios)
            {
                streamWriter.WriteLine(usuario.Nombre+";"+usuario.Contrasena);
            }
            streamWriter.Close();
        }
        public void CargarArchivo()
        {
            StreamReader streamReader = new StreamReader("D:\\Juan Manuel\\Ejercicios c·\\Usuarios.txt");
            string linea;
            linea = streamReader.ReadLine();
            while(linea != null)
            {
                string[] arreglo = linea.Split(';');
                list_Usuarios.Add(new Usuario(arreglo[0], arreglo[1]));
            }
            streamReader.Close();
        }

    }
}
