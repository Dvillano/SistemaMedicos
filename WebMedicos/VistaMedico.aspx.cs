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
            if (!IsPostBack)
            {
                llenarDropdownList();
                mostrarMedicos();
            }
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

            ddlEspecialidad.Items.Insert(0, new ListItem("-Elegir especialidad-", ""));

            ddlEspecialidad.DataBind();

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            guardarMedico();

        }

        private void guardarMedico()
        {
            Medico medico = new Medico(txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtNroMatricula.Text), Convert.ToInt32(ddlEspecialidad.SelectedValue));


            int filasAfectadas = AdminMedico.Crear(medico);

            if (filasAfectadas > 0)
            {
                mostrarMedicos();
                borrarCampos();
            }
        }

        private void borrarCampos()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtNroMatricula.Text = string.Empty;
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            modificarMedico();

        }

        private void modificarMedico()
        {
            Medico medicoModificado = new Medico(int.Parse(txtId.Text), txtNombre.Text, txtApellido.Text, Convert.ToInt32(txtNroMatricula.Text), Convert.ToInt32(ddlEspecialidad.SelectedValue));


            int filasAfectadas = AdminMedico.Modificar(medicoModificado);

            if (filasAfectadas > 0)
            {
                mostrarMedicos();
                borrarCampos();
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarMedico();
        }

        private void eliminarMedico()
        {
            int medicoEliminar = int.Parse(txtId.Text);

            int filasAfectadas = AdminMedico.Eliminar(medicoEliminar);

            if (filasAfectadas > 0)
            {
                mostrarMedicos();
                borrarCampos();
            }
        }
    }
}