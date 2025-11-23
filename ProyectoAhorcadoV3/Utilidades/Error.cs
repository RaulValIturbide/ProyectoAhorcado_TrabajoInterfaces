using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAhorcadoV3
{
    /// <summary>
    /// Este es un método cuyo unico objetivo es lanzar el error para que el usuario
    /// entienda en que se ha equivocado o porqué algo parece
    /// no funciona
    /// </summary>
    public class Error
    {
        public int CodigoError { get; set; } = 0;
        public string MensajeError { get; set; } = String.Empty;
    }
}
