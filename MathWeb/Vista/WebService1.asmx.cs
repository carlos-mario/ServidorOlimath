using Modelo;
using Modelo.Clases;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Vista
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {
        Persistencia p = new Persistencia();
        OracleConnection cadena = new OracleConnection(ConfigurationManager.ConnectionStrings["Conn"].ConnectionString);

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        //WebMethod para listar todas las Regionales haciendo el llamado desde un paquete que implementa un procedimiento almacenado
        [WebMethod]
        public Regionales[] mostrarRegionales()
        {
               List<Regionales> lista = new List<Regionales>();
               OracleDataAdapter objAdapter = new OracleDataAdapter();

               OracleCommand objSelectCmd = new OracleCommand();
                objSelectCmd.Connection = p.abrirConexion();
                objSelectCmd.CommandText = "GestionarRegionales.mostrarRegional";
                objSelectCmd.CommandType = CommandType.StoredProcedure;

                objSelectCmd.Parameters.Add("cur_items", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                OracleDataReader reader = objSelectCmd.ExecuteReader();
                while (reader.Read())
                {
                    lista.Add(
                        new Regionales(reader.GetInt32(0),
                                           reader.GetString(1),
                                           reader.GetString(2)));
                }
                p.cerrarConexion();
                return lista.ToArray();
            }
    }
}
