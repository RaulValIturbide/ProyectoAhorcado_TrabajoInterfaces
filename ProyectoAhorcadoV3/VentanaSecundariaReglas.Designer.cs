namespace ProyectoAhorcadoV3
{
    partial class VentanaSecundariaReglas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaSecundariaReglas));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.lbl_Instrucciones = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00031F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.99937F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00032F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Titulo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Instrucciones, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_Aceptar, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.81431F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.82141F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.36428F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Titulo.Font = new System.Drawing.Font("Verdana", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(203, 0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(393, 143);
            this.lbl_Titulo.TabIndex = 0;
            this.lbl_Titulo.Text = "COMO JUGAR";
            this.lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Instrucciones
            // 
            this.lbl_Instrucciones.AutoSize = true;
            this.lbl_Instrucciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Instrucciones.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Instrucciones.Location = new System.Drawing.Point(203, 143);
            this.lbl_Instrucciones.Name = "lbl_Instrucciones";
            this.lbl_Instrucciones.Size = new System.Drawing.Size(393, 255);
            this.lbl_Instrucciones.TabIndex = 1;
            this.lbl_Instrucciones.Text = resources.GetString("lbl_Instrucciones.Text");
            this.lbl_Instrucciones.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Aceptar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Aceptar.Location = new System.Drawing.Point(203, 401);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(393, 46);
            this.btn_Aceptar.TabIndex = 2;
            this.btn_Aceptar.Text = "Entendido";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // VentanaSecundariaReglas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximizeBox = false;
            this.Name = "VentanaSecundariaReglas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaSecundariaReglas";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Label lbl_Instrucciones;
        private System.Windows.Forms.Button btn_Aceptar;
    }
}