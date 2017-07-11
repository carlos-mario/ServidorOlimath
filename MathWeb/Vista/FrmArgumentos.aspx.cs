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
    public partial class FrmArgumentos : System.Web.UI.Page
    {
        ArgumentosController ac = new ArgumentosController();
        int id;
        string afirmacion, evidencia, justificacion, rutaimagen, rutavideo;
        bool ejecuto = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                mostrarArgumentos();
            }
        }

        public void mostrarArgumentos()
        {
            DataSet datos = new DataSet();
            datos = ac.mostrarArgumentos();
            gvMostrarArgumentos.DataSource = datos;
            gvMostrarArgumentos.DataBind();
        }

        public void limpiarCampos()
        {
            txtAfirmacionArg.Text = "";
            txtEvidenciaArg.Text = "";
            txtJustificacionArg.Text = "";
            txtRutaimaArg.Text = "";
            txtRutavidArg.Text = "";
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            afirmacion = txtAfirmacionArg.Text;
            evidencia = txtEvidenciaArg.Text;
            justificacion = txtJustificacionArg.Text;
            rutaimagen = txtRutaimaArg.Text;
            rutavideo = txtRutavidArg.Text;
            ejecuto = ac.insertarArgumento(afirmacion, evidencia, justificacion, rutaimagen, rutavideo);

            if (ejecuto)
            {
                //txtIdArg.Text = "Insertado correctamente!";
                mostrarArgumentos();
                limpiarCampos();
            }
            else
            {
                //txtIdArg.Text = "Elemento no insertado";
            }
        }

        protected void gvMostrarArgumentos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = gvMostrarArgumentos.Rows[e.RowIndex];
            id = Convert.ToInt32(gvMostrarArgumentos.DataKeys[e.RowIndex].Values[0]);
            afirmacion = (row.Cells[3].Controls[0] as TextBox).Text;
            evidencia = (row.Cells[4].Controls[0] as TextBox).Text;
            justificacion = (row.Cells[5].Controls[0] as TextBox).Text;
            rutaimagen = (row.Cells[6].Controls[0] as TextBox).Text;
            rutaimagen = (row.Cells[7].Controls[0] as TextBox).Text;
            ejecuto = ac.actualizarArgumento(id, afirmacion, evidencia, justificacion, rutaimagen, rutavideo);

            if (ejecuto)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Se Actualizo correctamente!');", true);
                mostrarArgumentos();
                limpiarCampos();
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('No se Actualizo!');", true);

            }
            gvMostrarArgumentos.EditIndex = -1;
            mostrarArgumentos();

        }

        protected void gvMostrarArgumentos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvMostrarArgumentos.EditIndex = e.NewEditIndex;
            mostrarArgumentos();
        }

        protected void gvMostrarArgumentos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            id = Convert.ToInt32(gvMostrarArgumentos.DataKeys[e.RowIndex].Values[0]);
            ejecuto = ac.eliminarArgumento(id);

            if (ejecuto)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Se Elimino correctamente!');", true);
                mostrarArgumentos();
                limpiarCampos();
            }
            else
            {
                ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Error al Eliminar!');", true);

            }
            gvMostrarArgumentos.EditIndex = -1;
            mostrarArgumentos();
        }

        protected void gvMostrarArgumentos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvMostrarArgumentos.EditIndex = -1;
            mostrarArgumentos();
        }

        protected void gvMostrarArgumentos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvMostrarArgumentos.PageIndex = e.NewPageIndex;
            mostrarArgumentos();
        }
    }
}