namespace ProyectoAhorcadoV3
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_pruebaSuerte = new System.Windows.Forms.Button();
            this.txtBox_Usuario = new System.Windows.Forms.TextBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_reloj = new System.Windows.Forms.Label();
            this.lbl_pista = new System.Windows.Forms.Label();
            this.lbl_txt_LetrasSeleccionadas = new System.Windows.Forms.Label();
            this.lbl_letrasSeleccionadas = new System.Windows.Forms.Label();
            this.lbl_intentos = new System.Windows.Forms.Label();
            this.tmr_reloj = new System.Windows.Forms.Timer(this.components);
            this.menu_Strip = new System.Windows.Forms.MenuStrip();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_MostrarNombreUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.personalizarNombreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accesibilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.letraPequeñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.letraMedianaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.letraGrandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modoDesarrolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_generarNuevaPalabra = new System.Windows.Forms.ToolStripMenuItem();
            this.verTodasLasPalabrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comoJugarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.img_imagenAhorcado = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.menu_Strip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_imagenAhorcado)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.948391F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.17527F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.17527F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.17527F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.17527F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.17527F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.17527F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_pruebaSuerte, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtBox_Usuario, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Titulo, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.img_imagenAhorcado, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_reloj, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_pista, 4, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_txt_LetrasSeleccionadas, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_letrasSeleccionadas, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_intentos, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(814, 437);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Palabra_Seleccionada";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_pruebaSuerte
            // 
            this.btn_pruebaSuerte.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_pruebaSuerte.Location = new System.Drawing.Point(205, 320);
            this.btn_pruebaSuerte.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_pruebaSuerte.Name = "btn_pruebaSuerte";
            this.btn_pruebaSuerte.Size = new System.Drawing.Size(113, 40);
            this.btn_pruebaSuerte.TabIndex = 2;
            this.btn_pruebaSuerte.Text = "Jugar";
            this.btn_pruebaSuerte.UseVisualStyleBackColor = true;
            this.btn_pruebaSuerte.Click += new System.EventHandler(this.btnpruebaSuerte_Click);
            // 
            // txtBox_Usuario
            // 
            this.txtBox_Usuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtBox_Usuario.Location = new System.Drawing.Point(72, 340);
            this.txtBox_Usuario.Margin = new System.Windows.Forms.Padding(0);
            this.txtBox_Usuario.Name = "txtBox_Usuario";
            this.txtBox_Usuario.Size = new System.Drawing.Size(123, 20);
            this.txtBox_Usuario.TabIndex = 1;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbl_Titulo, 4);
            this.lbl_Titulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Titulo.Font = new System.Drawing.Font("MS PGothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(198, 0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(486, 72);
            this.lbl_Titulo.TabIndex = 3;
            this.lbl_Titulo.Text = "EL AHORCADO";
            this.lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_reloj
            // 
            this.lbl_reloj.AutoSize = true;
            this.lbl_reloj.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_reloj.Location = new System.Drawing.Point(3, 424);
            this.lbl_reloj.Name = "lbl_reloj";
            this.lbl_reloj.Size = new System.Drawing.Size(66, 13);
            this.lbl_reloj.TabIndex = 5;
            this.lbl_reloj.Text = "0 s";
            // 
            // lbl_pista
            // 
            this.lbl_pista.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbl_pista, 3);
            this.lbl_pista.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_pista.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pista.Location = new System.Drawing.Point(444, 360);
            this.lbl_pista.Name = "lbl_pista";
            this.lbl_pista.Size = new System.Drawing.Size(367, 77);
            this.lbl_pista.TabIndex = 6;
            this.lbl_pista.Text = "Pista";
            this.lbl_pista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_pista.Visible = false;
            // 
            // lbl_txt_LetrasSeleccionadas
            // 
            this.lbl_txt_LetrasSeleccionadas.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbl_txt_LetrasSeleccionadas, 2);
            this.lbl_txt_LetrasSeleccionadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_txt_LetrasSeleccionadas.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_txt_LetrasSeleccionadas.Location = new System.Drawing.Point(75, 72);
            this.lbl_txt_LetrasSeleccionadas.Name = "lbl_txt_LetrasSeleccionadas";
            this.lbl_txt_LetrasSeleccionadas.Size = new System.Drawing.Size(240, 72);
            this.lbl_txt_LetrasSeleccionadas.TabIndex = 7;
            this.lbl_txt_LetrasSeleccionadas.Text = "Letras Seleccionadas";
            this.lbl_txt_LetrasSeleccionadas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_letrasSeleccionadas
            // 
            this.lbl_letrasSeleccionadas.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbl_letrasSeleccionadas, 2);
            this.lbl_letrasSeleccionadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_letrasSeleccionadas.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_letrasSeleccionadas.Location = new System.Drawing.Point(75, 144);
            this.lbl_letrasSeleccionadas.Name = "lbl_letrasSeleccionadas";
            this.lbl_letrasSeleccionadas.Size = new System.Drawing.Size(240, 72);
            this.lbl_letrasSeleccionadas.TabIndex = 8;
            this.lbl_letrasSeleccionadas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_intentos
            // 
            this.lbl_intentos.AutoSize = true;
            this.lbl_intentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_intentos.Location = new System.Drawing.Point(321, 144);
            this.lbl_intentos.Name = "lbl_intentos";
            this.lbl_intentos.Size = new System.Drawing.Size(117, 72);
            this.lbl_intentos.TabIndex = 9;
            this.lbl_intentos.Text = "0 fallos";
            this.lbl_intentos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmr_reloj
            // 
            this.tmr_reloj.Enabled = true;
            this.tmr_reloj.Interval = 1000;
            this.tmr_reloj.Tick += new System.EventHandler(this.tmr_reloj_Tick);
            // 
            // menu_Strip
            // 
            this.menu_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraciónToolStripMenuItem,
            this.modoDesarrolToolStripMenuItem,
            this.comoJugarToolStripMenuItem1});
            this.menu_Strip.Location = new System.Drawing.Point(0, 0);
            this.menu_Strip.Name = "menu_Strip";
            this.menu_Strip.Size = new System.Drawing.Size(814, 24);
            this.menu_Strip.TabIndex = 1;
            this.menu_Strip.Text = "menu_Configuracion";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nombreUsuarioToolStripMenuItem,
            this.accesibilidadToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // nombreUsuarioToolStripMenuItem
            // 
            this.nombreUsuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txt_MostrarNombreUsuario,
            this.personalizarNombreToolStripMenuItem});
            this.nombreUsuarioToolStripMenuItem.Name = "nombreUsuarioToolStripMenuItem";
            this.nombreUsuarioToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.nombreUsuarioToolStripMenuItem.Text = "Nombre Usuario";
            // 
            // txt_MostrarNombreUsuario
            // 
            this.txt_MostrarNombreUsuario.Name = "txt_MostrarNombreUsuario";
            this.txt_MostrarNombreUsuario.Size = new System.Drawing.Size(184, 22);
            this.txt_MostrarNombreUsuario.Text = "Invitado";
            // 
            // personalizarNombreToolStripMenuItem
            // 
            this.personalizarNombreToolStripMenuItem.Name = "personalizarNombreToolStripMenuItem";
            this.personalizarNombreToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.personalizarNombreToolStripMenuItem.Text = "Personalizar Nombre";
            this.personalizarNombreToolStripMenuItem.Click += new System.EventHandler(this.personalizarNombreToolStripMenuItem_Click);
            // 
            // accesibilidadToolStripMenuItem
            // 
            this.accesibilidadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.letraPequeñaToolStripMenuItem,
            this.letraMedianaToolStripMenuItem,
            this.letraGrandeToolStripMenuItem});
            this.accesibilidadToolStripMenuItem.Name = "accesibilidadToolStripMenuItem";
            this.accesibilidadToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.accesibilidadToolStripMenuItem.Text = "Accesibilidad";
            // 
            // letraPequeñaToolStripMenuItem
            // 
            this.letraPequeñaToolStripMenuItem.Name = "letraPequeñaToolStripMenuItem";
            this.letraPequeñaToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.letraPequeñaToolStripMenuItem.Text = "Letra Pequeña";
            this.letraPequeñaToolStripMenuItem.Click += new System.EventHandler(this.letraPequeñaToolStripMenuItem_Click);
            // 
            // letraMedianaToolStripMenuItem
            // 
            this.letraMedianaToolStripMenuItem.Name = "letraMedianaToolStripMenuItem";
            this.letraMedianaToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.letraMedianaToolStripMenuItem.Text = "Letra Mediana";
            this.letraMedianaToolStripMenuItem.Click += new System.EventHandler(this.letraMedianaToolStripMenuItem_Click);
            // 
            // letraGrandeToolStripMenuItem
            // 
            this.letraGrandeToolStripMenuItem.Name = "letraGrandeToolStripMenuItem";
            this.letraGrandeToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.letraGrandeToolStripMenuItem.Text = "Letra Grande";
            this.letraGrandeToolStripMenuItem.Click += new System.EventHandler(this.letraGrandeToolStripMenuItem_Click);
            // 
            // modoDesarrolToolStripMenuItem
            // 
            this.modoDesarrolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_generarNuevaPalabra,
            this.verTodasLasPalabrasToolStripMenuItem});
            this.modoDesarrolToolStripMenuItem.Name = "modoDesarrolToolStripMenuItem";
            this.modoDesarrolToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.modoDesarrolToolStripMenuItem.Text = "Modo Desarrollador";
            this.modoDesarrolToolStripMenuItem.Visible = false;
            // 
            // Menu_generarNuevaPalabra
            // 
            this.Menu_generarNuevaPalabra.Name = "Menu_generarNuevaPalabra";
            this.Menu_generarNuevaPalabra.Size = new System.Drawing.Size(194, 22);
            this.Menu_generarNuevaPalabra.Text = "Generar Nueva Palabra";
            this.Menu_generarNuevaPalabra.Click += new System.EventHandler(this.Menu_generarNuevaPalabra_Click);
            // 
            // verTodasLasPalabrasToolStripMenuItem
            // 
            this.verTodasLasPalabrasToolStripMenuItem.Name = "verTodasLasPalabrasToolStripMenuItem";
            this.verTodasLasPalabrasToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.verTodasLasPalabrasToolStripMenuItem.Text = "Ver Todas las Palabras";
            this.verTodasLasPalabrasToolStripMenuItem.Click += new System.EventHandler(this.verTodasLasPalabrasToolStripMenuItem_Click);
            // 
            // comoJugarToolStripMenuItem1
            // 
            this.comoJugarToolStripMenuItem1.Name = "comoJugarToolStripMenuItem1";
            this.comoJugarToolStripMenuItem1.Size = new System.Drawing.Size(83, 20);
            this.comoJugarToolStripMenuItem1.Text = "Como Jugar";
            this.comoJugarToolStripMenuItem1.Click += new System.EventHandler(this.comoJugarToolStripMenuItem1_Click);
            // 
            // img_imagenAhorcado
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.img_imagenAhorcado, 3);
            this.img_imagenAhorcado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.img_imagenAhorcado.Location = new System.Drawing.Point(444, 75);
            this.img_imagenAhorcado.Name = "img_imagenAhorcado";
            this.tableLayoutPanel1.SetRowSpan(this.img_imagenAhorcado, 4);
            this.img_imagenAhorcado.Size = new System.Drawing.Size(367, 282);
            this.img_imagenAhorcado.TabIndex = 4;
            this.img_imagenAhorcado.TabStop = false;
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menu_Strip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu_Strip;
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EL AHORCADO";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menu_Strip.ResumeLayout(false);
            this.menu_Strip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_imagenAhorcado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_Usuario;
        private System.Windows.Forms.Button btn_pruebaSuerte;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.PictureBox img_imagenAhorcado;
        private System.Windows.Forms.Label lbl_reloj;
        private System.Windows.Forms.Timer tmr_reloj;
        private System.Windows.Forms.Label lbl_pista;
        private System.Windows.Forms.Label lbl_txt_LetrasSeleccionadas;
        private System.Windows.Forms.Label lbl_letrasSeleccionadas;
        private System.Windows.Forms.Label lbl_intentos;
        private System.Windows.Forms.MenuStrip menu_Strip;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modoDesarrolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nombreUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accesibilidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem letraPequeñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem letraMedianaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem letraGrandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem txt_MostrarNombreUsuario;
        private System.Windows.Forms.ToolStripMenuItem personalizarNombreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_generarNuevaPalabra;
        private System.Windows.Forms.ToolStripMenuItem verTodasLasPalabrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comoJugarToolStripMenuItem1;
    }
}

