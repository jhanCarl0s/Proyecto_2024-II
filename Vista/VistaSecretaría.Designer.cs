namespace Proyecto_2024_II
{
    partial class VistaSecretaría
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
            if (disposing)
            {
                // Verifica que el handle no se esté creando y que aún no esté liberado
                if (this.IsHandleCreated && !this.IsDisposed)
                {
                    if (components != null)
                    {
                        components.Dispose();
                    }
                }
            }
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.cbFac = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbEsc = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDNIAl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomAl = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCU = new System.Windows.Forms.TextBox();
            this.cbTpTrab = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEst = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDNITrab = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIDTrab = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.pb_excel = new System.Windows.Forms.PictureBox();
            this.btn_Exportar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_excel)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(497, 371);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 50;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(598, 365);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 30);
            this.btnBuscar.TabIndex = 49;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Firebrick;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Location = new System.Drawing.Point(214, 332);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 29);
            this.btnCancelar.TabIndex = 46;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrar.Location = new System.Drawing.Point(133, 332);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(84, 29);
            this.btnRegistrar.TabIndex = 45;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click_1);
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(110, 401);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(585, 150);
            this.dgv.TabIndex = 44;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(250, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(279, 24);
            this.label9.TabIndex = 43;
            this.label9.Text = "Registrar Hijos de Trabajadores ";
            // 
            // cbFac
            // 
            this.cbFac.FormattingEnabled = true;
            this.cbFac.Location = new System.Drawing.Point(419, 248);
            this.cbFac.Name = "cbFac";
            this.cbFac.Size = new System.Drawing.Size(266, 21);
            this.cbFac.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Linux Biolinum G", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(416, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 14);
            this.label7.TabIndex = 41;
            this.label7.Text = "Facultad";
            // 
            // cbEsc
            // 
            this.cbEsc.FormattingEnabled = true;
            this.cbEsc.Location = new System.Drawing.Point(419, 291);
            this.cbEsc.Name = "cbEsc";
            this.cbEsc.Size = new System.Drawing.Size(266, 21);
            this.cbEsc.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Linux Biolinum G", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(416, 274);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 14);
            this.label8.TabIndex = 39;
            this.label8.Text = "Escuela";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Linux Biolinum G", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(417, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 14);
            this.label6.TabIndex = 38;
            this.label6.Text = "DNI";
            // 
            // txtDNIAl
            // 
            this.txtDNIAl.Location = new System.Drawing.Point(419, 208);
            this.txtDNIAl.Name = "txtDNIAl";
            this.txtDNIAl.ReadOnly = true;
            this.txtDNIAl.Size = new System.Drawing.Size(267, 20);
            this.txtDNIAl.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Linux Biolinum G", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(416, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 14);
            this.label5.TabIndex = 36;
            this.label5.Text = "Nombre";
            // 
            // txtNomAl
            // 
            this.txtNomAl.Location = new System.Drawing.Point(418, 165);
            this.txtNomAl.Name = "txtNomAl";
            this.txtNomAl.ReadOnly = true;
            this.txtNomAl.Size = new System.Drawing.Size(267, 20);
            this.txtNomAl.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Linux Biolinum G", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(417, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 14);
            this.label4.TabIndex = 34;
            this.label4.Text = "Código Universitario";
            // 
            // txtCU
            // 
            this.txtCU.Location = new System.Drawing.Point(419, 121);
            this.txtCU.Name = "txtCU";
            this.txtCU.Size = new System.Drawing.Size(267, 20);
            this.txtCU.TabIndex = 33;
            // 
            // cbTpTrab
            // 
            this.cbTpTrab.FormattingEnabled = true;
            this.cbTpTrab.Items.AddRange(new object[] {
            "Docente ",
            "Administrativo"});
            this.cbTpTrab.Location = new System.Drawing.Point(99, 165);
            this.cbTpTrab.Name = "cbTpTrab";
            this.cbTpTrab.Size = new System.Drawing.Size(266, 21);
            this.cbTpTrab.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Linux Biolinum G", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 14);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tipo de Trabajador";
            // 
            // cbEst
            // 
            this.cbEst.FormattingEnabled = true;
            this.cbEst.Items.AddRange(new object[] {
            "Activo ",
            "Cesante"});
            this.cbEst.Location = new System.Drawing.Point(100, 208);
            this.cbEst.Name = "cbEst";
            this.cbEst.Size = new System.Drawing.Size(266, 21);
            this.cbEst.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Linux Biolinum G", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 14);
            this.label3.TabIndex = 29;
            this.label3.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Linux Biolinum G", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 14);
            this.label1.TabIndex = 28;
            this.label1.Text = "DNI de Trabajador";
            // 
            // txtDNITrab
            // 
            this.txtDNITrab.Location = new System.Drawing.Point(99, 121);
            this.txtDNITrab.Name = "txtDNITrab";
            this.txtDNITrab.Size = new System.Drawing.Size(267, 20);
            this.txtDNITrab.TabIndex = 27;
            this.txtDNITrab.TextChanged += new System.EventHandler(this.txtDNITrab_TextChanged);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.Location = new System.Drawing.Point(513, 569);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(84, 29);
            this.btnModificar.TabIndex = 51;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Firebrick;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(604, 569);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(92, 29);
            this.btnEliminar.TabIndex = 52;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Linux Biolinum G", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(97, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 14);
            this.label10.TabIndex = 54;
            this.label10.Text = "ID";
            // 
            // txtIDTrab
            // 
            this.txtIDTrab.Location = new System.Drawing.Point(100, 249);
            this.txtIDTrab.Name = "txtIDTrab";
            this.txtIDTrab.ReadOnly = true;
            this.txtIDTrab.Size = new System.Drawing.Size(267, 20);
            this.txtIDTrab.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Linux Biolinum G", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(416, 314);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 14);
            this.label11.TabIndex = 56;
            this.label11.Text = "Fecha";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(418, 332);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(267, 20);
            this.txtFecha.TabIndex = 55;
            // 
            // pb_excel
            // 
            this.pb_excel.Image = global::Proyecto_2024_II.Properties.Resources.office365;
            this.pb_excel.Location = new System.Drawing.Point(129, 566);
            this.pb_excel.Name = "pb_excel";
            this.pb_excel.Size = new System.Drawing.Size(39, 32);
            this.pb_excel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_excel.TabIndex = 57;
            this.pb_excel.TabStop = false;
            // 
            // btn_Exportar
            // 
            this.btn_Exportar.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Exportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exportar.ForeColor = System.Drawing.Color.Black;
            this.btn_Exportar.Location = new System.Drawing.Point(174, 569);
            this.btn_Exportar.Name = "btn_Exportar";
            this.btn_Exportar.Size = new System.Drawing.Size(84, 29);
            this.btn_Exportar.TabIndex = 58;
            this.btn_Exportar.Text = "Exportar ";
            this.btn_Exportar.UseVisualStyleBackColor = false;
            this.btn_Exportar.Click += new System.EventHandler(this.btn_Exportar_Click);
            // 
            // VistaSecretaría
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_Exportar);
            this.Controls.Add(this.pb_excel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtIDTrab);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbFac);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbEsc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDNIAl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNomAl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCU);
            this.Controls.Add(this.cbTpTrab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbEst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDNITrab);
            this.Name = "VistaSecretaría";
            this.Size = new System.Drawing.Size(800, 612);
            this.Load += new System.EventHandler(this.VistaSecretaría_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_excel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbFac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbEsc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDNIAl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomAl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCU;
        private System.Windows.Forms.ComboBox cbTpTrab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEst;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDNITrab;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIDTrab;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.PictureBox pb_excel;
        private System.Windows.Forms.Button btn_Exportar;
    }
}