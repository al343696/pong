using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Pong
{
    class Raqueta
    {
        private PictureBox raquetaPictBox = null;
        private int posicion = 197, posicionInicial = 197;
        private bool keyPresionadaUp = false, keyPresionadaDown = false;
        private Keys arriba, abajo;

        public Raqueta(PictureBox miPictureBox)
        {
            this.raquetaPictBox = miPictureBox;
        }

        public PictureBox RaquetaPictBox { get { return raquetaPictBox; } }
        public int Posicion { get { return posicion; } set { posicion = value; } }
        public bool KeyPresionadaUp { get { return keyPresionadaUp; } set { keyPresionadaUp = value; } }
        public bool KeyPresionadaDown { get { return keyPresionadaDown; } set { keyPresionadaDown = value; } }
        public Keys Arriba { get { return arriba; } set { arriba = value; } }
        public Keys Abajo { get { return abajo; } set { abajo = value; } }

        public void ReiniciarRaquetas()
        {
            posicion = posicionInicial; // Reiniciamos la posicion
            Point p = raquetaPictBox.Location;
            p.Y = posicion;
            raquetaPictBox.Location = p; // Inicializar la posicion
        }

        public void KeyDown(Keys key)
        {
            if (key == Arriba) KeyPresionadaUp = true;
            if (key == Abajo) KeyPresionadaDown = true;
        }

        public void KeyUp(Keys key)
        {
            if (key == Arriba) KeyPresionadaUp = false;
            if (key == Abajo) KeyPresionadaDown = false;
        }

        public void MueveRaqueta()
        {
            this.RaquetaPictBox.Location = new Point(RaquetaPictBox.Location.X, posicion);
        }



    }
}
