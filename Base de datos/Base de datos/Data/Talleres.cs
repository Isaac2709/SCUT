using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Base_de_datos.Data
{
    class Talleres
    {
        /// <summary>
        /// Crea la coneccion del programa con la base de datos
        /// </summary>        
        /// <returns>SqlConnection</returns>
        public SqlConnection conectar()
        {
            string sc = "Data Source=MAFALDA;Initial Catalog=SCUT;Persist Security Info=True;User ID=sa;Password=12345";                                  
            //string sc = "Data Source=Isaac-PC;Initial Catalog=SCUT;Persist Security Info=True;User ID=sa;Password=12345";
            SqlConnection conn = new SqlConnection(sc);
            conn.Open();
            return (conn);
        }

        /// <summary>
        /// Inserta los talleres en la base de datos SCUT
        /// </summary>
        /// <param name="cedula_Jur_Talleres">String Cedula Juridiga de Talleres</param>
        /// <param name="nombre">String Nombre de talleres</param>
        /// <param name="especialidad">String Especialidad de talleres</param>
        /// <param name="email">String Email de los talleres</param>
        /// <param name="direccion">String Direccion de los talleres</param>
        /// <param name="telefono">String Telefono de los talleres</param>
        /// <returns>String</returns>
        public string insertarTalleres(string cedula_Jur_Talleres, string nombre, string especialidad, string email, string direccion, string telefono)
        {
            SqlConnection conn = conectar();
            string sql = "exec insertarTalleres " + "'" + cedula_Jur_Talleres + "'" + "," + "'" + nombre + "'" + "," + "'" + especialidad + "'" + "," + "'" + email + "'" + "," + "'" + direccion + "'" + "," + "'" + telefono + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Se ha insertado el nuevo taller";
            }
            catch (SqlException e)
            {
                conn.Close();
                return (e.Message.ToString());
            }
        }
    }
}
