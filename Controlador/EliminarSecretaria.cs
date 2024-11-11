using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_2024_II
{
    public partial class EliminarSecretaria : Form
    {
        private DataGridViewRow _row;
        public EliminarSecretaria(DataGridViewRow row)
        {
            InitializeComponent();
            _row = row;
            cargarDatos();
        }

        public void cargarDatos()
        {
            if (_row != null)
            {
                txtDNITrab.Text = (string)_row.Cells[8].Value;
                cbTpTrab.Text = (string)_row.Cells[1].Value;
                cbEst.Text = (string)_row.Cells[2].Value;
                txtIDTrab.Text = (string)_row.Cells[10].Value;
                txtCU.Text = (string)_row.Cells[3].Value;
                txtNomAl.Text = (string)_row.Cells[4].Value;
                txtDNIAl.Text = (string)_row.Cells[5].Value;
                cbFac.Text = (string)_row.Cells[6].Value;
                cbEsc.Text = (string)_row.Cells[7].Value;
                txtFecha.Clear();
                txtFecha.Text = (string)_row.Cells[9].Value.ToString();
            }
        }

        private void EliminarSecretaria_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            GestionaSecretaria gestiona = new GestionaSecretaria();
            gestiona.EliminarHijoTrabajador((int)_row.Cells[0].Value);
            MessageBox.Show("Registro Eliminado Correctamente.");
            this.Close();
        }
    }
}
