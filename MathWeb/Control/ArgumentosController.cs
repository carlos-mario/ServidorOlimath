using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Control
{
    public class ArgumentosController
    {
        ArgumentosMod arg = new ArgumentosMod();

        public DataSet mostrarArgumentos()
        {
            return arg.mostrarArgumentos();
        }

        public bool insertarArgumento(string afirmacion, string evidencia, string justificacion, string rutaimagen, string rutavideo)
        {
            return arg.insertarArgumento(afirmacion, evidencia, justificacion, rutaimagen, rutavideo);
        }

        public bool actualizarArgumento(int id, string afirmacion, string evidencia, string justificacion, string rutaimagen, string rutavideo)
        {
            return arg.actualizarArgumento(id, afirmacion, evidencia, justificacion, rutaimagen, rutavideo);
        }

        public bool eliminarArgumento(int id)
        {
            return arg.eliminarArgumento(id);
        } 
    }
}