using System;

namespace ConsoleApp1
{
    class Menu
    {
        static void Main(string[] args)
        {
            Class1 puntos = new Class1();
            detenerylimpiar inicio = new detenerylimpiar();
            detenerylimpiar limpiar = new detenerylimpiar();
            int opc=0;
            do
            {
                inicio.inicio();
                Console.WriteLine("▓▓                Taller                  ▓▓");
                inicio.lineas();
                Console.WriteLine("▓▓       Digite 1 para el Punto 1         ▓▓");
                inicio.lineas();
                Console.WriteLine("▓▓       Digite 2 para el Punto 2         ▓▓");
                inicio.lineas();
                Console.WriteLine("▓▓       Digite 3 para el Punto 3         ▓▓");
                inicio.lineas();
                Console.WriteLine("▓▓       Digite 4 para el Punto 4         ▓▓");
                inicio.lineas();
                Console.WriteLine("▓▓       Digite 5 para el Punto 5         ▓▓");
                inicio.lineas();
                Console.WriteLine("▓▓       Digite 6 para el Punto 6         ▓▓");
                inicio.lineas();
                Console.WriteLine("▓▓       Digite 7 para el Punto 7         ▓▓");
                inicio.lineas();
                Console.WriteLine("▓▓       Digite 8 para el Punto 8         ▓▓");
                inicio.lineas();
                Console.WriteLine("▓▓       Digite 9 para el Punto 9         ▓▓");
                inicio.lineas();
                Console.WriteLine("▓▓      Digite 10 para el Punto 10        ▓▓");
                inicio.fin();
                inicio.inicio();
                Console.WriteLine("▓▓         Digite 11 para salir           ▓▓");
                inicio.fin();
                Console.Write("»»»»  "); opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1: puntos.punto1();
                        limpiar.limpiar();
                        break;
                    case 2: puntos.punto2();
                        limpiar.limpiar();
                        break;
                    case 3: puntos.punto3();
                        limpiar.limpiar();
                        break;
                    case 4: puntos.punto4();
                        limpiar.limpiar();
                        break;
                    case 5: puntos.punto5();
                        limpiar.limpiar();
                        break;
                    case 6: puntos.punto6();
                        limpiar.limpiar();
                        break;
                    case 7: puntos.punto7();
                        limpiar.limpiar();
                        break;
                    case 8: puntos.punto8();
                        limpiar.limpiar();
                        break;
                    case 9: puntos.punto9();
                        limpiar.limpiar();
                        break;
                    case 10: puntos.punto10();
                        limpiar.limpiar();
                        break;
                    default:
                        break;

                }
            } while (opc != 11);
        }
    }
}