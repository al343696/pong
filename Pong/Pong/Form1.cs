using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Pong
{
     
    public partial class Form1 : Form
    {
        // Inicializacion de objetos
        Pelota pelota;
        Raqueta jugador1, jugador2;
        Marcador score;
        Stopwatch tiempo;
        private double ultimoTiempo = 0.0;

        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint
            | ControlStyles.UserPaint
            | ControlStyles.OptimizedDoubleBuffer
            | ControlStyles.SupportsTransparentBackColor, true);

            tiempo = new Stopwatch();
            tiempo.Start(); //Comienza el tiempo
            double tiempoJuego = tiempo.ElapsedMilliseconds / 1000.0; // de milisegundos a segundos
            double tiempoTranscurrido = tiempoJuego - ultimoTiempo;
            ultimoTiempo = tiempoJuego;

            // Creacion de objetos
            pelota = new Pelota(pelotaImg);
            jugador1 = new Raqueta(raqueta1);
            jugador1.Arriba = Keys.W;
            jugador1.Abajo = Keys.S;
            jugador2 = new Raqueta(raqueta2);
            jugador2.Arriba = Keys.Up;
            jugador2.Abajo = Keys.Down;
            score = new Marcador(marcadorPB);

            // A sus puestos!
            pelota.ReiniciarPelota();
            jugador1.ReiniciarRaquetas();
            jugador2.ReiniciarRaquetas();
            score.ActualizarMarcador();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            jugador1.KeyDown(e.KeyCode);
            jugador2.KeyDown(e.KeyCode);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            jugador1.KeyUp(e.KeyCode);
            jugador2.KeyUp(e.KeyCode);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            switch (pelota.Dir)
            {
                case "DOWN_RIGHT":
                    {
                        pelota.X = pelota.X + 0.5f;
                        pelota.Y = pelota.Y + 0.5f;
                        break;
                    }
                case "UP_RIGHT":
                    {
                        pelota.X = pelota.X + 0.5f;
                        pelota.Y = pelota.Y - 0.5f;
                        break;
                    }
                case "DOWN_LEFT":
                    {
                        pelota.X = pelota.X - 0.5f;
                        pelota.Y = pelota.Y + 0.5f;
                        break;
                    }
                case "UP_LEFT":
                    {
                        pelota.X = pelota.X - 0.5f;
                        pelota.Y = pelota.Y - 0.5f;
                        break;
                    }
                default:
                    {
                        pelota.Dir = "DOWN_RIGHT";
                        break;
                    }
            }
            
            pelota.MuevePelota();
            pelota.PelotaPictBox.Update();
            score.Score.Update();
            jugador1.RaquetaPictBox.Update();
            jugador2.RaquetaPictBox.Update();

            // Cambios de sentido en rebotes de techo y suelo
            if (pelota.Y >= 540 && pelota.Dir == "DOWN_RIGHT") pelota.Dir = "UP_RIGHT";
            else if (pelota.Y <= 0 && pelota.Dir == "UP_RIGHT") pelota.Dir = "DOWN_RIGHT";
            else if (pelota.Y >= 540 && pelota.Dir == "DOWN_LEFT") pelota.Dir = "UP_LEFT";
            else if (pelota.Y <= 0 && pelota.Dir == "UP_LEFT") pelota.Dir = "DOWN_LEFT";

            // Gol de cada jugador
            if (pelota.X >= 800)
            {
                score.MarcadorJ1 = score.MarcadorJ1 + 1;
                pelota.Dir = "DOWN_LEFT";
                pelota.ReiniciarPelota();
                score.ActualizarMarcador();
            }
            else if (pelota.X <= -20)
            {
                score.MarcadorJ2 = score.MarcadorJ2 + 1;
                pelota.Dir = "UP_RIGHT";
                pelota.ReiniciarPelota();
                score.ActualizarMarcador();
            }

            // Movimiento de raquetas
            if (jugador1.KeyPresionadaDown && jugador1.Posicion < 400) jugador1.Posicion = jugador1.Posicion + 1; jugador1.MueveRaqueta();
            if (jugador1.KeyPresionadaUp && jugador1.Posicion > 0) jugador1.Posicion = jugador1.Posicion - 1; jugador1.MueveRaqueta();
            if (jugador2.KeyPresionadaDown && jugador1.Posicion < 400) jugador2.Posicion = jugador2.Posicion + 1; jugador2.MueveRaqueta();
            if (jugador2.KeyPresionadaUp && jugador1.Posicion > 0) jugador2.Posicion = jugador2.Posicion - 1; jugador2.MueveRaqueta();

            // Colision Pelota con 
            // jugador1
            if (pelota.PelotaPictBox.Bounds.IntersectsWith(jugador1.RaquetaPictBox.Bounds) && pelota.Dir == "DOWN_LEFT") pelota.Dir = "DOWN_RIGHT";
            else if (pelota.PelotaPictBox.Bounds.IntersectsWith(jugador1.RaquetaPictBox.Bounds)) pelota.Dir = "UP_RIGHT";
            // jugador2
            if (pelota.PelotaPictBox.Bounds.IntersectsWith(jugador2.RaquetaPictBox.Bounds) && pelota.Dir == "DOWN_RIGHT") pelota.Dir = "DOWN_LEFT";
            else if (pelota.PelotaPictBox.Bounds.IntersectsWith(jugador2.RaquetaPictBox.Bounds)) pelota.Dir = "UP_LEFT";

            this.Invalidate();
        }
    }
}
