using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAhorcadoV3.Datos
{
    public class Partida
    {
        public string palabra { get; set; }
        public bool victoria { get; set; } //Si la partida se ha ganado o no
        public int tiempo {get;set;} //El tiempo que le ha costado al jugador terminar la partida
        public int intentos { get; set; } //Las veces que el jugador a intentado adivinar una letra
        public int aciertos { get; set; } //Las veces que el jugador a adivinado una letra
        public double tasaAciertos { get; set; }

        /// <summary>
        /// Metodo para calcular la tasa de aciertos asegurandonos que no se divide por 0
        /// </summary>
        /// <returns>devuelve el numero de aciertos</returns>
        public double CalcularTasaAciertos()
        {
            if (intentos == 0)
            {
                return 0;
            } 
            double tasa = (double)aciertos / intentos;
            return Math.Round(tasa, 2);
        }
    }

}
