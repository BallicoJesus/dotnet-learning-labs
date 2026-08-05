partial class Program
{
        static void Operators()
        {
            int number = 15;
            bool esPar = number % 2 == 0;
            bool esMayorQueDiez = number > 10 ;

            if(esPar && esMayorQueDiez)
        {
            Console.WriteLine ($"El numero {number} es par y es mayor que diez");
        }
            else if (!esPar && esMayorQueDiez)
        {
            Console.WriteLine ($"El numero {number} no es par y es mayor que diez");            
        }
        else
        {
            Console.WriteLine($"El numero {number} no cumple ninguna de las condiciones");
        }
        }
       
    }
