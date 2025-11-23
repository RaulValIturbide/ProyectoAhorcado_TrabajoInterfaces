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
    public partial class VentanaError : Form
    {
        public VentanaError(int NumeroError,string MostrarError)
        {
            InitializeComponent();
            lbl_NumError.Text =  "Error: " + NumeroError.ToString();
            lbl_MostrarError.Text = MostrarError;
        }

        /// <summary>
        /// Esto es para cuando las cosas vayan bien
        /// </summary>
        /// <param name="error"></param>
        public VentanaError(Error error)
        {
            InitializeComponent();

            lbl_NumError.Text = "";

            lbl_MostrarError.Text = error.MensajeError;

            pictureBox1.Image = Properties.Resources.checkVerde;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
