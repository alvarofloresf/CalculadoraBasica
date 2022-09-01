using System;

namespace CalculadoraCientifica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Calculadora-Cientifica------");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Division");
            Console.WriteLine("0. Salir");
            Console.WriteLine("Ingresar una opcion:");
            int op = int.Parse(Console.ReadLine());
            do
            {
                switch (op)
                {
                    case 1:
                        float res = 0;
                        Console.WriteLine("--- Suma ---");
                        Console.WriteLine("Ingrese un numero");
                        float num1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese otro numero");
                        float num2 = float.Parse(Console.ReadLine());
                        res = num1 + num2;
                        Console.WriteLine("El resultado de la suma es: " + res);
                        break;
                    case 2:
                        float res1 = 0;
                        Console.WriteLine("--- Suma ---");
                        Console.WriteLine("Ingrese un numero");
                        float num3 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese otro numero");
                        float num4 = float.Parse(Console.ReadLine());
                        res1 = num3 - num4;
                        Console.WriteLine("El resultado de la resta es: " + res1);
                        break;
                    case 3:
                        float res2 = 0;
                        Console.WriteLine("--- Suma ---");
                        Console.WriteLine("Ingrese un numero");
                        float num5 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese otro numero");
                        float num6 = float.Parse(Console.ReadLine());
                        res2 = num5 * num6;
                        Console.WriteLine("El resultado de la multiplicacion es: " + res2);
                        break;
                    case 4:
                        float res3 = 0;
                        Console.WriteLine("--- Suma ---");
                        Console.WriteLine("Ingrese un numero");
                        float num7 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese otro numero");
                        float num8 = float.Parse(Console.ReadLine());
                        res3 = num7 / num8;
                        Console.WriteLine("El resultado de la division es: " + res3);
                        break;
                    case 0:
                        Console.WriteLine("--- Gracias ---");
                        break;
                }
                Console.WriteLine("Quieres Realizar otra operacion?? 1. Si 2. No");
                op = int.Parse(Console.ReadLine());
                
            } while (op != 0);
            
        }
    }
}
