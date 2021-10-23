using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Medico
    {
        public Medico() { }

        //Constructor opcional con ID
        public Medico(int id, string nombre, string apellido, int nroMatricula, int especialidadId)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            NroMatricula = nroMatricula;
            EspecialidadId = especialidadId;
        }
        
        public Medico(string nombre, string apellido, int nroMatricula, int especialidadId)
        {
            Nombre = nombre;
            Apellido = apellido;
            NroMatricula = nroMatricula;
            EspecialidadId = especialidadId;
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int NroMatricula { get; set; }
        public int EspecialidadId { get; set; }
    }
}
