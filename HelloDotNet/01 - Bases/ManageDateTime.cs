partial class Program
{
       static void ShowTime()
        {
            DateTime currentDate = DateTime.Now;
            DateTime today = DateTime.Today;
            DateTime nowWeekAgo = currentDate.AddDays(-7);
            DateTime customDate = new(2024, 6, 15);

            DayOfWeek WeekDay = currentDate.DayOfWeek;

            Console.WriteLine($"Fecha y hora actual: {currentDate}");
            Console.WriteLine($"Fecha actual: {today}");
            Console.WriteLine($"Fecha hace una semana: {nowWeekAgo}");
            Console.WriteLine($"Fecha personalizada: {customDate}");
            Console.WriteLine($"Día de la semana: {WeekDay}");
        }
       
    }