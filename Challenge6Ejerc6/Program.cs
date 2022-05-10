using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge6Ejerc6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cola<String> cola = new Cola<String>();
            cola.Encolar("Nicolas");
            cola.Encolar("Lucas");
            cola.Encolar("Martina");
            cola.Encolar("Pedro");
            
            cola.MostrarCola();
            Console.WriteLine();
            cola.Desenconlar();
            cola.MostrarCola();

            Console.ReadKey();
        }
    }
}
