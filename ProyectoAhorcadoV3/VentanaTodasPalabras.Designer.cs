namespace ProyectoAhorcadoV3
{
    partial class VentanaTodasPalabras
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
            this.dataGridView_MostrarPalabras = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MostrarPalabras)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_MostrarPalabras
            // 
            this.dataGridView_MostrarPalabras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_MostrarPalabras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MostrarPalabras.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_MostrarPalabras.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_MostrarPalabras.Name = "dataGridView_MostrarPalabras";
            this.dataGridView_MostrarPalabras.Size = new System.Drawing.Size(584, 261);
            this.dataGridView_MostrarPalabras.TabIndex = 0;
            // 
            // VentanaTodasPalabras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.dataGridView_MostrarPalabras);
            this.Name = "VentanaTodasPalabras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaTodasPalabras";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MostrarPalabras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_MostrarPalabras;
    }
}