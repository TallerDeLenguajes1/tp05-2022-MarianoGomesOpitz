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