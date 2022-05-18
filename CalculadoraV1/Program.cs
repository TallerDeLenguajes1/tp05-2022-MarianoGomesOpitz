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


//////////////////FUNCIONES

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