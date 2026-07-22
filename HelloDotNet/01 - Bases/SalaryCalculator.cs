partial class Program
{
        static void SalaryCalculator()
        {
            Console.Write("Ingrese su nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese la cantidad de horas trabajadas: ");
            int horasTrabajadas = int.Parse(Console.ReadLine());
            Console.Write("Ingrese su tarifa por hora: ");
            double tarifaPorHora = double.Parse(Console.ReadLine());
            int horasExtras = 0;
            if (horasTrabajadas > 40)    
            {
            horasExtras = horasTrabajadas - 40;
            horasTrabajadas = 40;
            }
            int bonoPagado = 0;
            double salarioFinal = 0;
            Console.WriteLine("Recibe bono? Si/No: ");
            string recibeBono = Console.ReadLine();
            if (recibeBono.ToLower() == "si")
            {
            Console.Write("Ingrese el monto del bono: ");
            bonoPagado = int.Parse(Console.ReadLine());
            }else {
            bonoPagado = 0;
            }

            salarioFinal = horasTrabajadas * tarifaPorHora + horasExtras * (tarifaPorHora * 1.5) + bonoPagado;

            Console.WriteLine ("========================================================");
            Console.WriteLine("RECIBO DE SUELDO");
            Console.WriteLine ("========================================================");
            Console.WriteLine($"Empleado: {nombre}");
            Console.WriteLine($"Horas trabajadas: {horasTrabajadas}");
            Console.WriteLine($"Tarifa por hora: ${tarifaPorHora:C}");
            Console.WriteLine($"Horas extras: {horasExtras}");
            Console.WriteLine($"Bono pagado: ${bonoPagado:C}");
            Console.WriteLine($"Salario final: ${salarioFinal:C}");
        }
       
    }
