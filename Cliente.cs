using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chimbofetada
{
    internal class Cliente
    {
        string nombre;
        float cedula;
        float telefono;
        string correo; 
        Vendedor vendedor = new Vendedor();
        Catalogo catalogo = new Catalogo();

        public void Pagar(float valor)
        {
            Console.WriteLine("Has pagado {0} pesos",valor);
        }
        public Cliente(string nombre, float cedula, float telefono, string correo) 
        {
            this.nombre = nombre; this.cedula = cedula; this.telefono = telefono; this.correo = correo;
        }

        public void Preguntar()
        {
            Console.WriteLine("Hola mi nombre es {0}, me podrias mostrar el catalogo?",nombre);
            
            vendedor.ResponderC();
            VerCatalogo();
        }

        public void Reclamo() 
        { 
            
        }
        public void VerCatalogo()
        {
            catalogo.CatalogoDcondondes();
        }


    }
}
