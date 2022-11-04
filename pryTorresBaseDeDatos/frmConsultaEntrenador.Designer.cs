namespace pryTorresBaseDeDatos
{
    partial class frmConsultaEntrenador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaEntrenador));
            this.dgvEntrenadoresConsulta = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.mrcEntrenadores = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrenadoresConsulta)).BeginInit();
            this.mrcEntrenadores.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEntrenadoresConsulta
            // 
            this.dgvEntrenadoresConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntrenadoresConsulta.Location = new System.Drawing.Point(6, 19);
            this.dgvEntrenadoresConsulta.Name = "dgvEntrenadoresConsulta";
            this.dgvEntrenadoresConsulta.Size = new System.Drawing.Size(645, 242);
            this.dgvEntrenadoresConsulta.TabIndex = 0;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(440, 285);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(229, 23);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // mrcEntrenadores
            // 
            this.mrcEntrenadores.Controls.Add(this.dgvEntrenadoresConsulta);
            this.mrcEntrenadores.Location = new System.Drawing.Point(12, 12);
            this.mrcEntrenadores.Name = "mrcEntrenadores";
            this.mrcEntrenadores.Size = new System.Drawing.Size(657, 267);
            this.mrcEntrenadores.TabIndex = 2;
            this.mrcEntrenadores.TabStop = false;
            this.mrcEntrenadores.Text = "Entrenadores";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(12, 285);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(229, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmConsultaEntrenador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 328);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.mrcEntrenadores);
            this.Controls.Add(this.btnListar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultaEntrenador";
            this.Text = "Entrenadores";
            this.Load += new System.EventHandler(this.frmConsultaEntrenador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrenadoresConsulta)).EndInit();
            this.mrcEntrenadores.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEntrenadoresConsulta;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.GroupBox mrcEntrenadores;
        private System.Windows.Forms.Button btnSalir;
    }
}