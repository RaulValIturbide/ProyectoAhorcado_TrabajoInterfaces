namespace ProyectoAhorcadoV3
{
    partial class VentanaFinal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.lbl_txt_Palabra = new System.Windows.Forms.Label();
            this.lbl_palabraSeleccionada = new System.Windows.Forms.Label();
            this.lbl_txt_errores = new System.Windows.Forms.Label();
            this.lbl_contadorErrores = new System.Windows.Forms.Label();
            this.lbl_txt_tiempo = new System.Windows.Forms.Label();
            this.lbl_tiempoTotal = new System.Windows.Forms.Label();
            this.btn_reiniciar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_resultado, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_txt_Palabra, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_palabraSeleccionada, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_txt_errores, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_contadorErrores, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_txt_tiempo, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_tiempoTotal, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.btn_reiniciar, 2, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lbl_resultado, 3);
            this.lbl_resultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_resultado.Font = new System.Drawing.Font("MS Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.Location = new System.Drawing.Point(163, 0);
            this.lbl_resultado.Name = "lbl_resultado";
            this.tableLayoutPanel1.SetRowSpan(this.lbl_resultado, 2);
            this.lbl_resultado.Size = new System.Drawing.Size(474, 150);
            this.lbl_resultado.TabIndex = 0;
            this.lbl_resultado.Text = "lbl_Resultado";
            this.lbl_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_txt_Palabra
            // 
            this.lbl_txt_Palabra.AutoSize = true;
            this.lbl_txt_Palabra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_txt_Palabra.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_txt_Palabra.Location = new System.Drawing.Point(163, 150);
            this.lbl_txt_Palabra.Name = "lbl_txt_Palabra";
            this.lbl_txt_Palabra.Size = new System.Drawing.Size(154, 75);
            this.lbl_txt_Palabra.TabIndex = 1;
            this.lbl_txt_Palabra.Text = "La Palabra era";
            this.lbl_txt_Palabra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_palabraSeleccionada
            // 
            this.lbl_palabraSeleccionada.AutoSize = true;
            this.lbl_palabraSeleccionada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_palabraSeleccionada.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_palabraSeleccionada.Location = new System.Drawing.Point(483, 150);
            this.lbl_palabraSeleccionada.Name = "lbl_palabraSeleccionada";
            this.lbl_palabraSeleccionada.Size = new System.Drawing.Size(154, 75);
            this.lbl_palabraSeleccionada.TabIndex = 2;
            this.lbl_palabraSeleccionada.Text = "palabra_seleccionada";
            this.lbl_palabraSeleccionada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_txt_errores
            // 
            this.lbl_txt_errores.AutoSize = true;
            this.lbl_txt_errores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_txt_errores.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_txt_errores.Location = new System.Drawing.Point(163, 225);
            this.lbl_txt_errores.Name = "lbl_txt_errores";
            this.lbl_txt_errores.Size = new System.Drawing.Size(154, 75);
            this.lbl_txt_errores.TabIndex = 3;
            this.lbl_txt_errores.Text = "Errores";
            this.lbl_txt_errores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_contadorErrores
            // 
            this.lbl_contadorErrores.AutoSize = true;
            this.lbl_contadorErrores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_contadorErrores.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contadorErrores.Location = new System.Drawing.Point(483, 225);
            this.lbl_contadorErrores.Name = "lbl_contadorErrores";
            this.lbl_contadorErrores.Size = new System.Drawing.Size(154, 75);
            this.lbl_contadorErrores.TabIndex = 4;
            this.lbl_contadorErrores.Text = "contador_errores";
            this.lbl_contadorErrores.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_txt_tiempo
            // 
            this.lbl_txt_tiempo.AutoSize = true;
            this.lbl_txt_tiempo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_txt_tiempo.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_txt_tiempo.Location = new System.Drawing.Point(163, 300);
            this.lbl_txt_tiempo.Name = "lbl_txt_tiempo";
            this.lbl_txt_tiempo.Size = new System.Drawing.Size(154, 75);
            this.lbl_txt_tiempo.TabIndex = 5;
            this.lbl_txt_tiempo.Text = "Tiempo";
            this.lbl_txt_tiempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_tiempoTotal
            // 
            this.lbl_tiempoTotal.AutoSize = true;
            this.lbl_tiempoTotal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_tiempoTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tiempoTotal.Location = new System.Drawing.Point(483, 300);
            this.lbl_tiempoTotal.Name = "lbl_tiempoTotal";
            this.lbl_tiempoTotal.Size = new System.Drawing.Size(154, 75);
            this.lbl_tiempoTotal.TabIndex = 6;
            this.lbl_tiempoTotal.Text = "tiempo_total";
            this.lbl_tiempoTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_reiniciar
            // 
            this.btn_reiniciar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_reiniciar.Location = new System.Drawing.Point(323, 378);
            this.btn_reiniciar.Name = "btn_reiniciar";
            this.btn_reiniciar.Size = new System.Drawing.Size(154, 69);
            this.btn_reiniciar.TabIndex = 7;
            this.btn_reiniciar.Text = "Reiniciar";
            this.btn_reiniciar.UseVisualStyleBackColor = true;
            this.btn_reiniciar.Click += new System.EventHandler(this.btn_reiniciar_Click);
            // 
            // VentanaFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "VentanaFinal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaFinal";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Label lbl_txt_Palabra;
        private System.Windows.Forms.Label lbl_palabraSeleccionada;
        private System.Windows.Forms.Label lbl_txt_errores;
        private System.Windows.Forms.Label lbl_contadorErrores;
        private System.Windows.Forms.Label lbl_txt_tiempo;
        private System.Windows.Forms.Label lbl_tiempoTotal;
        private System.Windows.Forms.Button btn_reiniciar;
    }
}