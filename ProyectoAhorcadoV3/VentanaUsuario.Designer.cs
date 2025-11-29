namespace ProyectoAhorcadoV3
{
    partial class VentanaUsuario
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
            this.lbl_txt_NombreUsuario = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.txtBox_NombreUsuario = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_txt_NombreUsuario, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Aceptar, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBox_NombreUsuario, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(584, 261);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_txt_NombreUsuario
            // 
            this.lbl_txt_NombreUsuario.AutoSize = true;
            this.lbl_txt_NombreUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_txt_NombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_txt_NombreUsuario.Location = new System.Drawing.Point(3, 0);
            this.lbl_txt_NombreUsuario.Name = "lbl_txt_NombreUsuario";
            this.lbl_txt_NombreUsuario.Size = new System.Drawing.Size(286, 130);
            this.lbl_txt_NombreUsuario.TabIndex = 0;
            this.lbl_txt_NombreUsuario.Text = "Nombre Usuario";
            this.lbl_txt_NombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Aceptar.Location = new System.Drawing.Point(295, 211);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(286, 47);
            this.btn_Aceptar.TabIndex = 1;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // txtBox_NombreUsuario
            // 
            this.txtBox_NombreUsuario.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtBox_NombreUsuario.Location = new System.Drawing.Point(352, 60);
            this.txtBox_NombreUsuario.Margin = new System.Windows.Forms.Padding(60);
            this.txtBox_NombreUsuario.Name = "txtBox_NombreUsuario";
            this.txtBox_NombreUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtBox_NombreUsuario.TabIndex = 2;
            // 
            // VentanaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 261);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "VentanaUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaUsuario";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_txt_NombreUsuario;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.TextBox txtBox_NombreUsuario;
    }
}