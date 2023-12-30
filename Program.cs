using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "01234", modelo: "Tijolo", imei: "abc123", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram", modelo: nokia.Modelo);

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone: ");
Smartphone iphone = new Iphone(numero: "56789", modelo: "15", imei: "bcd456", memoria: 64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp", modelo: iphone.Modelo);