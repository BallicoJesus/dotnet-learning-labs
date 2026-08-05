partial class Program
{
        static void Arrays()
        {
           int [] numbers = new int [5];
           numbers [0] = 1;
           numbers [1] = 3;

           // Directa
           int [] numbersArray = [5, 10, 15, 20, 25, 30,];
           // Indices
           Console.WriteLine($"Primer elemento {numbersArray[0]}");
           Console.WriteLine($"Tercer elemento {numbersArray[2]}");
           //Tamano arreglo
           Console.WriteLine($"El numero de elementos del arreglo es {numbersArray.Length} ");
           // Desde el final del arreglo ^
           Console.WriteLine($"El ultimo elemento del arreglo es {numbersArray[^1]} ");
           Console.WriteLine($"El anteultimo elemento del arreglo es {numbersArray[^2]} ");
           //Rangos para obtener subarreglos ..
           int [] primerosTres = numbersArray [..3];
           int [] desdeElDos = numbersArray [2..];

           foreach (var number in desdeElDos)
        {
            Console.WriteLine(number);
        }


        }
       
    }
