﻿using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone nokia = new Nokia("1234", "Modelo 1", "1234567890ABCDEFGH", 64);
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Testando o smartphone Nokia");
Console.ResetColor();
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Smartphone iphone = new Iphone("4321", "Modelo 2", "1234567890ABCDEFGH", 32);
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Testando o smartphone Iphone");
Console.ResetColor();
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");