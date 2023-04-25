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
using System.Runtime.InteropServices.ComTypes;

namespace Proyecto_Final_2._0
{
    public partial class Form1 : Form
    {
        List<Usuario> usuarios = new List<Usuario>();

        string user, password;
        public Form1()
        {
            InitializeComponent();
            CargarArchivo();
        }
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Registro ventana = new Registro();
            ventana.ShowDialog();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            CargarArchivo();
            user = txtUsuario.Text;
            password = txtContrasena.Text;
            if (Validar(user, password))
            {
                VentanaPresupuestos ventanaPresupuestos = new VentanaPresupuestos(user, Presupuesto(user));
                ventanaPresupuestos.ShowDialog();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña errados");
            }
            txtUsuario.Clear();
            txtContrasena.Clear();
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
                presupuesto = double.Parse(vector[2]);
                Usuario usuario = new Usuario(vector[0], vector[1], presupuesto);
                usuarios.Add(usuario);
                linea = streamReader.ReadLine();
            }
            streamReader.Close();
        }

        public Boolean Validar(string user, string password)
        {
            Boolean r = false;
            foreach(Usuario usuario in usuarios)
            {
                if (usuario.User == user && usuario.Password == password)
                {
                    r = true;
                    break;
                }
            }
            return r;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public double Presupuesto(string user)
        {
            double p = 0;
            foreach(Usuario usuario in usuarios)
            {
                if (usuario.User == user)
                {
                    p = usuario.Presupuesto;
                    break;
                }
            }
            return p;
        }
    }
}
