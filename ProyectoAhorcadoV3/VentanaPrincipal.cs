using ProyectoAhorcadoV3.Datos;
using ProyectoAhorcadoV3.Utilidades;
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
    public partial class VentanaPrincipal : Form
    {
        #region Propiedades Privadas
        private static Palabras palabraSeleccionada; //Esta es la palabra para la partida actual
        private static string palabraTexto = "";
        private bool pistaActivada = false; //Solo habrá una pista por partida de las diferentes variantes
        private static char[] formandoPalabra; //La palabra conforme se va formando pero dividida en un array de char
        private int contarErrores = 0;//El contador de errores de la partida
        private int intentosJugador = 0; //Las veces que el jugador a intentado adivinar en este Formulario
        private int tiempoSegundos = 0;//El tiempo que lleva la partida ejecutandose
        private Usuario Jugador = new Usuario(); //El usuario actual de la partida (default -> "invitado",no admin)
        #endregion
        public VentanaPrincipal()
        {
            InitializeComponent();

            ModificarLetraAccesibilidad(EnumTamanyoLetra.LetraMediana);

            GestionPalabras.Cargar(); 

            palabraSeleccionada = GestionPalabras.GenerarPalabraAleatoria();

            palabraTexto = palabraSeleccionada.Texto;

            formandoPalabra = new string('_', palabraTexto.Length).ToCharArray();

            label1.Text = CrearBarraBajas();

            Reproductor.ReproducirMusicaAmbiental();
           
        }

        #region Eventos 
        /// <summary>
        /// Método On click que coje la palabra del Jugador, comprueba que reuna una serie de características
        /// (solo letra,solo una ...) y comprueba si se han reunido los requisitos para terminar la partida
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnpruebaSuerte_Click(object sender, EventArgs e)
        {
            this.Validate(); //Intentando resolver el problema de fallo en la lectura del textbox (prblema con foco ¿?)
            string user = textBox1.Text.Trim().ToLower();
            Console.WriteLine("Texto Introducido: " + user + "Tamaño: " + user.Length);//TODO Corregir esto
            Error error = ValidarDatos(user); //Comprobamos que está todo correcto 

            if (error.CodigoError == 0)
            {       
                AparicionLetra(user);               
                FinalizarPartida(); //Esto comprueba si se han reunido los requisitos para ganar o perder
                textBox1.Text = "";

            }
            else
            {
                VentanaError ventana = new VentanaError(error.CodigoError, error.MensajeError);
                ventana.ShowDialog();
            }
        }
        /// <summary>
        /// Metodo que va aumentando el reloj y genera una pista si se reunen una serie de condiciones,
        /// en este caso, un determinado tiempo de partida y fallos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmr_reloj_Tick(object sender, EventArgs e)
        {

                tiempoSegundos++;
                lbl_reloj.Text = tiempoSegundos.ToString() + " s";


                if (contarErrores > 4 && tiempoSegundos > 12 && !pistaActivada)
                {
                    CrearPista();
                    pistaActivada = true;
                }

        }
        /// <summary>
        /// Este metodo ejecuta la ventana de VentanaUsuario, sirve para
        /// que el usuario pueda personalizar su nombre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void personalizarNombreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmr_reloj.Stop();
            VentanaUsuario PersonalizarUsuario = new VentanaUsuario(Jugador);
            PersonalizarUsuario.ShowDialog();
            tmr_reloj.Start();
            txt_MostrarNombreUsuario.Text = Jugador.NombreUsuario;
            if (Jugador.NombreUsuario.Equals("admin"))
            {
                modoDesarrolToolStripMenuItem.Visible = true;
            }
            else
            {
                modoDesarrolToolStripMenuItem.Visible = false;
            }
        }


        private void letraPequeñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarLetraAccesibilidad(EnumTamanyoLetra.LetraPequenya);
        }

        private void letraMedianaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarLetraAccesibilidad(EnumTamanyoLetra.LetraMediana);
        }

        private void letraGrandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarLetraAccesibilidad(EnumTamanyoLetra.LetraGrande);
        }

        private void comoJugarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmr_reloj.Stop();
            VentanaSecundariaReglas ventanaSecundariaReglas = new VentanaSecundariaReglas();
            ventanaSecundariaReglas.ShowDialog();
            tmr_reloj.Start();
        }
        private void Menu_generarNuevaPalabra_Click(object sender, EventArgs e)
        {
            tmr_reloj.Stop();
            VentanaAgregarPalabra ventanaAgregarPalabra = new VentanaAgregarPalabra();
            ventanaAgregarPalabra.ShowDialog();
            tmr_reloj.Start();
        }
        private void verTodasLasPalabrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmr_reloj.Stop();
            VentanaTodasPalabras ventanaTodasPalabras = new VentanaTodasPalabras();
            ventanaTodasPalabras.ShowDialog();
            tmr_reloj.Start();
        }


        #endregion

        #region Metodos Privados
        /// <summary>
        /// Este metodo sirve para visualizar las barras de la palabra sin mostrarlas al principio de la partida
        /// </summary>
        /// <returns>Devuelve el tamaño de la palabra en un string compuesto por "_" por cada letra</returns>
        private string CrearBarraBajas()
        {
            string escritura = "";
            for (int i = 0; i < palabraTexto.Length; i++)
            {
                escritura += "_ ";
            }
            return escritura;
        }

        /// <summary>
        /// Este metodo sirve para Comprobar si la letra (usuario) introducida por el Jugador está en la palabra
        /// de la partida, si es así la revela, si no, aumenta los errores en +1, en ambos casos añade la letra a 
        /// las letras seleccionadas 
        /// </summary>
        /// <param name="usuario">La letra proporcionada por el Jugador</param>
        private void AparicionLetra(string usuario)
        {
            char letra = usuario[0]; // tomamos el primer carácter
            bool encontrada = false;
            intentosJugador++;
            for (int i = 0; i < palabraTexto.Length; i++)
            {
                 if (palabraTexto[i] == letra)
                 {
                    formandoPalabra[i] = letra;
                    encontrada = true;
                }          
            }
            if (!encontrada)
            {
                contarErrores++;
                if (contarErrores == 1)
                {
                    lbl_intentos.Text = $"{contarErrores} fallo";
                }
                else
                {
                    lbl_intentos.Text = $"{contarErrores} fallos";
                }
                DibujarError(contarErrores);                    
            }
            if (!YaExiste(usuario))
            {
                lbl_letrasSeleccionadas.Text += usuario[0] + ",";
            }
           
           label1.Text = string.Join(" ", formandoPalabra);       
        }
        private bool YaExiste(string letraUsuario)
        {
            return lbl_letrasSeleccionadas.Text.Contains(letraUsuario);
        }
        /// <summary>
        /// Este metodo sirve para comprobar si el usuario está introduciendo bien los datos,
        /// es decir, que no introduzca: caracteres especiales,números,más de una letra etc
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>Devolverá el error con su código, si es 0 es que está correcto</returns>
        private Error ValidarDatos(string usuario)
        {
            Error error = new Error();
            StringBuilder constructor = new StringBuilder();
            int contadorErrores = 0;

            if (usuario.Length == 0)
            {
                contadorErrores++;
                error.CodigoError = 101;
                constructor.AppendLine($"{contadorErrores}-Escribe una letra!! ^^");
            }
            else if (!char.IsLetter(usuario[0]) || usuario[0] == ' ')
            {
                 contadorErrores++;
                 error.CodigoError = 103;
                 constructor.AppendLine($"{contadorErrores}-Solo valen letras amig@ ^^");
                
            }
            if (usuario.Length > 1)
            {
                contadorErrores++;
                error.CodigoError = 102;
                constructor.AppendLine($"{contadorErrores}-Solo puedes escribir una única letra");
            }

            if (error.CodigoError != 0)
            {
                error.MensajeError = $"Casi pero no:{Environment.NewLine}{constructor.ToString()}";
            }
            return error;
        }


        /// <summary>
        /// Bruto pero efectivo ^^
        /// Básicamente son 11 imágenes con las 11 posibles situaciones de nuestro ahorcado, 
        /// dependiendo de los errores dibujará una u otra hasta completarse el ahorcado o ganar la partida
        /// </summary>
        /// <param name="numError"></param>
        private void DibujarError(int numError)
        {
            if (numError < 11)
            {
                switch (numError)
                {
                    case 1:
                        img_imagenAhorcado.Image = Properties.Resources.ahorcado_1;
                    break;
                    case 2:
                        img_imagenAhorcado.Image = Properties.Resources.ahorcado_2;
                    break;
                    case 3:
                        img_imagenAhorcado.Image = Properties.Resources.ahorcado_3;
                    break;
                    case 4:
                        img_imagenAhorcado.Image = Properties.Resources.ahorcado_4;
                    break;
                    case 5:
                        img_imagenAhorcado.Image = Properties.Resources.ahorcado_5;
                    break;
                    case 6:
                        img_imagenAhorcado.Image = Properties.Resources.ahorcado_6;
                    break;
                    case 7:
                        img_imagenAhorcado.Image = Properties.Resources.ahorcado_7;
                    break;
                    case 8:
                        img_imagenAhorcado.Image = Properties.Resources.ahorcado_8;
                    break;
                    case 9:
                        img_imagenAhorcado.Image = Properties.Resources.ahorcado_9;
                    break;
                    case 10:
                        img_imagenAhorcado.Image = Properties.Resources.ahorcado_10;
                    break;
                    case 11:
                        img_imagenAhorcado.Image = Properties.Resources.ahorcado_11;
                    break;
                }
            }
        }

        /// <summary>
        /// Este metodo abre la ventana "VentanaFinal" cuando se han reunido las condiciones para terminar la partida
        /// (victoria o derrota) y muestra al jugador las estadísticas 
        /// </summary>
        private void FinalizarPartida()
        {
            if (palabraTexto.Equals(new string(formandoPalabra)))
            {
                tmr_reloj.Stop();
                VentanaFinal ventana = new VentanaFinal(this,true, palabraTexto, contarErrores,tiempoSegundos, intentosJugador, Jugador.NombreUsuario);
                ventana.ShowDialog();
                tmr_reloj.Start();
            }
            else if(contarErrores > 10)
            {
                tmr_reloj.Stop();
                VentanaFinal ventana = new VentanaFinal(this,false, palabraTexto, contarErrores, tiempoSegundos,intentosJugador,Jugador.NombreUsuario);
                ventana.ShowDialog();
                tmr_reloj.Start();
            }

        }
        /// <summary>
        /// Todo se pone a "0" y se genera otra palabra aleatoria dando comienzo a una nueva partida,
        /// a este metodo lo llamamos desde el boton reiniciar del formulario VentanaFinal al activar el 
        /// botón "reiniciar"
        /// </summary>
        public void ReiniciarJuego()
        {
            tiempoSegundos = 0;
            contarErrores = 0;
            intentosJugador = 0;
            palabraTexto = GestionPalabras.GenerarPalabraAleatoria().Texto;
            formandoPalabra = new string('_', palabraTexto.Length).ToCharArray();
            label1.Text = CrearBarraBajas();
            img_imagenAhorcado.Image = null;
            lbl_pista.Text = "";
            lbl_reloj.Text = "0 s";
            lbl_letrasSeleccionadas.Text = "";
            btn_pruebaSuerte.Enabled = true;
            lbl_intentos.Text = $"{contarErrores} fallos";
            Reproductor.ReproducirMusicaAmbiental();
        }

        /// <summary>
        /// Este metodo ejecuta la pedida de una pista dentro de las, por ahora, 2 posibles pistas por palabras
        /// </summary>
        private void CrearPista()
        {
            Random random = new Random();
            lbl_pista.Visible = true;
            lbl_pista.Text =  "PISTA: " + palabraSeleccionada.ListaPistas.ElementAt<string>(random.Next(0, palabraSeleccionada.ListaPistas.Count));          

        }

        /// <summary>
        /// Metodo para cambiar la fuente de toda la pantalla por accesibilidad
        /// </summary>
        /// <param name="tamanyoLetra"></param>
        private void ModificarLetraAccesibilidad(EnumTamanyoLetra tamanyoLetra)
        {
           switch (tamanyoLetra)
                  {
               case EnumTamanyoLetra.LetraPequenya:
                    lbl_Titulo.Font = new Font("Verdana", 15, FontStyle.Bold);
                    lbl_txt_LetrasSeleccionadas.Font = new Font("Verdana", 11, FontStyle.Bold);
                    lbl_letrasSeleccionadas.Font = new Font("Verdana", 7, FontStyle.Regular);
                    textBox1.Font = new Font("Verdana", 7, FontStyle.Regular);
                    btn_pruebaSuerte.Font = new Font("Verdana", 7, FontStyle.Bold);
                    lbl_reloj.Font = new Font("Verdana", 7, FontStyle.Bold);
                    lbl_intentos.Font = new Font("Verdana", 11, FontStyle.Bold);
                    lbl_pista.Font = new Font("Verdana", 8, FontStyle.Regular);

                    letraPequeñaToolStripMenuItem.Checked = true;
                    letraMedianaToolStripMenuItem.Checked = false;
                    letraGrandeToolStripMenuItem.Checked = false;
                    break;

               case EnumTamanyoLetra.LetraMediana:
                    lbl_Titulo.Font = new Font("Verdana", 22, FontStyle.Bold);
                    lbl_txt_LetrasSeleccionadas.Font = new Font("Verdana", 16, FontStyle.Bold);
                    lbl_letrasSeleccionadas.Font = new Font("Verdana", 12, FontStyle.Regular);
                    textBox1.Font = new Font("Verdana", 12, FontStyle.Regular);
                    btn_pruebaSuerte.Font = new Font("Verdana", 12, FontStyle.Bold);
                    lbl_reloj.Font = new Font("Verdana", 12, FontStyle.Bold);
                    lbl_intentos.Font = new Font("Verdana", 16, FontStyle.Bold);
                    lbl_pista.Font = new Font("Verdana", 11, FontStyle.Regular);

                    letraPequeñaToolStripMenuItem.Checked = false;
                    letraMedianaToolStripMenuItem.Checked = true;
                    letraGrandeToolStripMenuItem.Checked = false;
                    break;

               case EnumTamanyoLetra.LetraGrande:
                    lbl_Titulo.Font = new Font("Verdana", 28, FontStyle.Bold);
                    lbl_txt_LetrasSeleccionadas.Font = new Font("Verdana", 20, FontStyle.Bold);
                    lbl_letrasSeleccionadas.Font = new Font("Verdana", 16, FontStyle.Regular);
                    textBox1.Font = new Font("Verdana", 16, FontStyle.Regular);
                    btn_pruebaSuerte.Font = new Font("Verdana", 16, FontStyle.Bold);
                    lbl_reloj.Font = new Font("Verdana", 16, FontStyle.Bold);
                    lbl_intentos.Font = new Font("Verdana", 20, FontStyle.Bold);
                    lbl_pista.Font = new Font("Verdana", 14, FontStyle.Regular);

                    letraPequeñaToolStripMenuItem.Checked = false;
                    letraMedianaToolStripMenuItem.Checked = false;
                    letraGrandeToolStripMenuItem.Checked = true;
                    break;
            }

        }

        #endregion


    }
}

