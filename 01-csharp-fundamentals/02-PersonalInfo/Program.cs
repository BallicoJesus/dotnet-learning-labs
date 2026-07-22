public class Program
{
    static void Main(string[] args)
    {
     Console.WriteLine("========================================================");
     Console.WriteLine("FICHA PERSONAL");
     Console.WriteLine("=======================================================");

     Console.WriteLine("Ingresa tu nombre: ");
     string nombre = Console.ReadLine();
     Console.WriteLine("Ingresa tu edad: ");
     int edad = int.Parse(Console.ReadLine());
     Console.WriteLine("Ingresa tu altura: ");
     double altura = double.Parse(Console.ReadLine());
     Console.WriteLine("Ingresa tu peso: ");
     double peso = double.Parse(Console.ReadLine());
     Console.WriteLine("Ingresa tu Ciudad: ");
     string ciudad = Console.ReadLine();
     Console.WriteLine("Trabaja? Si/No: ");
     string trabajaInput = Console.ReadLine();
     Console.WriteLine("Ingrese su año de nacimiento: ");
     int anioNacimiento = int.Parse(Console.ReadLine());
     double IMC = peso / (altura * altura);

     Console.WriteLine("========================================================");
     Console.WriteLine("FICHA PERSONAL");
     Console.WriteLine("=======================================================");
    Console.WriteLine($"Nombre: {nombre}");
    Console.WriteLine($"Edad: {edad}"); 
    Console.WriteLine($"Altura: {altura}");
    Console.WriteLine($"Peso: {peso}");
    Console.WriteLine($"Ciudad: {ciudad}"); 
    Console.WriteLine($"Trabaja: {trabajaInput}");
    Console.WriteLine($"Año de nacimiento: {anioNacimiento}");
    Console.WriteLine($"IMC: {IMC}");

    }

}