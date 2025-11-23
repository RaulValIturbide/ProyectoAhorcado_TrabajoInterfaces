using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace ProyectoAhorcadoV3.Utilidades
{
    public static class Reproductor
    {
        private static SoundPlayer reproductorActual;
        /// <summary>
        /// Reproduce un sonido WAV desde los recursos del proyecto.
        /// </summary>
        /// <param name="sonido">El recurso WAV que quieras reproducir</param>
        public static void ReproducirSonido(System.IO.Stream sonido)
        {
            reproductorActual = new SoundPlayer(sonido);
            reproductorActual.Play();
        }
        public static void ReproducirSonidoLoop(System.IO.Stream sonido)
        {
            reproductorActual = new SoundPlayer(sonido);
            reproductorActual.PlayLooping();
        }
        public static void PararSonido()
        {
            if (reproductorActual != null)
            {
                reproductorActual.Stop();
            }
        }

        /// <summary>
        /// Reproduce el sonido de victoria
        /// </summary>
        public static void ReproducirVictoria()
        {
            ReproducirSonido(Properties.Resources.sonido_victoria);
        }

        /// <summary>
        /// Reproduce el sonido de derrota
        /// </summary>
        public static void ReproducirDerrota()
        {
            ReproducirSonido(Properties.Resources.sonido_derrota);
        }
        public static void ReproducirMusicaAmbiental()
        {
            ReproducirSonidoLoop(Properties.Resources.Banda_Sonora);
        }
    }
}
