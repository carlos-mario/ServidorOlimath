using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modelo.Clases
{
    public class Regionales
    {
        public int ide { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }

         public Regionales() 
        {
            codigo = "";
            nombre = "";
        }

         public Regionales(int newIde,string newCodigo, string newNombre)
        {
            this.ide = newIde;
            this.codigo = newCodigo;
            this.nombre = newNombre;
        }
         
    }
}