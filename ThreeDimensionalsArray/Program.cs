namespace ThreeDimensionalsArray
{
    public class Program
    {
        static void Main(string[] args)
        {

            //ThreeDimentionalArray();
            printNummers();



        }


        public static void ThreeDimentionalArray()
        {

            string[,,] simpleArray =
            {
                {
                    {"000", "001"},
                    {"010", "011"}

                },

                {
                    {"100", "101"},
                    {"110", "111"}
                },
                 {
                    {"200", "201"},
                    {"210", "211"}
                },


                 
            };

            simpleArray[1, 0, 1] = "Hey";
            Console.WriteLine(simpleArray[0, 1, 0]);
            Console.WriteLine(simpleArray[1, 0, 1]);
        }


        public static void printNummers()
        {

            int[,] simpleIntegers =
            {

                {
                    1,
                    2,
                    3,
                    4,
                    5,
                }


            };


                foreach(var i in simpleIntegers)
            {

                Console.WriteLine(i);
            }
        }




    }
}







