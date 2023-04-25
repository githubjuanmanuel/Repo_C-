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

namespace Proyecto_Final_2._0
{
    public partial class Registro : Form
    {
        List<Usuario> usuarios = new List<Usuario>();

        string user, password;
        double presupuesto;

        public Registro()
        {
            InitializeComponent();

            CargarArchivo();
        }
       
        

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            
            if (txtUsuario.Text == string.Empty || txtContrasena.Text == string.Empty)
            {
                MessageBox.Show("Todos los campos son obligatorios");
                txtUsuario.Clear();
                txtContrasena.Clear();
                txtIngresaPresupuesto.Clear();
            }
           
            else if (Validar(txtUsuario.Text))
            {
                MessageBox.Show("El usuario ya existe");
                txtUsuario.Clear();
                txtContrasena.Clear();
                txtIngresaPresupuesto.Clear();
            }
            
            else
            {
                user = txtUsuario.Text;
                password = txtContrasena.Text;
                presupuesto = double.Parse(txtIngresaPresupuesto.Text);


                Usuario usuario = new Usuario(user, password, presupuesto);

                usuarios.Add(usuario);

                AlmacenarArchivo();

                MessageBox.Show("Usuario registrado");
                Close();
            }
        }

        
        public void AlmacenarArchivo()
        {
            StreamWriter streamWriter = new StreamWriter("D:\\Juan Manuel\\Ejercicios c·\\Proyecto_Final_2.0\\Datos_Usuarios.txt");
            foreach (Usuario usuario in usuarios)
            {
                streamWriter.WriteLine(usuario.User + ";" + usuario.Password + ";"+ usuario.Presupuesto);
            }
            streamWriter.Close();
        }

       
        public void CargarArchivo()
        {
            StreamReader streamReader = new StreamReader("D:\\Juan Manuel\\Ejercicios c·\\Proyecto_Final_2.0\\Datos_Usuarios.txt");
            string linea;
            linea = streamReader.ReadLine();
            while(linea != null)
            {
                string[] vector = linea.Split(';');
                double presupuesto;
                presupuesto=double.Parse(vector[2]);
                Usuario usuario = new Usuario(vector[0], vector[1], presupuesto);
                usuarios.Add(usuario);
                linea = streamReader.ReadLine();
            }
            streamReader.Close();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        public Boolean Validar(string user2)
        {
            Boolean r = false;

            foreach(Usuario usuario in usuarios)
            {
                if (usuario.User == user2)
                {
                    r = true;
                    break;
                }
            }
            return r;
        }
    }
}
