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
        Pacman pacman;
        int tiempo = 0;
        
        public Laberinto()
        {
            InitializeComponent();
          

        }

        private void Laberinto_Load(object sender, EventArgs e)
        {
            CargarMuros();
            CargarDots();
            pacman = new Pacman(70,70);
            this.Controls.Add(pacman.ImagenObj);
           
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
            for (int i = 0; i < stringsCoor.Length; i++)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            pacman.Animacion();
            int id=pacman.ComerDot(Dots);
            if(id>=0)
            {
                this.Controls.Remove(Dots.ElementAt(id).ImagenObj);
                Dots.RemoveAt(id);
                lblPuntaje.Text = "Puntaje : " + pacman.Puntaje;
            }
        }

        private void tiempoJuego_Tick(object sender, EventArgs e)
        {
            tiempo++;
            lbltiempo.Text = "Tiempo : " + tiempo;
        }

        private void Laberinto_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            c=char.ToUpper(c);

            if(c=='W')
            {
                if (!pacman.EvaluarColision(Muros))
                    pacman.MoverUp();
                else
                      
                    pacman.Rebote(5);
            }
            else if (c == 'S')
            {
                if (pacman.EvaluarColision(Muros))
                   pacman.Rebote(5);
                else
                  pacman.MoverDown();
            }

            else if (c == 'D')
            {
                if (pacman.EvaluarColision(Muros))
                    pacman.Rebote(5);
                else
                    pacman.MoverRight();
            }
            else if (c == 'A')
            {
                if (pacman.EvaluarColision(Muros))
                    pacman.Rebote(5);
                else
                    pacman.MoverLeft();
            }








        }
    }
}
