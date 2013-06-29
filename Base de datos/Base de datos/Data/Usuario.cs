using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Base_de_datos.Data
{
    class Usuario
    {
        public SqlConnection conectar()
        {
            //string sc = "Data Source=MAFALDA;Initial Catalog=SCUT;Persist Security Info=True;User ID=sa;Password=12345";                                  
            string sc = "Data Source=Isaac-PC;Initial Catalog=SCUT;Persist Security Info=True;User ID=sa;Password=12345";
            SqlConnection conn = new SqlConnection(sc);
            conn.Open();
            return (conn);
        }
        public string insertarUsuarios(string id_U, string cedula, string nombre, string apellido1, string apellido2, string fecha_nacimiento, char genero, string direccion, string e_mail, string puesto, char estado, string departamento)
        {
            SqlConnection conn = conectar();            
            //string sql = "exec insertarUsuarios '00000009','0-0000-0009','Leonardo','Víquez', 'Acuña','04-11-1970','M','Ciudad Quesada','leoviquez@gmsl.com','Chofer','A','Transporte'";
            string sql = "exec insertarUsuarios "+"'"+id_U+"'"+","+"'"+cedula+"'"+","+"'"+nombre+"'"+","+"'"+ apellido1+"'"+","+"'"+apellido2+"'"+","+"'"+fecha_nacimiento+"'"+","+"'"+genero+"'"+","+"'"+direccion+"'"+","+"'"+e_mail+"'"+","+"'"+puesto+"'"+","+"'"+estado+"'"+","+"'"+departamento+"'";          
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
            string sql = "exec insertarTelefonos " + "'" + id_U + "'" + "," + "'" + telefono +"'";
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
        public string insertarLicencias(string id_U, string licencia){
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
