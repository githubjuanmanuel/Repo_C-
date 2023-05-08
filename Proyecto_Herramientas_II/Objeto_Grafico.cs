using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Proyecto_Herramientas_II
{
    internal class Objeto_Grafico
    {
        private PictureBox imagenObj;
        int posx;
        int posy;
        protected string nombreRecurso;
        public Objeto_Grafico()
        {

        }
        public Objeto_Grafico(int x, int y, string nombre,
            int w, int h)
        {
            nombreRecurso = nombre;
            posx = x;
            posy = y;

            imagenObj = new PictureBox();
            imagenObj.Width = w;
            imagenObj.Height = h;
            imagenObj.Location = new Point(x, y);
            imagenObj.Image = Properties.Resources.ResourceManager.GetObject(nombre) as Image;
            imagenObj.SizeMode = PictureBoxSizeMode.StretchImage;
            imagenObj.BackColor = Color.Transparent;

        }

        public int Posx { get => posx; set => posx = value; }
        public int Posy { get => posy; set => posy = value; }
        public PictureBox ImagenObj { get => imagenObj; set => imagenObj = value; }

        public void SetPos(int x, int y)
        {
            this.posx = x;
            this.posy = y;
            imagenObj.Location = new Point(x, y);
        }
        public virtual void MoveLeft()
        {

        }

        public virtual void MoveRight()
        {

        }
    }
}
