using System.Xml;

namespace Csharp_Updated
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //Print something
           // Console.WriteLine("Insert something: ");
            //take the user inout and store it
            //variable UserInput, data type "string"
            //string userInput= Console.ReadLine();
          //  Console.WriteLine("Ýour entered: => " + userInput);


            // varibles

            //implecitely type variable

            var myFavoriteGenre = "horro";

            var myFavoriteNummer = 13;

            var secondNummer = 15;

            var total = myFavoriteNummer + secondNummer;

            // Console.WriteLine(total);


            //ejercicio

            int num1 = 10;
            int num2 = 20;
            int num3 = 30;
            int average = (num1 + num2 + num3) / 3;
            Console.WriteLine("The average is: " + average);



            String h = "Hello";
            String w = "World";

            Console.WriteLine(h);
            Console.WriteLine("{0} {1}" , h, w );


        }
    }
}
