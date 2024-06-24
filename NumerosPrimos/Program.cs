


int numero = 0;
int rangoi = 0;
int rangof = 0;
List <int> Primos = new List<int>();


bool EsPrimo (int numero = 0)
{
    bool primo;

    for (int i = 2; i < numero; i++)
    {
        if ((numero % i) == 0)
        {
            return false;
        }
    }   

   return true;
    }
    

Console.WriteLine("\nBUSCADOR DE NÚMEROS PRIMOS\n");
Console.WriteLine("\nBuscaremos los números primos dentro de un rango establecido por el usuario.\nIngrese el número inicial del rango:");
rangoi=int.Parse(Console.ReadLine());

Console.WriteLine("\nIngrese el número final de rango: ");
rangof = int.Parse(Console.ReadLine());

int total = rangof - rangoi;

for (int i=rangoi; i <= rangof && i >= rangoi; i++)
{
    if(EsPrimo(i)==true)
    {
        Primos.Add(i);
    }

}
     Console.WriteLine($"\nDentro del rango definido entre {rangoi} y {rangof} los números primos son:");

foreach (int i in Primos)
{
    Console.WriteLine(i);
    
}
