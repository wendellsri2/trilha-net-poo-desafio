
using DesafioPOO.Models;

Console.WriteLine("Escolha qual Smartphone: Digite 1 ou 2");

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{    
    Console.Write("Iphone ou Nokia (i/n)? ");
    char ch = char.Parse(Console.ReadLine());  
    

    if (ch == 'n')
    {
        Console.Write("Numero: ");
        string numero = Console.ReadLine();
        Console.Write("Modelo: ");
        string modelo = Console.ReadLine();
        Console.Write("Imei: ");
        string imei = Console.ReadLine();
        Console.Write("Memoria: ");
        int memoria = int.Parse(Console.ReadLine());

        Console.Write("Qual aplicativo deseja instalar (Whatsapp, Zoom, Facebook, Telegram): ");        

        Smartphone nokia = new Nokia(numero, modelo, imei, memoria);
        nokia.InstalarAplicativo(Console.ReadLine());
        nokia.ReceberLigacao();
    }
    else 
    {
        Console.Write("Numero: ");
        string numero = Console.ReadLine();
        Console.Write("Modelo: ");
        string modelo = Console.ReadLine();
        Console.Write("Imei: ");
        string imei = Console.ReadLine();
        Console.Write("Memoria: ");
        int memoria = int.Parse(Console.ReadLine());

        Console.Write("Qual aplicativo deseja instalar (Whatsapp, Zoom, Facebook, Telegram): ");

        Smartphone iphone = new Iphone(numero, modelo, imei, memoria);
        iphone.InstalarAplicativo(Console.ReadLine());
        iphone.Ligar();
    }

    
}

Console.WriteLine(".............");



