partial class Program
{
        static void ShowNumericTypes()
        {
            int integerNumber = 42;
            double decimalNumber = 3.14d;
            float floatingNumber = 2.5f;
            long longNumber = 1_234_567_890_123L;    
            decimal monetaryNumber = 99.99m; //numero de mucha precision , ideal para financias
            Console.WriteLine($"Numero Entero: {integerNumber}, Numero Decimal : {decimalNumber}, Numero Flotante: {floatingNumber}, Numero Largo: {longNumber}, Numero Monetario: {monetaryNumber}");
           /* Console.WriteLine( "integerNumber es un numero como: "+ integerNumber);
            Console.WriteLine( "decimalNumber es un numero como: "+ decimalNumber);
            Console.WriteLine( "floatingNumber es un numero como: "+ floatingNumber);
            Console.WriteLine( "longNumber es un numero como: "+ longNumber);
            Console.WriteLine( "monetaryNumber es un numero como: "+ monetaryNumber);*/
        }
       
    }