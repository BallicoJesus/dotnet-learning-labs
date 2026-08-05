partial class Program
{
    static void HandleNullables()
    {
        //no nulificable
       string firstName = "Carlos";
       //nulificable
       string? lastName = "Gomez";
       Console.WriteLine($"Nombre: {firstName}");

       /* if (lastName != null)
        {
            Console.WriteLine($"Apellido: {lastName}");
        }else
        {
            Console.WriteLine("Apellido no especificado");
        }*/
        
        //operador de coalescencia nula ??
        Console.WriteLine ($"Apellido: {lastName ?? "Apellido no especificado!"}");
        // aqui en la consola lo que pasa es , si apellido no es nulo, figura Apellido:"apellido", si es nulo entonces 
        //"apellido no especificado"


    }
       
    }
