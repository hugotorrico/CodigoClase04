
//Variable global
string nombreEmpresa = "Codigo Tecsup";
double IGV = 18;
double Descuento4TACategoria = 8;

double CalcularSueldoNeto(double sueldo)
{
    return sueldo - (sueldo * Descuento4TACategoria)/100;
}

//Conjunto de instrucciones
void MostarResultados(double sueldo,string Nombres)
{
    Console.WriteLine("La empresa:");
    Console.WriteLine(nombreEmpresa);
    Console.WriteLine("El trabajador:");
    Console.WriteLine(Nombres);
    Console.WriteLine("El sueldo Neto:");
    Console.WriteLine(CalcularSueldoNeto(sueldo));
  
}

MostarResultados(5000, "Hugo Torrico");


Console.Read();

