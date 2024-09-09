using DesafioPOO.Models;
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "12345", modelo:  "1", imei: "111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Wpp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "6789", modelo: "2", imei: "222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("telegram");
