using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone nokia = new Nokia("5454", "5200", "5446545456", 256);
Smartphone iphone = new Iphone("6", "6S", "5445465477", 64);

nokia.InstalarAplicativo("Twitter");
iphone.InstalarAplicativo("Chrome");
nokia.ReceberLigacao();
iphone.ReceberLigacao();
nokia.Ligar();
iphone.Ligar(); 