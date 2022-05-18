// See https://aka.ms/new-console-template for more information
using System;

string valor1, valor2;
char operacion, otroCalculo;
double x, y;
int verif;
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
    } while (!(double.TryParse(valor1, out x)) || !(double.TryParse(valor2, out y)) ||
    (operacion != '+' && operacion != '-' && operacion != '*' && operacion != '/'));

    double resultado = 0;
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

double Suma(double a, double b)
{
    return (a + b);
}

double Resta(double a, double b)
{
    return (a - b);
}

double Producto(double a, double b)
{
    return (a * b);
}

double Cociente(double a, double b)
{
    return (a / b);
}