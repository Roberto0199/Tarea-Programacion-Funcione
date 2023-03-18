
/*
//*Crear una función que calcule el área de un círculo, recibiendo como parámetro el radio.
static double AreaCirculo(double radio)
{
    double area = Math.PI * Math.Pow(radio, 2);
    return area;
}
double area = AreaCirculo(7);
Console.WriteLine("El área del círculo es: " + area);*/



/*
//*Crear una función que calcule el perímetro de un rectángulo, recibiendo como parámetros el ancho y la altura.
 static double PerimetrodeunRectangulo(double ancho, double altura)
{
    double perimetro = 2 * (ancho + altura);
    return perimetro;
}
double perimetro = PerimetrodeunRectangulo(4, 5);
Console.WriteLine("El Perimetro de tu rectangulo es:"+perimetro);*/


/*
//Crear una función que calcule el promedio de una lista de números, recibiendo como parámetro una lista de enteros.
static double Promedio(List<int> numeros)
{
    int suma = numeros.Sum();
    int totalElementos = numeros.Count;
    double promedio = (double)suma / totalElementos;
    return promedio;
}
List<int> Numeros = new List<int>() { 43, 34, 66, 91, 11 };
double promedio = Promedio(Numeros);
Console.WriteLine("El promedio de la lista es:"+promedio);*/


/*
//*Crear una función que determine si un número es par o impar, recibiendo como parámetro el número.
static void Par_o_Impar(int numero)
{
    if (numero % 2 == 0)
    {
        Console.WriteLine("El número {0} es par.", numero);
    }
    else
    {
        Console.WriteLine("El número {0} es impar.", numero);
    }
}
Par_o_Impar(32);*/


/*
//*Crear una función que convierta una cadena a mayúsculas, recibiendo como parámetro la cadena.
static string ConvMayus(string cadena)
{
    return cadena.ToUpper();
}
string resultado = ConvMayus("Mi nombre es Roberto");
Console.WriteLine(resultado);*/


//*Crear una función que calcule el factorial de un número, recibiendo como parámetro el número.
static int Factorial(int numero)
{
    int resultado = 1;
    for (int i = 2; i <= numero; i++)
    {
        resultado *= i;
    }
    return resultado;
}
int resultado = Factorial(6);
Console.WriteLine("El factorial de su numero es:"+resultado);
