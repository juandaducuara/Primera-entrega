using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class detenerylimpiar
    {
        public void limpiar()
        {
            Console.WriteLine("»» Presione cualquier tecla para volver al inicio ««");
            Console.ReadKey();
            Console.Clear();
        }
        public void inicio()
        {
            Console.WriteLine("▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
        }
        public void fin()
        {
            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.WriteLine("▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄");
        }
        public void lineas()
        {
            Console.WriteLine("▓─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═─═▓");
        }
    }
}
