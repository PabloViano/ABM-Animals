using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Animal
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? UltimaModificacion { get; set; }
        public bool Eliminado { get; set; }

        public Animal() { }
        public Animal(int id, string nombre, string especie)
        {
            this.ID = id;
            this.Nombre = nombre;
            this.Especie = especie;
            this.FechaCreacion = DateTime.Now.Date;
            this.UltimaModificacion = null;
            this.Eliminado = false;
        }
    }
}
