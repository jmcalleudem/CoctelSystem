using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoctelSystem
{
    public class Coctel
    {
        public string Nombre { get; set; }
        public Receta Receta { get; set; }

        public Coctel(string nombre, Receta receta)
        {
            Nombre = nombre;
            Receta = receta;
        }

        public bool PrepararCoctel()
        {
            if (Receta == null) return false;
            return true;
        }

        public double ObtenerFortaleza()
        {
            double alcoholTotal = 0;
            double volumenTotal = Receta.CalcularVolumenTotal();
            foreach (var ing in Receta.Ingredientes)
            {
                if (ing.Nombre.Contains("alcohol"))
                {
                    alcoholTotal += ing.Cantidad;
                }
            }
            return (alcoholTotal / volumenTotal) * 100;
        }

        public bool VerificarReceta()
        {
            return Receta.Ingredientes.Count > 0;
        }

        public string DescribirCoctel()
        {
            string descripcion = $"El cóctel {Nombre} lleva ";
            foreach (var ing in Receta.Ingredientes)
            {
                descripcion += $"{ing.Cantidad}ml de {ing.Nombre}, ";
            }
            return descripcion.TrimEnd(',', ' ');
        }
    }

}
