namespace pryTorresBaseDeDatos
{
    partial class frmConsultaDeportista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaDeportista));
            this.btnListar = new System.Windows.Forms.Button();
            this.dgvDeportistasConsulta = new System.Windows.Forms.DataGridView();
            this.mrcDeportistas = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeportistasConsulta)).BeginInit();
            this.mrcDeportistas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(454, 322);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(345, 23);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dgvDeportistasConsulta
            // 
            this.dgvDeportistasConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeportistasConsulta.Location = new System.Drawing.Point(15, 19);
            this.dgvDeportistasConsulta.Name = "dgvDeportistasConsulta";
            this.dgvDeportistasConsulta.Size = new System.Drawing.Size(760, 273);
            this.dgvDeportistasConsulta.TabIndex = 2;
            this.dgvDeportistasConsulta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeportistasConsulta_CellContentClick);
            // 
            // mrcDeportistas
            // 
            this.mrcDeportistas.Controls.Add(this.dgvDeportistasConsulta);
            this.mrcDeportistas.Location = new System.Drawing.Point(12, 12);
            this.mrcDeportistas.Name = "mrcDeportistas";
            this.mrcDeportistas.Size = new System.Drawing.Size(787, 304);
            this.mrcDeportistas.TabIndex = 4;
            this.mrcDeportistas.TabStop = false;
            this.mrcDeportistas.Text = "Deportistas";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 322);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(345, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmConsultaDeportista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 357);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.mrcDeportistas);
            this.Controls.Add(this.btnListar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaDeportista";
            this.Text = "Deportistas";
            this.Load += new System.EventHandler(this.frmConsultaDeportista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeportistasConsulta)).EndInit();
            this.mrcDeportistas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dgvDeportistasConsulta;
        private System.Windows.Forms.GroupBox mrcDeportistas;
        private System.Windows.Forms.Button btnSalir;
    }
}