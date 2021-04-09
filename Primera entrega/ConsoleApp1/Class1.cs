using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Class1
    {
        detenerylimpiar inicio = new detenerylimpiar();        
        public void punto1()
        {
            
            int punto1;
            inicio.inicio();
            Console.WriteLine("▓               Primer punto               ▓");
            inicio.lineas();
            Console.WriteLine("▓ Leer un número por teclado y definir si  ▓");
            Console.WriteLine("▓               es par o impar             ▓");
            inicio.lineas();
            Console.Write("▓ Digite  un numero: ");
            punto1 = int.Parse(Console.ReadLine());

            if (punto1 % 2 == 0)
            {
                inicio.inicio();
                Console.WriteLine("▓          El numero "+punto1+" es par              ▓");
                inicio.fin();
            }

            else
            {
                inicio.inicio();
                Console.WriteLine("▓          El numero "+punto1+" es impar            ▓");
                inicio.fin();
            }
        }
        public void punto2()
        {
            inicio.inicio();
            Console.WriteLine("▓                Segundo punto             ▓");
            inicio.lineas();
            Console.WriteLine("▓ Leer un número por teclado y generar con ▓");
            Console.WriteLine("▓  ese número la tabla de multiplicar del  ▓");
            Console.WriteLine("▓             número 1 al 10               ▓");
            inicio.lineas();
            Console.Write("▓ Ingrese el numero de la tabla deseada ");
            int n;
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("▓              "+n + " x " + i + " = " + i * n + "                  ▓"+ "\n");
                
            }
            inicio.fin();
            
        }
        public void punto3()
        {
            inicio.inicio();
            Console.WriteLine("▓                Tercer punto              ▓");
            inicio.lineas();
            Console.WriteLine("▓ Generar las tablas de multiplicar desde  ▓");
            Console.WriteLine("▓  el numero 2 al 9, cada una desde el     ▓");
            Console.WriteLine("▓              numero 1 al 10              ▓");
            inicio.lineas();
            int a, b;
            for (a = 2; a <= 9; a++)
            {
                Console.WriteLine("▓               Tabla " + a+ "                    ▓");
                for (b = 1; b <= 10; b++)
                {
                    Console.Write("▓              "+a + " x " + b + " = " + a * b + "                  ▓"+ "\n");

                }
                inicio.inicio();
            }
        }
        public void punto4()
        {
            inicio.inicio();
            Console.WriteLine("▓                Cuarto punto              ▓");
            inicio.lineas();
            Console.WriteLine("▓ Leer un número por teclado y definir si  ▓");
            Console.WriteLine("▓             es primo o no                ▓");
            inicio.lineas();
            //4. Leer un número por teclado y definir si es primo o no
            int a = 0, num;
            Console.Write("▓ Digite el numero: ");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    a++;
                }
            }
            if (a != 2)
            {
                inicio.inicio();
                Console.WriteLine("▓     El numero digitado es no primo       ▓");
                inicio.fin();
            }
            else
            {
                inicio.inicio();
                Console.WriteLine("▓       El numero digitado es primo        ▓");
                inicio.fin();
            }
        }
        public void punto5()
        {
            inicio.inicio();
            Console.WriteLine("▓                Quinto punto              ▓");
            inicio.lineas();
            Console.WriteLine("▓ Dado el vector edad = [12,50,23,11,18,35 ▓");
            Console.WriteLine("▓     41,85,16,45], ordenarlos en forma    ▓");
            Console.WriteLine("▓                ascendente                ▓");
            inicio.lineas();
            Console.WriteLine("▓       Ordenados   -   Desordenado        ▓");

            int[] edad = new int[] { 12, 50, 23, 11, 18, 35, 41, 85, 16, 45 };
            int[] edadi = new int[] { 12, 50, 23, 11, 18, 35, 41, 85, 16, 45 };
            for (int k = 0; k < edad.Length; k++)
            {
                for (int f = 0; f < edad.Length - 1; f++)
                {
                    if (edad[f] > edad[f + 1])
                    {
                        int aux;
                        aux = edad[f];
                        edad[f] = edad[f + 1];
                        edad[f + 1] = aux;
                    }
                }
            }
            for (int f = 0; f < edad.Length; f++)
            {
                Console.WriteLine("▓           " + edad[f] +"      -       "+ edadi[f] + "             ▓");
            }
            inicio.fin();
        }
        public void punto6()
        {
            int c = 0;
            int[] edad = { 12, 50, 23, 11, 18, 35, 41, 85, 16, 45 };
            string[] nombres = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };
            inicio.inicio();
            Console.WriteLine("▓                Sexto punto               ▓");
            inicio.lineas();
            Console.WriteLine("▓ Leer un nombre por teclado y definir si  ▓");
            Console.WriteLine("▓ existe, y en caso de existir mostrar su  ▓");
            Console.WriteLine("▓ edad de lo contrario un mensaje que el   ▓");
            Console.WriteLine("▓             nombre no existe             ▓");
            inicio.lineas();
                                      
            Console.Write("▓ Digite el nombre que desea buscar : ");
            string nombre = Console.ReadLine();

            for (int i = 0; i < nombres.Length; i++)
            {
                if (nombre == nombres[i])
                {
                    Console.WriteLine("▓ Nombre : " + nombre + "\n▓ Edad   : " + edad[i] + " años                         ▓");
                    inicio.fin();
                    c++;
                }
            }
            if (c == 0)
            {
                Console.WriteLine("▓ El nombre " + nombre + " no aparece en la lista    ▓");
                inicio.fin();
            }
        }
        public void punto7()
        {
            inicio.inicio();
            Console.WriteLine("▓              Septimo punto               ▓");
            inicio.lineas();
            Console.WriteLine("▓   Partiendo de los vectores anteriores   ▓");
            Console.WriteLine("▓  buscar el menor y el mayor y presentar  ▓");
            Console.WriteLine("▓  sus respectivos nombres con su edad.    ▓");
            inicio.lineas();                   
            
            int[] edad = { 12, 50, 23, 11, 18, 35, 41, 85, 16, 45 };
            string[] nombres = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };
            int em = 0, ea = 100, pem = 0, pea = 0;
            for (int i = 0; i < edad.Length; i++)
            {
                if (edad[i] > em)
                {
                    em = edad[i];
                    pem = i;
                }
                if (edad[i] < ea)
                {
                    ea = edad[i];
                    pea = i;
                }
            }
            Console.WriteLine("▓>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>▓");
            Console.WriteLine("▓ Persona mayor es : " + nombres[pem] + " Edad : " + em + " años  ▓");
            Console.WriteLine("▓ Persona menor es : " + nombres[pea] + " Edad : " + ea + " años  ▓");
            Console.WriteLine("▓<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<▓");
            inicio.fin();
        }
        public void punto8()
        {
            inicio.inicio();
            Console.WriteLine("▓               Octavo punto               ▓");
            inicio.lineas();
            Console.WriteLine("▓       Dado una palabra definir si es     ▓");
            Console.WriteLine("▓              palíndromo o no.            ▓");
            inicio.lineas();
            string str = "";
            inicio.inicio();
            Console.WriteLine("▓ Introduce una palabra para determinar si  ");
            Console.Write("▓ es PALINDROME o no : ");
            string s = Console.ReadLine();
            int i = s.Length;
            for (int c = i - 1; c >= 0; c--)
            {
                str = str + s[c];
            }
            if (str == s)
            {
                inicio.inicio();
                Console.WriteLine("▓      La palabra "+s + " es palindrome");
                inicio.fin();
            }
            else
            {
                inicio.inicio();
                Console.WriteLine("▓      La palabra " + s + " no es palindrome");
                inicio.fin();
            }
            
        }
        public void punto9()
        {
            inicio.inicio();
            Console.WriteLine("▓               Noveno punto               ▓");
            inicio.lineas();
            Console.WriteLine("▓    Resolver el algoritmo de Fibonacci,   ▓");
            Console.WriteLine("▓ mostrando por consola la serie hasta una ▓");
            Console.WriteLine("▓      cantidad determinada de números     ▓");
            inicio.lineas();
            int ant = 0, sig = 1, res = 0, num=0;
            Console.WriteLine("▓ Digite el limite de la succesion de      ▓");
            Console.Write("▓ Fibonacci : ");
            num = int.Parse(Console.ReadLine());
            for (int i = num; i > res; i--)
            {
                Console.Write("» " + res);
                res = ant + sig;
                ant = sig;
                sig = res ;
            }
            if (num == res)
            {
                Console.WriteLine(" » " + num + "\n▓ Su numero hace parte de la secuencia     ▓\n▓ Fibonacci                                ▓ ");
                inicio.fin();
            }
            else
            {
                Console.WriteLine(" » " + num + "\n▓ Su numero no hace parte de la secuencia  ▓\n▓ Fibonacci                                ▓");
                inicio.fin();
            }
        }
        public void punto10()
        {
            Console.WriteLine("Digite su salario :");
            int salario = int.Parse(Console.ReadLine());
            int parafiscales;
            Console.WriteLine("Digite su nombre : ");
            string nom = Console.ReadLine();
            Console.WriteLine("Digite su apellido : ");
            string ape = Console.ReadLine();
            Console.WriteLine("Digite su Cedula : ");
            string cel = Console.ReadLine();
        }
    }
}
