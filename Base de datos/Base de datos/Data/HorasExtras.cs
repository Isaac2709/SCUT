using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Base_de_datos.Data
{
    class HorasExtras
    {
        public SqlConnection conectar()
        {
            string sc = "Data Source=MAFALDA;Initial Catalog=SCUT;Persist Security Info=True;User ID=sa;Password=12345";                                  
            //string sc = "Data Source=Isaac-PC;Initial Catalog=SCUT;Persist Security Info=True;User ID=sa;Password=12345";
            SqlConnection conn = new SqlConnection(sc);
            conn.Open();
            return (conn);
        }
        public string insertarHoras_Extras(int oficioAprobacion, string horaIncio, string horaFinal, string fecha, string centroCosto, string id_U, string actividad)
        {
            SqlConnection conn = conectar();
            string sql = "exec insertarHoras_Extras " + "'" + oficioAprobacion + "'" + "," + "'" + horaIncio + "'" + "," + "'" + horaFinal + "'" + "," + "'" + fecha + "'" + "," + "'" + centroCosto + "'" + "," + "'" + id_U + "'" + "," + "'" + actividad + "'" ;
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Se ha insertado la hora extra";
            }
            catch (SqlException e)
            {
                conn.Close();
                return (e.Message.ToString());
            }
        }
        public string actualizarHoras_Extras(string oficio_Aprobacion, string hora_Inicio, string hora_Fin, string fecha, string id_CC, string id_U)
        {
            SqlConnection conn = conectar();
            //string sql = "exec insertarUsuarios '00000009','0-0000-0009','Leonardo','Víquez', 'Acuña','04-11-1970','M','Ciudad Quesada','leoviquez@gmsl.com','Chofer','A','Transporte'";
            string sql = "exec  actualizarHoras_Extras " + "'" + oficio_Aprobacion + "'" + "," + "'" + hora_Inicio + "'" + "," + "'" + hora_Fin + "'" + "," + "'" + fecha + "'" + "," + "'" + id_CC + "'" + "," + "'" + id_U + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Se ha actualizado las horas extra";
            }
            catch (SqlException e)
            {
                conn.Close();
                return (e.Message.ToString());
            }
        }


        public string borrarHoras_Extras(string oficio_Aprobacion)
        {
            SqlConnection conn = conectar();
            //string sql = "exec insertarUsuarios '00000009','0-0000-0009','Leonardo','Víquez', 'Acuña','04-11-1970','M','Ciudad Quesada','leoviquez@gmsl.com','Chofer','A','Transporte'";
            string sql = "exec  borrarHoras_Extras " + "'" + oficio_Aprobacion + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Se ha eliminado las horas extra";
            }
            catch (SqlException e)
            {
                conn.Close();
                return (e.Message.ToString());
            }
        }
    }
}
