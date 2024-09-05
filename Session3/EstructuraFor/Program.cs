/* See https://aka.ms/new-console-template for more information
Console.WriteLine("Ingresa el numero de la tabla");
int contador = 0;
int limite = int.Parse(Console.ReadLine());

while (contador < limite)
{
    contador++;
    Console.WriteLine(contador);
}
contador = 0;
Console.WriteLine("---------------");

for (int i = 0; i <=limite; i++)
{ 
Console.WriteLine(i);
}
*/

Console.WriteLine("Ingresa el numero de la tabla");

int numeroTabla=int.Parse(Console.ReadLine());

Console.WriteLine("---------------");

for (int i = 0; i <= 12; i++)
{
    int resul = numeroTabla * i;
    Console.WriteLine($"{numeroTabla}*{i}={resul}");

    for (int j = 0; j <= 3; j++)
    { 
    Console.WriteLine("secuencia para la siguiente iteracion:"+j);
    }

}