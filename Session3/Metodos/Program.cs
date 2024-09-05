
//sumatoria usando metodo void con paramewtros.
 void suma1(double n1, double n2)
{ 
    double res = n1+n2;
    Console.WriteLine(res);
}


Console.WriteLine("sumando con void usando parametros");
suma1(12, 23);

//sumatoria usando metodo void con parametros globales
double num1 = 5;
double num2 = 10;

double res = num1 * num2;
void suma2  ()
{
    res = num1 * num2;
        Console.WriteLine(res);
}

Console.WriteLine("sumado void usando parametros globales");
suma2 ();

//sumatoria usando metodos void con devolucion de parametros
double suma3(double n1, double n2)
{
    double res = n1 * n2;
    return res;
}

Console.WriteLine("sumando void usando devolucion de parametros");
double resulPara = suma3(45.34, 898.9);
Console.WriteLine(resulPara);

//sumatoria usando expresiones lamda
Func<double, double, double> sumaLamda = (n1, n2)=>(n1+n2);
Console.WriteLine("sumando con expresiones lamda");
double resLamda = sumaLamda(125, 145);
Console.WriteLine(resLamda);