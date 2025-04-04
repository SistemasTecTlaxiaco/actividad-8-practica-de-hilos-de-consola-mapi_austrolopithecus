using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Hilos_Corredores
{
    class Program
    {
        static void Main()
        {
            //EL CÓDIGO VA AQUÍ
        }

        static void Tarea(int id, int iteraciones)//METODO CON EL CUAL LOS HILOS SERÁN INICIALIZADOS
        {
            for (int i = 1; i <= iteraciones; i++)//CICLO FOR, TIENEN COMO ARGUMENTO UNA VARIABLE iteraciones
            {
                Console.WriteLine($"Hilo {id}: iteración {i}");//IMPRIME EL NOMBRE (id) DEL HILO Y EL NÚMERO DE ITERACIÓN (i)
                Thread.Sleep(1000); // Bloquea el proceso de un hilo por 1s
            }
            Console.WriteLine($"Hilo {id} ha terminado su tarea.");//AL TERMINAR LAS "i" ITERACIONES MUESTRA EL MENSAJE 
            //QUE INDICA QUE EL HILO "id" HA TERMINADO SU TAREA
        }

    }

}