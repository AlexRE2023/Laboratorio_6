using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int MaxPersonas;

            Console.Write("Ingrese el número máximo de personas: ");
            MaxPersonas = int.Parse(Console.ReadLine());
            Console.WriteLine("======================================");
            Console.WriteLine("El número máximo establecido es de " + MaxPersonas + " personas, presione una tecla para comenzar a contar");
            Console.ReadKey();
            Console.Clear();

            int AsistentesActuales = 0;
            int TIngresos = 0;
            int TSalidas = 0;
            int veceslle = 0;
            int vecesva = 0;

            char opcion;

            do
            {
                Console.Clear();
                Console.WriteLine("| Asistentes actuales | " + AsistentesActuales);
                Console.WriteLine("| Aforo               | " + (AsistentesActuales * 100 / MaxPersonas) + "%");
                Console.WriteLine("| Maximo              | " + MaxPersonas + " personas");
                Console.WriteLine("===========================");
                Console.WriteLine("[ i ] si ingresa una persona");
                Console.WriteLine("[ s ] si sale una persona");
                Console.WriteLine("[ x ] para terminar");

                opcion = Console.ReadKey().KeyChar;

                switch (opcion)
                {
                    case 'i':
                   

                        if (AsistentesActuales < MaxPersonas)
                        {
                            AsistentesActuales++;
                            TIngresos++;
                        }
                        else
                        {
                            Console.WriteLine("\nYa se alcanzó el aforo máximo de personas.");
                            Console.WriteLine("Presione una tecla para continuar...");
                            Console.ReadKey();
                        }
                        break;

                    case 's':
                    

                        if (AsistentesActuales > 0)
                        {
                            AsistentesActuales--;
                            TSalidas++;
                        }
                        else
                        {
                            Console.WriteLine("\nNo hay personas para sacar del local.");
                            Console.WriteLine("Presione una tecla para continuar...");
                            Console.ReadKey();
                        }
                        break;
                }

                if (AsistentesActuales == MaxPersonas)
                {
                    veceslle++;
                }

                if (AsistentesActuales == 0)
                {
                    vecesva++;
                }

            } while (opcion != 'x');
            Console.Clear();

            Console.WriteLine("=================================");
            Console.WriteLine("El programa ha terminado");
            Console.WriteLine("=================================");
            Console.WriteLine("Estadísticas:");
            Console.WriteLine("-------------------------------");
            Console.WriteLine(TIngresos + " personas ingresaron");
            Console.WriteLine(TSalidas + " personas salieron");
            Console.WriteLine(veceslle + " veces se llenó el local");
            Console.WriteLine("Estuvo vacío " + vecesva + " veces");
            Console.ReadKey();
        }
    }
}
