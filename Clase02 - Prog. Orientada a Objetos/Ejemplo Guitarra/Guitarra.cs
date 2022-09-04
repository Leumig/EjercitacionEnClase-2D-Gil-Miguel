using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo_Guitarra
{
    public class Guitarra
    {
        public string marca;
        public int precio;
        public string material;
        public bool estaAfinada;
        public int cantidadCuerdas;

        public Guitarra(string marca, int precio)
        {
            material = "NO CARGADO";
            this.marca = marca;
            this.precio = precio;
        }

        public Guitarra(string marca, int precio, string material) : this(marca, precio)
        {
            this.material = material;
        }

        public Guitarra(string marca, int precio, string material, bool estaAfinada, int cantidadCuerdas) : this(marca, precio, material)
        {
            this.estaAfinada = estaAfinada;
            this.cantidadCuerdas = cantidadCuerdas;
        }

        public Guitarra(string marca, int precio, bool estaAfinada) : this(marca, precio)
        {
            this.estaAfinada = estaAfinada;
        }

        public void SubirDePrecio(int aumento)
        {
            precio *= aumento;
        }
    }
}
