using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Base_de_datos.Data
{
    class Gastos
    {
        public SqlConnection conectar()
        {
            //string sc = "Data Source=MAFALDA;Initial Catalog=SCUT;Persist Security Info=True;User ID=sa;Password=12345";                                  
            string sc = "Data Source=Isaac-PC;Initial Catalog=SCUT;Persist Security Info=True;User ID=sa;Password=12345";
            SqlConnection conn = new SqlConnection(sc);
            conn.Open();
            return (conn);
        }
        public string insertarGasto_Combustible(int gastoCombustible, string fecha,int gastoEfectivo, int factura, string placa, string id_U)
        {
            SqlConnection conn = conectar();
            string sql = "exec insertarGasto_Combustible ''," + "'" + gastoCombustible + "'" + "," + "'" + fecha + "'" + "," + "'" + gastoEfectivo + "'" + "," + "'" + factura + "'" + "," + "'" + placa + "'" + "," + "'" + id_U + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Se ha insertado el nuevo gasto de combustible";
            }
            catch (SqlException e)
            {
                conn.Close();
                return (e.Message.ToString());
            }
        }
    }
}
