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
    public partial class Form1 : Form
    {
        private Control currentControl = new UserControl();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSecretaria_Click(object sender, EventArgs e)
        {
            // Limpiar el panel
            foreach (Control control in pnl_content.Controls)
            {
                control.Dispose();
            }
            pnl_content.Controls.Clear();
            currentControl = new VistaSecretaría();
            currentControl.Dock = DockStyle.Fill;
            pnl_content.Controls.Add(currentControl);
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            
                // Limpiar el panel
                foreach (Control control in pnl_content.Controls)
                {
                    control.Dispose();
                }
                pnl_content.Controls.Clear();
                currentControl = new index();
                currentControl.Dock = DockStyle.Fill;
                pnl_content.Controls.Add(currentControl);
            
        }

        private void pnl_content_Paint(object sender, PaintEventArgs e)
        {
            currentControl = new index();
            currentControl.Dock = DockStyle.Fill;
            pnl_content.Controls.Add(currentControl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Limpiar el panel
            foreach (Control control in pnl_content.Controls)
            {
                control.Dispose();
            }
            pnl_content.Controls.Clear();
            currentControl = new VistaPersonal();
            currentControl.Dock = DockStyle.Fill;
            pnl_content.Controls.Add(currentControl);

        }
    }
}
