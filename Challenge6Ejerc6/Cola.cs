using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge6Ejerc6
{
    class Cola <T>
    {
        Queue<T> cola = new Queue<T>();

        public void Encolar(T objeto)
        {
            cola.Enqueue(objeto);
        }

        public T Desenconlar() => cola.Dequeue();

        public void MostrarCola()
        {
            foreach (T Objeto in cola)
            {
                Console.WriteLine(Objeto);
            }
        }
    }
}
