using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacmanGame
{
    public partial class Laberinto : Form
    {
        List<ObjetoGrafico>Muros = new List<ObjetoGrafico>();
        List<ObjetoGrafico> Dots = new List<ObjetoGrafico>();
        public Laberinto()
        {
            InitializeComponent();
        }

        private void Laberinto_Load(object sender, EventArgs e)
        {

            CargarMuros();
            CargarDots();

        }
        public void CargarMuros()
        {
            int x, y;
            string[] strCor;
            var coor = Properties.Resources.coordenadas;
            string[] stringsCoor= coor.Split('\r');
            for (int i = 0; i < stringsCoor.Length-1; i++)
            {
                stringsCoor[i] = stringsCoor[i].Trim('\n');
                strCor = stringsCoor[i].Split(';');
                x = int.Parse(strCor[0]);
                y = int.Parse(strCor[1]);
                Muro muro = new Muro(x, y);
                this.Controls.Add(muro.ImagenObj);
                Muros.Add(muro);
            }
        }

        public void CargarDots()
        {
            int x, y;
            string[] strCor;
            var coor = Properties.Resources.dotCoor;
            string[] stringsCoor = coor.Split('\r');
            for (int i = 0; i < stringsCoor.Length - 1; i++)
            {
                stringsCoor[i] = stringsCoor[i].Trim('\n');
                strCor = stringsCoor[i].Split(';');
                x = int.Parse(strCor[0]);
                y = int.Parse(strCor[1]);
                Dot dot = new Dot(x, y);
                this.Controls.Add(dot.ImagenObj);
                Dots.Add(dot);
            }
        }
    }
}
