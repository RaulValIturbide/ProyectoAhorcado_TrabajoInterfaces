using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAhorcadoV3.Datos
{
    public class GestionPartida
    {
        public static List<Partida> listaPartidasTotales { get; set; } = new List<Partida>();
        private static string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "partidas.json");
        private static string rutaArchivoAciertosTotales = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "tasaAcierto.json");


        public static void Cargar()
        {
            if (File.Exists(rutaArchivo))
            {
                string json = File.ReadAllText(rutaArchivo);
                listaPartidasTotales = JsonConvert.DeserializeObject<List<Partida>>(json) ?? new List<Partida>();
            }
        }

        public static void Guardar()
        {
            string json = JsonConvert.SerializeObject(listaPartidasTotales, Formatting.Indented);
            File.WriteAllText(rutaArchivo, json);
        }

        public static void Agregar(Partida partida)
        {
            Cargar();
            listaPartidasTotales.Add(partida);
            Guardar();
        }

        public static void GenerarTasaAciertoTotal()
        {
            Cargar();
            if (listaPartidasTotales.Count != 0)
            {
                double tasaAcierto = listaPartidasTotales.Average(p => p.tasaAciertos);
                string txt_tasaAcierto = tasaAcierto * 100 + "%";
                string json = JsonConvert.SerializeObject(txt_tasaAcierto);
                File.WriteAllText(rutaArchivoAciertosTotales, json);
            }
          

        }
    }
}
