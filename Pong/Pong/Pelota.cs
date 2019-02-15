using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Media;
using System.Drawing.Drawing2D;

namespace Pong
{
    class Pelota
    {
        private PictureBox pelotaPictBox = null;
        private float x = 380, y = 270; // Posicion
        private string direccion;

        public Pelota (PictureBox miPictureBox)
        {
            this.pelotaPictBox = miPictureBox;
        }

        public PictureBox PelotaPictBox { get { return pelotaPictBox; } }
        public float X { get { return x; } set { x = value; } }
        public float Y { get { return y; } set { y = value; } }
        public string Dir { get { return direccion; } set { this.direccion = value; } }

        public void ReiniciarPelota()
        {
            x = 380;
            y = 270; // Reiniciamos la posicion
            this.pelotaPictBox.Location = new Point((int)X, (int)Y); // Inicializar mi posición
        }

        public void MuevePelota()
        {
            this.pelotaPictBox.Location = new Point((int)X, (int)Y);
        }
    }
}
