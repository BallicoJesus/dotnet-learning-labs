using System.Globalization;

partial class Program
{
        static void DiasDeVida()
        {
            Console.WriteLine("Ingrese su fecha de nacimiento (formato: dd/MM/yyyy):");
            string birthdayString = Console.ReadLine();
            DateTime birtDate = DateTime.ParseExact (birthdayString, "dd/MM/yyyy", CultureInfo.InvariantCulture);
           DateTime currentDate = DateTime.Now.Date;
           DateTime nextBirthDay = new DateTime (currentDate.Year, birtDate.Month, birtDate.Day);
        if (nextBirthDay < currentDate)
        {
            nextBirthDay = nextBirthDay.AddYears(1);
        }
        int dayRemainig = (nextBirthDay - currentDate).Days;
        Console.WriteLine($"faltan {dayRemainig} dias para tu proximo cumpleaños");
        }
       
    }
