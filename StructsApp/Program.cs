namespace StructsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point2 point1 = new Point2(10,20);
            point1.DisplayExc_Point_2();
            
            Point2 point2 = new Point2(20,30);
            point1.DisplayExc_Point_2();
            
            double distance = point1.DistanceTo(point2);
            Console.WriteLine($"Distance between points: {distance:F2} ");

            Point2 point3 = point1;
            point1.DisplayExc_Point_2();
            point3.DisplayExc_Point_2();

        }
    }

    public struct Point
    {

        //public int X { get; set; }
        //public int Y { get; set; } 
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void DisplayExc_Point_1()
        {
            Console.WriteLine($"Point: ({X}, {Y})");

        

        }

    }

    public struct Point2
    {
        //Its a common practice to make structs immutable
        //By declaring all fields as readonly and providing only
        // get accessors for properties

        public double X { get; }
        public double Y { get; } 
      

        public Point2(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double DistanceTo(Point2 other)
        {
            double dx = other.X - X;
            double dy = other.Y - Y;    
            return Math.Sqrt(dx * dx + dy * dy);    
        }

        public void DisplayExc_Point_2()
        {
            Console.WriteLine($"Point: ({X}, {Y})");

        

        }

    }















}
