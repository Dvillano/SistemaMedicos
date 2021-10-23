using Datos.Admin;
using Entidades.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsMedicos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mostrarMedicos();
            llenarComboTraer();
            llenarComboGuardar();

        }

        private void mostrarMedicos()
        {
            gridMedicos.DataSource = AdminMedico.Listar();
            gridMedicos.AllowUserToAddRows = false;
        }

        private void llenarComboGuardar()
        {
            DataTable dataTable = AdminEspecialidad.Listar();

            cbEspecialidad.DisplayMember = dataTable.Columns["Nombre"].ToString();
            cbEspecialidad.ValueMember = dataTable.Columns["Id"].ToString();
            cbEspecialidad.DataSource = dataTable;
        }

        private void llenarComboTraer()
        {
            DataTable dataTable = AdminEspecialidad.Listar();
      
            cbTraerPorEspecialidad.DisplayMember = dataTable.Columns["Nombre"].ToString();
            cbTraerPorEspecialidad.ValueMember = dataTable.Columns["Id"].ToString();
            cbTraerPorEspecialidad.DataSource = dataTable;


            //Agregar una fila al DataTable en memoria
            DataRow dataRow = dataTable.NewRow();
            dataRow["Nombre"] = "TODOS";
            dataTable.Rows.InsertAt(dataRow, 0);
        }

        private void btnGuardarMedico_Click(object sender, EventArgs e)
        {
            guardarMedico();
        }

        private void guardarMedico()
        {
            Medico medico = new Medico(txtNombre.Text, txtApellido.Text, int.Parse(txtMatricula.Text), (int)cbEspecialidad.SelectedValue);

            int filasAfectadas = AdminMedico.Crear(medico);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Medico guardado con exito");
            }
            else
            {
                MessageBox.Show("No se puedo guardar medico");
            }

            borrarCampos();
        }

        private void borrarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtMatricula.Clear();
        }

        private void cbTraerPorEspecialidad_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string especialidad = cbTraerPorEspecialidad.SelectedValue.ToString();

            if(especialidad == "")
            {
                mostrarMedicos();
            }
            else
            {
                gridMedicos.DataSource = AdminMedico.Listar((int) cbTraerPorEspecialidad.SelectedValue);
            }
        }

        private void btnTraerUnMedico_Click(object sender, EventArgs e)
        {
            traerUnMedico();
        }

        private void traerUnMedico()
        {
            int idMedico = int.Parse(txtId.Text);
            gridMedicos.DataSource = AdminMedico.TraerUno(idMedico);
        }
    }
}
