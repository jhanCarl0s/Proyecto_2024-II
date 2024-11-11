using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_2024_II
{
    public partial class VistaSecretaría : UserControl
    {
        GestionaSecretaria gestiona;
        private CancellationTokenSource _cts;
        private DataGridViewRow _row;

        public VistaSecretaría()
        {
            InitializeComponent();
            gestiona = new GestionaSecretaria();
            ConfigurarTextBox();
            cargarDatos();
        }

        public void ExportarAExcel(DataGridView tabla)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            int j = 0;

            foreach (DataGridViewColumn col in tabla.Columns) {
                j++;
                excel.Cells[1,j] = col.Name;
            }

            int i = 0;
            foreach (DataGridViewRow row in tabla.Rows)
            {
                i++;
                j = 0;
                foreach(DataGridViewColumn col in tabla.Columns)
                {
                    j++;
                    excel.Cells[i+1,j] = row.Cells[col.Name].Value;
                }
            }
            excel.Visible = true;
        }
        private void ConfigurarTextBox()
        {
            ConfigurarAutocompletadoDNITrabador(txtDNITrab);
            ConfigurarAutocompletadoCodigoUniversitario(txtCU);
            LlenarFacultades();
            

            cbTpTrab.SelectedIndexChanged += (s, e) => LlenarIDTrabajador();
            cbFac.SelectedIndexChanged += (s, e) => LlenarEscuelas();
            txtDNITrab.TextChanged += (s, e) => LlenarIDTrabajador();
            txtCU.TextChanged += (s, e) => LlenarNombreAlumno();
            txtCU.TextChanged += (s, e) => LlenarDNIAlumno();
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void ConfigurarAutocompletadoDNITrabador(System.Windows.Forms.TextBox textBox)
        {
            textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Crear un AutoCompleteStringCollection para reutilizarlo
            var autoCompleteCollection = new AutoCompleteStringCollection();
            textBox.AutoCompleteCustomSource = autoCompleteCollection;

            textBox.PreviewKeyDown += (s, e) =>
            {
                // Prevenir que la lista de autocompletado se cierre al usar las teclas de dirección
                if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
                    e.IsInputKey = true;
            };

            textBox.TextChanged += async (s, e) =>
            {
                // Cancelar la solicitud anterior si hay una nueva entrada
                _cts?.Cancel();
                _cts = new CancellationTokenSource();

                try
                {
                    // Esperar 300ms para aplicar debounce
                    await Task.Delay(300, _cts.Token);

                    if (!string.IsNullOrEmpty(textBox.Text))
                    {
                        var parametros = new Dictionary<string, object> { { "@Prefijo", textBox.Text } };
                        var sugerencias = await Task.Run(() =>
                            gestiona.ObtenerSugerencias(
                                GestionaSecretaria.Queries.BuscarDNITrabajador,
                                "DNI",
                                parametros
                            ), _cts.Token);

                        if (sugerencias != null && sugerencias.Count > 0)
                        {
                            // Actualizar las sugerencias solo si han cambiado
                            textBox.Invoke((System.Action)(() =>
                            {
                                if (!autoCompleteCollection.Cast<string>().SequenceEqual(sugerencias))
                                {
                                    autoCompleteCollection.Clear();
                                    autoCompleteCollection.AddRange(sugerencias.ToArray());
                                }
                            }));
                        }
                    }
                }
                catch (TaskCanceledException)
                {
                    // La tarea fue cancelada; no hacemos nada.
                }
            };
        }

        private void ConfigurarAutocompletadoCodigoUniversitario(System.Windows.Forms.TextBox textBox)
        {
            textBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Crear un AutoCompleteStringCollection para reutilizarlo
            var autoCompleteCollection = new AutoCompleteStringCollection();
            textBox.AutoCompleteCustomSource = autoCompleteCollection;

            textBox.PreviewKeyDown += (s, e) =>
            {
                // Prevenir que la lista de autocompletado se cierre al usar las teclas de dirección
                if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
                    e.IsInputKey = true;
            };

            textBox.TextChanged += async (s, e) =>
            {
                // Cancelar la solicitud anterior si hay una nueva entrada
                _cts?.Cancel();
                _cts = new CancellationTokenSource();

                try
                {
                    // Esperar 300ms para aplicar debounce
                    await Task.Delay(300, _cts.Token);

                    if (!string.IsNullOrEmpty(textBox.Text))
                    {
                        var parametros = new Dictionary<string, object> { { "@Prefijo", textBox.Text } };
                        var sugerencias = await Task.Run(() =>
                            gestiona.ObtenerSugerencias(
                                GestionaSecretaria.Queries.BuscarCodUniv,
                                "CodigoAlumno",
                                parametros
                            ), _cts.Token);

                        if (sugerencias != null && sugerencias.Count > 0)
                        {
                            // Actualizar las sugerencias solo si han cambiado
                            textBox.Invoke((System.Action)(() =>
                            {
                                if (!autoCompleteCollection.Cast<string>().SequenceEqual(sugerencias))
                                {
                                    autoCompleteCollection.Clear();
                                    autoCompleteCollection.AddRange(sugerencias.ToArray());
                                }
                            }));
                        }
                    }
                }
                catch (TaskCanceledException)
                {
                    // La tarea fue cancelada; no hacemos nada.
                }
            };
        }

        private async void LlenarNombreAlumno()
        {
            if (string.IsNullOrEmpty(txtCU.Text)) return;

            var parametros = new Dictionary<string, object> { { "@Prefijo", txtCU.Text } };
            string query = GestionaSecretaria.Queries.BuscarNombreAlumno;

            var sugerencias = await Task.Run(() =>
                gestiona.ObtenerSugerencias(query, "NombreCompleto", parametros)
            );

            if (sugerencias != null && sugerencias.Count > 0 && txtNomAl.IsHandleCreated)
            {
                txtNomAl.Invoke((System.Action)(() =>
                {
                    txtNomAl.Text = sugerencias[0]; // Asigna el primer resultado al campo Nombre
                }));
            }
        }

        private async void LlenarDNIAlumno()
        {
            if (string.IsNullOrEmpty(txtCU.Text)) return;

            var parametros = new Dictionary<string, object> { { "@Prefijo", txtCU.Text } };
            string query = GestionaSecretaria.Queries.BuscarDniAlumno;

            var sugerencias = await Task.Run(() =>
                gestiona.ObtenerSugerencias(query, "DNI", parametros)
            );

            if (sugerencias != null && sugerencias.Count > 0 && txtDNIAl.IsHandleCreated)
            {
                txtDNIAl.Invoke((System.Action)(() =>
                {
                    txtDNIAl.Text = sugerencias[0]; // Asigna el primer resultado al campo Nombre
                }));
            }
        }

        private async void LlenarIDTrabajador()
        {
            if (string.IsNullOrEmpty(txtDNITrab.Text) || cbTpTrab.SelectedIndex < 0) return;

            var parametros = new Dictionary<string, object> { { "@Prefijo", txtDNITrab.Text } };
            string query = cbTpTrab.SelectedIndex == 0
                ? GestionaSecretaria.Queries.BuscarDocente
                : GestionaSecretaria.Queries.BuscarAdministrativo;

            var sugerencias = await Task.Run(() =>
                gestiona.ObtenerSugerencias(query, "Codigo", parametros)
            );

            if (sugerencias != null && sugerencias.Count > 0 && txtIDTrab.IsHandleCreated)
            {
                txtIDTrab.Invoke((System.Action)(() =>
                {
                    txtIDTrab.Text = sugerencias[0]; // Asigna el primer resultado al campo ID
                }));
            }
        }

        public async void LlenarFacultades()
        {
            var parametros = new Dictionary<string, object> { { "@Prefijo", "" } };
            string query = GestionaSecretaria.Queries.ListarFacultades;

            var sugerencias = await Task.Run(() =>
                gestiona.ObtenerSugerencias(query, "NombreFacultad", parametros)
            );

            if (sugerencias != null && sugerencias.Count > 0 && cbFac.IsHandleCreated)
            {
                cbFac.Invoke((System.Action)(() =>
                {
                    int i = sugerencias.Count;
                    while (i > 0)
                    {
                        cbFac.Items.Add(sugerencias[i-1]);
                        i--;
                    }
                }));
            }
        }

        public async void LlenarEscuelas()
        {

            var parametros = new Dictionary<string, object> { { "@Prefijo", cbFac.Text } };
            string query = GestionaSecretaria.Queries.ListarEscuelas;

            var sugerencias = await Task.Run(() =>
                gestiona.ObtenerSugerencias(query, "NombreEscuela", parametros)
            );

            if (cbEsc.Items.Count>0)
            {
                cbEsc.SelectedItem = null;
                cbEsc.Items.Clear();
            }

            if (sugerencias != null && sugerencias.Count > 0 && cbEsc.IsHandleCreated)
            {
                cbEsc.Invoke((System.Action)(() =>
                {
                    int i = sugerencias.Count;
                    while (i > 0)
                    {
                        cbEsc.Items.Add(sugerencias[i - 1]);
                        i--;
                    }
                }));
            }
        }

        private void txtDNITrab_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            string idFacultad, idEscuela;
            var parametros = new Dictionary<string, object> { { "@Prefijo", cbFac.SelectedItem } };
            string query = GestionaSecretaria.Queries.BuscarIDFacultad;

            var sugerencias = gestiona.ObtenerSugerencias(query, "FacultadID", parametros);
            idFacultad = sugerencias[0];

            var parametros1 = new Dictionary<string, object> { { "@Prefijo", cbEsc.SelectedItem } };
            string query1 = GestionaSecretaria.Queries.BuscarIDEscuela;

            var sugerencias1 = gestiona.ObtenerSugerencias(query1, "EscuelaID", parametros1);
            idEscuela = sugerencias1[0];

            var ht = new ModeloSecretaria(
                txtDNITrab.Text, cbTpTrab.Text, cbEst.Text, txtIDTrab.Text, txtCU.Text,
                txtNomAl.Text, txtDNIAl.Text, idFacultad, idEscuela, txtFecha.Text
            );
            var gestor = new GestionaSecretaria();
            gestor.AgregarHijoTrabajador(ht);
            MessageBox.Show("Registrado correctamente");
            cargarDatos();
        }


        public void cargarDatos()
        {
            
            System.Data.DataTable dataTable = new System.Data.DataTable();
            dataTable = gestiona.CargarDatos(GestionaSecretaria.Queries.BuscarHijosTrabajadores, "");
            dgv.DataSource = dataTable;

        }
        private void VistaSecretaría_Load(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(dgv.SelectedRows.Count>0)
            {
                _row = dgv.SelectedRows[0];
                ModificarSecretaria ms = new ModificarSecretaria(_row);
                ms.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione el registro a modificar.");
            }

            cargarDatos();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count > 0)
            {
                _row = dgv.SelectedRows[0];
                EliminarSecretaria es = new EliminarSecretaria(_row);
                es.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione el registro a eliminar.");
            }
            cargarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtDNITrab.Clear();
            cbTpTrab.Text = string.Empty;
            cbEst.Text = string.Empty;
            txtIDTrab.Clear();
            txtCU.Clear();
            txtNomAl.Clear();
            txtDNIAl.Clear();
            cbFac.Text = string.Empty;
            cbEsc.Text = string.Empty;
        }

        private void btn_Exportar_Click(object sender, EventArgs e)
        {
            ExportarAExcel(dgv);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string prefijo = txtBuscar.Text;
            System.Data.DataTable dataTable = new System.Data.DataTable();
            dataTable = gestiona.CargarDatos(GestionaSecretaria.Queries.BuscarHijosTrabajadores, prefijo);
            dgv.DataSource = dataTable;
        }
    }
}
