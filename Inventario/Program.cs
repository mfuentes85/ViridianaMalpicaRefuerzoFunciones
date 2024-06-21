int opcion;
bool continuar;
int cont2 = 0;
int ContGlob = 0;
int CantProd;
Dictionary<string, int> Inventario = new Dictionary<string, int>();

do
{

    Console.WriteLine("\nINVENTARIO\n");
    Console.WriteLine("Seleccione la opción deseada:");
    Console.WriteLine("1.- Agregar producto.\n2.- Eliminar producto\n3.- Actualizar inventario existente\n4.- Mostrar inventario\n");
    opcion = int.Parse(Console.ReadLine());
    Console.Clear();

    switch (opcion)
    {
        case 1:
            int cont1 = 0;
            string NvoPM;
            string NvoProd;
            do
            {
                Console.WriteLine("\nINVENTARIO\n");
                Console.WriteLine("Introduzca el nuevo producto:");
                NvoPM = Console.ReadLine();
                NvoProd =NvoPM.ToUpper();

                Console.WriteLine("\nIntroduzca la cantidad:");
                CantProd = int.Parse(Console.ReadLine());

                Inventario.Add(NvoProd, CantProd);
                Console.WriteLine($"\nEl producto {NvoProd} se ha agregado correctamente\n");
                Console.WriteLine($"¿Desea agregar un nuevo producto?\n1.- Si\n2.- No\n");
                cont1 = int.Parse(Console.ReadLine());
                Console.Clear();
                
            }
            while (cont1 == 1);
            break;

        case 2:
            {
                string ElimPM; 
                string ElimProd;
                int eliminar = 0;
                

                do
                {
                    Console.WriteLine("\nINVENTARIO\n");
                    Console.WriteLine("Introduzca el nombre del producto que desea eliminar:");
                    ElimPM = Console.ReadLine();
                    ElimProd=ElimPM.ToUpper();

                    
                    if (Inventario.ContainsKey(ElimProd))
                    {

                        Console.WriteLine($"\nEsta seguro que desea eliminar {ElimProd} del inventario?\n1.Si 2. No \n");
                        eliminar = int.Parse(Console.ReadLine());

                        if (eliminar == 1)
                        {
                            Inventario.Remove(ElimProd);
                            Console.WriteLine($"\nEl producto {ElimProd} se ha eliminado exitosamente");
                            
                            Console.WriteLine("\n¿Desea eliminar otro producto? 1. Si  2. No");
                            cont2 = int.Parse(Console.ReadLine());
                            Console.Clear() ; 

                            if(cont2 == 1)
                            {
                                continue;
                            }
                            else if (cont2 == 2)
                            {
                                continue;
                            }
                                                        
                        }
                        else if (eliminar == 2)
                        {
                            goto borrarmas;
                           
                         }
                        else if (eliminar != 1 || eliminar != 2)
                        {
                            Console.WriteLine("\nOpcion invalida");
                            return;

                        }
                    }
                    else
                    {
                        Console.WriteLine("El producto solicitado no existe en el inventario");
                        goto borrarmas;

                    }
                    borrarmas:
                    Console.WriteLine("\n¿Desea eliminar otro producto? 1. Si  2. No");
                    cont2 = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
                while (cont2 == 1);
                break;
            }

        case 3:
            {
                string ActPM;
                string ActProd;
                int ItemsModif;
                int actualizar = 0;
                int cont3 = 0;

                do
                {
                    Console.WriteLine("\nINVENTARIO\n");
                    Console.WriteLine("Introduzca el nombre del producto que desea actualizar existencia.\n");
                    ActPM = Console.ReadLine();
                    ActProd=ActPM.ToUpper();

                    if (Inventario.ContainsKey(ActProd))
                    {
                        Console.WriteLine($"\nLa existencia actual de {ActProd} es {Inventario.TryGetValue(ActProd, out int value)} "); 

                        Console.WriteLine($"\nIntroduzca nueva cantidad de existencias de {ActProd}:");
                        ItemsModif = int.Parse(Console.ReadLine());

                        Console.WriteLine($"\nEsta seguro que desea modificar permanentemente la existencia de {ActProd} del inventario?\n1.Si 2. No \n");
                        actualizar = int.Parse(Console.ReadLine());

                        if (actualizar == 1)
                        {
                            Inventario[ActProd] = ItemsModif;
                            Console.WriteLine($"\nEl producto {ActProd} ha modificado sus existencias a {ItemsModif}");

                            Console.WriteLine("\n¿Desea actualizar el inventario de otro producto? 1. Si  2. No");
                            cont3 = int.Parse(Console.ReadLine());
                            Console.Clear();

                            if (cont3 == 1)
                            {
                                continue;
                            }
                            else if (cont3 == 2)
                            {
                                goto continuar;
                            }
                        }
                        else if (actualizar == 2)
                        {
                            continue;
                        }
                        else if (actualizar != 1 || actualizar != 2)
                        {
                            Console.WriteLine("\nOpcion invalida");
                            return;

                        }
                    }

                    actualizar:
                    Console.WriteLine("\n¿Desea actualizar las existencias de otro producto? 1. Si  2. No");
                    cont3 = int.Parse(Console.ReadLine());
                }
                while (cont3 == 1);
                break;
            }
        case 4:
            {
                
                Console.WriteLine("\nINVENTARIO\n");

                foreach(var producto in Inventario)
                {
                    Console.WriteLine($"   PRODUCTO        EXISTENCIA"); 
                    Console.WriteLine($"{producto.Key}   {producto.Value}");
                    goto continuar;
                }
                break;
            }

       default:
            {
                Console.WriteLine("Esa opción es inválida, intente otra vez");
                break;
            }
    }
    continuar:
    Console.WriteLine("\nINVENTARIO\n\n1.- Volver al menú principal\n2.- Terminar el programa");
    ContGlob = int.Parse(Console.ReadLine());
    if (ContGlob == 2)
    {
        return;
    }
    Console.Clear();
}

while (ContGlob == 1);
return;
    