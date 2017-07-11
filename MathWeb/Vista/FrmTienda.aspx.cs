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
    public partial class FrmTienda : System.Web.UI.Page
    {
        TiendaController tc = new TiendaController();
        int id, precio;
        //double precio;
        string codigo, nombre, imagen, tipo;
        bool ejecuto = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                mostrarTienda();
            }
        }

        public void mostrarTienda()
        {
            DataSet datos = new DataSet();
            datos = tc.mostrarTienda();
            gvMostrarTienda.DataSource = datos;
            gvMostrarTienda.DataBind();
        }

        public void limpiarCampos()
        {
            txtCodigoTie.Text = "";
            txtNombreTie.Text = "";
            txtImagenTie.Text = "";
            txtPrecioTie.Text = "";
            txtTipoTie.Text = "";
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            codigo = txtCodigoTie.Text;
            nombre = txtNombreTie.Text;
            imagen = txtImagenTie.Text;
            precio = int.Parse(txtPrecioTie.Text);
            tipo = txtTipoTie.Text;
            ejecuto = tc.insertarTienda(codigo, nombre, imagen, precio, tipo);

            if (ejecuto)
            {
                //txtIdArg.Text = "Insertado correctamente!";
                mostrarTienda();
                limpiarCampos();
            }
            else
            {
                //txtIdArg.Text = "Elemento no insertado";
            }
        }

        protected void gvMostrarTienda_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = gvMostrarTienda.Rows[e.RowIndex];
            id = Convert.ToInt32(gvMostrarTienda.DataKeys[e.RowIndex].Values[0]);
            codigo = (row.Cells[3].Controls[0] as TextBox).Text;
            nombre = (row.Cells[4].Controls[0] as TextBox).Text;
            imagen = (row.Cells[5].Controls[0] as TextBox).Text;
            precio = Convert.ToInt32((row.Cells[6].Controls[0] as TextBox).Text);
            tipo = (row.Cells[7].Controls[0] as TextBox).Text;
            ejecuto = tc.actualizarTienda(id, codigo, nombre, imagen, precio, tipo);

            if (ejecuto)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Se Actualizo correctamente!');", true);
                mostrarTienda();
                limpiarCampos();
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('No se Actualizo!');", true);

            }
            gvMostrarTienda.EditIndex = -1;
            mostrarTienda();

        }

        protected void gvMostrarTienda_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvMostrarTienda.EditIndex = e.NewEditIndex;
            mostrarTienda();
        }

        protected void gvMostrarTienda_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            id = Convert.ToInt32(gvMostrarTienda.DataKeys[e.RowIndex].Values[0]);
            ejecuto = tc.eliminarTienda(id);

            if (ejecuto)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Se Elimino correctamente!');", true);
                mostrarTienda();
                limpiarCampos();
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Error al Eliminar!');", true);

            }
            gvMostrarTienda.EditIndex = -1;
            mostrarTienda();
        }

        protected void gvMostrarTienda_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvMostrarTienda.EditIndex = -1;
            mostrarTienda();
        }

        protected void gvMostrarTienda_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvMostrarTienda.PageIndex = e.NewPageIndex;
            mostrarTienda();
        }
    }
}