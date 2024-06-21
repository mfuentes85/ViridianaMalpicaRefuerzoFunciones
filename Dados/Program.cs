
using System.Timers;

string lanzar;
int dado=0;
string cont;


    int LanzarDado(int dado)
    {
    Random random = new Random();
    dado = random.Next(1, 7);
        
    return dado;
    }

    Console.WriteLine("\nJUEGO DE DADOS\n");
do
{

    
    Console.WriteLine("\n¿Desea lanzar los dados? SI   NO");
    lanzar =  Console.ReadLine().ToUpper();
    evaluar:
    if (lanzar == "SI")
    {
        int dado1=LanzarDado(dado);
        int dado2=LanzarDado(dado);
       
        //imprime el valor de los dados 
        Console.WriteLine($"\nEl valor del dado 1 es: {dado1}\nEl valor del segundo dado es:{dado2}");
        
    }
    else if(lanzar=="NO")
    {
        Console.WriteLine("¿Desea terminar el programa? Escriba:\nSI\nNO\n");
        cont = Console.ReadLine().ToUpper();
        if (cont == "NO")
        {
            return;
        }

    }
        

}
while (lanzar == "SI");


