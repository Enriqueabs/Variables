using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string ciudad;
           Console.WriteLine("escribe tu nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("escribe tu ciudad:");
            ciudad = Console.ReadLine();
            Console.WriteLine("  hola  " + nombre + "  bienvenido a  " + ciudad);
            Console.WriteLine("presiona cualquier tecla para continuar");
            Console.ReadLine();
        }

    }
    
}
