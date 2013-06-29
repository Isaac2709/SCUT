using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Base_de_datos.Data
{
    class Mantenimiento
    {
        public SqlConnection conectar()
        {
            string sc = "Data Source=MAFALDA;Initial Catalog=SCUT;Persist Security Info=True;User ID=sa;Password=12345";
            //string sc = "Data Source=Isaac-PC;Initial Catalog=SCUT;Persist Security Info=True;User ID=sa;Password=12345";
            SqlConnection conn = new SqlConnection(sc);
            conn.Open();
            return (conn);
        }
        public string insertarMantenimiento(string monto, string detalle, string tipoMantenimento, int numeroFactura, string fecha, string cedula_jur_talleres, string cedula_jur_ag, string placa_Vehiculo)
        {
            SqlConnection conn = conectar();
            string sql;
            if (!string.Equals(cedula_jur_talleres, "null"))
            {
                sql = "exec insertarMantenimiento ''," + "'" + monto + "'" + "," + "'" + detalle + "'" + "," + "'" + tipoMantenimento + "'" + "," + "'" + numeroFactura + "'" + "," + "'" + fecha + "'" + "," + "'" + cedula_jur_talleres + "'" + "," + "null" + "," + "'" + placa_Vehiculo + "'";
            }
            else if (!string.Equals(cedula_jur_ag, "null"))
            {
                sql = "exec insertarMantenimiento '',null," + "'" + detalle + "'" + "," + "'" + tipoMantenimento + "'" + "," + "'" + numeroFactura + "'" + "," + "'" + fecha + "'" + "," + "null" + "," + "'" + cedula_jur_ag + "'" + "," + "'" + placa_Vehiculo + "'";
            }
            else return "Debe escoger una agencia o un taller";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Se ha insertado el nuevo mantenimiento";
            }
            catch (SqlException e)
            {
                conn.Close();                
                return (e.Message.ToString());
            }
        }
    }
}
