using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Veterinarios.Models
{
    public class Consultas
    {
        [Key]
        public int ID { get; set; }

        public DateTime Data { get; set; }

        public string Observacoes { get; set; }


        [ForeignKey(nameof(Animal))]  //nameof() -> devolve a designação do objeto que é colocado no parâmetro 
        public int AnimalFK { get; set; }
        public Animais Animal { get; set; }

        [ForeignKey(nameof(Veterinarios))]
        public int VeterinarioFK { get; set; }
        public Veterinarios Veterinarios { get; set; }

    }
}
    