// See https://aka.ms/new-console-template for more information

int CalcularAreaTriangulo(int base1, int altura1)
{
    int resultado = (base1 * altura1) / 2;

    return  resultado;
}
double CalcularAreaTrianguloLados(double lado1,double lado2, double lado3)
{
    double resultado=0;
    double semiperimetro = 0;

    semiperimetro = (lado1 + lado2 + lado3) / 2;

    //Raiz Cuadrada
    resultado = Math.Sqrt(semiperimetro * 
                         (semiperimetro - lado1) * 
                         (semiperimetro - lado2) * 
                         (semiperimetro - lado3));
    //Aproximar
    return Math.Round( resultado,2);
    
}
double CalcularAreaRectangulo(double base1, double altura1)
{
    return base1 * altura1;
}
double CalcularDistancia(double x1, double y1,  double x2, double y2)
{
    double resultado = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    return Math.Round( resultado,2);
}

double CalcularAreRectanguloCoordenadas(
    double x1, double y1, double x2, double y2,
    double x3, double y3, double x4, double y
    )
{
    double resultado = 0;
    double baseR, alturaR;

    baseR = CalcularDistancia(x1, y1, x2, y2);
    alturaR = CalcularDistancia(x2, y2, x3, y3);
    resultado = CalcularAreaRectangulo(baseR, alturaR);

    return resultado;

}


int base1, altura1;
base1 = 10;
altura1 = 20;
int area1 = CalcularAreaTriangulo(base1,altura1);
Console.WriteLine("El area del triángulo:");
Console.WriteLine(area1);

double lado1, lado2, lado3,area2;
lado1 = 7;
lado2 = 24;
lado3 = 26;
area2= CalcularAreaTrianguloLados(lado1,lado2,lado3);
Console.WriteLine("El area del triángulo:");
Console.WriteLine(area2);

//double x1, y1, x2, y2;
//x1 = 1;
//y1 = 1;
//x2 = 4;
//y2 = 1;
//double distancia = CalcularDistancia(x1, y1, x2, y2);
//Console.WriteLine("La distancia es");
//Console.WriteLine(distancia);

double x1, y1, x2, y2, x3, y3, x4, y4;
double AreaR;
x1 = 1;
y1 = 1;
x2 = 4;
y2 = 1;
x3 = 4;
y3 = 3;
x4 = 1;
y4 = 3;

AreaR = CalcularAreRectanguloCoordenadas(x1, y1, x2, y2, x3, y3, x4, y4);
Console.WriteLine("El area del rectangulo de coordenas es:");
Console.WriteLine(AreaR);




