using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2024_II
{
    internal class ModeloSecretaria
    {
        private String dniTrab;
        private String tpTrab;
        private String estado;
        private String idTrabajador;
        private String codUniv;
        private String nombre;
        private String dniAl;
        private string facultad;
        private string escuela;
        private String fecha;

        public ModeloSecretaria(string dniTrab, string tpTrab, string estado, string idTrabajador, string codUniv, string nombre, string dniAl, string facultad, string escuela, string fecha)
        {
            this.dniTrab = dniTrab;
            this.tpTrab = tpTrab;
            this.estado = estado;
            this.idTrabajador = idTrabajador;
            this.codUniv = codUniv;
            this.nombre = nombre;
            this.dniAl = dniAl;
            this.facultad = facultad;
            this.escuela = escuela;
            this.fecha = fecha;
        }

        public string DniTrab { get => dniTrab; set => dniTrab = value; }
        public string TpTrab { get => tpTrab; set => tpTrab = value; }
        public string Estado { get => estado; set => estado = value; }
        public string IdTrabajador { get => idTrabajador; set => idTrabajador = value; }
        public string CodUniv { get => codUniv; set => codUniv = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string DniAl { get => dniAl; set => dniAl = value; }
        public string Facultad { get => facultad; set => facultad = value; }
        public string Escuela { get => escuela; set => escuela = value; }
        public string Fecha { get => fecha; set => fecha = value; }
    }
}
