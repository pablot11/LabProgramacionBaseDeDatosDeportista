namespace pryTorresBaseDeDatos
{
    partial class frmCargarEntrenador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargarEntrenador));
            this.txtDireccionEntrenador = new System.Windows.Forms.TextBox();
            this.txtApellidoEntrenador = new System.Windows.Forms.TextBox();
            this.txtNombreEntrenador = new System.Windows.Forms.TextBox();
            this.lblCodigoEntrenador = new System.Windows.Forms.Label();
            this.lblDireccionEntrenador = new System.Windows.Forms.Label();
            this.lblApellidoEntrenador = new System.Windows.Forms.Label();
            this.lblNombreEntrenador = new System.Windows.Forms.Label();
            this.lblProvinciaEntrenador = new System.Windows.Forms.Label();
            this.txtProvinciaEntrenador = new System.Windows.Forms.TextBox();
            this.lblDeporteEntrenador = new System.Windows.Forms.Label();
            this.lstDeporteEntrenador = new System.Windows.Forms.ComboBox();
            this.btnCargarEntrenador = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.mrcCargarEntrenador = new System.Windows.Forms.GroupBox();
            this.txtCodigoEntrenador = new System.Windows.Forms.TextBox();
            this.mrcCargarEntrenador.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDireccionEntrenador
            // 
            this.txtDireccionEntrenador.Location = new System.Drawing.Point(96, 108);
            this.txtDireccionEntrenador.MaxLength = 25;
            this.txtDireccionEntrenador.Name = "txtDireccionEntrenador";
            this.txtDireccionEntrenador.Size = new System.Drawing.Size(100, 20);
            this.txtDireccionEntrenador.TabIndex = 4;
            this.txtDireccionEntrenador.TextChanged += new System.EventHandler(this.txtDireccionEntrenador_TextChanged);
            // 
            // txtApellidoEntrenador
            // 
            this.txtApellidoEntrenador.Location = new System.Drawing.Point(96, 82);
            this.txtApellidoEntrenador.MaxLength = 15;
            this.txtApellidoEntrenador.Name = "txtApellidoEntrenador";
            this.txtApellidoEntrenador.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoEntrenador.TabIndex = 3;
            this.txtApellidoEntrenador.TextChanged += new System.EventHandler(this.txtApellidoEntrenador_TextChanged);
            this.txtApellidoEntrenador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellidoEntrenador_KeyPress);
            // 
            // txtNombreEntrenador
            // 
            this.txtNombreEntrenador.Location = new System.Drawing.Point(96, 56);
            this.txtNombreEntrenador.MaxLength = 15;
            this.txtNombreEntrenador.Name = "txtNombreEntrenador";
            this.txtNombreEntrenador.Size = new System.Drawing.Size(100, 20);
            this.txtNombreEntrenador.TabIndex = 2;
            this.txtNombreEntrenador.TextChanged += new System.EventHandler(this.txtNombreEntrenador_TextChanged);
            this.txtNombreEntrenador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreEntrenador_KeyPress);
            // 
            // lblCodigoEntrenador
            // 
            this.lblCodigoEntrenador.AutoSize = true;
            this.lblCodigoEntrenador.Location = new System.Drawing.Point(6, 30);
            this.lblCodigoEntrenador.Name = "lblCodigoEntrenador";
            this.lblCodigoEntrenador.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoEntrenador.TabIndex = 4;
            this.lblCodigoEntrenador.Text = "Codigo:";
            // 
            // lblDireccionEntrenador
            // 
            this.lblDireccionEntrenador.AutoSize = true;
            this.lblDireccionEntrenador.Location = new System.Drawing.Point(6, 108);
            this.lblDireccionEntrenador.Name = "lblDireccionEntrenador";
            this.lblDireccionEntrenador.Size = new System.Drawing.Size(55, 13);
            this.lblDireccionEntrenador.TabIndex = 5;
            this.lblDireccionEntrenador.Text = "Dirección:";
            // 
            // lblApellidoEntrenador
            // 
            this.lblApellidoEntrenador.AutoSize = true;
            this.lblApellidoEntrenador.Location = new System.Drawing.Point(6, 82);
            this.lblApellidoEntrenador.Name = "lblApellidoEntrenador";
            this.lblApellidoEntrenador.Size = new System.Drawing.Size(47, 13);
            this.lblApellidoEntrenador.TabIndex = 6;
            this.lblApellidoEntrenador.Text = "Apellido:";
            // 
            // lblNombreEntrenador
            // 
            this.lblNombreEntrenador.AutoSize = true;
            this.lblNombreEntrenador.Location = new System.Drawing.Point(6, 56);
            this.lblNombreEntrenador.Name = "lblNombreEntrenador";
            this.lblNombreEntrenador.Size = new System.Drawing.Size(47, 13);
            this.lblNombreEntrenador.TabIndex = 7;
            this.lblNombreEntrenador.Text = "Nombre:";
            // 
            // lblProvinciaEntrenador
            // 
            this.lblProvinciaEntrenador.AutoSize = true;
            this.lblProvinciaEntrenador.Location = new System.Drawing.Point(6, 134);
            this.lblProvinciaEntrenador.Name = "lblProvinciaEntrenador";
            this.lblProvinciaEntrenador.Size = new System.Drawing.Size(54, 13);
            this.lblProvinciaEntrenador.TabIndex = 8;
            this.lblProvinciaEntrenador.Text = "Provincia:";
            // 
            // txtProvinciaEntrenador
            // 
            this.txtProvinciaEntrenador.Location = new System.Drawing.Point(96, 134);
            this.txtProvinciaEntrenador.MaxLength = 15;
            this.txtProvinciaEntrenador.Name = "txtProvinciaEntrenador";
            this.txtProvinciaEntrenador.Size = new System.Drawing.Size(100, 20);
            this.txtProvinciaEntrenador.TabIndex = 5;
            this.txtProvinciaEntrenador.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtProvinciaEntrenador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProvinciaEntrenador_KeyPress);
            // 
            // lblDeporteEntrenador
            // 
            this.lblDeporteEntrenador.AutoSize = true;
            this.lblDeporteEntrenador.Location = new System.Drawing.Point(6, 160);
            this.lblDeporteEntrenador.Name = "lblDeporteEntrenador";
            this.lblDeporteEntrenador.Size = new System.Drawing.Size(48, 13);
            this.lblDeporteEntrenador.TabIndex = 10;
            this.lblDeporteEntrenador.Text = "Deporte:";
            // 
            // lstDeporteEntrenador
            // 
            this.lstDeporteEntrenador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstDeporteEntrenador.FormattingEnabled = true;
            this.lstDeporteEntrenador.Items.AddRange(new object[] {
            "TENIS",
            "BASQUET",
            "CICLISMO",
            "FUTBOL",
            "RUGBY",
            "ATLETISMO",
            "PADEL",
            "HANDBALL"});
            this.lstDeporteEntrenador.Location = new System.Drawing.Point(96, 160);
            this.lstDeporteEntrenador.Name = "lstDeporteEntrenador";
            this.lstDeporteEntrenador.Size = new System.Drawing.Size(100, 21);
            this.lstDeporteEntrenador.TabIndex = 6;
            this.lstDeporteEntrenador.SelectedIndexChanged += new System.EventHandler(this.lstDeporteEntrenador_SelectedIndexChanged);
            // 
            // btnCargarEntrenador
            // 
            this.btnCargarEntrenador.Enabled = false;
            this.btnCargarEntrenador.Location = new System.Drawing.Point(137, 220);
            this.btnCargarEntrenador.Name = "btnCargarEntrenador";
            this.btnCargarEntrenador.Size = new System.Drawing.Size(75, 23);
            this.btnCargarEntrenador.TabIndex = 13;
            this.btnCargarEntrenador.Text = "Cargar";
            this.btnCargarEntrenador.UseVisualStyleBackColor = true;
            this.btnCargarEntrenador.Click += new System.EventHandler(this.btnCargarEntrenador_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 220);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // mrcCargarEntrenador
            // 
            this.mrcCargarEntrenador.Controls.Add(this.txtCodigoEntrenador);
            this.mrcCargarEntrenador.Controls.Add(this.lblCodigoEntrenador);
            this.mrcCargarEntrenador.Controls.Add(this.txtDireccionEntrenador);
            this.mrcCargarEntrenador.Controls.Add(this.txtApellidoEntrenador);
            this.mrcCargarEntrenador.Controls.Add(this.lstDeporteEntrenador);
            this.mrcCargarEntrenador.Controls.Add(this.txtNombreEntrenador);
            this.mrcCargarEntrenador.Controls.Add(this.lblDeporteEntrenador);
            this.mrcCargarEntrenador.Controls.Add(this.lblDireccionEntrenador);
            this.mrcCargarEntrenador.Controls.Add(this.txtProvinciaEntrenador);
            this.mrcCargarEntrenador.Controls.Add(this.lblApellidoEntrenador);
            this.mrcCargarEntrenador.Controls.Add(this.lblProvinciaEntrenador);
            this.mrcCargarEntrenador.Controls.Add(this.lblNombreEntrenador);
            this.mrcCargarEntrenador.Location = new System.Drawing.Point(12, 12);
            this.mrcCargarEntrenador.Name = "mrcCargarEntrenador";
            this.mrcCargarEntrenador.Size = new System.Drawing.Size(200, 202);
            this.mrcCargarEntrenador.TabIndex = 15;
            this.mrcCargarEntrenador.TabStop = false;
            this.mrcCargarEntrenador.Text = "Datos Entrenador";
            this.mrcCargarEntrenador.Enter += new System.EventHandler(this.mrcCargarEntrenador_Enter);
            // 
            // txtCodigoEntrenador
            // 
            this.txtCodigoEntrenador.Location = new System.Drawing.Point(96, 30);
            this.txtCodigoEntrenador.MaxLength = 5;
            this.txtCodigoEntrenador.Name = "txtCodigoEntrenador";
            this.txtCodigoEntrenador.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoEntrenador.TabIndex = 1;
            this.txtCodigoEntrenador.TextChanged += new System.EventHandler(this.txtCodigoEntrenador_TextChanged);
            this.txtCodigoEntrenador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoEntrenador_KeyPress);
            // 
            // frmCargarEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 255);
            this.Controls.Add(this.mrcCargarEntrenador);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCargarEntrenador);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCargarEntrenador";
            this.Text = "Carga Entrenador";
            this.Load += new System.EventHandler(this.frmCargarEntrenador_Load);
            this.mrcCargarEntrenador.ResumeLayout(false);
            this.mrcCargarEntrenador.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtDireccionEntrenador;
        private System.Windows.Forms.TextBox txtApellidoEntrenador;
        private System.Windows.Forms.TextBox txtNombreEntrenador;
        private System.Windows.Forms.Label lblCodigoEntrenador;
        private System.Windows.Forms.Label lblDireccionEntrenador;
        private System.Windows.Forms.Label lblApellidoEntrenador;
        private System.Windows.Forms.Label lblNombreEntrenador;
        private System.Windows.Forms.Label lblProvinciaEntrenador;
        private System.Windows.Forms.TextBox txtProvinciaEntrenador;
        private System.Windows.Forms.Label lblDeporteEntrenador;
        private System.Windows.Forms.ComboBox lstDeporteEntrenador;
        private System.Windows.Forms.Button btnCargarEntrenador;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox mrcCargarEntrenador;
        private System.Windows.Forms.TextBox txtCodigoEntrenador;
    }
}