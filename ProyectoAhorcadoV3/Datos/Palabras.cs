using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProyectoAhorcadoV3.Datos
{
    
    public class Palabras
    {
        public string Texto { get; set; } = String.Empty;
        public List<string> ListaPistas { get; set; } = new List<string>();


        /// <summary>
        /// Metodo para comprobar si la palabra reune una serie de requisitos para cuando se agregue
        /// </summary>
        /// <returns>Devuelve un Error, si su codigo es 0 es que todo va bien</returns>
        public Error ValidarDatos()
        {
            Error error = new Error();

            //Aquí comprobamos la palabra en si
            if (string.IsNullOrWhiteSpace(Texto))
            {
                error.CodigoError = 104;
                error.MensajeError = "El texto no puede estar vacío";
            }
            else
            {
                for (int i = 0; i < Texto.Length; i++)
                {
                    if (!char.IsLetter(Texto[i]))
                    {
                        error.CodigoError = 500;
                        error.MensajeError = "Las palabras solo pueden estar formadas por letras";
                    }
                }
            }

            //Aquí comprobamos las pistas para que no se queden vacías
            foreach (string pista in ListaPistas)
            {
                if (string.IsNullOrWhiteSpace(pista))
                {
                    error.CodigoError = 303;
                    error.MensajeError = "Ninguna Pista puede estar vacía";
                }
            }
            if (error.CodigoError == 0)
            {
                error.MensajeError = $"Palabra {Texto} agregada con éxito";
            }
            return error;
        }
    }






}
