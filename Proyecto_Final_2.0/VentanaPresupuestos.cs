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
    public partial class VentanaPresupuestos : Form
    {
        List<Usuario> usuarios = new List<Usuario>();
        List<Gasto> gastos = new List<Gasto>();
        double presupuesto, gasto = 0;
        string usuario2;
        int index;
        public VentanaPresupuestos(string user, double presupuesto)
        {
            InitializeComponent();
            CargarArchivo();
            CargarGasto();
            lblBienvenido.Text = lblBienvenido.Text + " " + user;
            usuario2 = user;
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.User == usuario2)
                {
                    presupuesto = usuario.Presupuesto;
                    
                }
            }
            PresupuestoInicial(presupuesto);
            
            PresupuestoFinal(presupuesto);
             
            MostrarGastos(usuario2);
        }

        private void VentanaPresupuestos_Load(object sender, EventArgs e)
        {

        }

        private void btnPresupuesto_Click(object sender, EventArgs e)
        {
            presupuesto = double.Parse(txtPresupuesto.Text);
            ModificarPresupuesto(presupuesto);
            AlmacenarArchivo();
            txtPresupuesto.Clear();
            PresupuestoInicial(presupuesto);
            
            PresupuestoFinal(presupuesto);
             
        }

        private void btnGasto_Click(object sender, EventArgs e)
        {
            gasto = double.Parse(txtGasto.Text);
            Gasto NuevoGasto = new Gasto(usuario2, gasto);
            gastos.Add(NuevoGasto);
            GuardarGastos();
            MostrarGastos(usuario2);
            PresupuestoFinal(presupuesto);
            txtGasto.Clear();
        }
        public void AlmacenarArchivo()
        {
            StreamWriter streamWriter = new StreamWriter("D:\\Juan Manuel\\Ejercicios c·\\Proyecto_Final_2.0\\Datos_Usuarios.txt");
            foreach (Usuario usuario in usuarios)
            {
                streamWriter.WriteLine(usuario.User + ";" + usuario.Password + ";" + usuario.Presupuesto);
            }
            streamWriter.Close();
        }
        public void CargarArchivo()
        {
            StreamReader streamReader = new StreamReader("D:\\Juan Manuel\\Ejercicios c·\\Proyecto_Final_2.0\\Datos_Usuarios.txt");
            string linea;
            linea = streamReader.ReadLine();
            while (linea != null)
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
        public void GuardarGastos()
        {
            StreamWriter streamWriter = new StreamWriter("D:\\Juan Manuel\\Ejercicios c·\\Proyecto_Final_2.0\\Gastos_Usuario.txt");
            foreach(Gasto gasto in gastos)
            {
                streamWriter.WriteLine(gasto.Usuario + ";" + gasto.CantidadGasto);
            }
            streamWriter.Close();
        }
        public void CargarGasto()
        {
            StreamReader streamReader = new StreamReader("D:\\Juan Manuel\\Ejercicios c·\\Proyecto_Final_2.0\\Gastos_Usuario.txt");
            string linea;
            linea = streamReader.ReadLine();
            while (linea != null)
            {
                string[] vector = linea.Split(';');
                double GastosUsuario;
                GastosUsuario = double.Parse(vector[1]);
                Gasto gasto = new Gasto(vector[0], GastosUsuario);
                gastos.Add(gasto);
                linea = streamReader.ReadLine();
            }
            streamReader.Close();
        }
        public void ModificarPresupuesto(double presupuesto)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.User == usuario2)
                {
                    usuario.Presupuesto = presupuesto;
                }
            }
            PresupuestoFinal(presupuesto);

        }
        public void PresupuestoInicial(double presupuesto)
        {
            txtPresupuestoInicial.Text = presupuesto.ToString();
        }

        private void listViewGastos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                index = e.ItemIndex;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            gastos[index].CantidadGasto = double.Parse(txtModificar.Text);
            GuardarGastos();
            MessageBox.Show("Gasto Modificado");
            PresupuestoFinal(presupuesto);
            MostrarGastos(usuario2);
            txtModificar.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            gastos.RemoveAt(index);
            MessageBox.Show("Gasto Eliminado");
            GuardarGastos();
            PresupuestoFinal(presupuesto);
            MostrarGastos(usuario2);
            
        }

        public void PresupuestoFinal(double presupuesto)
        {
            double PresupuestoAux;
            PresupuestoAux = presupuesto;
           
                foreach(Gasto gasto in gastos)
                {
                    if (usuario2 == gasto.Usuario)
                    {
                        PresupuestoAux = PresupuestoAux - gasto.CantidadGasto;
                    }
                }

                txtPresupuestoFinal.Text = PresupuestoAux.ToString();
            
 
        }
        public void MostrarGastos(string usuario)
        {
            listViewGastos.Items.Clear();
            foreach (Gasto gasto in gastos)
            {
                if (usuario == gasto.Usuario)
                {
                    ListViewItem item = new ListViewItem(gasto.CantidadGasto.ToString());
                    listViewGastos.Items.Add(item);
                }
            }
        }
       
    }
}
