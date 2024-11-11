using Excel = Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_2024_II
{
    public partial class VistaPersonal : UserControl
    {
        public VistaPersonal()
        {
            InitializeComponent();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(filePath);
                Excel._Worksheet excelWorksheet = excelWorkbook.Sheets[1];
                Excel.Range excelRange = excelWorksheet.UsedRange;

                DataTable dt = new DataTable();
                for (int i = 1; i <= excelRange.Columns.Count; i++)
                {
                    dt.Columns.Add(excelRange.Cells[1, i].Value2.ToString());
                }

                for (int i = 2; i <= excelRange.Rows.Count; i++)
                {
                    DataRow row = dt.NewRow();
                    for (int j = 1; j <= excelRange.Columns.Count; j++)
                    {
                        row[j - 1] = excelRange.Cells[i, j].Value2.ToString();
                    }
                    dt.Rows.Add(row);
                }

                dgvPersonal.DataSource = dt;
                excelWorkbook.Close(false);
                excelApp.Quit();
            }
        }
  

    }
}
