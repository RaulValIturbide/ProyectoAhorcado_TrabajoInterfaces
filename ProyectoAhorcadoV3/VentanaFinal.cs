using ProyectoAhorcadoV3.Datos;
using ProyectoAhorcadoV3.Utilidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAhorcadoV3
{
    public partial class VentanaFinal : Form
    {
        private Form formPrincipal;
        private Partida estaPartida = new Partida();
        public VentanaFinal(Form form1,bool resultado,string palabraSeleccionada, int contadorErrores, int tiempoSegundos,int intentos,string nombreJugador)
        {
            InitializeComponent();

            formPrincipal = form1;

            GenerarPartida(resultado,palabraSeleccionada, contadorErrores, tiempoSegundos, intentos);

            GestionPartida.Agregar(estaPartida);

            GestionPartida.GenerarTasaAciertoTotal();

            DatosComunes(palabraSeleccionada, contadorErrores, tiempoSegundos);

            if (resultado)
            {
                MostrarVictoria(nombreJugador);
            }
            else
            {
                MostrarDerrota(nombreJugador);
                
            }          
        }
        #region Metodos Privados

        private void MostrarVictoria(string nombreJugador)
        {
            lbl_resultado.Text = $"{nombreJugador}, HAS GANADO!!{Environment.NewLine} VICTORIA!!";
            Reproductor.ReproducirVictoria();
        }

        private void MostrarDerrota(string nombreJugador)
        {
            lbl_resultado.Text = $"{nombreJugador}, HAS Perdido!! {Environment.NewLine} Una Lástima!!";
            Reproductor.ReproducirDerrota();
        }

        private void DatosComunes(string palabraSeleccionada, int contadorErrores, int tiempoSegundos)
        {
            lbl_palabraSeleccionada.Text = palabraSeleccionada;
            lbl_tiempoTotal.Text = tiempoSegundos.ToString() + " s";
            lbl_contadorErrores.Text = contadorErrores.ToString();
            
        }

        private void GenerarPartida(bool resultado, string palabraSeleccionada,int contadorErrores, int tiempoSegundos,int intentos)
        {
            estaPartida.palabra = palabraSeleccionada;
            estaPartida.victoria = resultado;
            estaPartida.tiempo = tiempoSegundos;
            estaPartida.intentos = intentos;
            estaPartida.aciertos = intentos - contadorErrores;
            estaPartida.tasaAciertos = estaPartida.CalcularTasaAciertos();
        }

        private void btn_reiniciar_Click(object sender, EventArgs e)
        {
            this.Close();
            Reproductor.PararSonido();

            if(formPrincipal is Form1 juego)
            {
                juego.ReiniciarJuego();
            }   
        }
        #endregion
    }
}
