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
            Console.WriteLine("Inicio del programa en el hilo principal.");

            // Se crean tres objetos de la clase Thread, APLICANDO EL METODO 'Tarea' CON 2 ARGUMENTOS, 'id'-> nombre del hilo 
            // 'iteraciones'-> numero de iteraciones que ejecutara el hilo 
            Thread thread1 = new Thread(() => Tarea(1, 5));
            Thread thread2 = new Thread(() => Tarea(2, 3));
            Thread thread3 = new Thread(() => Tarea(3, 7));

            //Cada Hilo (objeto) inicia su ejecución a través del método "Start()" que invoca al método tarea "Tarea()"
            thread1.Start();
            thread2.Start();
            thread3.Start();
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