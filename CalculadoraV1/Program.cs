// See https://aka.ms/new-console-template for more information
using System;

string valor1, valor2;
char operacion, otroCalculo;
int x, y, verif;
do
{
    verif = 0;
    do
    {
        if (verif > 1)
        {
            Console.WriteLine("\nHa ingresado un valor erroneo, ingrese de nuevo!!\n");
        }
        Console.WriteLine("\nIngrese la operación a realizar (+, -, *, /):");
        operacion = Console.ReadKey().KeyChar;
        Console.WriteLine("\nIngrese un valor:");
        valor1 = Console.ReadLine();
        Console.WriteLine("Ingrese otro valor:");
        valor2 = Console.ReadLine();
        verif++;
    } while (!(int.TryParse(valor1, out x)) || !(int.TryParse(valor2, out y)) ||
    (operacion != '+' && operacion != '-' && operacion != '*' && operacion != '/'));

    int resultado = 0;
    switch (operacion)
    {
        case '+':
            resultado = Suma(x, y);
            break;

        case '-':
            resultado = Resta(x, y);
            break;

        case '*':
            resultado = Producto(x, y);
            break;

        case '/':
            resultado = Cociente(x, y);
            break;
    }
    Console.WriteLine("El resultado de " + valor1 + " " + operacion + " " + valor2 + " es: " + resultado + "\n");
    Console.WriteLine("Desea realizar otra operación? ('Y' para Sí):");
    otroCalculo = Console.ReadKey().KeyChar;
} while (otroCalculo == 'y' || otroCalculo == 'Y');

string value;
char otroNumero;
double num;
do
{
    verif = 0;
    do
    {
        if (verif > 1)
        {
            Console.WriteLine("\nHa ingresado un valor erroneo, ingrese de nuevo!!\n");
        }
        Console.WriteLine("\nIngrese un número:");
        value = Console.ReadLine();
        verif++;
    } while (!(double.TryParse(value, out num)));

    Console.WriteLine("Valor absoluto de " + num + ": " + ValorAbsoluto(num));
    Console.WriteLine("Cuadrado de " + num + ": " + Cuadrado(num));
    Console.WriteLine("Raiz cuadrada de " + num + ": " + RaizCuadrada(num));
    Console.WriteLine("Seno de " + num + ": " + Seno(num));
    Console.WriteLine("Coseno de " + num + ": " + Coseno(num));
    Console.WriteLine("Parte entera de " + num + ": " + ParteEntera(num));

    Console.WriteLine("Desea insertar otro número? ('Y' para Sí):");
    otroNumero = Console.ReadKey().KeyChar;
} while (otroNumero == 'y' || otroNumero == 'Y');

int Suma(int a, int b)
{
    return (a + b);
}

int Resta(int a, int b)
{
    return (a - b);
}

int Producto(int a, int b)
{
    return (a * b);
}

int Cociente(int a, int b)
{
    return (a / b);
}

double ValorAbsoluto(double z)
{
    return (Math.Abs(z));
}

double Cuadrado(double z)
{
    return (Math.Pow(z, 2));
}

double RaizCuadrada(double z)
{
    return (Math.Sqrt(z));
}

double Seno(double z)
{
    return (Math.Sin(z));
}

double Coseno(double z)
{
    return (Math.Cos(z));
}

double ParteEntera(double z)
{
    return (Math.Round(z));
}