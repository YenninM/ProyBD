using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
//
//using System.Data;
//using System.Data.SqlClient;

namespace ProyBD
{
    class ConsultasSQL
    {


        MySqlConnection conex;
        string cadenaconex;

        public MySqlConnection conexion() 
        {
            cadenaconex = "Data Source=pc-yennin;Initial Catalog=fmrdb;Integrated Security=True";
            conex = new MySqlConnection(cadenaconex);
            return conex;
        }
        
        protected void AbrirConexion() 
        {
            conex.Open();
        }
        protected void CerrarConexion() 
        {
            conex.Close();
        
        }
        /*public static SqlConnection Conectar() {
            SqlConnection cn = new SqlConnection("SERVER=localhost;DATABASE=fmrdb;Integrated Security = true;");
            cn.Open();
            return cn;
        
        }*/


        //private SqlConnection connection = new SqlConnection("Data Source = localhost; Initial Catalog = fmrdb; Integrated Security = true");
        //private DataSet ds;

        /*public DataTable MostrarDatos() 
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from CLIENTES", connection);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds);
            connection.Close();
            return ds.Tables["tabla"];
        }

        public DataTable Buscar(string nombre)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand(string.Format("select * from CLIENTES where NOMBREC like '%(0)%'", nombre), connection);
            //selecciona la fila del nombre, el 0 se sustituye oor el nombre
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            connection.Close();
            return ds.Tables["tabla"];
        }

        public bool Insertar(string id, string nombre, string direccion, string colonia,  string telefono)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand(string.Format("insert into CLIENTES values {0}, '{1}', '{2}', '{3}', '{4}'", new string[] { id, nombre, direccion, colonia, telefono }), connection);
            int filasafectadas = cmd.ExecuteNonQuery();
            connection.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }

        public bool Eliminar(string id)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand(string.Format("delete from clientes where IDCLIENTE= {0}",id), connection);
            int filasafectadas = cmd.ExecuteNonQuery();
            connection.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }

        public bool Actualizar(string id, string nombre)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand(string.Format("update CLIENTES set NOMBREC={0} where IDCLIENTE={1}", new string[]{nombre, id}), connection);
            int filasafectadas = cmd.ExecuteNonQuery();
            connection.Close();
            if (filasafectadas > 0) return true;
            else return false;
        }*/
    }
}
