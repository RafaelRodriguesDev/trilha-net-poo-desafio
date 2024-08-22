using DesafioPOO.Models;

Console.WriteLine("Smarphone Iphone:");
Smartphone meuIphone = new Iphone(numero:"123456789", modelo:"iPhone 14",imei: "111222333",memoria: 128);
Console.WriteLine($"Numero:{meuIphone.Numero}, Modelo:{meuIphone.Modelo}, IMEI:{meuIphone.IMEI}, Memoria: {meuIphone.Memoria}");
meuIphone.Ligar();
meuIphone.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smarphone Nokia:");
Smartphone meuNokia = new Nokia(numero:"987654321", modelo:"iPhone 13",imei: "33225544",memoria: 250);
Console.WriteLine($"Numero:{meuNokia.Numero}, Modelo:{meuNokia.Modelo}, IMEI:{meuNokia.IMEI}, Memoria: {meuNokia.Memoria}");
meuNokia.Ligar();
meuNokia.InstalarAplicativo("Facebookapp");

