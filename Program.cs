using System;
using System.Threading.Tasks;
using ConsoleApp2.Clases;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Prestamo x = new Prestamo();

            x.Cancha = "FUTBOL";
            Console.WriteLine(x.Costo);

            x.Horas = 2;
            Console.WriteLine(x.Subtotal);

            Console.WriteLine(x.Descuento);
        }
    }
}
