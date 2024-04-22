using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoctelSystem
{
    public class Ingrediente
    {
        public string Nombre { get; set; }
        public double Cantidad { get; set; } // Cantidad en mililitros

        public Ingrediente(string nombre, double cantidad)
        {
            Nombre = nombre;
            Cantidad = cantidad;
        }

        public void AgregarCantidad(double cantidad)
        {
            Cantidad += cantidad;
        }

        public bool CompararCantidad(double cantidad)
        {
            return Cantidad == cantidad;
        }

        public bool EsSuficiente(double cantidadNecesaria)
        {
            return Cantidad >= cantidadNecesaria;
        }

        public double CalcularPorcentaje(double total)
        {
            return (Cantidad / total) * 100;
        }
    }

}
