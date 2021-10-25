using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Datos.Admin;
using Entidades;
using Entidades.Models;

namespace WebMedicos
{
    public partial class VistaMedico : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            mostrarMedicos();
            llenarDropdownList();
        }

        private void mostrarMedicos()
        {
            gridMedico.DataSource = AdminMedico.Listar();
            gridMedico.DataBind();
        }

        private void llenarDropdownList()
        {
            DataTable dt = AdminEspecialidad.Listar();
            ddlEspecialidad.DataSource = dt;
            ddlEspecialidad.DataValueField = dt.Columns["Id"].ToString();
            ddlEspecialidad.DataTextField = dt.Columns["Nombre"].ToString();
           
            ddlEspecialidad.DataBind();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico(txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtNroMatricula.Text), Convert.ToInt32(ddlEspecialidad.SelectedValue));


            int filasAfectadas = AdminMedico.Crear(medico);

            if (filasAfectadas > 0)
            {
                mostrarMedicos();
                borrarCampos()
            }

            if (!Page.IsPostBack)
            {
                mostrarMedicos();
                llenarDropdownList();
            }

            
        }

        private void borrarCampos()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtNroMatricula.Text = string.Empty;
        }

        protected void ddlEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPrueba.Text = ddlEspecialidad.SelectedItem.ToString();
        }
    }
}