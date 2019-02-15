using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    class Marcador
    {
        private Label score = null;
        private int marcadorJ1 = 0, marcadorJ2 = 0;

        public Marcador(Label miPictureBox)
        {
            this.score = miPictureBox;
        }

        public Label Score { get { return score; } }
        public int MarcadorJ1 { get { return marcadorJ1; } set { marcadorJ1 = value; } }
        public int MarcadorJ2 { get { return marcadorJ2; } set { marcadorJ2 = value; } }

        public void ActualizarMarcador ()
        {
            this.score.Text = MarcadorJ1 + " : " + MarcadorJ2;
        }
        
    }
}
