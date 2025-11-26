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
        private static void ReproducirSonidoEfectos(System.IO.Stream sonido)
        {
            reproductorActual = new SoundPlayer(sonido);
            reproductorActual.Play();
        }
        private static void ReproducirSonidoLoop(System.IO.Stream sonido)
        {
            reproductorActual = new SoundPlayer(sonido);
            reproductorActual.PlayLooping();
        }
        public static  void PararSonidoEfectos()
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
            ReproducirSonidoEfectos(Properties.Resources.sonido_victoria);
        }

        /// <summary>
        /// Reproduce el sonido de derrota
        /// </summary>
        public static void ReproducirDerrota()
        {
            ReproducirSonidoEfectos(Properties.Resources.sonido_derrota);
        }
        public static void ReproducirMusicaAmbiental()
        {
            ReproducirSonidoLoop(Properties.Resources.Banda_Sonora);
        }
    }
}
