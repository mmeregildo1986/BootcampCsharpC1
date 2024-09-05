// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hola! Alumnos");
//Variables
int edad = 20;
long altura = 21;
string nombre = "Manuel";
decimal montoEnBanco = 1236544556.5m;
double dinero = 1651.36;
char letra= 'A';
bool tieneGorro= false;

Console.WriteLine("Escribe tu nombre");
nombre=Console.ReadLine();
Console.WriteLine("Mi nombre es "+nombre+" y mi edad es " +edad);
Console.WriteLine($"Mi altura es {altura}");
Console.WriteLine("escrib e tu dinero");
dinero =double.Parse(Console.ReadLine());
Console.WriteLine($"tu dinero es{dinero}");
