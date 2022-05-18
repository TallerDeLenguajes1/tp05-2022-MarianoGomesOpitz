// See https://aka.ms/new-console-template for more information
using System;

int verif;
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

string coso1, coso2;
double num1, num2;
do
{
    verif = 0;
    do
    {
        if (verif > 1)
        {
            Console.WriteLine("\nHa ingresado un valor erroneo, ingrese de nuevo!!\n");
        }
        Console.WriteLine("\nIngrese el primer número:");
        coso1 = Console.ReadLine();
        Console.WriteLine("\nIngrese el otro número:");
        coso2 = Console.ReadLine();
        verif++;
    } while (!(double.TryParse(coso1, out num1)) || !(double.TryParse(coso2, out num2)));

    Console.WriteLine("\nEl máximo de esos números es " + Maximo(num1, num2));
    Console.WriteLine("El mínimo de esos números es " + Minimo(num1, num2));
  
    Console.WriteLine("\nDesea probar con otros números? ('Y' para Sí):");
    otroNumero = Console.ReadKey().KeyChar;
} while (otroNumero == 'y' || otroNumero == 'Y');



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

double Maximo(double a, double b){
    return (Math.Max(a, b));
}

double Minimo(double a, double b){
    return (Math.Min(a, b));
}