partial class Program
{
        static void DaysOfLife()
        {
            DateTime birthDate = new DateTime (1993, 2, 17);
            TimeSpan difference = DateTime.Now - birthDate ;
            Console.WriteLine ($"Haz vivido {difference.Days} dias.");

        }
       
    }
