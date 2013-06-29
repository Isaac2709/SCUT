using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Base_de_datos.Data
{
    class SolicitudFichaSalida
    {
        public SqlConnection conectar()
        {
            //string sc = "Data Source=MAFALDA;Initial Catalog=SCUT;Persist Security Info=True;User ID=sa;Password=12345";                                  
            string sc = "Data Source=Isaac-PC;Initial Catalog=SCUT;Persist Security Info=True;User ID=sa;Password=12345";
            SqlConnection conn = new SqlConnection(sc);
            conn.Open();
            return (conn);
        }
        public string insertarSolicitudFichaSalida(int numero_Solicitud,string tipoActividad,string Hora_Sal,string Hora_Lleg,int Kilometraje_Inic,int Kilometraje_Final,string Ruta,string Fecha_Salida,string Fecha_Llegada,string id_U,string placa_Vehiculo,string id_CC)
        {
            SqlConnection conn = conectar();
            string sql = "exec insertarSolicitud_Ficha_Salida " + "'" + numero_Solicitud + "'" + "," + "'" + tipoActividad + "'" + "," + "'" + Hora_Sal + "'" + "," + "'" + Hora_Lleg + "'" + "," + "'" + Kilometraje_Inic + "'" + "," + "'" + Kilometraje_Final + "'" + "," + "'" + Ruta + "'" + "," + "'" + Fecha_Salida + "'" + "," + "'" + Fecha_Llegada + "'" + "," + "'" + id_U + "'" + "," + "'" + placa_Vehiculo + "'" + "," + "'" + id_CC + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Se ha guardado";
            }
            catch (SqlException e)
            {
                conn.Close();                
                return (e.Message.ToString());
            }
        }
        public string insertarTelefonos(string id_U, string telefono)
        {
            SqlConnection conn = conectar();
            string sql = "exec insertarTelefonos " + "'" + id_U + "'" + "," + "'" + telefono + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Se ha guardado el nuevo telefono";
            }
            catch (SqlException e)
            {
                conn.Close();
                return (e.Message.ToString());
            }
        }
        public string insertarLicencias(string id_U, string licencia)
        {
            SqlConnection conn = conectar();
            string sql = "exec insertarTipos_Licencia " + "'" + id_U + "'" + "," + "'" + licencia + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Se ha ingresado la nueva licencia";
            }
            catch (SqlException e)
            {
                conn.Close();
                return (e.Message.ToString());
            }
        }
    }
}
