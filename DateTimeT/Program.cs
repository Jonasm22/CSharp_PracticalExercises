namespace DateTimeT
{
    internal class Program
    {

        //SMALL EXAMPLE HOW TO MANAGE DATE TIME
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2018, 5, 21);

            Console.WriteLine($"Entry At: {dateTime}");

            //WRITE TODAY ON SCREEN

            Console.WriteLine(DateTime.Today);

            // Write current time on screen
            Console.WriteLine(DateTime.Now);

            DateTime tomorrow = getTomorrow();
            Console.WriteLine("Tomorrow will be: " + getTomorrow());
            Console.WriteLine("Today is: " + DateTime.Today.DayOfWeek);
            Console.WriteLine("First day of year is: " + GetFirstDayOfYear(1999));

            int day = DateTime.DaysInMonth(2000, 2);
            Console.WriteLine("Day in Feb" + day);



        }


            public static DateTime getTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }
        
        public static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year ,1,1) ;
        }



    }
}
