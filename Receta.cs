using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoctelSystem
{
    using System.Collections.Generic;

    public class Receta
    {
        public string NombreCoctel { get; set; }
        public List<Ingrediente> Ingredientes { get; set; }

        public Receta(string nombreCoctel)
        {
            NombreCoctel = nombreCoctel;
            Ingredientes = new List<Ingrediente>();
        }

        public void AgregarIngrediente(Ingrediente ingrediente)
        {
            Ingredientes.Add(ingrediente);
        }

        public double CalcularVolumenTotal()
        {
            double total = 0;
            foreach (var ingrediente in Ingredientes)
            {
                total += ingrediente.Cantidad;
            }
            return total;
        }

        public bool ContieneIngrediente(string nombre)
        {
            foreach (var ing in Ingredientes)
            {
                if (ing.Nombre == nombre) return true;
            }
            return false;
        }
    }

}
