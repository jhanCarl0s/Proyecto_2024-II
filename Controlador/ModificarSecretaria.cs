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
    public partial class ModificarSecretaria : Form
    {
        private  DataGridViewRow _row;
        public ModificarSecretaria( DataGridViewRow row)
        {
            InitializeComponent();
            _row = row;
            cargarDatos();
        }

        public void cargarDatos()
        {
            if (_row != null )
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

        private void ModificarSecretaria_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var gestiona = new GestionaSecretaria();
            string idFacultad, idEscuela;
            var parametros = new Dictionary<string, object> { { "@Prefijo", cbFac.SelectedItem } };
            string query = GestionaSecretaria.Queries.BuscarIDFacultad;

            var sugerencias = gestiona.ObtenerSugerencias(query, "FacultadID", parametros);
            idFacultad = sugerencias[0];

            var parametros1 = new Dictionary<string, object> { { "@Prefijo", cbEsc.SelectedItem } };
            string query1 = GestionaSecretaria.Queries.BuscarIDEscuela;

            var sugerencias1 = gestiona.ObtenerSugerencias(query1, "EscuelaID", parametros1);
            idEscuela = sugerencias1[0];
            
            var modificado = new ModeloSecretaria(txtDNITrab.Text, cbTpTrab.Text, cbEst.Text, txtIDTrab.Text, txtCU.Text,
                txtNomAl.Text, txtDNIAl.Text, idFacultad, idEscuela, txtFecha.Text);
            gestiona.ModificarHijoTrabajador(modificado);
            MessageBox.Show("Registro Modificado Correctamente.");
            this.Close();
        }

        private void txtCU_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
