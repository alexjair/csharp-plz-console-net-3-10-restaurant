/*
 1.Validar si es un usuario existente o se debe registrar
 1,1.si no existe se debe registrar
 2.Debe darle la bienvenida si el usuario existe
 3.Se debe repetir  10 veces
 Hecho por : Juan leal 
 */
string NombreIngreso = "";
string EstadoRegistro = " ";
List<string> Nombres = new List<string>();
Nombres.Add("juan"); Nombres.Add("carlos"); Nombres.Add("David");
int TotalUsuarios = Nombres.Count;
bool continuar = true;

Console.WriteLine("--------------------------------------BIENVENIDO------------------------------------");
while (continuar)
{
    Console.WriteLine($"\nActualmente tenemos {10 - TotalUsuarios} espacios para usuarios disponibles");
    Console.WriteLine("\n¿Ya se encuentra registrado? si:Y no:N");
    EstadoRegistro = (Console.ReadLine()).ToUpper();
    if (EstadoRegistro == "Y")
    {
        Console.WriteLine("Ingrese su nombre de usuario");
        NombreIngreso = Console.ReadLine();
        if (Nombres.Contains(NombreIngreso)) { Console.WriteLine($"Bienvenido {NombreIngreso}"); }
    }
    else if (EstadoRegistro == "N")
    {
        Console.WriteLine("\nRegistrando nuevo usuario.....\nPara comenzar cree su nombre de usuario");
        NombreIngreso = Console.ReadLine();
        if (Nombres.Contains(NombreIngreso))
        {
            Console.WriteLine($"\nEl nombre de usuario {NombreIngreso} ya esta asignado elija otro redirigiendo... ");
        }
        else
        {
            Nombres.Add(NombreIngreso);
            Console.WriteLine($"\nRegistrando.....\nFelicidades {NombreIngreso} su registro fue exitoso");
            TotalUsuarios++;
            Console.WriteLine($"\nRedirigiendo para nuevas entradas.....\nRegistros disponibles: {10 - TotalUsuarios}");
        }
        if (TotalUsuarios == 10)
        {
            Console.WriteLine("\n---------------------------limite de usuarios alcanzado-----------------------------" +
                "\nmostrando usuarios registrados....");
            for (int i = 0; i < Nombres.Count; i++)
            {
                Console.WriteLine(Nombres[i]);
            }
            continuar = false;
        }
    }
    else { Console.WriteLine("No es una opcion valida intente nuevamente"); }

}
