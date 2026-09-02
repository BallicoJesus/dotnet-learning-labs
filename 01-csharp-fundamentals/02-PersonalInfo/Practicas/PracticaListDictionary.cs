partial class Program
{
            static void PracticeListDictionary()
            {
            List<string> alumnos = new List<string> {"Ana","Carlos", "Juan"};
            alumnos.Add("Lucia");
            System.Console.WriteLine($"Total de nombres: {names.Count}");
            foreach (var alumno in alumnos) 
            {
                System.Console.WriteLine (alumno);
            }

            alumnos.Remove("Ana");
            bool isPresent = alumnos.Contains("Ana");
            System.Console.WriteLine($" Ana esta en la lista? {isPresent}" );

            //Dictionary
            Dictionary<double, string> estudiantes = new Dictionary<double, string>
            {
                {8.5,"Ana"},
                {6,"Felipe"},
                {9,"Elena"},
            } ;
            System.Console.WriteLine ($"El estudiante con ID 1 es: {estudiantes[1]}");
            foreach (var estudiante in estudiantes)
            {
                System.Console.WriteLine($"ID: {estudiante.Key}, Nombre: {estudiante.Value}");
            }
            estudiantes.Add(10, Jesus);

            Console.WriteLine("Ingrese el nombre del alumno del que quiere saber la nota:");
            string? nombreBuscado = Console.ReadLine();

            if (estudiantes.ContainsKey(nombreBuscado!))
            {
                Console.WriteLine($"La nota de {nombreBuscado} es {estudiantes[nombreBuscado!]}");
            }
            else
            {
                Console.WriteLine("El alumno no existe.");
            }

        }
       
    }