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
