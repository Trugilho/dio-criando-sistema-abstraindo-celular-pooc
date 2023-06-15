using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("(27) 9934-3456", "Tijolão", "00000000", 128);

nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone:");

Iphone iphone = new Iphone("(27) 9876-1234", "iPhone 15", "7777777", 64);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("facebook");


