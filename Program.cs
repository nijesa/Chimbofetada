using System.Security.Cryptography.X509Certificates;

namespace Chimbofetada
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Vendedor vendedor = new Vendedor();
            Factura factura = new Factura();
            Condones condones = new Condones();
            string metodoPago;

            Console.WriteLine("Hola, bienvenido a Chimbofetada, porfavor ingresa tu nombre, tu telefono,\ntu cedula y tu correo electronico");
            Cliente cliente = new Cliente(Console.ReadLine(),float.Parse(Console.ReadLine()),float.Parse(Console.ReadLine()),Console.ReadLine());
            cliente.Preguntar();
        }
        public void Comunicar()
        {

        }

        public void GenerarColilla()
        {
            
        }

    }
}