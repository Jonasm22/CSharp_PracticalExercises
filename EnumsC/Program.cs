namespace EnumsC
{

    enum Day { Mon, Tu, We, Th,Fr, Sa, Sun};
    enum Month { Jan = 1, Fr, Mar,Apr,Jun, Jul = 12,Aug};

     class Program
    {
        static void Main(string[] args)
        {
            Day fr = Day.Fr;
            Day su = Day.Sun;
            Day a = Day.Fr;
             

            Console.WriteLine(fr== a);
            Console.WriteLine(Day.Mon);
            Console.WriteLine((int)Day.Mon);

            Console.WriteLine((int)Month.Fr);
            Console.WriteLine((int)Month.Jul);
            Console.WriteLine((int)Month.Aug);
          


        }
    }
}
