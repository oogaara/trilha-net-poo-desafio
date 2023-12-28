using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia(numero:"1234-5678", modelo:"testeNokiaBeta", imei:"99999999999999", memoria:64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("-----------------------");

Smartphone iphone = new Iphone(numero:"1234-5678", modelo:"Iphone20super-beta", imei:"8888888888888", memoria:128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("SnapChat");