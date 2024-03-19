using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chimbofetada
{
    internal class Vendedor
    {
        Catalogo catalogo = new Catalogo();
        string nombre;
        string horario;
        float salario;

        public void ResponderC()
        {
            Console.WriteLine("Si, claro!!");
        }

        public void VenderCon()
        {

        }

        public void Cobrar()
        {

        }

        public void VerCatalogo()
        {
            catalogo.CatalogoDcondondes();
        }


    }
}
