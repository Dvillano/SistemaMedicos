using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Server
{
    internal static class AdminDB
    {
        internal static SqlConnection ConectarBase()
        {
            //Importamos el string con los datos de la conexion
            string cadena = Datos.Properties.Settings.Default.KeyDBMedicos;

            //Creamos conexion a base de datos
            SqlConnection connection = new SqlConnection(cadena);

            //Abrimos conexion
            connection.Open();

            return connection;
        }
    }
}
