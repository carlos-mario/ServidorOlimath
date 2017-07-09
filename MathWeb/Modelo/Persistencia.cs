using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace Modelo
{
    public class Persistencia
    {
        OracleConnection cadena = new OracleConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);

        public OracleConnection abrirConexion()
        {

            try
            {
                cadena.Open();
                return cadena;
            }
            catch (Exception e)
            {
                //cadena.Close();
                return null;

            }
        }

        public void cerrarConexion()
        {
            cadena.Close();
        }

        public bool ejecutarDML(String sql)
        {
            bool ejecuto = false;
            cadena.Open();
            OracleCommand comando = new OracleCommand(sql, cadena);
            if (comando.ExecuteNonQuery() > 0)
            {
                ejecuto = true;
            }
            cadena.Close();
            return ejecuto;
        }

        public DataSet ejecutarConsulta(string sql)
        {
            DataSet datos = new DataSet();
            cadena.Open();
            OracleDataAdapter miadaptador = new OracleDataAdapter(sql, cadena);
            miadaptador.Fill(datos);
            cadena.Close();
            return datos;
        }
    }
}