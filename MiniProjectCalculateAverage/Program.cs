namespace MiniProjectCalculateAverage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AverageCalculator(); 
        }
        public static void AverageCalculator()
        {
            // REPASAR CONTENIDO
            int currentScore;
            int sum = 0;
            int counter = 0;

            do
            {
                Console.WriteLine("Enter your students score . Enter -1  t0 finish!");
                currentScore = int.Parse(Console.ReadLine());
                
                if(currentScore != -1)
                {
                    sum = sum + currentScore;
                    counter++;

                }
            } while (currentScore != -1);

            int avareage = sum / counter;
            Console.WriteLine("the avarage is: " + avareage);
            Console.ReadKey();
           




        }




    }
}
