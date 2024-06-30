namespace IntroductionsTo_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ArraysWithInt();
            StringsDay();

        }



        public static void ArraysWithInt()
        {

            //declare an array
            /*
            int[] myIntArray = new int[5];

            Assigned values to the array
            myIntArray[0] = 5;
            myIntArray[1] = 12;
            myIntArray[2] = 13;
            myIntArray[3] = 14;
            myIntArray[4] = 15;


            Console.WriteLine(myIntArray[0]);
            */

            int[] myIntArray = [5, 12, 13, 14, 15];

            Console.WriteLine(myIntArray[1]);

        }


        public static void StringsDay()
        {
            string[] days = ["Mon", "Tue", "Wen", "Thurs", "Fri", "sam"];
            Console.WriteLine("Lenght = " + days.Length);


          /*  for (int i = 0; i < days.Length; i++)
            {
                Console.WriteLine(days[i]);
            }
          */

            foreach (var item in days)
            {
                Console.WriteLine(item);
            }


        }
    }
}
