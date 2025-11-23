using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAhorcadoV3.Datos
{
    public class GestionPalabras
    {
        
        private static string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"palabras.json");

        public static List<Palabras> Lista { get; set; } = new List<Palabras>();

        public static void Cargar()
        {
            if (File.Exists(rutaArchivo))
            {
                string json = File.ReadAllText(rutaArchivo);
                Lista = JsonConvert.DeserializeObject<List<Palabras>>(json) ?? new List<Palabras>();
            }
            else
            {
                CrearArchivoInicial();
            }
        }

        public static void Guardar()
        {
            string json = JsonConvert.SerializeObject(Lista, Formatting.Indented);
            File.WriteAllText(rutaArchivo, json);
        }

        public static void Agregar(Palabras palabra)
        {
            Lista.Add(palabra);
            Guardar();
        }

        /// <summary>
        /// Metodo simple para coger todas las palabras en formato
        /// JSON de nuestro archivo, hacer un random entre todas las que hay
        /// y elegir una al azar (dinámico ya que la aleatoriedad va conforme al tamaño
        /// de la lista)
        /// </summary>
        /// <returns>Devuelve el texto de un objeto Palabras aleatorio</returns>
        public static Palabras GenerarPalabraAleatoria()
        {
            Palabras palabraSeleccionada = null;
            if (Lista.Count != 0)
            {
                Random random = new Random();
                int aleatorio = random.Next(Lista.Count);
                palabraSeleccionada = Lista.ElementAt<Palabras>(aleatorio);
            }
            return palabraSeleccionada;
        }

        #region Metodos Privados
        /// <summary>
        /// Este método lo que hace es sustituir a una BBDD, básicamente si 
        /// la app aún no tiene el archivo json, bien porque se ha borrado o porque
        /// es la primera vez que se inicia pues se crean estas palabras de base
        /// y se guardan
        /// </summary>
        private static void CrearArchivoInicial()
        {
            Lista = new List<Palabras>
            {
                new Palabras { Texto = "hola", ListaPistas = new List<string>{ "Es la forma más común de iniciar una conversación", "Tiene cuatro letras y empieza con 'h'" } },
                new Palabras { Texto = "adios", ListaPistas = new List<string>{ "Se dice al terminar una conversación o al marcharse", "Empieza con 'a' y termina con 's'" } },
                new Palabras { Texto = "programar", ListaPistas = new List<string>{ "Escribir instrucciones para que un ordenador las ejecute", "Relacionado con lenguajes como C#, Java o Python" } },
                new Palabras { Texto = "ahorcado", ListaPistas = new List<string>{ "Estas muy cerca de serlo", "También describe una persona colgada" } },
                new Palabras { Texto = "ordenador", ListaPistas = new List<string>{ "Se usa para trabajar, estudiar o jugar", "Tiene teclado, pantalla y ratón" } },
                new Palabras { Texto = "teclado", ListaPistas = new List<string>{ "Sirve para escribir letras y números", "Tiene teclas como 'Enter' y 'Espacio'" } },
                new Palabras { Texto = "pantalla", ListaPistas = new List<string>{ "Muestra imágenes, texto y vídeos", "Puede ser de ordenador, móvil o televisor" } },
                new Palabras { Texto = "raton", ListaPistas = new List<string>{ "Se usa para mover el cursor", "Tiene botones y a veces rueda" } },
                new Palabras { Texto = "codigo", ListaPistas = new List<string>{ "Conjunto de instrucciones que entiende un ordenador", "Puede estar escrito en C#, Java, Python, etc" } },
                new Palabras { Texto = "juego", ListaPistas = new List<string>{ "Actividad de entretenimiento con reglas", "Puede ser de mesa, de cartas o digital" } }
            };
            Guardar();
        }
        #endregion


    }
}
