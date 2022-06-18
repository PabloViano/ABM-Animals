using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Logica
{
    public class Class1
    {
        public List<Animal> Animales = new List<Animal>()
        {
            new Animal() { Nombre = "Perro", Eliminado = false, Especie = "Caniche", FechaCreacion = DateTime.Now, ID = 1},
            new Animal() { Nombre = "Gato", Eliminado = false, Especie = "Montes", FechaCreacion = DateTime.Now, ID = 2},
            new Animal() {Nombre = "Loro", Eliminado = false, Especie = "Amazonico", FechaCreacion = DateTime.Now, ID = 3},
            new Animal(){Nombre = "Pezcado", Eliminado = false, Especie = "Surubi", FechaCreacion = DateTime.Now, ID = 4},
        };
        public Animal Alta (string nombre, string especie)
        {
            if (nombre != null && especie != null)
            {
                Animal animal = new Animal(Animales.Count() + 1, nombre, especie);
                Animales.Add(animal);
                return animal;
            }
            return null;
        }
        public Animal Baja (int id)
        {
            if (Animales.Exists(x => x.ID == id))
            {
                Animal animal = Animales.Find(x => x.ID == id);
                Animales.Remove(Animales.Find(x => x.ID == id));
                return animal;
            }
            return null;
        }
        public Animal Modificacion (Modificacion modificacion)
        {
            foreach (var animal in Animales)
            {
                if (animal.ID == modificacion.ID)
                {
                    switch (modificacion.Modificar)
                    {
                        case "Nombre":
                            {
                                animal.Nombre = modificacion.NuevoValor;
                            }
                            break;
                        case "Especie":
                            {
                                animal.Especie = modificacion.NuevoValor;
                            }
                            break;
                    }
                    return animal;
                }
            }
            return null;
        }
        public Animal BuscarPorAproximacion(string nombre, string especie)
        {
            foreach (Animal animal in Animales)
            {
                if (animal.Nombre.Contains(nombre) && animal.Especie.Contains(especie)) { return animal; }
            }
            return null;
        }
        public Animal BuscarPorID(int id)
        {
            if (Animales.Exists(x => x.ID == id) == true) { return Animales.FirstOrDefault(x => x.ID == id); }
            return null;
        }
    }
}
