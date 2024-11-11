namespace Proyecto_2024_II
{
    partial class Form1
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_nav = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnSecretaria = new System.Windows.Forms.Button();
            this.pnl_content = new System.Windows.Forms.Panel();
            this.pnl_nav.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_nav
            // 
            this.pnl_nav.BackColor = System.Drawing.Color.Turquoise;
            this.pnl_nav.Controls.Add(this.label2);
            this.pnl_nav.Controls.Add(this.button1);
            this.pnl_nav.Controls.Add(this.btnInicio);
            this.pnl_nav.Controls.Add(this.btnSecretaria);
            this.pnl_nav.Location = new System.Drawing.Point(0, 1);
            this.pnl_nav.Name = "pnl_nav";
            this.pnl_nav.Size = new System.Drawing.Size(804, 58);
            this.pnl_nav.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoEllipsis = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 75);
            this.label2.TabIndex = 49;
            this.label2.Text = "Sistema de Gestión de Hijos de Trabajadores";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(633, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 39);
            this.button1.TabIndex = 48;
            this.button1.Text = "Personal";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.Black;
            this.btnInicio.Location = new System.Drawing.Point(455, 11);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(90, 39);
            this.btnInicio.TabIndex = 47;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnSecretaria
            // 
            this.btnSecretaria.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSecretaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecretaria.ForeColor = System.Drawing.Color.Black;
            this.btnSecretaria.Location = new System.Drawing.Point(544, 11);
            this.btnSecretaria.Name = "btnSecretaria";
            this.btnSecretaria.Size = new System.Drawing.Size(90, 39);
            this.btnSecretaria.TabIndex = 46;
            this.btnSecretaria.Text = "Secretaría";
            this.btnSecretaria.UseVisualStyleBackColor = false;
            this.btnSecretaria.Click += new System.EventHandler(this.btnSecretaria_Click);
            // 
            // pnl_content
            // 
            this.pnl_content.Location = new System.Drawing.Point(0, 57);
            this.pnl_content.Name = "pnl_content";
            this.pnl_content.Size = new System.Drawing.Size(805, 614);
            this.pnl_content.TabIndex = 1;
            this.pnl_content.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_content_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 664);
            this.Controls.Add(this.pnl_content);
            this.Controls.Add(this.pnl_nav);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnl_nav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_nav;
        private System.Windows.Forms.Panel pnl_content;
        private System.Windows.Forms.Button btnSecretaria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label label2;
    }
}

