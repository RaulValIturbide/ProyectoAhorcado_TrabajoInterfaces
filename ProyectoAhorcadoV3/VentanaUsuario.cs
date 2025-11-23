using ProyectoAhorcadoV3.Datos;
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
    public partial class VentanaUsuario : Form
    {
        private Usuario _Jugador;
        public VentanaUsuario(Usuario Jugador)
        {
            InitializeComponent();
            _Jugador = Jugador;
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            _Jugador.NombreUsuario = txtBox_NombreUsuario.Text;
            this.Close();
        }
    }
}
