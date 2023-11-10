using DesafioPOOCelular.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("999554685", "Modelo 1", "465132", 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone("998313285", "Modelo 2", "425111", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");