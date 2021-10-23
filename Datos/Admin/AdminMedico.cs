using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Datos.Server;
using System.Data;

namespace Datos.Admin
{
    public static class AdminMedico
    {
        //Metodo Listar() Modelo conectado
        public static List<Medico> Listar()
        {
            string querySql = "SELECT Id,Nombre,Apellido,NroMatricula,EspecialidadId FROM dbo.Medico";

            //Creamos comando para el reader
            SqlCommand command = new SqlCommand(querySql, AdminDB.ConectarBase());

            //Creamos reader
            SqlDataReader reader;
            reader = command.ExecuteReader();

            //Creamos lista de medicos para usar el reader y devolverla
            List<Medico> listaMedicos = new List<Medico>();

            while (reader.Read())
            {
                listaMedicos.Add
                    (
                    new Medico
                    {
                        Id = (int) reader["Id"],
                        Nombre = reader["Nombre"].ToString(),
                        Apellido = reader["Apellido"].ToString(),
                        NroMatricula = (int) reader["NroMatricula"],
                        EspecialidadId = (int) reader["EspecialidadId"]
                    }
                    );
            }

            //Cerrar conexion DB y reader
            AdminDB.ConectarBase().Close();
            reader.Close();

            return listaMedicos;
        }

        //Metodo Listar(idEspecialidad ) Modelo desconectado
        public static DataTable Listar(int EspecialidadId)
        {
            
            string querySql = "SELECT Id,Nombre,Apellido,NroMatricula,EspecialidadId FROM dbo.Medico WHERE EspecialidadId = @EspecialidadId";

            SqlDataAdapter adapter = new SqlDataAdapter(querySql, AdminDB.ConectarBase());

            //Declarar parametros
            adapter.SelectCommand.Parameters.Add("@EspecialidadId", SqlDbType.Int).Value = EspecialidadId;

            //Crear DataSet
            DataSet ds = new DataSet();
            adapter.Fill(ds, "EspecialidadId");


            return ds.Tables["EspecialidadId"];
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


        // Insertar medico en DB
        public static int Crear(Medico medico)
        {
            string querySql = "INSERT INTO dbo.Medico(Nombre, Apellido,NroMatricula, EspecialidadId) VALUES (@Nombre, @Apellido, @NroMatricula, @EspecialidadId)";

            SqlDataAdapter adapter = new SqlDataAdapter(querySql, AdminDB.ConectarBase());


            adapter.SelectCommand.Parameters.Add("@Nombre", SqlDbType.VarChar,50).Value = medico.Nombre;
            adapter.SelectCommand.Parameters.Add("@Apellido", SqlDbType.VarChar, 50).Value = medico.Apellido;
            adapter.SelectCommand.Parameters.Add("@NroMatricula", SqlDbType.Int).Value = medico.NroMatricula;
            adapter.SelectCommand.Parameters.Add("@EspecialidadId", SqlDbType.Int, 50).Value = medico.EspecialidadId;

            int filasAfectadas = adapter.SelectCommand.ExecuteNonQuery();

            return filasAfectadas;
        }

        //TODO Falta implementar codigo

    }
}
