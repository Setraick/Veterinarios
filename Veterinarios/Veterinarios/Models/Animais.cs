using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Veterinarios.Models
{
    public class Animais
    {
        public int ID { get; set; }

        public string Nome { get; set; }

        public string Especie { get; set; }

        public string Raca { get; set; }

        public double Peso { get; set; }

        public string Foto { get; set; }

        //*****************************************************
        //adição da FK 
        //*****************************************************
        [ForeignKey("Dono")]    //anotação: vai associar o atributo 'Dono FK' ao atributo 'Dono' com a caracteristica de FK
        public int DonoFK { get; set; } //donoFK int
        public Donos Dono { get; set; } //Refrences Donos(ID)
    }
}
