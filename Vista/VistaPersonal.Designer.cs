namespace Proyecto_2024_II
{
    partial class VistaPersonal
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPersonal = new System.Windows.Forms.DataGridView();
            this.btnImportar = new System.Windows.Forms.Button();
            this.pb_excel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_excel)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonal
            // 
            this.dgvPersonal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonal.Location = new System.Drawing.Point(24, 84);
            this.dgvPersonal.Name = "dgvPersonal";
            this.dgvPersonal.Size = new System.Drawing.Size(679, 150);
            this.dgvPersonal.TabIndex = 0;
            // 
            // btnImportar
            // 
            this.btnImportar.BackColor = System.Drawing.Color.Green;
            this.btnImportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportar.ForeColor = System.Drawing.Color.Black;
            this.btnImportar.Location = new System.Drawing.Point(105, 242);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(87, 30);
            this.btnImportar.TabIndex = 50;
            this.btnImportar.Text = "Importar";
            this.btnImportar.UseVisualStyleBackColor = false;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // pb_excel
            // 
            this.pb_excel.Image = global::Proyecto_2024_II.Properties.Resources.office365;
            this.pb_excel.Location = new System.Drawing.Point(60, 240);
            this.pb_excel.Name = "pb_excel";
            this.pb_excel.Size = new System.Drawing.Size(39, 32);
            this.pb_excel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_excel.TabIndex = 58;
            this.pb_excel.TabStop = false;
            // 
            // VistaPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pb_excel);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.dgvPersonal);
            this.Name = "VistaPersonal";
            this.Size = new System.Drawing.Size(706, 381);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_excel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPersonal;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.PictureBox pb_excel;
    }
}
