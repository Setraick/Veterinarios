using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Veterinarios.Models
{
    public class Veterinarios
    {
        public Veterinarios()
        {
            ListaConsultas = new HashSet<Consultas>
        }
        public int ID { get; set; }


        public int Nome { get; set; }

        public int NumCedulaProf { get; set; }

        public string Fotografia { get; set; }

        public ICollection<Consultas> ListaConsultas { get; set; }
    }
}
