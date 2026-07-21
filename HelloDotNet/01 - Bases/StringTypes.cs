partial class Program
{
        static void ShowStringTypes()
        {
           string name = "Juan";
           string message = "Hola " + name; //concatenado
           string interpolatedMessage = $"Hola {name}"; //interpolado
           Console.WriteLine(message);
           Console.WriteLine(interpolatedMessage);
           Console.WriteLine($"Tu nombre tiene {name.Length} letras");
           Console.WriteLine($"Tu nombre en mayusculas es: {name.ToUpper()}");
           Console.WriteLine($"Tu nombre en minusculas es: {name.ToLower()}");
           int number = 42;
           string numberAsString = number.ToString();
           Console.WriteLine(number);
           bool isString = true;
           Console.WriteLine(isString);

        }
       
    }
