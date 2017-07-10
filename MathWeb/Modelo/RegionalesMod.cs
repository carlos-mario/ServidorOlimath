using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Modelo
{
    public class RegionalesMod
    {
        Persistencia p = new Persistencia();

        public DataSet mostrarRegionales()
        {
            OracleDataAdapter objAdapter = new OracleDataAdapter();
            DataSet datos = new DataSet();

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarRegionales.mostrarRegional";
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            objSelectCmd.Parameters.Add("cur_regionales", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            objAdapter.SelectCommand = objSelectCmd;
            objAdapter.Fill(datos);
            p.cerrarConexion();
            return datos;
        }

        public bool insertarRegional(string codigo, string nombre)
        {
            bool ejecuto = false;
            int filas = 0;

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarRegionales.insertarRegional";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("r_cod", OracleDbType.Varchar2, 11).Value = codigo;
            objSelectCmd.Parameters.Add("r_nom", OracleDbType.Varchar2, 20).Value = nombre;

            objSelectCmd.Parameters.Add("ejecuto", OracleDbType.Int16).Direction = ParameterDirection.Output; ;

            try
            {
                objSelectCmd.ExecuteNonQuery();
                filas = int.Parse(objSelectCmd.Parameters[2].Value.ToString());
                if (filas == 1)
                {
                    ejecuto = true;
                }
            }
            catch (Exception e)
            {

            }
            p.cerrarConexion();
            return ejecuto;
        }

        public bool actualizarRegional(int id, string codigo, string nombre)
        {
            bool ejecuto = false;
            int filas = 0;

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarRegionales.actualizarRegional";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("r_ide", OracleDbType.Int16).Value = id;
            objSelectCmd.Parameters.Add("r_cod", OracleDbType.Varchar2, 11).Value = codigo;
            objSelectCmd.Parameters.Add("r_nom", OracleDbType.Varchar2, 20).Value = nombre;

            objSelectCmd.Parameters.Add("ejecuto", OracleDbType.Int16).Direction = ParameterDirection.Output; ;

            try
            {
                objSelectCmd.ExecuteNonQuery();
                filas = int.Parse(objSelectCmd.Parameters[3].Value.ToString());
                if (filas == 1)
                {
                    ejecuto = true;
                }
            }
            catch (Exception e)
            {

            }
            p.cerrarConexion();
            return ejecuto;
        }

        public bool eliminarRegional(int id)
        {
            bool ejecuto = false;
            int filas = 0;

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarRegionales.eliminarRegional";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("r_ide", OracleDbType.Int16).Value = id;

            objSelectCmd.Parameters.Add("ejecuto", OracleDbType.Int16).Direction = ParameterDirection.Output; ;

            try
            {
                objSelectCmd.ExecuteNonQuery();
                filas = int.Parse(objSelectCmd.Parameters[1].Value.ToString());
                if (filas == 1)
                {
                    ejecuto = true;
                }
            }
            catch (Exception e)
            {

            }
            p.cerrarConexion();
            return ejecuto;
        }
    }
}