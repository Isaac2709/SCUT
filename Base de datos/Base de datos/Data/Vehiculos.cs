using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Base_de_datos.Data
{
    class Vehiculos
    {
        public SqlConnection conectar()
        {
            string sc = "Data Source=MAFALDA;Initial Catalog=SCUT;Persist Security Info=True;User ID=sa;Password=12345";
            //string sc = "Data Source=Isaac-PC;Initial Catalog=SCUT;Persist Security Info=True;User ID=sa;Password=12345";
            SqlConnection conn = new SqlConnection(sc);
            conn.Open();
            return (conn);
        }
        public string insertarVehiculos(string placa,string departamento,string descripcion,int modelo,string numero_chasis,string numero_Motor,int cilindros,string cilindrada,string color,decimal puertas,string tipo_combustible,string marca,string estilo,string fecha_compra,int kilometraje,decimal capacidad,char velocidades,int id_garantia,string cedula_jur_ag,string sucursal)
        {
            SqlConnection conn = conectar();
            string sql = "exec insertarVehiculos " + "'" + placa + "'" + "," + "'" + departamento + "'" + "," + "'" + descripcion + "'" + "," + "'" + modelo + "'" + "," + "'" + numero_chasis + "'" + "," + "'" + numero_Motor + "'" + "," + "'" + cilindros + "'" + "," + "'" + cilindrada + "'" + "," + "'" + color + "'" + "," + "'" + puertas + "'" + "," + "'" + tipo_combustible + "'" + "," + "'" + marca + "'" + "," + "'" + estilo + "'" + "," + "'" + fecha_compra + "'" + "," + "'" + kilometraje + "'" + "," + "'" + capacidad + "'" + "," + "'" + velocidades + "'" + "," + "'" + id_garantia + "'" + "," + "'" + cedula_jur_ag + "'" + "," + "'" + sucursal + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                return "Se ha insertado el nuevo vehiculo";
            }
            catch (SqlException e)
            {
                conn.Close();                
                return (e.Message.ToString());
            }
        }
    }
}
