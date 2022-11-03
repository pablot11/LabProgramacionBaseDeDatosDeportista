namespace pryTorresBaseDeDatos
{
    partial class frmCargarDeportistas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargarDeportistas));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCargarDeportista = new System.Windows.Forms.Button();
            this.mskCodigoDeportista = new System.Windows.Forms.MaskedTextBox();
            this.lstDeporteDeportista = new System.Windows.Forms.ComboBox();
            this.lblDeporteDeportista = new System.Windows.Forms.Label();
            this.txtTelefonoDeportista = new System.Windows.Forms.TextBox();
            this.lblTelefonoDeportista = new System.Windows.Forms.Label();
            this.lblNombreDeportista = new System.Windows.Forms.Label();
            this.lblApellidoDeportista = new System.Windows.Forms.Label();
            this.lblDireccionDeportista = new System.Windows.Forms.Label();
            this.lblCodigoDeportista = new System.Windows.Forms.Label();
            this.txtNombreDeportista = new System.Windows.Forms.TextBox();
            this.txtApellidoDeportista = new System.Windows.Forms.TextBox();
            this.txtDireccionDeportista = new System.Windows.Forms.TextBox();
            this.txtEdadDeportista = new System.Windows.Forms.TextBox();
            this.lblEdadDeportista = new System.Windows.Forms.Label();
            this.mrcDeportistaCargar = new System.Windows.Forms.GroupBox();
            this.mrcDeportistaCargar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 231);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 29;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCargarDeportista
            // 
            this.btnCargarDeportista.Enabled = false;
            this.btnCargarDeportista.Location = new System.Drawing.Point(137, 231);
            this.btnCargarDeportista.Name = "btnCargarDeportista";
            this.btnCargarDeportista.Size = new System.Drawing.Size(75, 23);
            this.btnCargarDeportista.TabIndex = 28;
            this.btnCargarDeportista.Text = "Cargar";
            this.btnCargarDeportista.UseVisualStyleBackColor = true;
            this.btnCargarDeportista.Click += new System.EventHandler(this.btnCargarDeportista_Click);
            // 
            // mskCodigoDeportista
            // 
            this.mskCodigoDeportista.Location = new System.Drawing.Point(96, 30);
            this.mskCodigoDeportista.Mask = "AAAAA";
            this.mskCodigoDeportista.Name = "mskCodigoDeportista";
            this.mskCodigoDeportista.Size = new System.Drawing.Size(56, 20);
            this.mskCodigoDeportista.TabIndex = 27;
            this.mskCodigoDeportista.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mskCodigoDeportista_MaskInputRejected);
            // 
            // lstDeporteDeportista
            // 
            this.lstDeporteDeportista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstDeporteDeportista.FormattingEnabled = true;
            this.lstDeporteDeportista.Items.AddRange(new object[] {
            "TENIS",
            "BASQUET",
            "CICLISMO",
            "FUTBOL",
            "RUGBY",
            "ATLETISMO",
            "PADEL",
            "HANDBALL"});
            this.lstDeporteDeportista.Location = new System.Drawing.Point(96, 184);
            this.lstDeporteDeportista.Name = "lstDeporteDeportista";
            this.lstDeporteDeportista.Size = new System.Drawing.Size(100, 21);
            this.lstDeporteDeportista.TabIndex = 26;
            this.lstDeporteDeportista.SelectedIndexChanged += new System.EventHandler(this.lstDeporteDeportista_SelectedIndexChanged);
            // 
            // lblDeporteDeportista
            // 
            this.lblDeporteDeportista.AutoSize = true;
            this.lblDeporteDeportista.Location = new System.Drawing.Point(6, 184);
            this.lblDeporteDeportista.Name = "lblDeporteDeportista";
            this.lblDeporteDeportista.Size = new System.Drawing.Size(48, 13);
            this.lblDeporteDeportista.TabIndex = 25;
            this.lblDeporteDeportista.Text = "Deporte:";
            // 
            // txtTelefonoDeportista
            // 
            this.txtTelefonoDeportista.Location = new System.Drawing.Point(96, 134);
            this.txtTelefonoDeportista.Name = "txtTelefonoDeportista";
            this.txtTelefonoDeportista.Size = new System.Drawing.Size(100, 20);
            this.txtTelefonoDeportista.TabIndex = 24;
            this.txtTelefonoDeportista.TextChanged += new System.EventHandler(this.txtTelefonoDeportista_TextChanged);
            // 
            // lblTelefonoDeportista
            // 
            this.lblTelefonoDeportista.AutoSize = true;
            this.lblTelefonoDeportista.Location = new System.Drawing.Point(6, 134);
            this.lblTelefonoDeportista.Name = "lblTelefonoDeportista";
            this.lblTelefonoDeportista.Size = new System.Drawing.Size(52, 13);
            this.lblTelefonoDeportista.TabIndex = 23;
            this.lblTelefonoDeportista.Text = "Telefono:";
            // 
            // lblNombreDeportista
            // 
            this.lblNombreDeportista.AutoSize = true;
            this.lblNombreDeportista.Location = new System.Drawing.Point(6, 56);
            this.lblNombreDeportista.Name = "lblNombreDeportista";
            this.lblNombreDeportista.Size = new System.Drawing.Size(47, 13);
            this.lblNombreDeportista.TabIndex = 22;
            this.lblNombreDeportista.Text = "Nombre:";
            // 
            // lblApellidoDeportista
            // 
            this.lblApellidoDeportista.AutoSize = true;
            this.lblApellidoDeportista.Location = new System.Drawing.Point(6, 82);
            this.lblApellidoDeportista.Name = "lblApellidoDeportista";
            this.lblApellidoDeportista.Size = new System.Drawing.Size(47, 13);
            this.lblApellidoDeportista.TabIndex = 21;
            this.lblApellidoDeportista.Text = "Apellido:";
            // 
            // lblDireccionDeportista
            // 
            this.lblDireccionDeportista.AutoSize = true;
            this.lblDireccionDeportista.Location = new System.Drawing.Point(6, 108);
            this.lblDireccionDeportista.Name = "lblDireccionDeportista";
            this.lblDireccionDeportista.Size = new System.Drawing.Size(55, 13);
            this.lblDireccionDeportista.TabIndex = 20;
            this.lblDireccionDeportista.Text = "Dirección:";
            // 
            // lblCodigoDeportista
            // 
            this.lblCodigoDeportista.AutoSize = true;
            this.lblCodigoDeportista.Location = new System.Drawing.Point(6, 30);
            this.lblCodigoDeportista.Name = "lblCodigoDeportista";
            this.lblCodigoDeportista.Size = new System.Drawing.Size(43, 13);
            this.lblCodigoDeportista.TabIndex = 19;
            this.lblCodigoDeportista.Text = "Codigo:";
            // 
            // txtNombreDeportista
            // 
            this.txtNombreDeportista.Location = new System.Drawing.Point(96, 56);
            this.txtNombreDeportista.Name = "txtNombreDeportista";
            this.txtNombreDeportista.Size = new System.Drawing.Size(100, 20);
            this.txtNombreDeportista.TabIndex = 18;
            this.txtNombreDeportista.TextChanged += new System.EventHandler(this.txtNombreDeportista_TextChanged);
            // 
            // txtApellidoDeportista
            // 
            this.txtApellidoDeportista.Location = new System.Drawing.Point(96, 82);
            this.txtApellidoDeportista.Name = "txtApellidoDeportista";
            this.txtApellidoDeportista.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoDeportista.TabIndex = 17;
            this.txtApellidoDeportista.TextChanged += new System.EventHandler(this.txtApellidoDeportista_TextChanged);
            // 
            // txtDireccionDeportista
            // 
            this.txtDireccionDeportista.Location = new System.Drawing.Point(96, 108);
            this.txtDireccionDeportista.Name = "txtDireccionDeportista";
            this.txtDireccionDeportista.Size = new System.Drawing.Size(100, 20);
            this.txtDireccionDeportista.TabIndex = 16;
            this.txtDireccionDeportista.TextChanged += new System.EventHandler(this.txtDireccionDeportista_TextChanged);
            // 
            // txtEdadDeportista
            // 
            this.txtEdadDeportista.Location = new System.Drawing.Point(96, 158);
            this.txtEdadDeportista.Name = "txtEdadDeportista";
            this.txtEdadDeportista.Size = new System.Drawing.Size(100, 20);
            this.txtEdadDeportista.TabIndex = 30;
            this.txtEdadDeportista.TextChanged += new System.EventHandler(this.txtEdadDeportista_TextChanged);
            // 
            // lblEdadDeportista
            // 
            this.lblEdadDeportista.AutoSize = true;
            this.lblEdadDeportista.Location = new System.Drawing.Point(6, 158);
            this.lblEdadDeportista.Name = "lblEdadDeportista";
            this.lblEdadDeportista.Size = new System.Drawing.Size(35, 13);
            this.lblEdadDeportista.TabIndex = 31;
            this.lblEdadDeportista.Text = "Edad:";
            // 
            // mrcDeportistaCargar
            // 
            this.mrcDeportistaCargar.Controls.Add(this.lblCodigoDeportista);
            this.mrcDeportistaCargar.Controls.Add(this.lblEdadDeportista);
            this.mrcDeportistaCargar.Controls.Add(this.txtEdadDeportista);
            this.mrcDeportistaCargar.Controls.Add(this.txtDireccionDeportista);
            this.mrcDeportistaCargar.Controls.Add(this.txtApellidoDeportista);
            this.mrcDeportistaCargar.Controls.Add(this.txtNombreDeportista);
            this.mrcDeportistaCargar.Controls.Add(this.mskCodigoDeportista);
            this.mrcDeportistaCargar.Controls.Add(this.lblDireccionDeportista);
            this.mrcDeportistaCargar.Controls.Add(this.lstDeporteDeportista);
            this.mrcDeportistaCargar.Controls.Add(this.lblApellidoDeportista);
            this.mrcDeportistaCargar.Controls.Add(this.lblDeporteDeportista);
            this.mrcDeportistaCargar.Controls.Add(this.lblNombreDeportista);
            this.mrcDeportistaCargar.Controls.Add(this.txtTelefonoDeportista);
            this.mrcDeportistaCargar.Controls.Add(this.lblTelefonoDeportista);
            this.mrcDeportistaCargar.Location = new System.Drawing.Point(12, 12);
            this.mrcDeportistaCargar.Name = "mrcDeportistaCargar";
            this.mrcDeportistaCargar.Size = new System.Drawing.Size(200, 213);
            this.mrcDeportistaCargar.TabIndex = 32;
            this.mrcDeportistaCargar.TabStop = false;
            this.mrcDeportistaCargar.Text = "Datos Deportista";
            // 
            // frmCargarDeportistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 264);
            this.Controls.Add(this.mrcDeportistaCargar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCargarDeportista);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCargarDeportistas";
            this.Text = "Carga Deportistas";
            this.Load += new System.EventHandler(this.frmCargarDeportistas_Load);
            this.mrcDeportistaCargar.ResumeLayout(false);
            this.mrcDeportistaCargar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCargarDeportista;
        private System.Windows.Forms.MaskedTextBox mskCodigoDeportista;
        private System.Windows.Forms.ComboBox lstDeporteDeportista;
        private System.Windows.Forms.Label lblDeporteDeportista;
        private System.Windows.Forms.TextBox txtTelefonoDeportista;
        private System.Windows.Forms.Label lblTelefonoDeportista;
        private System.Windows.Forms.Label lblNombreDeportista;
        private System.Windows.Forms.Label lblApellidoDeportista;
        private System.Windows.Forms.Label lblDireccionDeportista;
        private System.Windows.Forms.Label lblCodigoDeportista;
        private System.Windows.Forms.TextBox txtNombreDeportista;
        private System.Windows.Forms.TextBox txtApellidoDeportista;
        private System.Windows.Forms.TextBox txtDireccionDeportista;
        private System.Windows.Forms.TextBox txtEdadDeportista;
        private System.Windows.Forms.Label lblEdadDeportista;
        private System.Windows.Forms.GroupBox mrcDeportistaCargar;
    }
}