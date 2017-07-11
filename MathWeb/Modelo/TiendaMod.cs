using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Modelo
{
    public class TiendaMod
    {
        Persistencia p = new Persistencia();

        public DataSet mostrarTienda()
        {
            OracleDataAdapter objAdapter = new OracleDataAdapter();
            DataSet datos = new DataSet();

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarTienda.mostrarTienda";
            objSelectCmd.CommandType = CommandType.StoredProcedure;

            objSelectCmd.Parameters.Add("cur_tienda", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
            objAdapter.SelectCommand = objSelectCmd;
            objAdapter.Fill(datos);
            p.cerrarConexion();
            return datos;
        }

        public bool insertarTienda(string codigo, string nombre, string imagen, int precio, string tipo)
        {
            bool ejecuto = false;
            int filas = 0;
            
            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarTienda.insertarTienda";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("t_cod", OracleDbType.Varchar2, 12).Value = codigo;
            objSelectCmd.Parameters.Add("t_nom", OracleDbType.Varchar2, 50).Value = nombre;
            objSelectCmd.Parameters.Add("t_img", OracleDbType.Varchar2, 50).Value = imagen;
            objSelectCmd.Parameters.Add("t_precio", OracleDbType.Int32).Value = precio;
            objSelectCmd.Parameters.Add("t_tipo", OracleDbType.Varchar2, 50).Value = tipo;

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

        public bool actualizarTienda(int id, string codigo, string nombre, string imagen, int precio, string tipo)
        {
            bool ejecuto = false;
            int filas = 0;

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarTienda.actualizarTienda";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("t_ide", OracleDbType.Int16).Value = id;
            objSelectCmd.Parameters.Add("t_cod", OracleDbType.Varchar2, 12).Value = codigo;
            objSelectCmd.Parameters.Add("t_nom", OracleDbType.Varchar2, 50).Value = nombre;
            objSelectCmd.Parameters.Add("t_img", OracleDbType.Varchar2, 50).Value = imagen;
            objSelectCmd.Parameters.Add("t_precio", OracleDbType.Int32).Value = precio;
            objSelectCmd.Parameters.Add("t_tipo", OracleDbType.Varchar2, 50).Value = tipo;

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

        public bool eliminarTienda(int id)
        {
            bool ejecuto = false;
            int filas = 0;

            OracleCommand objSelectCmd = new OracleCommand();
            objSelectCmd.Connection = p.abrirConexion();
            objSelectCmd.CommandText = "GestionarTienda.eliminarTienda";
            objSelectCmd.CommandType = CommandType.StoredProcedure;
            objSelectCmd.Parameters.Add("t_ide", OracleDbType.Int16).Value = id;

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