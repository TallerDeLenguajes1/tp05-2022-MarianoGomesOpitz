// See https://aka.ms/new-console-template for more information
using System;
Random rand = new Random();

Console.WriteLine("\nIngrese una cadena de texto:");
string cadena = Console.ReadLine();
Console.WriteLine("\nAlgunas letras que forman parte de la cadena:");

int longitud = cadena.Length, posi = 0;
char letra;
for (int i = 0; i < 4; i++)
{
    posi = rand.Next(0, longitud);
    letra = cadena[posi];
    Console.WriteLine("Letra en la posición " + posi + ": " + letra);
}
Console.WriteLine("\nLongitud de la cadena: " + longitud);

Console.WriteLine("\n/--------------------/");
Console.WriteLine("\nConcatenar cadenas");
Console.WriteLine("\nIngrese la primer cadena:");
string cad1 = Console.ReadLine();
Console.WriteLine("Ingrese la segunda cadena:");
string cad2 = Console.ReadLine();
string conc1 = cad1 + cad2;
string conc2 = cad2 + cad1;
Console.WriteLine("\nConcatenación 1: " + conc1);
Console.WriteLine("\nConcatenación 2: " + conc2);


Console.WriteLine("\n/--------------------/");
Console.WriteLine("\nSubcadena");
Console.WriteLine("Ingrese una cadena:");
cadena = Console.ReadLine();
longitud = cadena.Length;
posi = rand.Next(1, longitud);
string subCadena = "";
for (int i = 0; i < posi; i++)
{
    subCadena += cadena[i];
}
Console.WriteLine("\nCadena original: " + cadena);
Console.WriteLine("\nSubcadena: " + subCadena);

string valor1, valor2, texto, solucion = "", suma = "La suma", resta = "La resta", producto = "El producto", cociente = "El cociente";
char operacion, otroCalculo;
double x, y, resultado;
int verif;
do
{
    verif = 0;
    do
    {
        if (verif > 0)
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

    resultado = 0;
    switch (operacion)
    {
        case '+':
            resultado = Suma(x, y);
            solucion = suma;
            break;

        case '-':
            resultado = Resta(x, y);
            solucion = resta;
            break;

        case '*':
            resultado = Producto(x, y);
            solucion = producto;
            break;

        case '/':
            resultado = Cociente(x, y);
            solucion = cociente;
            break;
    }
    texto = solucion + " de " + valor1 + " y de " + valor2 + " es igual a: " + resultado;
    Console.WriteLine(texto + "\n");
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
