using DesafioPOO.Models;
using System;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("SmartPhone ");
Smartphone Nokia = new nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111111", memoria: 56);
Nokia.Ligar();
Nokia.InstalarAplicativo("Telegram");


Console.WriteLine("\n");

Console.WriteLine("SmartPhone Iphone");
Smartphone iphone = new Iphone(numero: "9585", modelo: "Modelo 4", imei: "222222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");
