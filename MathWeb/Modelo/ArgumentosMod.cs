using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Modelo
{
    public class ArgumentosMod
    {
        Persistencia p = new Persistencia();

        public DataSet mostrarArgumentos()
        {
            OracleDataAdapter objAdapter = new OracleDataAdapter();
            DataSet datos = new DataSet();

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarArgumentos.mostrarArgumento";
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            objSelectCmd.Parameters.Add("cur_argumentos", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            objAdapter.SelectCommand = objSelectCmd;
            objAdapter.Fill(datos);
            p.cerrarConexion();
            return datos;
        }

        public bool insertarArgumento(string afirmacion, string evidencia, string justificacion, string rutaimagen, string rutavideo)
        {
            bool ejecuto = false;
            int filas = 0;

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarArgumentos.insertarArgumento";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("arg_afi", OracleDbType.Varchar2, 300).Value = afirmacion;
            objSelectCmd.Parameters.Add("arg_evi", OracleDbType.Varchar2, 300).Value = evidencia;
            objSelectCmd.Parameters.Add("arg_jus", OracleDbType.Varchar2, 300).Value = justificacion;
            objSelectCmd.Parameters.Add("arg_rutima", OracleDbType.Varchar2, 100).Value = rutaimagen;
            objSelectCmd.Parameters.Add("arg_rutvid", OracleDbType.Varchar2, 100).Value = rutavideo;

            objSelectCmd.Parameters.Add("ejecuto", OracleDbType.Int16).Direction = ParameterDirection.Output; ;

            try
            {
                objSelectCmd.ExecuteNonQuery();
                filas = int.Parse(objSelectCmd.Parameters[5].Value.ToString());
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

        public bool actualizarArgumento(int id, string afirmacion, string evidencia, string justificacion, string rutaimagen, string rutavideo)
        {
            bool ejecuto = false;
            int filas = 0;

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarArgumentos.actualizarArgumento";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("arg_ide", OracleDbType.Int16).Value = id;
            objSelectCmd.Parameters.Add("arg_afi", OracleDbType.Varchar2, 300).Value = afirmacion;
            objSelectCmd.Parameters.Add("arg_evi", OracleDbType.Varchar2, 300).Value = evidencia;
            objSelectCmd.Parameters.Add("arg_jus", OracleDbType.Varchar2, 300).Value = justificacion;
            objSelectCmd.Parameters.Add("arg_rutima", OracleDbType.Varchar2, 100).Value = rutaimagen;
            objSelectCmd.Parameters.Add("arg_rutvid", OracleDbType.Varchar2, 100).Value = rutavideo;

            objSelectCmd.Parameters.Add("ejecuto", OracleDbType.Int16).Direction = ParameterDirection.Output; ;

            try
            {
                objSelectCmd.ExecuteNonQuery();
                filas = int.Parse(objSelectCmd.Parameters[6].Value.ToString());
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

        public bool eliminarArgumento(int id)
        {
            bool ejecuto = false;
            int filas = 0;

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarArgumentos.eliminarArgumento";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("arg_ide", OracleDbType.Int16).Value = id;

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