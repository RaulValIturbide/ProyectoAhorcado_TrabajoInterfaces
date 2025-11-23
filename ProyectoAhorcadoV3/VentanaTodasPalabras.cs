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
    public partial class VentanaTodasPalabras : Form
    {
        public VentanaTodasPalabras()
        {
            InitializeComponent();

            GestionPalabras.Cargar();

            var palabrasPlano = GestionPalabras.Lista
                .Select(p => new
                {
                    Palabra = p.Texto,
                    Pista1 = p.ListaPistas.ElementAtOrDefault(0),
                    Pista2 = p.ListaPistas.ElementAtOrDefault(1),
                }).ToList();


            dataGridView_MostrarPalabras.AutoGenerateColumns = true;
            dataGridView_MostrarPalabras.DataSource = palabrasPlano;

            dataGridView_MostrarPalabras.Columns["Palabra"].HeaderText = "Palabra";
            dataGridView_MostrarPalabras.Columns["Pista1"].HeaderText = "Pista 1";
            dataGridView_MostrarPalabras.Columns["Pista2"].HeaderText = "Pista 2";

        }
    }
}
