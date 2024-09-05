// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hola! Alumnos");
//Variables
int edad = 20;
long altura = 21;
string nombre = "Manuel";
decimal montoEnBanco = 1236544556.5m;
double dinero = 1651.36;
float danio = 124.4f;
char letra= 'A';
bool tieneGorro= false;
var kilometros = 545454.4544;
Console.WriteLine("Escribe tu nombre");
nombre=Console.ReadLine();
Console.WriteLine("Mi nombre es "+nombre+" y mi edad es " +edad);
Console.WriteLine($"Mi altura es {altura}");
Console.WriteLine("escribe tu dinero");

//este es com entyario de prueba
/*
 * comentrarioi largo
 */
dinero =double.Parse(Console.ReadLine());
Console.WriteLine($"tu dinero es{dinero}");
Console.WriteLine("Escribe tu edad");
edad = int.Parse( Console.ReadLine());
Console.WriteLine($"Mi edad es:  {edad}");

if (edad >= 18) 
{
    Console.WriteLine("Puedes ingresar eres mayor de edad");
}
else
{
    Console.WriteLine("No puedes ingresar vete a tu casa");
}
Console.WriteLine("tienes gorro???");
string respuestaGorro = Console.ReadLine();
if (respuestaGorro == "si")
{ 
tieneGorro = true;
}
else if (respuestaGorro =="no")
{ tieneGorro = false; }

if (tieneGorro == true)
{ Console.WriteLine("si tienes gorro entra"); }
else { Console.WriteLine("no tienes gorro largate"); }