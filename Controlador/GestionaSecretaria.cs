using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Collections;

namespace Proyecto_2024_II
{

    internal class GestionaSecretaria
    {
        private String conexion = "Server=.; Database=OTI_2024;Trusted_Connection=True;";
        public List<string> ObtenerSugerencias(string query, string columnaResultado, Dictionary<string, object> parametros)
        {
            List<string> sugerencias = new List<string>();

            try
            {
                using (SqlConnection connection = new SqlConnection(conexion))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Agrega los parámetros dinámicamente
                        foreach (var param in parametros)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value);
                        }

                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                sugerencias.Add(reader[columnaResultado].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener sugerencias: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return sugerencias;
        }

        public DataTable CargarDatos(string query, string nombre)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(conexion))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
            }
            return dataTable;

        }
        public static class Queries
        {
            public static string BuscarHijosTrabajadores =>
                @"SELECT h.id, h.TpTrabajador, h.Estado, h.CodUniv, h.nombre, h.dni, f.NombreFacultad AS facultad, 
                e.NombreEscuela AS escuela, h.DNITrab, h.Fecha, h.CodTrab
                FROM HijosTrabajadores h 
                inner join Facultad f ON h.facultad = f.FacultadID
                inner join Escuela E ON e.EscuelaID = h.escuela
                WHERE nombre LIKE '%' + @Nombre + '%'";
            public static string BuscarDNITrabajador =>
                @"SELECT DNI
                FROM Persona
                WHERE DNI LIKE @Prefijo + '%'";

            public static string BuscarIDFacultad =>
                @"SELECT FacultadID
                FROM Facultad
                WHERE NombreFacultad LIKE @Prefijo";

            public static string BuscarIDEscuela =>
                @"SELECT EscuelaID
                FROM Escuela
                WHERE NombreEscuela LIKE @Prefijo";
            public static string BuscarAdministrativo =>
                @"SELECT Codigo
                FROM Persona p
                INNER JOIN Administrativo d ON p.PersonaID = d.AdministrativoID
                WHERE DNI LIKE @Prefijo + '%'";

            public static string BuscarDocente =>
                @"SELECT Codigo
                FROM Persona p
                INNER JOIN Docente d ON p.PersonaID = d.DocenteID
                WHERE DNI LIKE @Prefijo + '%'";



            public static string BuscarCodUniv =>
                @"SELECT CodigoAlumno
                FROM Alumno
                WHERE CodigoALumno LIKE @Prefijo + '%'";

            public static string BuscarNombreAlumno =>
                @"SELECT p.Nombres +' '+ p.Apellidos AS NombreCompleto
                FROM Persona p
                inner join Alumno a ON p.PersonaID = a.AlumnoID
                WHERE a.CodigoAlumno LIKE @Prefijo";

            public static string BuscarDniAlumno =>
                @"SELECT DNI
                FROM Persona p
                inner join Alumno a ON p.PersonaID = a.AlumnoID
                WHERE a.CodigoAlumno LIKE @Prefijo";

            public static string ListarFacultades =>
                @"SELECT DISTINCT NombreFacultad
                FROM Facultad
                ORDER BY 1 DESC";

            public static string ListarEscuelas =>
                @"SELECT DISTINCT e.NombreEscuela
                FROM Escuela e
                inner join Facultad f ON e.FacultadID = f.FacultadID
                WHERE f.NombreFacultad LIKE @Prefijo
                ORDER BY 1 DESC";
            public static string BuscarPacientes =>
                @"SELECT DISTINCT p.NombreCompleto
              FROM Pacientes p
              INNER JOIN Consultas c ON p.ID = c.PacienteID
              WHERE p.NombreCompleto LIKE @Prefijo + '%'
              AND p.Estado IN ('Activo', 'En Tratamiento')
              ORDER BY p.NombreCompleto";

            // Agrega más queries según necesites
        }


        public void AgregarHijoTrabajador(ModeloSecretaria hijoTrabajador)
        {
            String query = "INSERT INTO HijosTrabajadores(TpTrabajador, Estado, CodUniv, nombre, dni, facultad, escuela, DNITrab, Fecha, CodTrab)\r\nVALUES(@TpTrabajador, @Estado, @CodUniv, @nombre, @dni, @facultad, @escuela, @DNITrab, @Fecha, @CodTrab)";
            using (SqlConnection con = new SqlConnection(conexion)) {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@TpTrabajador", hijoTrabajador.TpTrab);
                    command.Parameters.AddWithValue("@Estado", hijoTrabajador.Estado);
                    command.Parameters.AddWithValue("@CodUniv", hijoTrabajador.CodUniv);
                    command.Parameters.AddWithValue("@nombre", hijoTrabajador.Nombre);
                    command.Parameters.AddWithValue("@dni", hijoTrabajador.DniAl);
                    command.Parameters.AddWithValue("@facultad", hijoTrabajador.Facultad);
                    command.Parameters.AddWithValue("@escuela", hijoTrabajador.Escuela);
                    command.Parameters.AddWithValue("@DNITrab", hijoTrabajador.DniTrab);
                    command.Parameters.AddWithValue("@Fecha", hijoTrabajador.Fecha);
                    command.Parameters.AddWithValue("@CodTrab", hijoTrabajador.IdTrabajador);

                    con.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void ModificarHijoTrabajador(ModeloSecretaria hijoTrabajador)
        {

            String query = "UPDATE HijosTrabajadores\r\nSET TpTrabajador=@TpTrabajador, Estado=@Estado, CodUniv=@CodUniv, nombre=@nombre, dni=@dni, \r\nfacultad=@facultad, escuela=@escuela, DNITrab=@DNITrab, Fecha=@Fecha, CodTrab=@CodTrab\r\nWHERE dni = @dni AND DNITrab = @DNITrab";
            using (SqlConnection con = new SqlConnection(conexion))
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("@TpTrabajador", hijoTrabajador.TpTrab);
                    command.Parameters.AddWithValue("@Estado", hijoTrabajador.Estado);
                    command.Parameters.AddWithValue("@CodUniv", hijoTrabajador.CodUniv);
                    command.Parameters.AddWithValue("@nombre", hijoTrabajador.Nombre);
                    command.Parameters.AddWithValue("@dni", hijoTrabajador.DniAl);
                    command.Parameters.AddWithValue("@facultad", hijoTrabajador.Facultad);
                    command.Parameters.AddWithValue("@escuela", hijoTrabajador.Escuela);
                    command.Parameters.AddWithValue("@DNITrab", hijoTrabajador.DniTrab);
                    command.Parameters.AddWithValue("@Fecha", hijoTrabajador.Fecha);
                    command.Parameters.AddWithValue("@CodTrab", hijoTrabajador.IdTrabajador);

                    con.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void EliminarHijoTrabajador(int id)
        {
            string query = "DELETE HijosTrabajadores\r\nWHERE id=@Prefijo";
            using (SqlConnection con = new SqlConnection(conexion))
            {
                using (SqlCommand command = new SqlCommand(query, con))
                {

                    command.Parameters.AddWithValue("@Prefijo", id);

                    con.Open();
                    command.ExecuteNonQuery();
                }

            }
        }

        public DataTable Buscar(string prefijo)
        {
            DataTable dt = new DataTable();
            string query = "\r\nSELECT *\r\nFROM HijosTrabajadores\r\nWHERE DNITrab LIKE '%' + @Prefijo + '%' OR CodUniv LIKE '%' + @Prefijo + '%'";
            using(SqlConnection con = new SqlConnection(conexion))
            {
                using (SqlCommand command = new SqlCommand(query, con)) {
                    command.Parameters.AddWithValue("@Prefijo", prefijo);

                    con.Open();
                    using (SqlDataReader reader = command.ExecuteReader()) { 
                        dt.Load(reader);
                    }
                }

            }
            return dt;
        }

    }
}
