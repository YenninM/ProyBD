using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace ProyBD.DAO
{
    
    class ClientesTabla:ConsultasSQL
    {
        
        string instruccion;
        
        public DataTable VistaTabla() 
        {
            instruccion = "SELECT * FROM CLIENTES";
            MySqlDataAdapter adp = new MySqlDataAdapter(instruccion, conexion());
            DataTable COnsulta = new DataTable();
            adp.Fill(COnsulta);
            return COnsulta;


        }







    }
}
