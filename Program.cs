using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Calculadora en C#");
            Console.WriteLine("1- Suma");
            Console.WriteLine("2- Resta");
            Console.WriteLine("3- Multiplicación");
            Console.WriteLine("4- División");
            Console.WriteLine("5- Elevar un número a la potencia");
            Console.WriteLine("6- Salir");
            Console.Write("Selecciona una opción: ");

            int opcion;
            if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 6)
            {
                Console.WriteLine("Opción no válida, intenta nuevamente.");
                continue;
            }

            if (opcion == 6)
            {
                break;
            }

            Console.Write("Ingresa el primer número: ");
            double numero1;
            while (!double.TryParse(Console.ReadLine(), out numero1))
            {
                Console.WriteLine("Número no válido, intenta nuevamente.");
                Console.Write("Ingresa el primer número: ");
            }

            double numero2 = 0;
            if (opcion != 5)
            {
                Console.Write("Ingresa el segundo número: ");
                while (!double.TryParse(Console.ReadLine(), out numero2))
                {
                    Console.WriteLine("Número no válido, intenta nuevamente.");
                    Console.Write("Ingresa el segundo número: ");
                }
            }

            double resultado = 0;
            switch (opcion)
            {
                case 1:
                    resultado = numero1 + numero2;
                    Console.WriteLine($"Resultado: {numero1} + {numero2} = {resultado}");
                    break;
                case 2:
                    resultado = numero1 - numero2;
                    Console.WriteLine($"Resultado: {numero1} - {numero2} = {resultado}");
                    break;
                case 3:
                    resultado = numero1 * numero2;
                    Console.WriteLine($"Resultado: {numero1} * {numero2} = {resultado}");
                    break;
                case 4:
                    if (numero2 == 0)
                    {
                        Console.WriteLine("Error: División por cero no permitida.");
                    }
                    else
                    {
                        resultado = numero1 / numero2;
                        Console.WriteLine($"Resultado: {numero1} / {numero2} = {resultado}");
                    }
                    break;
                case 5:
                    Console.Write("Ingresa la potencia: ");
                    double potencia;
                    while (!double.TryParse(Console.ReadLine(), out potencia))
                    {
                        Console.WriteLine("Número no válido, intenta nuevamente.");
                        Console.Write("Ingresa la potencia: ");
                    }
                    resultado = Math.Pow(numero1, potencia);
                    Console.WriteLine($"Resultado: {numero1} ^ {potencia} = {resultado}");
                    break;
            }

            Console.WriteLine("Presiona cualquier tecla para continuar...");
            Console.ReadKey();
        }

        Console.WriteLine("Gracias por usar la calculadora. ¡Hasta luego!");
    }
}
