using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //Funcion para calcular la resta de 2 numeros
        static int Resta(int a, int b)
        {
            return a - b;
        }
        //Funcion para calcular la division de 2 numeros
        static int Division(int a, int b)
        {
            if(a/b == 0)
            {
                return Convert.ToInt32("error en la division");
            }
            else
            {
                return a / b;
            }
            
        }
        //Funcion para calcular la multiplicacion de 2 numeros
        static int Multiplicacion(int a, int b)
        {
            return a * b;
        }

        //Función para calcular la suma de 2 números enteros
        static int Suma(int a, int b)
        {
            return a + b;
        }

        //Procedimiento que imprime la raíz cuadrada de los 10 primeros números
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }

        //Funcion para convertir de Fahrenheit a Celsius
        static int Fahren_to_Celsius(int a)
        {
            int rspt = (5 * (a - 32)) / 9;
            return rspt;
        }
        //Funcion para convertir de Celsius a Fahrenheit
        static int Celsius_to_Fahren(int a)
        {
            int rspt2 = ((9 * a) / 5) + 32;
            return rspt2;
        }

        //Funcion para mostrar los 10 primeros numeros primos
        static void Primos()
        {
            int cont = 0;
            for (int i = 2; i <= 30; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        cont = cont + 1;
                    }
                }
                if (cont <= 2)
                { //si variable cont es mayor a dos, el numero es divisible en mas de dos numero osea no es primo
                    Console.WriteLine(i);
                }
                cont = 0;
            }
        }


            static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[3] Resta de dos números");
                Console.WriteLine("[4] Multiplicacion de dos números");
                Console.WriteLine("[5] Division de dos números");
                Console.WriteLine("[6] Conversion a Celsius o a Fahrenheit");
                Console.WriteLine("[7] Impresion de los 10 primeros numeros primos");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int d = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", c, d, Resta(c, d));
                        Console.ReadKey();
                        break;

                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        int e = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La multiplicacion de {0} y {1} es {2}", e, f, Multiplicacion(e, f));
                        Console.ReadKey();
                        break;

                    case "5":
                        Console.WriteLine("Ingrese el primer número");
                        int g = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        int h = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La division de {0} y {1} es {2}", g, h, Division(g, h));
                        Console.ReadKey();
                        break;

                    case "6":
                        Console.WriteLine("Elige tu conversion");
                        string conversion_op;

                            Console.WriteLine("Conversion de Temperatura Avanzado");
                            Console.WriteLine("[1] de Fahrenheit a Celsius");
                            Console.WriteLine("[2] de Celsius a Fahrenheit");
 
                            conversion_op = Console.ReadLine();
                            switch (conversion_op)
                            {
                                case "1":
                                    Console.WriteLine("Ingrese el valor de temperatura");
                                    int i = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("La transformacion de {0} Fahrenheit a Celcius es {1} grados Celsius", i, Fahren_to_Celsius(i));
                                    Console.ReadKey();
                                    break;

                                case "2":
                                    Console.WriteLine("Ingrese el valor de temperatura");
                                    int j = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("La transformacion de {0} Celsius a Fahrenheit es {1} grados Fahrenheit", j, Celsius_to_Fahren(j));
                                    Console.ReadKey();
                                    break;
                            }
                        
                        break;

                    case "7":
                        Console.WriteLine("============================================");
                        Console.WriteLine("Calculando los 10 Primeros numeros primos...");
                        Console.WriteLine("============================================");
                        Primos();
                        Console.ReadKey();
                        break;

                }
            } while (!opcion.Equals("0"));

        }

    }
}
