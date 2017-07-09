using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Control
{
    public class RegionalesController
    {
        RegionalesMod re = new RegionalesMod();

        public DataSet mostrarRegionales()
        {
            return re.mostrarRegionales();
        }

        public bool insertarRegional(string codigo, string nombre)
        {
            return re.insertarRegional(codigo, nombre);
        }

        public bool actualizarRegional(int id, string codigo, string nombre)
        {
            return re.actualizarRegional(id, codigo, nombre);
        }

        public bool eliminarRegional(int id)
        {
            return re.eliminarRegional(id);
        }
    }
}