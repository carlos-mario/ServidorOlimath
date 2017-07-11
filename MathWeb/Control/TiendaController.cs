using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Control
{
    public class TiendaController
    {
        TiendaMod tie = new TiendaMod();

        public DataSet mostrarTienda()
        {
            return tie.mostrarTienda();
        }

        public bool insertarTienda(string codigo, string nombre, string imagen, int precio, string tipo)
        {
            return tie.insertarTienda(codigo, nombre, imagen, precio, tipo);
        }

        public bool actualizarTienda(int id, string codigo, string nombre, string imagen, int precio, string tipo)
        {
            return tie.actualizarTienda(id, codigo, nombre, imagen, precio, tipo);
        }

        public bool eliminarTienda(int id)
        {
            return tie.eliminarTienda(id);
        }
    }
}