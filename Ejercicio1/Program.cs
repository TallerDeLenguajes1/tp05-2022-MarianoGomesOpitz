// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingrese un número:");
string value = Console.ReadLine();
int valor;
if (int.TryParse(value, out valor))
{
    if (valor > 0)
    {
        int aux = valor, res, upsideDown = 0;
        while (aux != 0)
        {
            res = aux % 10;
            upsideDown = (upsideDown * 10) + res;
            aux /= 10;
        }
        Console.WriteLine("El numero " + valor + " invertido es " + upsideDown);
    }
    else
    {
        Console.WriteLine("La conversión no se puede llevar a cabo ya que el valor ingresado no es un número positivo");
    }
}
else
{
    Console.WriteLine("La conversión no se puede llevar a cabo ya que el valor ingresado no es número");
}