using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Base_de_datos.Data
{
    class Agencia
    {
        public SqlConnection conectar()
        {
            //string sc = "Data Source=MAFALDA;Initial Catalog=SCUT;Persist Security Info=True;User ID=sa;Password=12345";
            string sc = "Data Source=Isaac-PC;Initial Catalog=SCUT;Persist Security Info=True;User ID=sa;Password=12345";
            SqlConnection conn = new SqlConnection(sc);
            conn.Open();
            return (conn);
        }
        public string insertarAgencia(string cedula_Jur_Ag,string direccion, string telefono,string email,string nombre)
        {
            SqlConnection conn = conectar();
            string sql = "exec insertarAgencia " + "'" + cedula_Jur_Ag + "'" + "," + "'" + direccion + "'" + "," + "'" + telefono + "'" + "," + "'" + email + "'" + "," + "'" + nombre + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();            
                conn.Close();
                return "Se ha insertado la nueva agencia";
            }
            catch (SqlException e)
            {
                conn.Close();
                return (e.Message.ToString());
            }
        }

        public string actualizarAgencia(string cedula_Jur_Ag,string direccion,string telefono	,string email,string nombre)  
        {
            SqlConnection conn = conectar();
            //string sql = "exec insertarUsuarios '00000009','0-0000-0009','Leonardo','Víquez', 'Acuña','04-11-1970','M','Ciudad Quesada','leoviquez@gmsl.com','Chofer','A','Transporte'";
            string sql = "exec actualizarAgencia " + "'" + cedula_Jur_Ag + "'" + "," + "'" + direccion + "'" + "," + "'" + nombre + "'" + "," + "'" + telefono + "'" + "," + "'" + email + "'" + "," + "'" + nombre + "'" ;
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Se ha actualizado la agencia";
            }
            catch (SqlException e)
            {
                conn.Close();
                return (e.Message.ToString());
            }
        }
    }
}
