using Datos.Server;
using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Admin
{
    public static class AdminEspecialidad
    {
        //Metodo Listar() Modelo desconectado
        public static DataTable Listar()
        {
            string querySQL = "SELECT DISTINCT Nombre, Id FROM dbo.Especialidad";

            SqlDataAdapter adapter = new SqlDataAdapter(querySQL, AdminDB.ConectarBase());

            DataSet ds = new DataSet();

            adapter.Fill(ds, "Especialidad");

            return ds.Tables["Especialidad"];
        }

        
        public static DataTable TraerUno(int idMedico)
        {
            string querySql = "SELECT Id,Nombre,Apellido,NroMatricula,EspecialidadId FROM dbo.Medico WHERE Id = @Id";

            SqlDataAdapter adapter = new SqlDataAdapter(querySql, AdminDB.ConectarBase());

            //Declarar parametros
            adapter.SelectCommand.Parameters.Add("@Id", SqlDbType.Int).Value = idMedico;

            //Crear DataSet
            DataSet ds = new DataSet();
            adapter.Fill(ds, "idMedico");


            return ds.Tables["idMedico"];
        }

        public static int Crear(Especialidad especialidad)
        {
            string querySql = "INSERT INTO dbo.Especialidad (Nombre) VALUES (@Nombre)";

            SqlDataAdapter adapter = new SqlDataAdapter(querySql, AdminDB.ConectarBase());


            adapter.SelectCommand.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = especialidad.Nombre;

            int filasAfectadas = adapter.SelectCommand.ExecuteNonQuery();

            return filasAfectadas;
        }

        //TODO Falta implementar codigo
    }
}
