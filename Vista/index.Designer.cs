namespace Proyecto_2024_II
{
    partial class index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(index));
            this.label1 = new System.Windows.Forms.Label();
            this.pb_logoUNP = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logoUNP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 39);
            this.label1.TabIndex = 52;
            this.label1.Text = "Bienvenido ";
            // 
            // pb_logoUNP
            // 
            this.pb_logoUNP.Image = ((System.Drawing.Image)(resources.GetObject("pb_logoUNP.Image")));
            this.pb_logoUNP.Location = new System.Drawing.Point(274, 153);
            this.pb_logoUNP.Name = "pb_logoUNP";
            this.pb_logoUNP.Size = new System.Drawing.Size(200, 200);
            this.pb_logoUNP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pb_logoUNP.TabIndex = 51;
            this.pb_logoUNP.TabStop = false;
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb_logoUNP);
            this.Name = "index";
            this.Size = new System.Drawing.Size(738, 433);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logoUNP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_logoUNP;
    }
}
