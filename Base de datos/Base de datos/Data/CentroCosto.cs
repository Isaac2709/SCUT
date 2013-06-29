using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Base_de_datos.Data
{
    class CentroCosto
    {
        public SqlConnection conectar()
        {
            //string sc = "Data Source=MAFALDA;Initial Catalog=SCUT;Persist Security Info=True;User ID=sa;Password=12345";                                  
            string sc = "Data Source=Isaac-PC;Initial Catalog=SCUT;Persist Security Info=True;User ID=sa;Password=12345";
            SqlConnection conn = new SqlConnection(sc);
            conn.Open();
            return (conn);
        }
        public string insertarCentroCosto(string id_CC, string nombre)
        {
            SqlConnection conn = conectar();
            string sql = "exec insertarCentro_Costo " + "'" + id_CC + "'" + "," + "'" + nombre + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Se ha insertado el nuevo Centro de Costo";
            }
            catch (SqlException e)
            {
                conn.Close();
                return (e.Message.ToString());
            }
        }
        public string borrarCentroCosto(string id_CC)
        {
            SqlConnection conn = conectar();
            string sql = "exec borrarCentro_Costo " + "'" + id_CC + "'" ;
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Se ha borrado el Centro de Costo";
            }
            catch (SqlException e)
            {
                conn.Close();
                return (e.Message.ToString());
            }
        }
        public string modificarCentroCosto(string id_CC, string nombre)
        {
            SqlConnection conn = conectar();
            string sql = "exec actualizarCentro_Costo " + "'" + id_CC + "'" + ',' + "'" + nombre+ "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Se ha modificado el Centro de Costo";
            }
            catch (SqlException e)
            {
                conn.Close();
                return (e.Message.ToString());
            }
        }
    }
}
