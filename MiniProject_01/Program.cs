namespace MiniProject_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert the first number: ");
            int FirstNummer = int.Parse( Console.ReadLine());

            Console.Write("Insert the second number: ");
            int SecondNummer = int.Parse(Console.ReadLine());


            int total = FirstNummer + SecondNummer;


            //String concatination
           
//Console.WriteLine("Addition total= "  + FirstNummer +  " and " + SecondNummer +  "is = " + total);

            //String Interpolation
            Console.WriteLine($"The addition from  {FirstNummer} and {SecondNummer} is = " + total);

        }
    }
}
