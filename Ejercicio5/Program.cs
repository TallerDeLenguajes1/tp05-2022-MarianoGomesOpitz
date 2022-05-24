// See https://aka.ms/new-console-template for more information
using System;

////Link válido
int verif = 0;
string link = "";
Console.WriteLine("Ingrese un link válido:");
do
{
    if (verif > 0)
    {
        if (Uri.IsWellFormedUriString(link, UriKind.Absolute))
        {
            Console.WriteLine("Link válido");
            break;
        }
        else
        {
            Console.WriteLine("Link Inválido, ingrese de nuevo:");
        }
    }
    link = Console.ReadLine();
    verif++;
} while (true);

////Email válido
verif = 0;
string mail = "";
Console.WriteLine("Ingrese un correo electrónico válido:");
do
{
    if (verif > 0)
    {
        try
        {
            var addr = new System.Net.Mail.MailAddress(mail);
            if (addr.Address == mail)
            {
                Console.WriteLine("Correo válido");
                break;
            }
        }
        catch
        {
            Console.WriteLine("Correo inválido, ingrese de nuevo:");
        }
    }
    mail = Console.ReadLine();
    verif++;
} while (true);