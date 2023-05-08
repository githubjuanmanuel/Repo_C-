using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Herramientas_II
{
    public partial class Espacio : Form
    {
        List<Objeto_Grafico>Bunkers = new List<Objeto_Grafico>();
        List<Objeto_Grafico>Aliens = new List<Objeto_Grafico>();
        Canon canon = new Canon(273, 650);
        public Espacio()
        {
            InitializeComponent();
        }

        private void Espacio_Load(object sender, EventArgs e)
        {
            Cargar_Bunkers();
            Cargar_Aliens();
            this.Controls.Add(canon.ImagenObj);
            

        }

        public void Cargar_Bunkers()
        {
            int x, y;
            string[] strCor;
            var coor = Properties.Resources.Bunkers;
            string[] stringsCoor = coor.Split('\n');
            for (int i = 0; i < stringsCoor.Length - 1; i++)
            {
                stringsCoor[i] = stringsCoor[i].Trim('\n');
                strCor = stringsCoor[i].Split(';');
                x = int.Parse(strCor[0]);
                y = int.Parse(strCor[1]);
                Bunker bunker = new Bunker(x, y);
                this.Controls.Add(bunker.ImagenObj);
                Bunkers.Add(bunker);
            }
        }
        public void Cargar_Aliens()
        {
            int x, y;
            string[] strCor;
            var coor = Properties.Resources.Alienigenas;
            string[] stringsCoor = coor.Split('\n');
            for (int i = 0; i < stringsCoor.Length ; i++)
            {
                stringsCoor[i] = stringsCoor[i].Trim('\n');
                strCor = stringsCoor[i].Split(';');
                x = int.Parse(strCor[0]);
                y = int.Parse(strCor[1]);
                Alienigena alien = new Alienigena(x, y);
                this.Controls.Add(alien.ImagenObj);
                Aliens.Add(alien);
            }
        }

        private void Espacio_KeyPress(object sender, KeyPressEventArgs e)
        {
            char tecla = e.KeyChar;
            int tecla2 = Convert.ToInt32(e.KeyChar);
            if (tecla == 'A' || tecla == 'a')
            {
                canon.MoveLeft();
            }else if (tecla == 'D' || tecla == 'd')
            {
                canon.MoveRight();
            }else if( tecla2 == 32)
            {
                canon.Disparar();
            }
        }
        
    }
}
