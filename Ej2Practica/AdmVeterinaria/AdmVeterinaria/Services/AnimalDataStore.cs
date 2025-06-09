using System.Data.Common;
using AdmVeterinaria.Clases;

namespace AdmVeterinaria.Services
{
    public class AnimalDataStore
    {
        public static AnimalDataStore Current { get; } = new AnimalDataStore();
        public List<Animal> Animales { get; set; }

        public AnimalDataStore()
        {
            Animales = new List<Animal>();
            Animales.Add(new Animal
            {
                IdAnimal = "1",
                Nombre = "Cata",
                Raza = "Caniche",
                Edad = "10",
                Sexo = "Hembra",
            });
        }
    }
}
