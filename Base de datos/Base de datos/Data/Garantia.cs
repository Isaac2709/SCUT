using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Base_de_datos.Data
{
    class Garantia
    {
        public SqlConnection conectar()
        {
            string sc = "Data Source=MAFALDA;Initial Catalog=SCUT;Persist Security Info=True;User ID=sa;Password=12345";                                  
            //string sc = "Data Source=Isaac-PC;Initial Catalog=SCUT;Persist Security Info=True;User ID=sa;Password=12345";
            SqlConnection conn = new SqlConnection(sc);
            conn.Open();
            return (conn);
        }
        public string insertarGarantia(int km_Vencimiento,string fecha_Vencimiento)
        {
            SqlConnection conn = conectar();
            string sql = "exec insertarGarantia " + "'" + km_Vencimiento + "'" + "," + "'" + fecha_Vencimiento + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Se ha insertado la nueva garantia";
            }
            catch (SqlException e)
            {
                conn.Close();
                return (e.Message.ToString());
            }
        }

        public string actualizarGarantia(int id_Garantia, int km_Vencimiento, string fecha_Vencimiento)
        {
            SqlConnection conn = conectar();
            string sql = "exec actualizarGarantia " + "'" + id_Garantia + "'" + "," + "'" + km_Vencimiento + "'" + "," + "'" + fecha_Vencimiento + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Se ha modificado la garantia";
            }
            catch (SqlException e)
            {
                conn.Close();
                return (e.Message.ToString());
            }
        }



        public string borrarGarantia(int id_Garantia)
        {
            SqlConnection conn = conectar();
            string sql = "exec borrarGarantia " + "'" + id_Garantia + "'" ;
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Se ha modificado la garantia";
            }
            catch (SqlException e)
            {
                conn.Close();
                return (e.Message.ToString());
            }
        }
    }
}
