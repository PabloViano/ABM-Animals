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
        List<Animal> Animales = new List<Animal>();
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
    }
}
