using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia(numero:"123456789", modelo:"Nokia 3310", imei:"IMEI123456", memoria:16);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.Write("\n");

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone(numero:"987654321", modelo:"iPhone 13", imei:"IMEI987654", memoria:128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");

