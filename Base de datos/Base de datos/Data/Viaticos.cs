using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Base_de_datos.Data
{
    class Viaticos
    {
        public SqlConnection conectar()
        {
            string sc = "Data Source=MAFALDA;Initial Catalog=SCUT;Persist Security Info=True;User ID=sa;Password=12345";                                  
            //string sc = "Data Source=Isaac-PC;Initial Catalog=SCUT;Persist Security Info=True;User ID=sa;Password=12345";
            SqlConnection conn = new SqlConnection(sc);
            conn.Open();
            return (conn);
        }
        public string insertarViaticos(string detalle, string fecha, int monto, string id_U)
        {
            SqlConnection conn = conectar();
            string sql = "exec insertarViaticos ''," + "'" + detalle + "'" + "," + "'" + fecha + "'" + "," + "'" + monto + "'" + "," + "'" + id_U + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Se ha insertado el nuevo viatico";
            }
            catch (SqlException e)
            {
                conn.Close();
                return (e.Message.ToString());
            }
        }
        public string actualizarViaticos(string detalle, string fecha, int monto, string id_U)
        {
            SqlConnection conn = conectar();
            string sql = "exec actualizarViaticos ''," + "'" + detalle + "'" + "," + "'" + fecha + "'" + "," + "'" + monto + "'" + "," + "'" + id_U + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Se ha modificado los valores";
            }
            catch (SqlException e)
            {
                conn.Close();
                return (e.Message.ToString());
            }
        }

        public string borrarViaticos(string id_U)
        {
            SqlConnection conn = conectar();
            string sql = "exec borrarViaticos ''," + "'" + id_U + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Se ha modificado los valores";
            }
            catch (SqlException e)
            {
                conn.Close();
                return (e.Message.ToString());
            }
        }
    }
}
