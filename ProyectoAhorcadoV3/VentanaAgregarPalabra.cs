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
    public partial class VentanaAgregarPalabra : Form
    {
        private Palabras palabraAgregar = new Palabras();
        public VentanaAgregarPalabra()
        {
            InitializeComponent();
        }

        private void btn_agregarPalabra_Click(object sender, EventArgs e)
        {
            palabraAgregar.Texto = txtBox_AgregarPalabra.Text.ToLower();
            palabraAgregar.ListaPistas.Add(txtBox_Pista1.Text);
            palabraAgregar.ListaPistas.Add(txtBox_Pista2.Text);

          Error error = palabraAgregar.ValidarDatos();//Aqui comprobamos que la palabra reuna las condiciones y las pistas no estan vacías

            if (error.CodigoError != 0)
            {
                VentanaError ventanaError = new VentanaError(error.CodigoError, error.MensajeError);
                ventanaError.ShowDialog();
                palabraAgregar.ListaPistas = new List<string>(); 
            }
            else
            {
                GestionPalabras.Agregar(palabraAgregar);
                VentanaError ventanaError = new VentanaError(error);
                ventanaError.ShowDialog();
                VaciarFormulario();
                txtBox_AgregarPalabra.Focus();//Redirigimos al admin a la posicion de crear palabra
            }

        }
        /// <summary>
        /// Si la palabra se agrega con éxito vaciarmeos el formulario para que 
        /// el admin no tenga que estar saliendo al menu constantemente
        /// </summary>
        private void VaciarFormulario()
        {
            txtBox_AgregarPalabra.Text = "";
            txtBox_Pista1.Text = "";
            txtBox_Pista2.Text = "";
            palabraAgregar.ListaPistas = new List<string>();
        }
    }
}
