using Control;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class FrmRegionales : System.Web.UI.Page
    {
        RegionalesController rc = new RegionalesController();
        int ide;
        string codigo, nombre;
        bool ejecuto = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
               mostrarRegionales();
            }
        }

        public void mostrarRegionales()
        {
            DataSet datos = new DataSet();
            datos = rc.mostrarRegionales();
            gvMostrarRegionales.DataSource = datos;
            gvMostrarRegionales.DataBind();
        }

        public void limpiarCampos()
        {
            //txtIdReg.Text = "";
            txtCodigoReg.Text = "";
            txtNombreReg.Text = "";
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            codigo = txtCodigoReg.Text;
            nombre = txtNombreReg.Text;
            ejecuto = rc.insertarRegional(codigo, nombre);

            if (ejecuto)
            {
                //txtIdReg.Text = "Insertado correctamente!";
                mostrarRegionales();
                limpiarCampos();
            }
            else
            {
                //txtIdReg.Text = "Elemento no insertado";
            }
        }

        protected void gvMostrarRegionales_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = gvMostrarRegionales.Rows[e.RowIndex];
            ide = Convert.ToInt32(gvMostrarRegionales.DataKeys[e.RowIndex].Values[0]);
            codigo = (row.Cells[3].Controls[0] as TextBox).Text;
            nombre = (row.Cells[4].Controls[0] as TextBox).Text; 
            //string fecha = (row.Cells[3].Controls[0] as TextBox).Text;
            //float total = float.Parse((row.Cells[4].Controls[0] as TextBox).Text);
            //int idclien = int.Parse((row.Cells[5].Controls[0] as TextBox).Text);
            ejecuto = rc.actualizarRegional(ide, codigo, nombre);

            if (ejecuto)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Se Actualizo correctamente!');", true);
                mostrarRegionales();
                limpiarCampos();
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('No se Actualizo!');", true);
   
            }
            gvMostrarRegionales.EditIndex = -1;
            mostrarRegionales();
            
        }

        protected void gvMostrarRegionales_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvMostrarRegionales.EditIndex = e.NewEditIndex;
            mostrarRegionales();
        }

        protected void gvMostrarRegionales_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            ide = Convert.ToInt32(gvMostrarRegionales.DataKeys[e.RowIndex].Values[0]);
            ejecuto = rc.eliminarRegional(ide);

            if (ejecuto)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Se Elimino correctamente!');", true);
                mostrarRegionales();
                limpiarCampos();
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Error al Eliminar!');", true);

            }
            gvMostrarRegionales.EditIndex = -1;
            mostrarRegionales();
        }

        protected void gvMostrarRegionales_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvMostrarRegionales.EditIndex = -1;
            mostrarRegionales();
        }

        protected void gvMostrarRegionales_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvMostrarRegionales.PageIndex = e.NewPageIndex;
            mostrarRegionales();
        }
    }
}