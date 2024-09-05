// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
DateTime FechNac = new DateTime(1986, 1, 26);
var fechaAct = DateTime.Now;
Console.WriteLine($"Naci la fecha: {FechNac.Date.ToString("MM,dd,yy")}");
Console.WriteLine($"la fecha actual es: {fechaAct.Date.ToString("dd/MM/yy")}");

var restFech = fechaAct - FechNac;

Console.WriteLine($"tu edad es: {restFech.Days/365}");